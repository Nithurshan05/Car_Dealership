
//using ABC_Car_Traders.commonClass;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace ABC_Car_Traders
//{
//    class Car_DetailClass : ABC_DBClass
//    {
//        public int id { get; set; }
//        public string fuel { get; set; }
//        public string Gear { get; set; }
//        public string car_Type { get; set; }
//        public string color { get; set; }
//        public string year { get; set; }
//        public string cc { get; set; }
//        public string imagePath { get; set; }
//        //public Car_Details myForm { get; set; }

//        public Car_DetailClass(Car_Details _form)
//        {
//            myForm = _form;
//            string Fuelsql = "SELECT * FROM Fuel_Type";
//            string Gearsql = "SELECT * FROM Gear_Type";
//            string TypeCarsql = "SELECT * FROM Car_Type";
//            loadFKInComboBox(Fuelsql, myForm.fuelComBx, "name", "fuel_type_id");
//            loadFKInComboBox(Gearsql, myForm.gearComBx, "Gear_Type", "Gear_ID");
//            loadFKInComboBox(TypeCarsql, myForm.CarTypeComBx, "Car_Type", "Car_Type_Id");
//            myForm.Load += (object sender, EventArgs e) => view();
//            myForm.saveBtn.Click += (object sender, EventArgs e) => save();
//            myForm.updateBtn.Click += (object sender, EventArgs e) => update();
//            myForm.deleteBtn.Click += (object sender, EventArgs e) => delete();
//            myForm.carDetailGridView.CellClick += cellClick;
//            myForm.addImg.Click += (object sender, EventArgs e) => uploadImage();
//        }
//        private void cellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            int rowIndex = e.RowIndex;


//            if (rowIndex > -1)
//            {

//                DataGridView gv = (DataGridView)sender;
//                DataGridViewRow selectedRow = gv.Rows[rowIndex];

//                string fuel = selectedRow.Cells["fuel_type_id"].Value.ToString();
//                string gear = selectedRow.Cells["car_Gear_Id"].Value.ToString();
//                string type = selectedRow.Cells["car_Type_Id"].Value.ToString();
//                string color = selectedRow.Cells["car_Color"].Value.ToString();
//                string year = selectedRow.Cells["car_year"].Value.ToString();
//                string cc = selectedRow.Cells["car_CC"].Value.ToString();
//                string imagePath = selectedRow.Cells["image_Path"].Value.ToString();

//                myForm.colorTxt.Text = color;
//                myForm.yearTxt.Text = year;
//                myForm.ccTxt.Text = cc;
//                myForm.addImg.Text = imagePath;

//            }
//        }

//            public void save()
//            {
//                string sql = $"insert into Car_DetailsTable(fuel_type_Id, car_Gear_Id, car_Type_Id, car_Color, car_year, car_CC, image_Path) VALUES ({myForm.fuelComBx.SelectedValue}, '{myForm.gearComBx.SelectedValue}', '{myForm.CarTypeComBx.SelectedValue}', '{myForm.colorTxt.Text}' , '{myForm.yearTxt.Text}', '{myForm.ccTxt.Text}', '{myForm.pathTxt.Text}')";
//                if (execute(sql, executeType.save))
//                {
//                    view();
//                }

//            }

//        public void update()
//        {
//            if (showUpdateConfirmationMessage())
//            {
//                string sql = $"update Car_DetailsTable set fuel_type_id = {myForm.fuelComBx.SelectedValue} , " +
//                $"car_Gear_Id = '{myForm.gearComBx.SelectedValue}' ," +
//                $"car_Type_Id = '{myForm.CarTypeComBx.SelectedValue}' ," +
//                $"car_Color = '{myForm.colorTxt.Text}' ," +
//                $"car_Year = '{myForm.yearTxt.Text}' ," +
//                $"car_CC = '{myForm.ccTxt.Text}', " +
//                $"image_Path = '{myForm.pathTxt.Text}' " +
//                $"where car_ID = '{myForm.idBox.Text}'";
//                if (execute(sql, executeType.update))
//                {
//                    view();
//                }
//            }
//        }


//        public void delete()
//        {
//            if (showDeleteConfirmationMessage())
//            {
//                string sql = $"delete from Car_DetailsTable where car_ID = '{myForm.idBox.Text}'";
//                if (execute(sql, executeType.delete))
//                {
//                    view();
//                }
//            }
//        }

//        public void view()
//            {
//                string sql = "select * from Car_DetailsTable";
//                loadDataInDataGridView(sql, myForm.carDetailGridView);
//            }
        
//        private void uploadImage()
//        {
//            OpenFileDialog openFileDialog = new OpenFileDialog();
//            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
//            if (openFileDialog.ShowDialog() == DialogResult.OK)
//            {
//                myForm.addImg.Image = Image.FromFile(openFileDialog.FileName);
//                myForm.pathTxt.Text = openFileDialog.FileName;
//            }
//        }

//    } 
//}
