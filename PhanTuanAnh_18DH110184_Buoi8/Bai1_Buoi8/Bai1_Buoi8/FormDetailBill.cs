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
    public partial class FormDetailBill : Form
    {
        public FormDetailBill()
        {
            InitializeComponent();
            InitGioHang();
        }

        private void InitGioHang()
        {
            InitListView();
            InitMaHD();
            InitNgayBan();
        }

        private void InitListView()
        {
            listViewDSThucUong.View = View.Details;
            listViewDSThucUong.GridLines = true;
            listViewDSThucUong.Columns.Add("Tên sản phẩm", -2, HorizontalAlignment.Center);
            listViewDSThucUong.Columns.Add("Số lượng", -2, HorizontalAlignment.Center);
            listViewDSThucUong.Columns.Add("Giá", -2, HorizontalAlignment.Center);
            listViewDSThucUong.Columns.Add("Tỉ lệ giảm", -2, HorizontalAlignment.Center);
            listViewDSThucUong.Columns.Add("Thành tiền", -2, HorizontalAlignment.Center);
            listViewDSThucUong.Columns.Add("Ma san pham", -2, HorizontalAlignment.Center);
            listViewDSThucUong.Columns[5].Width = 0;
        }

        public void AddItem(ThucUong thucUong, int soLuong, int TiLeGiam)
        {
            ListViewItem item = new ListViewItem(thucUong.TenHangHoa);
            item.SubItems.Add(soLuong.ToString());
            item.SubItems.Add(thucUong.Gia.ToString());
            item.SubItems.Add(TiLeGiam.ToString());
            item.SubItems.Add(GetThucUongToTal(thucUong.Gia, soLuong, TiLeGiam).ToString());
            item.SubItems.Add(thucUong.MaHH);
            listViewDSThucUong.Items.Add(item);
            listViewDSThucUong.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDSThucUong.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDSThucUong.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDSThucUong.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDSThucUong.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private double GetThucUongToTal(int gia, int soLuong, int phanTram)
        {
            double temp = gia * soLuong;
            double discountTemp = gia * ((double)phanTram / 100) * soLuong;
            double total = temp - discountTemp;
            return total;
        }

        private void InitMaHD()
        {
            Random random = new Random();
            int digit = random.Next(99999999);
            string mahd = "HD" + digit;
            tbMaHD.Text = mahd;
        }

        private void InitNgayBan()
        {
            tbNgayBan.Text = GetDateTime().ToString();
        }

        private DateTime GetDateTime()
        {
            return DateTime.Now;
        }

        public void GetInvoiceTotal()
        {
            double total = 0;
            ListView.ListViewItemCollection collection = listViewDSThucUong.Items;
            foreach (ListViewItem item in collection)
                total += Convert.ToDouble(item.SubItems[4].Text);
            tbTotal.Text = total.ToString();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            DataProvider dbc = new DaTaProvider();

            HoaDon hoadon = new HoaDon();
            hoadon.Msdh = tbMaHD.Text;
            hoadon.NgayBan = GetDateTime();
            dbc.AddDonHang(hoadon);
            //Add cthd to db
            ListView.ListViewItemCollection collection = listViewDSThucUong.Items;
            foreach (ListViewItem item in collection)
            {
                ChiTietHoaDon cthd = new ChiTietHoaDon();
                cthd.Msdh = tbMaHD.Text;
                cthd.Mshh = item.SubItems[5].Text;
                cthd.SoLuong = Convert.ToInt32(item.SubItems[1].Text);
                cthd.TiLeGiam = Convert.ToInt32(item.SubItems[3].Text);
                //add to db
                dbc.AddCTDH(cthd);
            }
            MessageBox.Show("Hoàn thành!!!!!!");
            Close();
        }
}
