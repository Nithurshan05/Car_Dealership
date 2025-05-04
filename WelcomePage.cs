using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders.Customer
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void logoutBtn_Enter(object sender, EventArgs e)
        {
            
        }

        private void adminLogin_Click(object sender, EventArgs e)
        {
            Admin_Login admin_Login= new Admin_Login();
            this.Hide();
            admin_Login.Show();
        }

        private void CustomerLogin_Click(object sender, EventArgs e)
        {
            Customer_Login customer_Login = new Customer_Login();
            this.Hide();
            customer_Login.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
