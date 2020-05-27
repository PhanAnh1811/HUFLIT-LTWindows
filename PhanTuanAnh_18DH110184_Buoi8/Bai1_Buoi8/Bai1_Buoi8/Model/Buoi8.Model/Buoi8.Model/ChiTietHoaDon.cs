using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Buoi8.Model
{
    class ChiTietHoaDon
    {
        private string msdh, mshh;
        private int soLuong, tiLeGiam;

        public string Msdh
        {
            get { return msdh; }
            set { msdh = value; }
        }
        public string Mshh
        {
            get { return mshh; }
            set { mshh = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public int TiLeGiam
        {
            get { return tiLeGiam; }
            set { tiLeGiam = value; }
        }

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(string msdh, string mshh, int soLuong, int tiLeGiam)
        {
            this.msdh = msdh;
            this.mshh = mshh;
            this.soLuong = soLuong;
            this.tiLeGiam = tiLeGiam;
        }
    }
}
