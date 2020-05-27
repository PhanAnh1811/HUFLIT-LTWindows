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
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mshh = txtMSHH.Text;

            DataProvider data = new DataProvider();
            data.DeleteProduct(mshh);

            MessageBox.Show("Bạn Đã xóa thành công", "OKE!");
            txtMSHH.Text = "";
        }

        private void FormDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormMain F1 = new FormMain();
            F1.ShowDialog();
        }
    }
}
