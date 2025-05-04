using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class customerForm : Form
    {
        internal CustomerDetails customerDetails = null;
        public customerForm()
        {
            InitializeComponent();
            new CustomerDetails(this);
        }

        private void yearTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void colorTex_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void pathTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerForm_Load(object sender, EventArgs e)
        {
            

        }
        private void searchValueBox_TextChanged(object sender, EventArgs e)
        {
            //string col = searchColumnComboBox.Text;

            //string sql = "select * from cus_registration";

            //if (col == "ID")
            //{
            //    sql = $"select * from cus_registration where customer_id like '{searchValueBox.Text}%'";
            //}
            //else if (col == "Name")
            //{
            //    sql = $"select * from cus_registration where customer_name like '{searchValueBox.Text}%'";
            //}
            //customerDetails.Search(sql);
        }
    }
}
 