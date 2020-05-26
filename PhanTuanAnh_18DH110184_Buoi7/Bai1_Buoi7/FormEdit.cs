using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_Buoi7
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        public static readonly string connectionString = "Data Source=DESKTOP-G3K9KPG;Initial Catalog=QLQuan;Integrated Security=True";

        private void FormEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormMain F1 = new FormMain();
            F1.ShowDialog();
        }

        
        SqlConnection connection;

        private void button1_Click(object sender, EventArgs e)
        {
            string mshh = txtMSHH.Text;
            string tenSanPham = txtTenSanPham.Text;
            int gia = int.Parse(txtGia.Text);
            bool tinhTrang = radioConHang.Checked ? true : false;

            connection = new SqlConnection(connectionString);
            string queryString = "UPDATE ThucUong SET TenHang = @TenHang, Gia = @Gia, TinhTrang = @TinhTrang WHERE MSHH=@MSHH";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHH", mshh);
            command.Parameters.AddWithValue("@TenHang", tenSanPham);
            command.Parameters.AddWithValue("@Gia", gia);
            command.Parameters.AddWithValue("@TinhTrang", tinhTrang);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read() == false)
            {
                MessageBox.Show("Bạn đã sửa thành công", "OKE!");
            }
            else
            {
                MessageBox.Show("Bạn đã nhập sai MSHH", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSHH.Focus();
                Clear();
            }
            reader.Close();
        }

        public void Clear()
        {
            txtMSHH.Text = "";
            txtGia.Text = "";
            txtTenSanPham.Text = "";
            radioConHang.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}