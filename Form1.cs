using ABC_Car_Traders.Customer;
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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
            new Admin_LoginClass(this);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            WelcomePage WP = new WelcomePage();
            this.Hide();
            WP.Show();

        }
    }
}
