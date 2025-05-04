using ABC_Car_Traders.commonClass;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    class Add_CarClass : ABC_DBClass
    {
        // Properties to hold car details
        public int id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public decimal price { get; set; }
        public decimal tax { get; set; }
        public string qty { get; set; }
        public string fuel { get; set; }
        public string Gear { get; set; }
        public string car_Type { get; set; }
        public string color { get; set; }
        public string year { get; set; }
        public string cc { get; set; }
        public string imagePath { get; set; }
        public CarForm myForm { get; set; }

        // Constructor to initialize the form and load data into dropdowns
        public Add_CarClass(CarForm _form)
        {
            myForm = _form;

            // Load dropdowns with data from the database
            string brandsql = "select * from BrandTable";
            string Fuelsql = "SELECT * FROM Fuel_Type";
            string Gearsql = "SELECT * FROM Gear_Type";
            string TypeCarsql = "SELECT * FROM Car_Type";
            loadFKInComboBox(brandsql, myForm.brandComBx, "Brand_name", "Brand_ID");
            loadFKInComboBox(Fuelsql, myForm.fuelComBx, "name", "fuel_type_id");
            loadFKInComboBox(Gearsql, myForm.gearComBx, "Gear_Type", "Gear_ID");
            loadFKInComboBox(TypeCarsql, myForm.CarTypeComBx, "Car_Type", "Car_Type_Id");

            // Event handlers for various button clicks and cell selection in DataGridView
            myForm.Load += (object sender, EventArgs e) => view();
            myForm.saveBtn.Click += (object sender, EventArgs e) => save();
            myForm.updateBtn.Click += (object sender, EventArgs e) => update();
            myForm.deleteBtn.Click += (object sender, EventArgs e) => delete();
            myForm.carGridView.CellClick += cellClick;
            myForm.browseBtn.Click += (object sender, EventArgs e) => uploadImage();
            myForm.clearBtn.Click += (object sender, EventArgs e) => clear();
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
                id = int.Parse(selectedRow.Cells["car_Id"].Value.ToString());
                brand = selectedRow.Cells["car_Brand"].Value.ToString();
                model = selectedRow.Cells["car_Model"].Value.ToString();
                price = decimal.Parse(selectedRow.Cells["car_Price"].Value.ToString());
                tax = decimal.Parse(selectedRow.Cells["car_Tax"].Value.ToString());
                qty = selectedRow.Cells["car_Qty"].Value.ToString();
                fuel = selectedRow.Cells["fuel_type_id"].Value.ToString();
                Gear = selectedRow.Cells["car_Gear_Id"].Value.ToString();
                car_Type = selectedRow.Cells["car_Type_Id"].Value.ToString();
                color = selectedRow.Cells["car_Color"].Value.ToString();
                year = selectedRow.Cells["car_year"].Value.ToString();
                cc = selectedRow.Cells["car_CC"].Value.ToString();
                imagePath = selectedRow.Cells["image_Path"].Value.ToString();

                // Update form fields with selected car details
                myForm.idBox.Text = id.ToString();
                myForm.brandComBx.Text = brand;
                myForm.modelTxt.Text = model;
                myForm.priceTxt.Text = price.ToString("F2");
                myForm.taxTxt.Text = tax.ToString("F2");
                myForm.qtyTxt.Text = qty;
                myForm.fuelComBx.Text = fuel;
                myForm.gearComBx.Text = Gear;
                myForm.CarTypeComBx.Text = car_Type;
                myForm.colorTxt.Text = color;
                myForm.yearTxt.Text = year;
                myForm.ccTxt.Text = cc;
                myForm.addImg.Text = imagePath;
            }
        }

        // Method to save a new car record to the database
        public void save()
        {
            string sql = $"insert into Car_DetailsTable (car_Brand, car_Model, car_Price, car_Tax, car_Qty, fuel_type_Id, car_Gear_Id, car_Type_Id, car_Color, car_year, car_CC, image_Path) " +
                $"values ('{myForm.brandComBx.SelectedValue}', '{myForm.modelTxt.Text}', '{myForm.priceTxt.Text}', '{myForm.taxTxt.Text}', '{myForm.qtyTxt.Text}', '{myForm.fuelComBx.SelectedValue}', '{myForm.gearComBx.SelectedValue}', " +
                $"'{myForm.CarTypeComBx.SelectedValue}', '{myForm.colorTxt.Text}', '{myForm.yearTxt.Text}', '{myForm.ccTxt.Text}', '{myForm.pathTxt.Text}')";
            if (execute(sql, executeType.save))
            {
                view(); // Refresh the data grid view to show the newly added record
            }
        }

        // Method to update an existing car record in the database
        public void update()
        {
            if (showUpdateConfirmationMessage())
            {
                string sql = $"update Car_DetailsTable set car_Brand = '{myForm.brandComBx.SelectedValue}', " +
                $"car_Model = '{myForm.modelTxt.Text}', " +
                $"car_Price = '{myForm.priceTxt.Text}', " +
                $"car_Tax = '{myForm.taxTxt.Text}', " +
                $"car_Qty = '{myForm.qtyTxt.Text}', " +
                $"fuel_type_Id = '{myForm.fuelComBx.SelectedValue}', " +
                $"car_Gear_Id = '{myForm.gearComBx.SelectedValue}', " +
                $"car_Type_Id = '{myForm.CarTypeComBx.SelectedValue}', " +
                $"car_Color = '{myForm.colorTxt.Text}', " +
                $"car_year = '{myForm.yearTxt.Text}', " +
                $"car_CC = '{myForm.ccTxt.Text}', " +
                $"image_Path = '{myForm.pathTxt.Text}' " +
                $"where car_Id = '{myForm.idBox.Text}'";
                if (execute(sql, executeType.update))
                {
                    view(); // Refresh the data grid view to show the updated record
                }
            }
        }

        // Method to delete a car record from the database
        public void delete()
        {
            if (showDeleteConfirmationMessage())
            {
                string sql = $"delete from Car_DetailsTable where car_Id = '{myForm.idBox.Text}'";
                if (execute(sql, executeType.delete))
                {
                    view(); // Refresh the data grid view to remove the deleted record
                }
            }
        }

        // Method to load all car records into DataGridView
        public void view()
        {
            string sql = "select * from Car_DetailsTable";
            loadDataInDataGridView(sql, myForm.carGridView);
        }

        // Method to upload an image for the car
        private void uploadImage()
        {
            // Open file dialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                myForm.addImg.Image = Image.FromFile(openFileDialog.FileName);
                myForm.pathTxt.Text = openFileDialog.FileName; // Update image path
            }
        }

        // Method to clear form fields
        private void clear()
        {
            myForm.idBox.Text = id.ToString();
            myForm.brandComBx.Text = brand;
            myForm.priceTxt.Text = price.ToString("F2");
            myForm.taxTxt.Text = tax.ToString("F2");
            myForm.qtyTxt.Text = qty;
            myForm.fuelComBx.Text = fuel;
            myForm.gearComBx.Text = Gear;
            myForm.CarTypeComBx.Text = car_Type;
            myForm.colorTxt.Text = color;
            myForm.yearTxt.Text = year;
            myForm.ccTxt.Text = cc;
            myForm.addImg.Text = imagePath;
            myForm.idBox.Focus(); // Optionally reset focus to the first field
        }
    }
}
