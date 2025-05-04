using ABC_Car_Traders.commonClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    class Admin_LoginClass : ABC_DBClass
    {
        // Reference to the Admin_Login form instance
        public Admin_Login admin_login { get; set; }

        public Admin_LoginClass(Admin_Login _admin_login)
        {
            admin_login = _admin_login;

            // Handle the login button click
            admin_login.loginBtn.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    // Retrieve and trim the username and password from textboxes
                    string username = admin_login.UserNameTxt.Text.Trim();
                    string password = admin_login.passwordTxt.Text.Trim();

                    // Check if the username is empty and display the label if it is
                    if (string.IsNullOrEmpty(username))
                    {
                        admin_login.emptyUsername.Visible = true;  // Show the label
                    }

                    // Check if the password is empty and display the label if it is
                    if (string.IsNullOrEmpty(password))
                    {
                        admin_login.emptyPassword.Visible = true;  // Show the label
                    }

                    // If either username or password is empty, exit the method
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        return;
                    }

                    // SQL query to check the credentials against the Admin_Register table
                    string sql = $"SELECT * FROM Admin_Register WHERE admin_Name = '{username}' AND admin_Password = '{password}'";
                    DataTable dt = getDataFromDB(sql);

                    // If credentials are valid, hide the login form and show the AdminForm
                    if (dt.Rows.Count > 0)
                    {
                        admin_login.Hide();
                        AdminForm CA = new AdminForm();
                        CA.Show();
                    }
                    else
                    {
                        // Show error message if credentials are incorrect
                        MessageBox.Show("Incorrect username or password.");
                    }
                }
                catch (Exception ex)
                {
                    // Display any exceptions that occur
                    MessageBox.Show(ex.Message);
                }
            };

            // Hide the username error label when the username textbox is clicked
            admin_login.UserNameTxt.Click += (object sender, EventArgs e) =>
            {
                admin_login.emptyUsername.Visible = false;
            };

            // Hide the password error label when the password textbox is clicked
            admin_login.passwordTxt.Click += (object sender, EventArgs e) =>
            {
                admin_login.emptyPassword.Visible = false;
            };

            // Track password visibility state
            bool passwordVisible = false;

            // Show the password when the eyeCloseBtn is clicked
            admin_login.eyeCloseBtn.Click += (object sender, EventArgs e) =>
            {
                admin_login.passwordTxt.PasswordChar = '\0';  // Show password
                passwordVisible = true;

                // Toggle visibility of eye buttons
                admin_login.eyeCloseBtn.Visible = false;
                admin_login.eyeOpenBtn.Visible = true;
            };

            // Hide the password when the eyeOpenBtn is clicked
            admin_login.eyeOpenBtn.Click += (object sender, EventArgs e) =>
            {
                admin_login.passwordTxt.PasswordChar = '*';  // Hide password
                passwordVisible = false;

                // Toggle visibility of eye buttons
                admin_login.eyeOpenBtn.Visible = false;
                admin_login.eyeCloseBtn.Visible = true;
            };
        }
    }
}
