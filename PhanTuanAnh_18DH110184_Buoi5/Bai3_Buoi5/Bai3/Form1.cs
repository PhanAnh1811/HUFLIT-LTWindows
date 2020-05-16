using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class FormBai3 : Form
    {
        public FormBai3()
        {
            InitializeComponent();
            View();
        }

        private void View()
        {
            this.rdBtnNVKD.Checked = true;
            this.txtBoxSLSP.Enabled = false;
        }

        private void Clear_Two_TextBox()
        {
            this.txtBoxSLSP.Text = "";
            this.txtBoxLCB.Text = "";
            this.txtBoxSLHD.Text = "";
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            NhanVien nv;
            string maNV = this.txtBoxMSNV.Text;
            string hoTen = this.txtBoxHoTenNV.Text;
            bool isNhanVienKinhDoanh = this.rdBtnNVKD.Checked;

            if (isNhanVienKinhDoanh)
            {
                int luongCB = int.Parse(this.txtBoxLCB.Text);
                int soLuongHD = int.Parse(this.txtBoxSLHD.Text);
                nv = new NhanVienKinhDoanh(maNV, hoTen, luongCB, soLuongHD);
            }

            else
            {
                int soLuongSP = int.Parse(this.txtBoxSLSP.Text);
                nv = new NhanVienSanXuat(maNV, hoTen, soLuongSP);            
            }

            lblLuongNhanVien.Text = nv.TinhLuong().ToString();
        }

        private void rdBtnNVSX_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Two_TextBox();

            this.txtBoxSLSP.Enabled = true;
            this.txtBoxSLHD.Enabled = false;
            this.txtBoxLCB.Enabled = false;           
        }

        private void rdBtnNVKD_CheckedChanged(object sender, EventArgs e)
        {
            Clear_Two_TextBox();

            this.txtBoxSLSP.Enabled = false;
            this.txtBoxLCB.Enabled = true;
            this.txtBoxSLHD.Enabled = true;           
        }
    }
}
