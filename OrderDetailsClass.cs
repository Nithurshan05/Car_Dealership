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
using System.Data;

namespace ABC_Car_Traders
{
    internal class OrderDetailsClass : ABC_DBClass
    {
        // Reference to the OrderDetailsForm instance
        public OrderDetailsForm OCD { get; set; }

        // Constructor that initializes event handlers for the OrderDetailsForm
        public OrderDetailsClass(OrderDetailsForm _form)
        {
            OCD = _form;
            OCD.Load += (object sender, EventArgs e) => OrderDetailsForm_Load();
            OCD.CarOrder.Click += (object sender, EventArgs e) => CarOrder_Click();
        }

        // Event handler for form load event
        private void OrderDetailsForm_Load()
        {
            // SQL query to select all records from the ordergroupstatus table
            string sql = $"SELECT * from ordergroupstatus";
            // Retrieve data from the database and bind it to the DataGridView
            DataTable dt = getDataFromDB(sql);
            OCD.OrderDetailsGridView.DataSource = dt;
        }

        // Event handler for CarOrder button click event
        private void CarOrder_Click()
        {
            // SQL query to join addToCart and ordergroupstatus tables
            string sql = $"SELECT * FROM addToCart JOIN ordergroupstatus ON addToCart.order_group_id = ordergroupstatus.order_group_id;";
            // Retrieve data from the database and bind it to the DataGridView
            DataTable dt = getDataFromDB(sql);
            OCD.OrderDetailsGridView.DataSource = dt;
        }

        // Method to execute a SQL query and return the results as a DataTable
        private DataTable getDataFromDB(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                // Use SqlDataAdapter to fill the DataTable with data from the database
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                // Show error message if an exception occurs
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}
