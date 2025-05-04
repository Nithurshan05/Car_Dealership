using ABC_Car_Traders.commonClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    class customerRegClass : ABC_DBClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string password { get; set; }
        public CustomerRegister myForm { get; set; }
    }
}
