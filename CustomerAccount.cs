using ABC_Car_Traders.commonClass;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ABC_Car_Traders
{
    public struct Cus_PageList
    {
        public string customer_name { get; set; }
        public string Name { get; set; }
        public Form form { get; set; }
    }

    public partial class CustomerAccount : Form
    {
        Cus_PageList[] pageLists =
        {
            new Cus_PageList(){Name = "Cus_Home", form = new Cus_Home()},
        };
        private string currentusername;

        Cus_PageList cus_PageList;


        public CustomerAccount(string name)
        {
            InitializeComponent();
            username_label.Text = name;
            cus_PageList.customer_name = name;
        }

        private void showPage(string _name)
        {
            foreach (Cus_PageList pageList in pageLists)
            {
                if (pageList.Name == _name)
                {
                    UIClass.appsFormLoadInsidePanel(pageList.form, CerterPanal_load);
                    CenterForm(pageList.form);
                    break;
                }
            }
        }

        private void clearActiveStyle()
        {
            foreach (Control c in TopBarContainer.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.BackColor = Color.Transparent;

                }
            }
        }

        private void TopBar_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Clear previous styles
            clearActiveStyle();

            // Set the button's color to indicate it's active
            btn.BackColor = Color.FromArgb(125, 112, 123);

            // Determine which form to load based on the clicked button
            string _pageName = btn.Text.Trim();
            showPage(_pageName);
        }

        private void CuatomerAccount_Load(object sender, EventArgs e)
        {
            showPage("Cus_Home"); // Load the Home page by default
        }

        private void CenterForm(Form form)
        {
            //form.TopLevel = false;
            //form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.None;

            //// Center the form in the panel
            //form.Location = new Point(
            //    (CerterPanal_load.Width - form.Width) / 2,
            //    (CerterPanal_load.Height - form.Height) / 2
            //);

            //CerterPanal_load.Controls.Add(form);
            //form.Show();
        }

     

        private void CerterPanal_load_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CarParts_Click(object sender, EventArgs e)
        {
            UIClass.appsFormLoadInsidePanel(new CarParts_View (cus_PageList.customer_name), CerterPanal_load);
        }

        private void Status_Click(object sender, EventArgs e)
        {
            UIClass.appsFormLoadInsidePanel(new OrderDetailsForm(), CerterPanal_load);
        }

        private void Home_Click(object sender, EventArgs e)
        {
            UIClass.appsFormLoadInsidePanel(new Cus_Home(), CerterPanal_load);
        }

        private void username_label_Click(object sender, EventArgs e)
        {
            Customer_Login customer_Login = new Customer_Login();
            this.Hide();
            customer_Login.Show();
        }

        private void carViewBtn_Click(object sender, EventArgs e)
        {
            UIClass.appsFormLoadInsidePanel(new Cars_View(cus_PageList.customer_name), CerterPanal_load);

        }

        private void Power_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
