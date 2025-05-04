using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Car_Traders.commonClass;
using System.Windows.Forms;
using System.Drawing;

namespace ABC_Car_Traders
{
    class CustomerDetails : ABC_DBClass
    {
        // Properties to hold customer details
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string district { get; set; }
        public string nic { get; set; }
        public string town { get; set; }
        public string profileURL { get; set; }
        public customerForm customerDetails { get; set; }
        // Constructor to initialize the form and set up event handlers

        private Timer searchTimer;
        public CustomerDetails(customerForm _form)
        {
            // Initialize the search timer
            searchTimer = new Timer();
            searchTimer.Interval = 500; // Delay of 500 ms (adjustable)
            searchTimer.Tick += (object sender, EventArgs e) => PerformSearch();


            customerDetails = _form;
            customerDetails.Load += (object sender, EventArgs e) => view();
            customerDetails.saveBtn.Click += (object sender, EventArgs e) => save();
            customerDetails.updateBtn.Click += (object sender, EventArgs e) => update();
            customerDetails.deleteBtn.Click += (object sender, EventArgs e) => delete();
            customerDetails.customerGridView.CellClick += cellClick;
            customerDetails.browseBtn.Click += (object sender, EventArgs e) => uploadImage();
            customerDetails.clearBtn.Click += (object sender, EventArgs e) => clear();
            customerDetails.searchValueBox.TextChanged += (object sender, EventArgs e) => searchValueBox_TextChanged();
        }

        // Event handler for cell click in DataGridView
        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                DataGridView gv = (DataGridView)sender;
                DataGridViewRow selectedRow = gv.Rows[rowIndex];

                // Populate form fields with selected row data
                id = int.Parse(selectedRow.Cells["customer_id"].Value.ToString());
                name = selectedRow.Cells["customer_name"].Value.ToString();
                address = selectedRow.Cells["customer_Address"].Value.ToString();
                email = selectedRow.Cells["customer_email"].Value.ToString();
                mobile = selectedRow.Cells["customer_mobile"].Value.ToString();
                password = selectedRow.Cells["password"].Value.ToString();
                nic = selectedRow.Cells["NIC"].Value.ToString();
                town = selectedRow.Cells["town"].Value.ToString();
                district = selectedRow.Cells["district"].Value.ToString();
                profileURL = selectedRow.Cells["profileURL"].Value.ToString();
                

                // Update form fields with selected customer details
                customerDetails.idBox.Text = id.ToString();
                customerDetails.userNameTxt.Text = name;
                customerDetails.emailTxt.Text = email;
                customerDetails.mobileTxt.Text = mobile;
                customerDetails.passwordTxt.Text = password;
                customerDetails.nicTxt.Text = nic;
                customerDetails.townTxt.Text = town;
                customerDetails.districtTxt.Text = district;
                customerDetails.pathTxt.Text = profileURL;
                customerDetails.addressTex.Text = address;
            }
        }

        // Method to save a new customer record to the database
        public void save()
        {
            string sql = $"insert into cus_registration (customer_name,customer_Address, customer_email, customer_mobile, teacherName, friendName, " +
                $"password, NIC, town, district, profileURL) " +
                $"values ('{customerDetails.userNameTxt.Text}', '{customerDetails.addressTex.Text}', '{customerDetails.emailTxt.Text}', '{customerDetails.mobileTxt.Text}', " +
                $"'{customerDetails.passwordTxt.Text}', '{customerDetails.nicTxt.Text}', '{customerDetails.townTxt.Text}', " +
                $"'{customerDetails.districtTxt.Text}', '{customerDetails.profileImg.Text}', '{customerDetails.teachBx.Text}', '{customerDetails.frdBx.Text}')";
            if (execute(sql, executeType.save))
            {
                view(); // Refresh the DataGridView to show the newly added record
            }
        }

        // Method to update an existing customer record in the database
        public void update()
        {
            if (showUpdateConfirmationMessage())
            {
                string sql = $"update cus_registration set customer_name = '{customerDetails.userNameTxt.Text}', " +
                    $"customer_email = '{customerDetails.emailTxt.Text}', " +
                    $"customer_mobile = '{customerDetails.mobileTxt.Text}', " +
                    $"password = '{customerDetails.passwordTxt.Text}', " +
                    $"NIC = '{customerDetails.nicTxt.Text}', " +
                    $"town = '{customerDetails.townTxt.Text}', " +
                    $"district = '{customerDetails.districtTxt.Text}', " +
                    $"profileURL = '{customerDetails.pathTxt.Text}', " +
                    $"customer_Address = '{customerDetails.addressTex.Text}' " +
                    $"WHERE customer_id = '{customerDetails.idBox.Text}'";
                if (execute(sql, executeType.update))
                {
                    view(); // Refresh the DataGridView to show the updated record
                }
            }
        }

        // Method to load all customer records into DataGridView
        public void view()
        {
            string sql = "select * from cus_registration";
            loadDataInDataGridView(sql, customerDetails.customerGridView);
        }

        // Method to perform a search based on user input
        public void Search(string sql)
        {
            loadDataInDataGridView(sql, customerDetails.customerGridView);
        }

        // Method to delete a customer record from the database
        public void delete()
        {
            if (showDeleteConfirmationMessage())
            {
                string sql = $"delete from cus_registration where customer_id = '{customerDetails.idBox.Text}'";
                if (execute(sql, executeType.delete))
                {
                    view(); // Refresh the DataGridView to remove the deleted record
                }
            }
        }

        // Method to upload a profile image for the customer
        private void uploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                customerDetails.profileImg.Image = Image.FromFile(openFileDialog.FileName);
                customerDetails.pathTxt.Text = openFileDialog.FileName; // Update profile image path
            }
        }

        // Method to clear all form fields
        private void clear()
        {
            customerDetails.idBox.Text = string.Empty;
            customerDetails.userNameTxt.Text = string.Empty;
            customerDetails.addressTex.Text = string.Empty;
            customerDetails.passwordTxt.Text = string.Empty;
            customerDetails.pathTxt.Text = string.Empty;
            customerDetails.profileImg.Image = null;
            customerDetails.emailTxt.Text = string.Empty;
            customerDetails.nicTxt.Text = string.Empty;
            customerDetails.districtTxt.Text = string.Empty;
            customerDetails.townTxt.Text = string.Empty;
            customerDetails.mobileTxt.Text = string.Empty;
            customerDetails.idBox.Focus(); // Optionally reset focus to the ID field
        }

        // Event handler for text changed event in search value box
        private void searchValueBox_TextChanged()
        {
            if (searchTimer.Enabled)
            {
                searchTimer.Stop(); // Stop the timer if it's already running
            }
            searchTimer.Start(); // Restart the timer with each keystroke
        }

        private void PerformSearch()
        {
            searchTimer.Stop(); // Stop the timer to prevent multiple executions

            string col = customerDetails.searchColumnComboBox.Text;
            string searchValue = customerDetails.searchValueBox.Text;

            string sql = "select * from cus_registration";

            if (!string.IsNullOrEmpty(searchValue))
            {
                if (col == "ID")
                {
                    sql = $"select * from cus_registration where customer_id LIKE '{searchValue}%'";
                }
                else if (col == "Name")
                {
                    sql = $"select * from cus_registration where customer_name LIKE '{searchValue}%'";
                }
            }

            Search(sql); // Call the Search method to load filtered data
        }

    }
}
