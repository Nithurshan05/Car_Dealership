using ABC_Car_Traders.Customer;
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

namespace ABC_Car_Traders
{
    public partial class Customer_Login : Form
    {

        private Customer_LoginClass customer_LoginClass= null;

        public Customer_Login()
        {
            InitializeComponent();
            new Customer_LoginClass(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WelcomePage WP = new WelcomePage();
            this.Hide();
            WP.Show();

        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            CustomerRegister cusReg = new CustomerRegister();
            this.Hide();
            cusReg.Show();
        }

        private void forgetPasswordBtn_Click(object sender, EventArgs e)
        {
            Forgot_Password sendCode = new Forgot_Password();
            this.Hide();
            sendCode.Show();
        }

        private void Customer_Login_Load(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
