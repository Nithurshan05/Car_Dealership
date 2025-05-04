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
using System.IO;
using System.Security.Cryptography;

namespace ABC_Car_Traders
{
    internal class CarPartsClass : ABC_DBClass
    {
        // Properties for storing car parts details
        string currentcustomer_name { get; set; }
        string imagePath { get; set; }
        string carParts_Brand { get; set; }
        string carParts_Model { get; set; }
        decimal carParts_Price { get; set; }
        decimal carParts_Dis { get; set; }
        string Description { get; set; }

        public int orderGroupId { get; set; }
        public CarParts_View CPView { get; set; }

        // Constructor: Initializes event handlers for the view
        public CarPartsClass(CarParts_View _form)
        {
            CPView = _form;
            CPView.Load += (object sender, EventArgs e) => CarPartsViewLoad();
            CPView.SaveToCart.Click += (object sender, EventArgs e) => SaveToCart_Click();
            CPView.modelComBx.SelectedIndexChanged += (object sender, EventArgs e) => modelComBx_SelectedIndexChanged();
            CPView.brandsComBx.SelectedIndexChanged += (object sender, EventArgs e) => brandsComBx_SelectedIndexChanged_1();
        }

        // Method to display all car parts
        private void DisplayAllCarParts()
        {
            DisplayCarParts("SELECT * FROM CarParts_DetailsTable JOIN BrandTable ON CarParts_DetailsTable.carParts_Brand = BrandTable.Brand_ID");
        }

