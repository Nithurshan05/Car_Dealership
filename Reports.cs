using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class ReportsForm : Form
    {
        internal ReportClass reportClass = null;

        //internal SqlConnection connect = new SqlConnection(@"Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True");

        public ReportsForm()
        {
            InitializeComponent();
            new ReportClass(this);
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            //report();
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            //report();
        }

        private void report()
        {
            //string sql = $"select * from addToCart where date between '{FromDate.Text}' and '{ToDate.Text}'";
            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter(sql, connect);
            //da.Fill(dt);
            //ReportGridView.DataSource = dt;
        }
    }
}
