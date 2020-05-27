using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Buoi8.Model
{
    class HoaDon
    {
        private string msdh;
        private DateTime ngayBan;

        public string Msdh
        {
            get { return msdh; }
            set { value = msdh; }
        }

        public DateTime NgayBan
        {
            get { return ngayBan; }
            set { ngayBan = value; }
        }

        public HoaDon() { }

        public HoaDon(string msdh, DateTime ngayBan)
        {
            this.msdh = msdh;
            this.ngayBan = ngayBan;
        }
    }
}
