using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            double x = double.Parse(this.txtSo.Text);
            this.txtKetQua.Text = (x * x).ToString();

            //double res = Math.Pow(x, 2);
            //this.txtKetQua.Text = "" + res;
        }

        private void btnLapPhuong_Click(object sender, EventArgs e)
        {
            double x = double.Parse(this.txtSo.Text);
            this.txtKetQua.Text = (x * x * x).ToString();

            //double res = Math.Pow(x, 3);
            //this.txtKetQua.Text = "" + res;
        }

        private void btnGiaiThua_Click(object sender, EventArgs e)
        {
            double res = 1;
            double x = double.Parse(this.txtSo.Text);

            for (double i = 1; i <= x; i++) 
            {
                res *= i;
            }

            this.txtKetQua.Text = "" + res;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void txtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
    }
}
