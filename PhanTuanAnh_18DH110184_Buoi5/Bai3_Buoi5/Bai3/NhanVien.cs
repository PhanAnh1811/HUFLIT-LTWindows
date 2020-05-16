using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    abstract class NhanVien
    {
        public string maNV;
        public string hoTen;

        public NhanVien(string maNV, string hoTen)
        {
            this.maNV = maNV;
            this.hoTen = hoTen;
        }

        public NhanVien()
        {
            maNV = "";
            hoTen = "";
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public abstract int TinhLuong();
    }
    }
