using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Buoi8.Model
{
    class ThucUong
    {
        private string maHH, tenHangHoa;
        private int gia, tinhTrang;

        public string MaHH
        {
            get { return maHH; }
            set { maHH = value; }
        }

        public string TenHangHoa
        {
            get { return tenHangHoa; }
            set { tenHangHoa = value; }
        }

        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public int TinhTrang
        {
            get { return tinhTrang; }
            set { tinhTrang = value; }
        }

        public ThucUong() { }

        public ThucUong(string maHH, string tenHangHoa, int gia, int tinhTrang)
        {
            this.maHH = maHH;
            this.tenHangHoa = tenHangHoa;
            this.gia = gia;
            this.tinhTrang = tinhTrang;
        }
    }
}
