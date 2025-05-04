using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class CarPartsForm : Form
    {
        public CarPartsForm()
        {
            InitializeComponent();
            new AddCarParts_Class(this);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
