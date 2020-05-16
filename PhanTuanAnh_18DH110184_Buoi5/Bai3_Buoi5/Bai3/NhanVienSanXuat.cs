using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class NhanVienSanXuat : NhanVien
    {
        
        private int soSanPham;
        public static readonly int tienThuongsanPham = 1000;
        
        public int SoSanPham
        {
            get { return soSanPham; }
            set { soSanPham = value; }
        }

        public NhanVienSanXuat(string maNV, string hoTen,int soSamPham) : base(maNV, hoTen)
        {
            this.SoSanPham = soSanPham;
        }

        public override int TinhLuong()
        {
            int kq = this.soSanPham *NhanVienSanXuat.tienThuongsanPham;
            if (soSanPham > 3000)
            {
                kq = (int)(kq * 1.05);
            }
            return kq;
        }
    }
}
