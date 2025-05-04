using System;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CustomerRegister : Form
    {
        private CustomerClass customerClass = null;

        public CustomerRegister()
        {
            InitializeComponent();
            new CustomerClass(this);
        }


        private void backToLogin_Click(object sender, EventArgs e)
        {
            Customer_Login login = new Customer_Login();
            this.Hide();
            login.Show();
        }

        public void userNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerSubmitBtn_Click(object sender, EventArgs e)
        {

        }

        private void cus_Reg_Enter(object sender, EventArgs e)
        {

        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
