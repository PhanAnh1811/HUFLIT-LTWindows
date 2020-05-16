using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class FormBai2 : Form
    {
        public FormBai2()
        {
            InitializeComponent();
        }

        private void btnCongPhanSo_Click(object sender, EventArgs e)
        {
            int tuSoA = int.Parse(this.txtBoxTuSoA.Text);
            int mauSoA = int.Parse(this.txtBoxMauSoA.Text);

            int tuSoB = int.Parse(this.txtBoxTuSoB.Text);
            int mauSoB = int.Parse(this.txtBoxMauSoB.Text);
            
            PhanSo KQ1 = new PhanSo(tuSoA, mauSoA)+ new PhanSo(tuSoB, mauSoB);
            KQ1.RutGon();
            lblKetQua.Text = "Kết quả cộng 2 phân số là: " + KQ1.toString();
            

        }
    }
}
