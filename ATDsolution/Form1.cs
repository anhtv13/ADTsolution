using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDsolution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControlMenu.ButtonClick += new EventHandler(UserControl_ButtonClick);
        }
        //đăng kí sự kiện
        private void UserControl_ButtonClick(object sender, EventArgs e)
        {
            userControlMenu.Visible = false;
            MessageBox.Show(sender.ToString());
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (userControlMenu.Visible == false)
            {
                userControlMenu.Visible = true;
            }
            else
            {
                userControlMenu.Visible = false;
            }
        }

        
    }
}
