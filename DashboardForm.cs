using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ABC_Car_Traders
{
    public partial class DashboardForm : Form
    {
        private string connectionString = "Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True";

        public DashboardForm()
        {
            InitializeComponent();
            DisplayTotalUsers(); // Display total number of users
            DisplayTotalSoldCars(); // Display total number of sold cars
            DisplayTodaySoldAmount(); // Display today's sold amount
            DisplayCurrentMonthSoldAmount(); // Display current month's sold amount
            LoadCarChartData(); // Load and display car sales data in chart
            LoadCarPartsChartData(); // Load and display car parts data in chart
        }

        private void DisplayTotalUsers()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM login";
                    SqlCommand command = new SqlCommand(query, connection);
                    int totalUsers = (int)command.ExecuteScalar();
                    TotalUserLbl.Text = "Total Users: " + totalUsers.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching total users: " + ex.Message);
            }
        }

        private void DisplayTotalSoldCars()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(quantity) FROM addToCartDetail";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    int totalSoldCars = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    SoldCarLbl.Text = "Total Sold Cars: " + totalSoldCars.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching total sold cars: " + ex.Message);
            }
        }

        private void DisplayTodaySoldAmount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(grand_total) FROM addToCart WHERE CAST(date AS DATE) = CAST(GETDATE() AS DATE)";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    decimal todaySoldAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    TodaySoldAmountLbl.Text = "Today's Sold Amount: $" + todaySoldAmount.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching today's sold amount: " + ex.Message);
            }
        }

        private void DisplayCurrentMonthSoldAmount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT SUM(grand_total) FROM addToCart WHERE YEAR(date) = YEAR(GETDATE()) AND MONTH(date) = MONTH(GETDATE())";
                    SqlCommand command = new SqlCommand(query, connection);
                    object result = command.ExecuteScalar();
                    decimal currentMonthSoldAmount = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                    MonthSoldAmount.Text = "Current Month's Sold Amount: $" + currentMonthSoldAmount.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching current month's sold amount: " + ex.Message);
            }
        }

        private void LoadCarChartData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CAST(date AS DATE) AS SaleDate, SUM(grand_total) AS TotalAmount FROM addToCart GROUP BY CAST(date AS DATE)";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Configure chart properties
                    chart1.Series.Clear();
                    chart1.Series.Add("Sales");
                    chart1.Series["Sales"].XValueMember = "SaleDate";
                    chart1.Series["Sales"].YValueMembers = "TotalAmount";
                    chart1.Series["Sales"].ChartType = SeriesChartType.Line;
                    chart1.Series["Sales"].IsValueShownAsLabel = false;

                    // Bind the data to the chart
                    chart1.DataSource = dataTable;
                    chart1.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading car chart data: " + ex.Message);
            }
        }

        private void LoadCarPartsChartData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT CAST(date AS DATE) AS SaleDate, SUM(grand_total) AS TotalAmount FROM addToCart GROUP BY CAST(date AS DATE)";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Configure chart properties
                    CarPartsChat.Series.Clear();
                    CarPartsChat.Series.Add("Sales");
                    CarPartsChat.Series["Sales"].XValueMember = "SaleDate";
                    CarPartsChat.Series["Sales"].YValueMembers = "TotalAmount";
                    CarPartsChat.Series["Sales"].ChartType = SeriesChartType.Pie;
                    CarPartsChat.Series["Sales"].IsValueShownAsLabel = false;

                    // Bind the data to the chart
                    CarPartsChat.DataSource = dataTable;
                    CarPartsChat.DataBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading car parts chart data: " + ex.Message);
            }
        }

        private void CarPartsChat_Click(object sender, EventArgs e)
        {
            // Handle CarPartsChat click event if needed
        }
    }
}
