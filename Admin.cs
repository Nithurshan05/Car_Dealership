using ABC_Car_Traders.Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABC_Car_Traders
{
    public struct PageList
    {
        public string Name { get; set; }
        public Form form { get; set; }
    }
    public partial class AdminForm : Form
    {
        PageList[] pageLists =
        {
            new PageList(){Name = "Dashboard", form =  new DashboardForm()},
            new PageList(){Name = "Customer", form= new customerForm()},
            new PageList(){Name = "Car", form = new CarForm()},
            new PageList(){Name = "Car Parts", form = new CarPartsForm()},
            new PageList(){Name = "Order Details", form = new OrderDetailsForm()},
            new PageList(){Name = "Reports", form = new ReportsForm()},
            new PageList(){Name = "Settings", form = new SettingsForm()},

        };
        public AdminForm()
        {
            InitializeComponent();

        }
        private void navBtn_Click(object sender, EventArgs e)
        {
            clearActiveStyle();
            Button btn = (Button)sender;
            btn.ForeColor = Color.FromArgb(106, 4, 15);

            //change the name of the pageTitle
            string pageName = btn.Text.Trim();
            pageTitle.Text = pageName;

            //change the name of the page from clicked button
            string _pageName = btn.Text.Trim();
            pageTitle.Text = _pageName;
            showPage(_pageName);
        }

        private void showPage(string _name)
        {
            foreach (PageList pageList in pageLists)
            {
                if (pageList.Name == _name)
                {
                    UIClass.appsFormLoadInsidePanel(pageList.form, formLoadArea);
                    break;
                }
            }
        }

        private void clearActiveStyle()
        {
            foreach (Control c in appSideBarContainer.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.ForeColor = Color.FromArgb(0, 23, 61);
                }
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            showPage("Dashboard");
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Admin_Login adminLogout = new Admin_Login();
            this.Hide();
            adminLogout.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formLoadArea_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
