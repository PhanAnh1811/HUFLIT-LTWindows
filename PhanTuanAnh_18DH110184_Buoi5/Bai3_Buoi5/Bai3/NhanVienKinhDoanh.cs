using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class NhanVienKinhDoanh : NhanVien
    {
        private int hopDong = 0;
        private int luongCoBan = 0;
        public static readonly int tienThuonghopDong = 500000;
        public int HopDong
        {
            get { return hopDong; }
            set { hopDong = value; }
        }
        public int LuongCoBan
        {
            get { return luongCoBan; }
            set { luongCoBan = value; }
        }

        public NhanVienKinhDoanh(string maNV, string hoTen,int hopDong,int luongCoBan) : base(maNV, hoTen)
        {
            this.HopDong = hopDong;
            this.LuongCoBan = luongCoBan;
        }

        public override int TinhLuong()
        {
            return luongCoBan + hopDong * tienThuonghopDong;
        }
    }
}
