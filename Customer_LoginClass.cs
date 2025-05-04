using ABC_Car_Traders.commonClass;
using System;
using System.Data;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    class Customer_LoginClass : ABC_DBClass
    {
        public Customer_Login customer_Login { get; set; }

        public Customer_LoginClass(Customer_Login _customer_Login)
        {
            customer_Login = _customer_Login;

            // Handle the login button click
            customer_Login.loginBtn.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    string username = customer_Login.UserName.Text.Trim();
                    string password = customer_Login.passwordTxt.Text.Trim();

                    // Check if the username is empty
                    if (string.IsNullOrEmpty(username))
                    {
                        customer_Login.emptyUserName.Visible = true;  // Show the label
                    }

                    // Check if the password is empty
                    if (string.IsNullOrEmpty(password))
                    {
                        customer_Login.emptyPassword.Visible = true;  // Show the label
                    }

                    // If either field is empty, exit the method
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        return;
                    }

                    // Query to check credentials against the cus_registration table
                    string sql = $"SELECT * FROM cus_registration WHERE customer_name = '{username}' AND password = '{password}'";
                    DataTable dt = getDataFromDB(sql);

                    // If credentials are valid, hide the login form and show the CustomerAccount form
                    if (dt.Rows.Count > 0)
                    {
                        customer_Login.Hide();
                        new CustomerAccount(username).Show();
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
            customer_Login.UserName.Click += (object sender, EventArgs e) =>
            {
                customer_Login.emptyUserName.Visible = false;
            };

            // Hide the password error label when the password textbox is clicked
            customer_Login.passwordTxt.Click += (object sender, EventArgs e) =>
            {
                customer_Login.emptyPassword.Visible = false;
            };

            bool passwordVisible = false;

            // Show the password when the eyeCloseBtn is clicked
            customer_Login.eyeCloseBtn.Click += (object sender, EventArgs e) =>
            {
                customer_Login.passwordTxt.PasswordChar = '\0';  // Show password
                passwordVisible = true;

                // Toggle visibility of eye buttons
                customer_Login.eyeCloseBtn.Visible = false;
                customer_Login.eyeOpenBtn.Visible = true;
            };

            // Hide the password when the eyeOpenBtn is clicked
            customer_Login.eyeOpenBtn.Click += (object sender, EventArgs e) =>
            {
                customer_Login.passwordTxt.PasswordChar = '*';  // Hide password
                passwordVisible = false;

                // Toggle visibility of eye buttons
                customer_Login.eyeOpenBtn.Visible = false;
                customer_Login.eyeCloseBtn.Visible = true;
            };
        }
    }
}
