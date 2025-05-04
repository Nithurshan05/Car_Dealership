using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABC_Car_Traders.commonClass;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ABC_Car_Traders
{
    class AddCarParts_Class : ABC_DBClass
    {
        public int id { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string price { get; set; }
        public string discount { get; set; }
        public string qty { get; set; }
        public string partsName { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public string imagePath { get; set; }

        public CarPartsForm myForm { get; set; }
        public AddCarParts_Class(CarPartsForm _form)
        {
            myForm = _form;
            string brandsql = "select * from BrandTable";
            loadFKInComboBox(brandsql, myForm.brandComBx, "Brand_name", "Brand_ID");
            myForm.Load += (object sender, EventArgs e) => view();
            myForm.saveBtn.Click += (object sender, EventArgs e) => save();
            myForm.updateBtn.Click += (object sender, EventArgs e) => update();
            myForm.deleteBtn.Click += (object sender, EventArgs e) => delete();
            myForm.car_PartsGridView.CellClick += cellClick;
            myForm.browseBtn.Click += (object sender, EventArgs e) => uploadImage();
            myForm.clearBtn.Click += (object sender, EventArgs e) => clear();
        }
        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex > -1)
            {
                DataGridView gv = (DataGridView)sender;
                DataGridViewRow selectedRow = gv.Rows[rowIndex];

                id = int.Parse(selectedRow.Cells["carParts_Id"].Value.ToString());
                brand = selectedRow.Cells["carParts_Brand"].Value.ToString();
                 model = selectedRow.Cells["carParts_Model"].Value.ToString();
                 price = selectedRow.Cells["carParts_Price"].Value.ToString();
                 discount = selectedRow.Cells["carParts_Dis"].Value.ToString();
                 qty = selectedRow.Cells["carParts_Qty"].Value.ToString();
                 color = selectedRow.Cells["carParts_Color"].Value.ToString();
                 description = selectedRow.Cells["Description"].Value.ToString();
                 partsName = selectedRow.Cells["parts_Name"].Value.ToString();
                 imagePath = selectedRow.Cells["image_Path"].Value.ToString();
                
                myForm.idBox.Text = id.ToString();
                myForm.brandComBx.Text = brand;
                myForm.modelTxt.Text = model;
                myForm.priceTxt.Text = price;
                myForm.disTxt.Text = discount;
                myForm.qtyTxt.Text = qty;
                myForm.colorTxt.Text = color;
                myForm.addImg.Text = imagePath;
                myForm.partsNameTxt.Text = partsName;
                myForm.descriptionTxt.Text = description;

            }
        }
        public void save()
        {
            string sql = $"insert into CarParts_DetailsTable (parts_Name, carParts_Brand, carParts_Model , carParts_Price, carParts_Dis, carParts_Qty, carParts_Color, Description, image_Path) " +
                $"values ('{myForm.partsNameTxt.Text}','{myForm.brandComBx.SelectedValue}', '{myForm.modelTxt.Text}', '{myForm.priceTxt.Text}', '{myForm.disTxt.Text}' , '{myForm.qtyTxt.Text}', " +
                $" '{myForm.colorTxt.Text}' ,'{myForm.descriptionTxt.Text}', '{myForm.pathTxt.Text}')";
            if (execute(sql, executeType.save))
            {
                view();
            }
        }
        public void update()
        {
            if (showUpdateConfirmationMessage())
            {
                string sql = $"update CarParts_DetailsTable set carParts_Brand = '{myForm.brandComBx.SelectedValue}' , " +
                $"carParts_Model = '{myForm.modelTxt.Text}' ," +
                $"carParts_Price = '{myForm.priceTxt.Text}' ," +
                $"carParts_Dis = '{myForm.disTxt.Text}' ," +
                $"carParts_Qty = '{myForm.qtyTxt.Text}' ," +
                $"carParts_Color = '{myForm.colorTxt.Text}' ," +
                $"Description = '{myForm.descriptionTxt.Text}', " +
                $"parts_Name = '{myForm.partsNameTxt.Text}', " +
                $"image_Path = '{myForm.pathTxt.Text}'" +
                $"where carParts_ID = '{myForm.idBox.Text}'";
                if (execute(sql, executeType.update))
                {
                    view();
                }
            }
        }
        public void delete()
        {
            if (showDeleteConfirmationMessage())
            {
                string sql = $"delete from CarParts_DetailsTable where carParts_Id = '{myForm.idBox.Text}'";
                if (execute(sql, executeType.delete))
                {
                    view();
                }
            }
        }
        public void view()
        {
            string sql = "select * from CarParts_DetailsTable";
            loadDataInDataGridView(sql, myForm.car_PartsGridView);
        }
        private void uploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                myForm.addImg.Image = Image.FromFile(openFileDialog.FileName);
                myForm.pathTxt.Text = openFileDialog.FileName;
            }
        }
        private void clear()
        {
            myForm.idBox.Text = id.ToString();
            myForm.partsNameTxt.Text = partsName;
            myForm.brandComBx.Text = brand;
            myForm.priceTxt.Text = price.ToString();
            myForm.disTxt.Text = discount.ToString();
            myForm.qtyTxt.Text = qty;
            myForm.colorTxt.Text = color;
            myForm.descriptionTxt.Text = description;
            myForm.addImg.Text = imagePath;
            myForm.idBox.Focus();
        }
    }
}