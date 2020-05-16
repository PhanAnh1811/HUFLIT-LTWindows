using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class NVKinhDoanh : NhanVien
    {
        private int hopDong;
        private int luongCoBan;

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

        public NVKinhDoanh(string maNV, string hoTen) : base(maNV, hoTen) { }

        public override int TinhLuong()
        {
            return luongCoBan + hopDong * 500000;
        }
    }
}
