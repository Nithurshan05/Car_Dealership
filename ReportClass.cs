using ABC_Car_Traders.commonClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    class ReportClass : ABC_DBClass
    {
        public ReportsForm reportClass { get; set; }

        public ReportClass(ReportsForm _form)
        {
            reportClass = _form;

            // Handle date changes and refresh the report
            reportClass.FromDate.ValueChanged += (object sender, EventArgs e) => FromDate_ValueChanged();
            reportClass.ToDate.ValueChanged += (object sender, EventArgs e) => ToDate_ValueChanged();
        }

        private void FromDate_ValueChanged()
        {
            report(); // Refresh the report when the 'From Date' changes
        }

        private void ToDate_ValueChanged()
        {
            report(); // Refresh the report when the 'To Date' changes
        }

        private void report()
        {
            // Construct the SQL query to get data between the selected dates
            string sql = $"select * from addToCart where date between '{reportClass.FromDate.Text}' and '{reportClass.ToDate.Text}'";

            // Create and fill the DataTable with the query results
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            da.Fill(dt);

            // Bind the results to the DataGridView
            reportClass.ReportGridView.DataSource = dt;
        }
    }
}
