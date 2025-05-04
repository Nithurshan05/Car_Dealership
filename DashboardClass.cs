//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using ABC_Car_Traders.commonClass;
//using ABC_Car_Traders.Customer;
//using System.IO;
//using System.Data;
//using System.Windows.Forms.DataVisualization.Charting;

//namespace ABC_Car_Traders
//{
//    internal class DashboardClass : ABC_DBClass
//    {
//        public DashboardForm dashboardForm;
//        public DashboardClass(DashboardForm _form)
//        {
//            dashboardForm = _form;
//            dashboardForm.Load += (object sender, EventArgs e) =>
//            DisplayTotalUsers(); // Call method to display total users
//            DisplayTotalSoldCars(); // Call method to display total sold cars
//            DisplayTodaySoldAmount(); // Call method to display today's sold amount
//            DisplayCurrentMonthSoldAmount(); // Call method to display current month's sold amount
//            LoadCarChartData(); // Call method to display Car data in the chart
//            LoadCarPartsChartData(); // Call method to display CarParts data in the chart

//            private void DisplayTotalUsers()
//            {
//                try
//                {
//                    using (SqlConnection connection = new SqlConnection(Connect))
//                    {
//                        connection.Open();
//                        string query = "SELECT COUNT(*) FROM login"; // Query to get the total number of users
//                        SqlCommand command = new SqlCommand(query, connection);
//                        int totalUsers = (int)command.ExecuteScalar(); // Execute the query and get the total number of users

//                        // Set the Label text to display the total users
//                        TotalUserLbl.Text = "Total Users: " + totalUsers.ToString();
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("An error total users: " + ex.Message);
//                }
//            }

//            private void DisplayTotalSoldCars()
//            {
//                try
//                {
//                    using (SqlConnection connection = new SqlConnection(connectionString))
//                    {
//                        connection.Open();
//                        string query = "SELECT SUM(quantity) FROM addToCartDetail"; // Query to sum the total quantity of sold cars
//                        SqlCommand command = new SqlCommand(query, connection);
//                        object result = command.ExecuteScalar();
//                        int totalSoldCars = result != DBNull.Value ? Convert.ToInt32(result) : 0; // Handle null result

//                        // Set the Label text to display the total sold cars
//                        SoldCarLbl.Text = "Total Sold Cars: " /*+ totalSoldCars.ToString()*/;
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("An error total sold cars: " + ex.Message);
//                }
//            }

//            private void DisplayTodaySoldAmount()
//            {
//                try
//                {
//                    using (SqlConnection connection = new SqlConnection(connectionString))
//                    {
//                        connection.Open();

//                        // Query to sum today's sold amount based on the current date
//                        string query = "SELECT SUM(grand_total) FROM addToCart WHERE CAST(date AS DATE) = CAST(GETDATE() AS DATE)";
//                        SqlCommand command = new SqlCommand(query, connection);
//                        object result = command.ExecuteScalar();
//                        decimal todaySoldAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0; // Handle null result

//                        // Set the Label text to display today's sold amount
//                        TodaySoldAmountLbl.Text = "Today's Sold Amount: $" + todaySoldAmount.ToString("0.00");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("An error today's sold amount: " + ex.Message);
//                }
//            }

//            private void DisplayCurrentMonthSoldAmount()
//            {
//                try
//                {
//                    using (SqlConnection connection = new SqlConnection(connectionString))
//                    {
//                        connection.Open();

//                        // Query to sum the current month's sold amount
//                        string query = "SELECT SUM(grand_total) FROM addToCart WHERE YEAR(date) = YEAR(GETDATE()) AND MONTH(date) = MONTH(GETDATE())";
//                        SqlCommand command = new SqlCommand(query, connection);
//                        object result = command.ExecuteScalar();
//                        decimal currentMonthSoldAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0; // Handle null result

//                        // Set the Label text to display the current month's sold amount
//                        MonthSoldAmount.Text = "Current Month's Sold Amount: $" + currentMonthSoldAmount.ToString("0.00");
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("An error current month's sold amount: " + ex.Message);
//                }
//            }

//            private void LoadCarChartData()
//            {
//                try
//                {
//                    using (SqlConnection connection = new SqlConnection(connectionString))
//                    {
//                        connection.Open();

//                        // Query to fetch date and total grand price grouped by date
//                        string query = "SELECT CAST(date AS DATE) AS SaleDate, SUM(grand_total) AS TotalAmount FROM addToCart GROUP BY CAST(date AS DATE)";
//                        SqlCommand command = new SqlCommand(query, connection);
//                        SqlDataAdapter adapter = new SqlDataAdapter(command);
//                        DataTable dataTable = new DataTable();
//                        adapter.Fill(dataTable);

//                        // Set chart properties
//                        chart1.Series.Clear(); // Clear existing series
//                        chart1.Series.Add("Sales"); // Add new series
//                        chart1.Series["Sales"].XValueMember = "SaleDate"; // X-axis: SaleDate
//                        chart1.Series["Sales"].YValueMembers = "TotalAmount"; // Y-axis: TotalAmount
//                        chart1.Series["Sales"].ChartType = SeriesChartType.Line; // Set chart type to Line
//                        chart1.Series["Sales"].IsValueShownAsLabel = false; // Hide values on the chart

//                        // Bind the data
//                        chart1.DataSource = dataTable;
//                        chart1.DataBind();
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("An error occurred while loading chart data: " + ex.Message);
//                }
//            }
//            private void LoadCarPartsChartData()
//            {
//                try
//                {
//                    using (SqlConnection connection = new SqlConnection(connectionString))
//                    {
//                        connection.Open();

//                        // Query to fetch date and total grand price grouped by date
//                        string query = "SELECT CAST(date AS DATE) AS SaleDate, SUM(grand_total) AS TotalAmount FROM addToCart GROUP BY CAST(date AS DATE)";
//                        SqlCommand command = new SqlCommand(query, connection);
//                        SqlDataAdapter adapter = new SqlDataAdapter(command);
//                        DataTable dataTable = new DataTable();
//                        adapter.Fill(dataTable);

//                        // Set chart properties
//                        CarPartsChat.Series.Clear(); // Clear existing series
//                        CarPartsChat.Series.Add("Sales"); // Add new series
//                        CarPartsChat.Series["Sales"].XValueMember = "SaleDate"; // X-axis: SaleDate
//                        CarPartsChat.Series["Sales"].YValueMembers = "TotalAmount"; // Y-axis: TotalAmount
//                        CarPartsChat.Series["Sales"].ChartType = SeriesChartType.Pie; // Set chart type to Line
//                        CarPartsChat.Series["Sales"].IsValueShownAsLabel = false; // Hide values on the chart

//                        // Bind the data
//                        chart1.DataSource = dataTable;
//                        chart1.DataBind();
//                    }
//                }
//                catch (Exception ex)
//                {
//                    MessageBox.Show("An error chart data: " + ex.Message);
//                }
//            }
//        }
//    }
//}
