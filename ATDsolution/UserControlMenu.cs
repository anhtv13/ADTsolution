using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATDsolution
{
    public partial class UserControlMenu : UserControl
    {
        public event EventHandler ButtonClick;

        public UserControlMenu()
        {
            InitializeComponent();
        }

        #region Mouse Hover
        private void buttonThongtin_MouseHover(object sender, EventArgs e)
        {
            panelMenu2.BringToFront();
        }

        private void buttonGiaodich_MouseHover(object sender, EventArgs e)
        {
            panelMenu3.BringToFront();
        }

        private void buttonTaikhoan_MouseHover(object sender, EventArgs e)
        {
            panelMenu4.BringToFront();
        }

        private void buttonCaidat_MouseHover(object sender, EventArgs e)
        {
            panelMenu5.BringToFront();
        }
        #endregion

        #region Mouse Click
        //panel1
        private void buttonBanggia_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonBanggia, e);  
        }

        private void buttonThongtinCP_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonThongtinCP, e);  
        }

        private void buttonBieudo_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonBieudo, e);
        }

        private void buttonMarket_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonMarket, e);
        }

        private void buttonGDthoathuan_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonGDthoathuan, e);
        }

        //panel2
        private void buttonDatlenh_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonDatlenh, e);
        }

        private void buttonSolenh_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonSolenh, e);
        }

        private void buttonDangkitracuu_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonDangkitracuu, e);
        }

        private void buttonXacnhanphieulenh_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonXacnhanphieulenh, e);
        }

        private void buttonChuyentien_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonChuyentien, e);
        }

        private void buttonUngtruoctienban_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonUngtruoctienban, e);
        }

        private void buttonGuiHTLS_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonGuiHTLS, e);
        }

        private void buttonTattoanHTLS_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonTattoanHTLS, e);
        }

        //panel3
        private void buttonThongtincanhan_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonThongtincanhan, e);
        }

        private void buttonLichsumuaban_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonLichsumuaban, e);
        }

        private void buttonBangcandoi_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonBangcandoi, e);
        }

        private void buttonTrangthaiCK_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonTrangthaiCK, e);
        }

        private void buttonDanhmucdautu_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonDanhmucdautu, e);
        }

        private void buttonBaocaono_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonBaocaono, e);
        }

        private void buttonSaokechungkhoan_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonSaokechungkhoan, e);
        }

        private void buttonSaoketien_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonSaoketien, e);
        }

        //panel4
        private void buttonChialenh_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonChialenh, e);
        }

        private void buttonCauhinhcotbanggia_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonCauhinhcotbanggia, e);
        }

        private void buttonCauhinhgiaodienbanggia_Click(object sender, EventArgs e)
        {
            if (this.ButtonClick != null)
                this.ButtonClick(buttonCauhinhgiaodienbanggia, e);
        }
        #endregion

        

    }
}
