using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class NVSanXuat : NhanVien
    {
        private int luongCoBan;
        private int soSanPham;

        public int LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }
        public int SoSanPham
        {
            get { return soSanPham; }
            set { soSanPham = value; }
        }

        public NVSanXuat(string maNV, string hoTen) : base(maNV, hoTen) { }

        public override int TinhLuong()
        {
            int kq = luongCoBan + soSanPham * 1000;
            if (soSanPham >= 3000)
            {
                kq = (int)(kq * 0.05);
            }
            return kq;
        }
    }
}
