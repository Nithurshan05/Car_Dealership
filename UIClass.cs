using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    internal class UIClass
    {
        //application close btn click fun
        public static void appCloseBtnFun()
        {
            Application.Exit();
        }

        public static void formCloseBtnFun(Form formName)
        {
            formName.Close();
        }

        public static void appsMinBtnFun(Form formName)
        {
            formName.WindowState = FormWindowState.Minimized;
        }

        public static void appsFormLoadInsidePanel(Form formName, Panel panelName)
        {
            //clear controls first
            panelName.Controls.Clear();

            //add controls
            formName.TopLevel = false;
            formName.AutoScroll = true;
            panelName.Controls.Add(formName);
            formName.FormBorderStyle = FormBorderStyle.None;
            formName.Dock = DockStyle.Fill;
            formName.Show();
        }
    }
}
