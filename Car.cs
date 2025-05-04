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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
            new Add_CarClass(this);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

        }
        private void browseBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
