using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Buoi8
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            string msdh = this.txtBoxMSDH.Text;

            DataProvider dataProvider = new DataProvider();
            dataProvider.CreateBill(msdh, DateTime.Now);

            FormDetailBill formChiTietDonHang = new FormDetailBill(msdh);
            formChiTietDonHang.Show();

            formChiTietDonHang.FormClosed += new FormClosedEventHandler(OnCloseFormDetailBill);

            this.Hide();
        }

        private void OnCloseFormDetailBill(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
