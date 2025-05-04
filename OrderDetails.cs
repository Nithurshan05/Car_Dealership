using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABC_Car_Traders
{
    public partial class OrderDetailsForm : Form
    {
        //private SqlConnection connect = new SqlConnection(@"Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True");

        public OrderDetailsForm()
        {
            InitializeComponent();
            new OrderDetailsClass(this);
        }
        private void CarPartOrder_Click(object sender, EventArgs e)
        {

        }

        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            //string sql = $"SELECT * from ordergroupstatus";
            //DataTable dt = getDataFromDB(sql);
            //OrderDetailsGridView.DataSource = dt;
        }

        private void CarOrder_Click(object sender, EventArgs e)
        {
            //string sql = $"SELECT * FROM addToCart JOIN ordergroupstatus ON addToCart.order_group_id = ordergroupstatus.order_group_id;";
            //DataTable dt = getDataFromDB(sql);
            //OrderDetailsGridView.DataSource = dt;
        }
    }
}




