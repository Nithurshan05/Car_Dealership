using System;
using ABC_Car_Traders.commonClass;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    class CustomerClass : ABC_DBClass
    {
        public CustomerRegister myForm { get; set; }
        public int id { get; set; }

        public CustomerClass(CustomerRegister _form)
        {
            myForm = _form;

            // Handle the register button click to save the customer information
            myForm.registerSubmitBtn.Click += (object sender, EventArgs e) => save();

            // Handle the form load event to display customer information
            myForm.Load += (object sender, EventArgs e) => view();
        }

        // Method to save new customer registration
        public void save()
        {
            // SQL query to insert new customer details into the database
            string sql = $"insert into cus_registration (customer_name, customer_email, customer_mobile, password, teacherName, friendName) " +
             $"values ('{myForm.userNameTxt.Text}', '{myForm.emailTxt.Text}', '{myForm.mobileTxt.Text}', '{myForm.passwordTxt.Text}', '{myForm.teachBx.Text}', '{myForm.frdBx.Text}')";
            // Execute the SQL query and refresh the view if successful
            if (execute(sql, executeType.save))
            {
                view();
            }
        }

        // Method to view customer details
        public void view()
        {
            // SQL query to select all customer details
            string sql = "select * from cus_registration";
            // Execute the SQL query to retrieve data (not shown in the current implementation)
        }

        // Method to update existing customer details
        public void update()
        {
            // Show a confirmation message before updating
            if (showUpdateConfirmationMessage())
            {
                // SQL query to update customer details
                string sql = $"update cus_registration set customer_email = '{myForm.emailTxt.Text}', " +
                             $"password = '{myForm.passwordTxt.Text}'";
                // Execute the SQL query and refresh the view if successful
                if (execute(sql, executeType.update))
                {
                    view();
                }
            }
        }
    }
}
