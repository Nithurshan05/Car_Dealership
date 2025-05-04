using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CarPartsDetailsView : Form
    {
        private decimal carPrice;
        private string carName;
        public CarPartsDetailsView(string imagePath, string brand, string model, string color, string discription, decimal price)
        {
            InitializeComponent();
            // Set car details
            BrandLbl.Text = $"Brand: {brand}";
            ModelLbl.Text = $"Model: {model}";
            ColorLbl.Text = $"Color: {color}";
            PriceLbl.Text = $"Price: ${price}";
            DisLbl.Text = $" Year: {discription}";

            // Store car name and price
            carName = $"{brand} {model}";
            carPrice = price;

            // Load car image
            if (File.Exists(imagePath))
            {
                ViewImage.Image = Image.FromFile(imagePath);
                ViewImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
