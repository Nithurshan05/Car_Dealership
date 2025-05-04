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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            Forgot_Password sendCode = new Forgot_Password();
            this.Hide();
            sendCode.Show();
        }
    }
}
