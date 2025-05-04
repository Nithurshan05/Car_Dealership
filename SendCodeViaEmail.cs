using System;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class Forgot_Password : Form
    {
        public Forgot_Password()
        {
            InitializeComponent();
        }
       
        private void ResetPassword_Click(object sender, EventArgs e)
        {
            ResetPassword RP = new ResetPassword();
            this.Hide();
            RP.Show();
        }
        private void Reset(object sender, EventArgs e)
        {

        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            Customer_Login BTL = new Customer_Login();
            this.Hide();
            BTL.Show();

        }
    }
}
    