        // Method to display car parts based on a query
        private void DisplayCarParts(string query)
        {
            CPView.flowLayoutPanelForCarParts.Controls.Clear();
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string imagePath = reader["image_Path"].ToString();
                    string brand = reader["carParts_Brand"].ToString();
                    string model = reader["carParts_Model"].ToString();
                    string Description = reader["Description"].ToString();
                    string priceString = reader["carParts_Price"].ToString();
                    string disString = reader["carParts_Dis"].ToString();

                    decimal price;
                    decimal dis;
                    if (!decimal.TryParse(priceString, out price) || !decimal.TryParse(disString, out dis))
                    {
                        MessageBox.Show("Invalid price or tax format.");
                        continue;
                    }

                    AddCarPartsToPanel(imagePath, brand, model, price, dis);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading car data: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // Method to add car parts to the panel
        private void AddCarPartsToPanel(string imagePath, string brand, string model, decimal price, decimal dis)
        {
            Panel carPanel = new Panel
            {
                Size = new Size(250, 350),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(240, 230),
                Cursor = Cursors.Hand,
                Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

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
                Text = "Price: " + price.ToString("C"),
                AutoSize = true,
                Font = new Font("Arial", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 23, 61),
            };

            Button buttonAddToCart = new Button
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

            carPanel.Controls.Add(pictureBox);
            carPanel.Controls.Add(labelBrand);
            carPanel.Controls.Add(labelModel);
            carPanel.Controls.Add(labelPrice);
            carPanel.Controls.Add(buttonAddToCart);

            labelBrand.Location = new Point(15, 235);
            labelModel.Location = new Point(15, 255);
            labelPrice.Location = new Point(15, 275);
            buttonAddToCart.Location = new Point(100, 300);

            pictureBox.Click += (sender, e) =>
            {
                OpenCarPartsDetailsForm(imagePath, brand, model);
            };

            buttonAddToCart.Click += (sender, e) =>
            {

                decimal totalPrice = price * (1 + dis / 100);  // Calculate total price with discount
                ListViewItem item = new ListViewItem($"{brand}   {model}            {price}")
                {
                    SubItems = 
                    {
                        price.ToString("C"),
                        "1", // Default quantity
                        totalPrice.ToString("C") // Total price
                    }
                };
                CPView.CarsPartsViewListView.Items.Add(item);
                UpdateGrandTotal();
                MessageBox.Show("Car added to ListView");
            };

            CPView.flowLayoutPanelForCarParts.Controls.Add(carPanel);
        }

        // Method to open the details form for a specific car part
        private void OpenCarPartsDetailsForm(string imagePath, string brand, string model)
        {
            try
            {
                string query = "SELECT * FROM CarParts_DetailsTable WHERE carParts_Brand = carParts_Brand AND carParts_Model = @carParts_Model";
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("carParts_Brand", brand);
                    cmd.Parameters.AddWithValue("@carParts_Model", model);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string Name = reader["parts_Name"] != DBNull.Value ? reader["parts_Name"].ToString() : string.Empty;
                            decimal price = reader["carParts_Price"] != DBNull.Value ? Convert.ToDecimal(reader["carParts_Price"]) : 0;
                            string Description = reader["Description"] != DBNull.Value ? reader["Description"].ToString() : string.Empty;

                            CarPartsDetailsView CarPartsdetailsView = new CarPartsDetailsView(imagePath, brand, model, Name, Description, price);
                            CarPartsdetailsView.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No details found for this car part.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally { connect.Close(); }
        }

        // Method to load models based on the selected brand
        private void LoadModels(string brand)
        {
            try
            {
                connect.Open();
                string query = $"SELECT DISTINCT carParts_Model FROM CarParts_DetailsTable JOIN BrandTable ON CarParts_DetailsTable.carParts_Brand = BrandTable.Brand_ID WHERE Brand_name = '{CPView.brandsComBx.SelectedItem}'";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@carParts_Brand", brand);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        CPView.modelComBx.Items.Clear();
                        while (reader.Read())
                        {
                            CPView.modelComBx.Items.Add(reader["carParts_Model"].ToString());
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading models: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // Method to update the grand total in the ListView
        private void UpdateGrandTotal()
        {

            // Calculate the grand total by summing the last column (total price) of each ListViewItem
            decimal grandTotal = CPView.CarsPartsViewListView.Items
                 .Cast<ListViewItem>()
                 .Where(item => item.Text != "Grand Total") // Ignore any existing Grand Total item
                 .Sum(item => decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency));

            // Check if the Grand Total item already exists
            ListViewItem grandTotalItem = CPView.CarsPartsViewListView.Items
                .Cast<ListViewItem>()
                .FirstOrDefault(item => item.Text == "Grand Total");

            if (grandTotalItem != null)
            {
                // Update the existing Grand Total item's total price
                grandTotalItem.SubItems[3].Text = grandTotal.ToString("C");
            }
            else
            {
                // Create a new Grand Total item if it doesn't exist
                grandTotalItem = new ListViewItem("Grand Total")
                {
                    Font = new Font(CPView.CarsPartsViewListView.Font, FontStyle.Bold)
                };
                grandTotalItem.SubItems.Add(""); // Empty for Price column
                grandTotalItem.SubItems.Add(""); // Empty for Quantity column
                grandTotalItem.SubItems.Add(grandTotal.ToString("C")); // Grand Total price

                // Add the new Grand Total item to the ListView
                CPView.CarsPartsViewListView.Items.Add(grandTotalItem);
            }

            // Ensure the Grand Total item is at the bottom of the list
            CPView.CarsPartsViewListView.Items.Remove(grandTotalItem);
            CPView.CarsPartsViewListView.Items.Add(grandTotalItem);
        }

        // Event handler for form load: initializes the view
        private void CarPartsViewLoad()
        {
            DisplayAllCarParts();
            LoadBrands();
        }

        // Event handler for brand selection change: loads models based on selected brand
        private void brandsComBx_SelectedIndexChanged_1()
        {
            if (CPView.brandsComBx.SelectedIndex != -1)
            {
                // Load models based on the selected brand
                LoadModels(CPView.brandsComBx.SelectedItem.ToString());
                // Display cars based on the selected brand and model
                string brand = CPView.brandsComBx.SelectedItem.ToString();
                Console.WriteLine(brand);
                DisplayCarParts($"SELECT * FROM CarParts_DetailsTable JOIN BrandTable ON CarParts_DetailsTable.carParts_Brand = BrandTable.Brand_ID WHERE Brand_name = '{brand}'");
            }
        }

        // Event handler for model selection change: updates displayed car parts based on selected model
        private void modelComBx_SelectedIndexChanged()
        {

            if (CPView.modelComBx.SelectedIndex != -1 && CPView.brandsComBx.SelectedIndex != -1)
            {
                // Display cars based on the selected brand and model
                string brand = CPView.brandsComBx.SelectedItem.ToString();
                string model = CPView.modelComBx.SelectedItem.ToString();
                DisplayCarParts($"SELECT * FROM CarParts_DetailsTable JOIN BrandTable ON CarParts_DetailsTable.carParts_Brand = BrandTable.Brand_ID WHERE Brand_name = '{brand}' AND carParts_Model = '{model}'");
            }
        }

        // Event handler for saving to cart: implementation pending
        private void SaveToCart_Click()
        {
            // Implementation for saving items to cart
        }

        // Method to load brands into the combo box
        private void LoadBrands()
        {

            string query = "SELECT Brand_name FROM BrandTable";
            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(query, connect))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    CPView.brandsComBx.Items.Clear();
                    while (reader.Read())
                    {
                        CPView.brandsComBx.Items.Add(reader["Brand_name"].ToString());
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading brands: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }

            // Display all cars initially
            DisplayAllCarParts();
        }
    }
}
