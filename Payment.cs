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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders
{
    public partial class CarMenu : Form
    {

        private SqlConnection connect = new SqlConnection(@"Data Source=BMCC-NITHU;Initial Catalog=ABC_Traders;Integrated Security=True");

        public string username {  get; set; }
        public int groupId {  get; set; }

        public CarMenu(string _username, int _groupId)
        {
            InitializeComponent();

            username = _username;
            groupId = _groupId;

        }
        private void AddNewCar_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM addToCart JOIN addToCartDetail ON addToCart.order_group_id = addToCartDetail.order_group_id WHERE addToCart.username = '{username}' AND addToCart.order_group_id = {groupId}";
            DataTable dt = getDataFromDB(sql);
            paymentGridView.DataSource = dt;
            

        }

        private DataTable getDataFromDB(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, connect);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void PayLater_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your payments to add Later.");
            this.Close();
        }

        private void Pay_Click(object sender, EventArgs e)
        {
            connect.Open();
            string sql = $"UPDATE ordergroupstatus SET status = 'paid' WHERE order_group_id = {groupId}";
            SqlCommand cmd = new SqlCommand(sql, connect);
            int affectedRow = cmd.ExecuteNonQuery();

            if (affectedRow > 0)
            {
                MessageBox.Show("Payment Successfully.");
            }
            connect.Close();

            this.Close();

        }
    }
}
