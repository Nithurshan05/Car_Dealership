using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders.Customer
{
    public partial class CarParts_View : Form
    {
        public string username { get; set; }
        public int _orderGroupId { get; set; }

        public CarParts_View(string _username)
        {
            InitializeComponent();
            username = _username;
            userNameLbl.Text = _username;
            new CarPartsClass(this);

        }
        internal SqlConnection connect = new SqlConnection(@"Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True");

        private void CarPartsViewLoad(object sender, EventArgs e)
        {

        }
        
        private void Part_ComBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveToCart_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    connect.Open();

                    // Get the current maximum order_group_id
                    int orderGroupId;
                    using (SqlCommand command = new SqlCommand("SELECT ISNULL(MAX(order_group_id), 9999) + 1 FROM addToCart", connect))
                    {
                        orderGroupId = (int)command.ExecuteScalar();
                    }

                    // Get the current date and time
                    DateTime currentDate = DateTime.Now;

                    // Calculate the grand total from the ListView (excluding the "Grand Total" row)
                    decimal grandTotal = CarsPartsViewListView.Items
                        .Cast<ListViewItem>()
                        .Where(item => item.Text != "Grand Total")
                        .Sum(item => decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency));

                    // Insert into addToCart table
                    string insertToCartQuery = $"INSERT INTO addToCart VALUES ({orderGroupId}, {grandTotal}, '{currentDate}', '{username}')";

                    SqlCommand cartCommand = new SqlCommand(insertToCartQuery, connect);
                    Console.WriteLine(insertToCartQuery);
                    cartCommand.ExecuteNonQuery();

                    // Insert into addToCartDetail table
                    foreach (ListViewItem item in CarsPartsViewListView.Items)
                    {
                        if (item.Text != "Grand Total")
                        {
                            string carName = item.SubItems[0].Text;
                            decimal price = decimal.Parse(item.SubItems[1].Text, System.Globalization.NumberStyles.Currency);
                            int quantity = int.Parse(item.SubItems[2].Text);
                            decimal totalPrice = decimal.Parse(item.SubItems[3].Text, System.Globalization.NumberStyles.Currency);

                            string insertToCartDetailQuery = @"
                INSERT INTO addToCartDetail (order_group_id, car_name, price, quantity, total_price) 
                VALUES (@order_group_id, @car_name, @price, @quantity, @total_price)"
                            ;

                            using (SqlCommand cartDetailCommand = new SqlCommand(insertToCartDetailQuery, connect))
                            {
                                cartDetailCommand.Parameters.AddWithValue("@order_group_id", orderGroupId);
                                cartDetailCommand.Parameters.AddWithValue("@car_name", carName);
                                cartDetailCommand.Parameters.AddWithValue("@price", price);
                                cartDetailCommand.Parameters.AddWithValue("@quantity", quantity);
                                cartDetailCommand.Parameters.AddWithValue("@total_price", totalPrice);

                                cartDetailCommand.ExecuteNonQuery();
                            }
                        }
                    }

                    // Insert into ordergroupstatus table with default status 'pending'
                    string insertToOrderGroupStatusQuery = @"
        INSERT INTO ordergroupstatus (order_group_id, status) 
        VALUES (@order_group_id, @status)"
                    ;

                    using (SqlCommand orderGroupStatusCommand = new SqlCommand(insertToOrderGroupStatusQuery, connect))
                    {
                        orderGroupStatusCommand.Parameters.AddWithValue("@order_group_id", orderGroupId);
                        orderGroupStatusCommand.Parameters.AddWithValue("@status", "pending");

                        orderGroupStatusCommand.ExecuteNonQuery();

                        _orderGroupId = orderGroupId;
                    }

                    MessageBox.Show("Cars successfully added to the cart with date saved!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving to the cart: " + ex.Message);
            }
            //this.Hide();
            new CarMenu(username, _orderGroupId).Show();
        }

        private void brandsComBx_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void modelComBx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
