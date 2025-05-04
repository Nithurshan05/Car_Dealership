using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_Car_Traders.commonClass;
using ABC_Car_Traders.Customer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace ABC_Car_Traders
{
    // Class to handle operations related to viewing and managing cars
    internal class CarViewClass : ABC_DBClass
    {
        // Properties to store car details
        private string currentcustomer_name { get; set; }
        public string imagePath { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public decimal price { get; set; }
        public decimal Tax { get; set; }
        public int orderGroupId { get; set; }
        public Cars_View carsview { get; set; }

        // Constructor to initialize event handlers
        public CarViewClass(Cars_View _form)
        {
            carsview = _form;
            carsview.Load += (object sender, EventArgs e) => CarsViewLoad();
            carsview.SaveToCart.Click += (object sender, EventArgs e) => Payment();
            carsview.button1.Click += (object sender, EventArgs e) => button1_Click();
            carsview.modelComBx.SelectedIndexChanged += (object sender, EventArgs e) => modelComBx_SelectedIndexChanged_1();
            carsview.brandsComBx.SelectedIndexChanged += (object sender, EventArgs e) => brandsComBx_SelectedIndexChanged_1();
        }

        // Method to display all cars
        private void DisplayAllCars()
        {
            // SQL query to select all cars with their brands
            DisplayCars("select * from Car_DetailsTable JOIN BrandTable ON Car_DetailsTable.car_Brand = BrandTable.Brand_ID\r\n");
        }

        // Method to execute query and display cars in the panel
        private void DisplayCars(string query)
        {
            carsview.flowLayoutPanelForCar.Controls.Clear();
            try
            {
                // Open database connection and execute query
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    // Read car details from the database
                    imagePath = reader["image_Path"].ToString();
                    brand = reader["Brand_name"].ToString();
                    model = reader["car_Model"].ToString();
                    price = decimal.Parse(reader["car_Price"].ToString());
                    Tax = decimal.Parse(reader["car_Tax"].ToString());

                    // Add car details to the panel
                    AddCarToPanel(imagePath, brand, model, price, Tax);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error loading car data: " + ex.Message);
            }
        }

        // Method to create and add a car panel to the flow layout
        private void AddCarToPanel(string imagePath, string brand, string model, decimal price, decimal tax)
        {
            // Create a new panel for the car
            Panel carPanel = new Panel
            {
                Size = new Size(250, 350),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            // Create and configure the PictureBox to display car image
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(240, 230),
                Cursor = Cursors.Hand,
                Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Create and configure labels to display car details
            Label labelBrand = new Label
            {
                Text = "Brand: " + brand,
                AutoSize = true,
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 23, 61),
            };

            Label labelModel = new Label
            {
                Text = "Model: " + model,
                AutoSize = true,
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 23, 61),
            };

            Label labelPrice = new Label
            {
                Text = "Price: " + price,
                AutoSize = true,
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 23, 61),
            };

            // Create and configure the 'Add to List' button
            System.Windows.Forms.Button buttonAddToCart = new System.Windows.Forms.Button
            {
                Text = "Add to List",
                AutoSize = true,
                Font = new Font("Arial", 8, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(0, 23, 61),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleCenter,
                FlatAppearance = { BorderColor = Color.White }
            };

            // Add controls to the panel
            carPanel.Controls.Add(pictureBox);
            carPanel.Controls.Add(labelBrand);
            carPanel.Controls.Add(labelModel);
            carPanel.Controls.Add(labelPrice);
            carPanel.Controls.Add(buttonAddToCart);

            // Position the controls within the panel
            labelBrand.Location = new Point(15, 235);
            labelModel.Location = new Point(15, 255);
            labelPrice.Location = new Point(15, 275);
            buttonAddToCart.Location = new Point(100, 300);

            // Event handler for pictureBox click
            pictureBox.Click += (sender, e) =>
            {
                OpenCarDetailsForm(imagePath, brand, model);
            };

            // Event handler for 'Add to List' button click
            buttonAddToCart.Click += (sender, e) =>
            {
                decimal totalPrice = price * (1 + tax / 100);  // Calculate total price
                ListViewItem item = new ListViewItem($"{brand}   {model}        {price}")
                {
                    // Add car details to ListView
                    SubItems = {
                        price.ToString("C"),
                        "1", // Default quantity
                        totalPrice.ToString("C") // Total price
                    }
                };
                carsview.CarsViewListView.Items.Add(item);
                UpdateGrandTotal();
                MessageBox.Show("Car added to ListView");
            };

            // Add car panel to the flow layout panel
            carsview.flowLayoutPanelForCar.Controls.Add(carPanel);
        }

        // Method to open the car details form
        private void OpenCarDetailsForm(string imagePath, string brand, string model)
        {
            try
            {
                string query = "SELECT * FROM Car_DetailsTable WHERE car_Brand = car_Brand AND car_Model = @car_Model";
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("car_Brand", brand);
                    cmd.Parameters.AddWithValue("@car_Model", model);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve car details and show in a new form
                            string color = reader["car_Color"].ToString();
                            int year = Convert.ToInt32(reader["car_Year"]);
                            decimal price = Convert.ToDecimal(reader["car_Price"]);

                            Car_Details_View detailsView = new Car_Details_View(imagePath, brand, model, color, year, price);
                            detailsView.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No details found for this car.");
                        }
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error : " + ex.Message);
            }
        }

        // Method to load models based on the selected brand
        private void LoadModels(string brand)
        {
            try
            {
                connect.Open();
                string query = $"SELECT DISTINCT car_Model FROM Car_DetailsTable JOIN BrandTable ON Car_DetailsTable.car_Brand = BrandTable.Brand_ID WHERE Brand_name = '{carsview.brandsComBx.SelectedItem}'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@car_Brand", brand);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        carsview.modelComBx.Items.Clear();
                        while (reader.Read())
                        {
                            carsview.modelComBx.Items.Add(reader["car_Model"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading models: " + ex.Message);
            }
            finally { connect.Close(); }
        }

        // Method to update the grand total in the ListView
        private void UpdateGrandTotal()
        {
            decimal grandTotal = carsview.CarsViewListView.Items
                 .Cast<ListViewItem>()
                 .Where(item => item.Text != "Grand Total")
                 .Sum(item => decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency));

            ListViewItem grandTotalItem = carsview.CarsViewListView.Items
                .Cast<ListViewItem>()
                .FirstOrDefault(item => item.Text == "Grand Total");

            if (grandTotalItem != null)
            {
                // Update existing grand total item
                grandTotalItem.SubItems[3].Text = grandTotal.ToString("C");
            }
            else
            {
                // Add new grand total item
                grandTotalItem = new ListViewItem("Grand Total")
                {
                    Font = new Font(carsview.CarsViewListView.Font, FontStyle.Bold)
                };
                grandTotalItem.SubItems.Add(""); // Empty Price
                grandTotalItem.SubItems.Add(""); // Empty Quantity
                grandTotalItem.SubItems.Add(grandTotal.ToString("C")); // Total Price
                carsview.CarsViewListView.Items.Add(grandTotalItem);
            }

            // Ensure the grand total item is at the bottom
            carsview.CarsViewListView.Items.Remove(grandTotalItem);
            carsview.CarsViewListView.Items.Add(grandTotalItem);
        }

        // Method to handle actions when the form is loaded
        private void CarsViewLoad()
        {
            // Load all brands into the combo box
            string query = "SELECT Brand_name FROM BrandTable";
            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    carsview.brandsComBx.Items.Clear();
                    while (reader.Read())
                    {
                        carsview.brandsComBx.Items.Add(reader["Brand_name"].ToString());
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading brands: " + ex.Message);
            }

            // Display all cars initially
            DisplayAllCars();
        }

        // Event handler for brand selection change
        private void brandsComBx_SelectedIndexChanged_1()
        {
            if (carsview.brandsComBx.SelectedIndex != -1)
            {
                // Load models based on the selected brand
                LoadModels(carsview.brandsComBx.SelectedItem.ToString());
                // Display cars based on the selected brand and model
                string brand = carsview.brandsComBx.SelectedItem.ToString();
                DisplayCars($"SELECT * FROM Car_DetailsTable JOIN BrandTable ON Car_DetailsTable.car_Brand = BrandTable.Brand_ID WHERE Brand_name = '{brand}'");
            }
        }

        // Event handler for model selection change
        private void modelComBx_SelectedIndexChanged_1()
        {
            if (carsview.modelComBx.SelectedIndex != -1 && carsview.brandsComBx.SelectedIndex != -1)
            {
                // Display cars based on the selected brand and model
                string brand = carsview.brandsComBx.SelectedItem.ToString();
                string model = carsview.modelComBx.SelectedItem.ToString();
                DisplayCars($"SELECT * FROM Car_DetailsTable JOIN BrandTable ON Car_DetailsTable.car_Brand = BrandTable.Brand_ID WHERE Brand_name = '{brand}' AND car_Model = '{model}'");
            }
        }

        // Method to handle payment logic (example placeholder)
        private void Payment()
        {
           
        }
        private void button1_Click()
        {
            // Find the item in the ListView that matches the car's brand and model
    var itemToRemove = carsview.CarsViewListView.Items
        .Cast<ListViewItem>()
        .FirstOrDefault(item => item.Text.Contains(brand) && item.Text.Contains(model));

            if (itemToRemove != null)
            {
                // Remove the item from the ListView
                carsview.CarsViewListView.Items.Remove(itemToRemove);

                // Update the grand total after removal
                UpdateGrandTotal();

                MessageBox.Show("Car removed from ListView");
            }
            else
            {
                MessageBox.Show("Item not found in the list.");
            }
        }
    }
}
