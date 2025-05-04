//using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;


//namespace ABC_Car_Traders.Customer
//{
//    public partial class Cars_View : Form
//    {
//        private string connect = "Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True";
//        private string currentcustomer_name { get; set; }

//        public string imagePath { get; set; }
//        public string brand { get; set; }
//        public string model { get; set; }
//        public decimal price { get; set; }
//        public decimal Tax { get; set; }

//        private Add_CarClass CarView_ClasscarView = null;

//        public string username { get; set; }

//        public Cars_View(string _username)
//        {
//            InitializeComponent();


//            // Initially hide the model combo box
//            //currentcustomer_name = customerName;
//            //userNameLbl.Text = $"customer_name: {customerName}";

//            userNameLbl.Text = _username;
//            username = _username;

//        }

//        private void DisplayAllCars()
//        {
//            DisplayCars("SELECT * FROM Car_DetailsTable");
//        }

//        private void DisplayCars(string query)
//        {
//            flowLayoutPanelForCar.Controls.Clear();
//            try
//            {
//                using (SqlConnection connection = new SqlConnection(connect))
//                {
//                    connection.Open();
//                    SqlCommand command = new SqlCommand(query, connection);
//                    SqlDataReader reader = command.ExecuteReader();

//                    while (reader.Read())
//                    {
//                        string imagePath = reader["image_Path"].ToString();
//                        string brand = reader["car_Brand"].ToString();
//                        string model = reader["car_Model"].ToString();
//                        string priceString = reader["car_Price"].ToString();
//                        string taxString = reader["car_Tax"].ToString();

//                        decimal price;
//                        decimal tax;
//                        if (!decimal.TryParse(priceString, out price) || !decimal.TryParse(taxString, out tax))
//                        {
//                            MessageBox.Show("Invalid price or tax format.");
//                            continue;
//                        }

//                        AddCarToPanel(imagePath, brand, model, price, tax);
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while loading car data: " + ex.Message);
//            }
//        }
//        private void AddCarToPanel(string imagePath, string brand, string model, decimal price, decimal tax)
//        {
//            Panel carPanel = new Panel
//            {
//                Size = new Size(250, 350),
//                BorderStyle = BorderStyle.FixedSingle,
//                Margin = new Padding(5)

//            };

//            PictureBox pictureBox = new PictureBox
//            {
//                Size = new Size(240, 230),
//                Cursor = Cursors.Hand,
//                Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : null,
//                SizeMode = PictureBoxSizeMode.StretchImage
//            };

//            Label labelBrand = new Label
//            {
//                Text = "Brand: " + brand,
//                AutoSize = true,
//                Font = new Font("Arial", 11, FontStyle.Bold),
//                ForeColor = Color.FromArgb(0, 23, 61),
//            };

//            Label labelModel = new Label
//            {
//                Text = "Model: " + model,
//                AutoSize = true,
//                Font = new Font("Arial", 11, FontStyle.Bold),
//                ForeColor = Color.FromArgb(0, 23, 61),
//            };

//            Label labelPrice = new Label
//            {
//                Text = "Price: " + price,
//                AutoSize = true,
//                Font = new Font("Arial", 11, FontStyle.Bold),
//                ForeColor = Color.FromArgb(0, 23, 61),
//            };

//            System.Windows.Forms.Button buttonAddToCart = new System.Windows.Forms.Button
//            {
//                Text = "Add to List",
//                AutoSize = true,
//                Font = new Font("Arial", 8, FontStyle.Bold),
//                ForeColor = Color.White,
//                BackColor = Color.FromArgb(0, 23, 61),
//                FlatStyle = FlatStyle.Flat,
//                TextAlign = ContentAlignment.MiddleCenter,
//                FlatAppearance = { BorderColor = Color.White }
//            };


//            carPanel.Controls.Add(pictureBox);
//            carPanel.Controls.Add(labelBrand);
//            carPanel.Controls.Add(labelModel);
//            carPanel.Controls.Add(labelPrice);
//            carPanel.Controls.Add(buttonAddToCart);

//            labelBrand.Location = new Point(15, 235);
//            labelModel.Location = new Point(15, 255);
//            labelPrice.Location = new Point(15, 275);
//            buttonAddToCart.Location = new Point(100, 300);

//            pictureBox.Click += (sender, e) =>
//            {
//                OpenCarDetailsForm(imagePath, brand, model);
//            };

//            buttonAddToCart.Click += (sender, e) =>
//            {
//                decimal totalPrice = price * (1 + tax / 100);  // Total Price calculation
//                ListViewItem item = new ListViewItem($"{brand} {model}");
//                item.SubItems.Add(price.ToString("C"));
//                item.SubItems.Add("1");  // Assuming default quantity as 1
//                item.SubItems.Add(totalPrice.ToString("C")); // Total Price column
//                CarsViewListView.Items.Add(item);
//                UpdateGrandTotal();
//                MessageBox.Show("Car added to ListView");
//            };

//            flowLayoutPanelForCar.Controls.Add(carPanel);
//        }

//        private void OpenCarDetailsForm(string imagePath, string brand, string model)
//        {

//            try
//            {

//                string query = "SELECT * FROM Car_DetailsTable WHERE car_Brand = @car_Brand AND car_Model = @car_Model";
//                using (SqlConnection conn = new SqlConnection(connect))
//                {
//                    conn.Open();
//                    using (SqlCommand cmd = new SqlCommand(query, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@car_Brand", brand);
//                        cmd.Parameters.AddWithValue("@car_Model", model);
//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {

//                            while (reader.Read())
//                            {
//                                if (reader.Read())
//                                {
//                                    string color = reader["car_Color"].ToString();
//                                    int year = Convert.ToInt32(reader["car_Year"]);
//                                    decimal price = Convert.ToDecimal(reader["car_Price"]);
//                                    string brandName = reader["Brand_name"].ToString();

//                                    Console.WriteLine(brandName + " " + color);

//                                    Car_Details_View detailsView = new Car_Details_View(imagePath, brandName, model, color, year, price);
//                                    detailsView.ShowDialog();
//                                }
//                                else
//                                {
//                                    MessageBox.Show("No details found for this car.");
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error : " + ex.Message);
//            }
//        }

//        private void brandsComBx_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            string selectedBrand = brandsComBx.SelectedItem?.ToString();
//            if (string.IsNullOrEmpty(selectedBrand)) return;

//            if (selectedBrand == "All")
//            {
//                brandsComBx.Visible = false;
//                DisplayAllCars();
//            }
//            else
//            {
//                brandsComBx.Visible = true;
//                LoadModels(selectedBrand);
//                DisplayCars($"SELECT cd.*, b.Brand_name FROM Car_DetailsTable cd JOIN BrandTable b ON cd.car_Brand = b.Brand_ID WHERE b.Brand_name = '{selectedBrand}'");
//            }

//        }
//        private void LoadModels(string brand)
//        {
//            try
//            {
//                using (SqlConnection conn = new SqlConnection(@"Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True"))
//                {
//                    conn.Open();
//                    string query = "SELECT DISTINCT car_Model FROM Car_DetailsTable WHERE brand = @car_Brand";
//                    using (SqlCommand cmd = new SqlCommand(query, conn))
//                    {
//                        cmd.Parameters.AddWithValue("@car_Brand", brand);
//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {
//                            modelComBx.Items.Clear();
//                            while (reader.Read())
//                            {
//                                modelComBx.Items.Add(reader["car_Model"].ToString());
//                            }
//                        }
//                    }
//                    conn.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while loading models: " + ex.Message);
//            }
//        }

//        private void modelComBx_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            string selectedBrand = brandsComBx.SelectedItem?.ToString();
//            string selectedModel = modelComBx.SelectedItem?.ToString();

//            if (string.IsNullOrEmpty(selectedBrand) || string.IsNullOrEmpty(selectedModel)) return;

//            DisplayCars($"SELECT * FROM Car_DetailsTable WHERE car_Brand = '{selectedBrand}' AND car_Model = '{selectedModel}'");
//        }
//        private void UpdateGrandTotal()
//        {
//            decimal grandTotal = CarsViewListView.Items
//                 .Cast<ListViewItem>()
//                 .Where(item => item.Text != "Grand Total")
//                 .Sum(item => decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency));

//            ListViewItem grandTotalItem = CarsViewListView.Items
//                .Cast<ListViewItem>()
//                .FirstOrDefault(item => item.Text == "Grand Total");

//            if (grandTotalItem != null)
//            {
//                // Update existing grand total item
//                grandTotalItem.SubItems[3].Text = grandTotal.ToString("C");
//            }
//            else
//            {
//                // Add new grand total item
//                grandTotalItem = new ListViewItem("Grand Total")
//                {
//                    Font = new Font(CarsViewListView.Font, FontStyle.Bold)
//                };
//                grandTotalItem.SubItems.Add(""); // Empty Price
//                grandTotalItem.SubItems.Add(""); // Empty Quantity
//                grandTotalItem.SubItems.Add(grandTotal.ToString("C")); // Total Price
//                CarsViewListView.Items.Add(grandTotalItem);
//            }

//            // Ensure the grand total item is at the bottom
//            CarsViewListView.Items.Remove(grandTotalItem);
//            CarsViewListView.Items.Add(grandTotalItem);
//        }

//        private void InitializeListView()
//        {
//            CarsViewListView.Columns.Add("Car Name", 200, HorizontalAlignment.Left);
//            CarsViewListView.Columns.Add("Price", 100, HorizontalAlignment.Left);
//            CarsViewListView.Columns.Add("Quantity", 100, HorizontalAlignment.Left);
//            CarsViewListView.Columns.Add("Total Price", 150, HorizontalAlignment.Left); // Total Price column
//            CarsViewListView.View = View.Details;
//            CarsViewListView.LabelEdit = true;

//        }
//        private void CarsViewLoad(object sender, EventArgs e)
//        {
//            LoadBrands();
//            DisplayAllCars();
//            InitializeListView();
//            //AddCarToPanel(imagePath, brand, model, carPrice, carTax);
//        }
//        private void LoadBrands()
//        {
//            try
//            {
//                using (SqlConnection conn = new SqlConnection(@"Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True"))
//                {
//                    conn.Open();
//                    string query = "SELECT DISTINCT Brand_name FROM BrandTable";
//                    using (SqlCommand cmd = new SqlCommand(query, conn))
//                    {
//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {
//                            brandsComBx.Items.Clear();
//                            brandsComBx.Items.Add("All");
//                            while (reader.Read())
//                            {
//                                brandsComBx.Items.Add(reader["Brand_name"].ToString());
//                            }
//                        }
//                    }
//                    conn.Close();
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while loading brands: " + ex.Message);
//            }
//        }

//        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void userNameLbl_Click(object sender, EventArgs e)
//        {

//        }

//        private void flowLayoutPanelForCar_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void SaveToCart_Click(object sender, EventArgs e)
//        {

//            try
//            {
//                using (SqlConnection connection = new SqlConnection(connect))
//                {
//                    connection.Open();

//                    // Get the current maximum order_group_id
//                    int orderGroupId;
//                    using (SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(order_group_id), 9999) + 1 FROM addToCart", connection))
//                    {
//                        orderGroupId = (int)command.ExecuteScalar();
//                    }

//                    // Get the current date and time
//                    DateTime currentDate = DateTime.Now;

//                    // Calculate the grand total from the ListView (excluding the "Grand Total" row)
//                    decimal grandTotal = CarsViewListView.Items
//                        .Cast<ListViewItem>()
//                        .Where(item => item.Text != "Grand Total")
//                        .Sum(item => decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency));

//                    // Insert into addToCart table
//                    string insertToCartQuery = $"INSERT INTO addToCart VALUES ({orderGroupId}, {grandTotal}, '{currentDate}', '{username}')";

//                    SqlCommand cartCommand = new SqlCommand(insertToCartQuery, connection);
//                    Console.WriteLine(insertToCartQuery);
//                    cartCommand.ExecuteNonQuery();

//                    // Insert into addToCartDetail table
//                    foreach (ListViewItem item in CarsViewListView.Items)
//                    {
//                        if (item.Text != "Grand Total")
//                        {
//                            string carName = item.SubItems[0].Text;
//                            decimal price = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
//                            int quantity = int.Parse(item.SubItems[2].Text);
//                            decimal totalPrice = decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency);

//                            string insertToCartDetailQuery = @"
//                        INSERT INTO addToCartDetail (order_group_id, car_name, price, quantity, total_price) 
//                        VALUES (@order_group_id, @car_name, @price, @quantity, @total_price)";

//                            using (SqlCommand cartDetailCommand = new SqlCommand(insertToCartDetailQuery, connection))
//                            {
//                                cartDetailCommand.Parameters.AddWithValue("@order_group_id", orderGroupId);
//                                cartDetailCommand.Parameters.AddWithValue("@car_name", carName);
//                                cartDetailCommand.Parameters.AddWithValue("@price", price);
//                                cartDetailCommand.Parameters.AddWithValue("@quantity", quantity);
//                                cartDetailCommand.Parameters.AddWithValue("@total_price", totalPrice);

//                                cartDetailCommand.ExecuteNonQuery();
//                            }
//                        }
//                    }

//                    // Insert into ordergroupstatus table with default status 'pending'
//                    string insertToOrderGroupStatusQuery = @"
//                INSERT INTO ordergroupstatus (order_group_id, status) 
//                VALUES (@order_group_id, @status)";

//                    using (SqlCommand orderGroupStatusCommand = new SqlCommand(insertToOrderGroupStatusQuery, connection))
//                    {
//                        orderGroupStatusCommand.Parameters.AddWithValue("@order_group_id", orderGroupId);
//                        orderGroupStatusCommand.Parameters.AddWithValue("@status", "pending");

//                        orderGroupStatusCommand.ExecuteNonQuery();
//                    }

//                    MessageBox.Show("Cars successfully added to the cart with date saved!");
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred while saving to the cart: " + ex.Message);
//            }
//        }


//    }

//}
