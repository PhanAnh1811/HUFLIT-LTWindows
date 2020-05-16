using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class PhanSo
    {

        public int tuso;
        public int mauso;

        public PhanSo()
        {
            tuso = 0;
            mauso = 1;
        }

        public PhanSo(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        private int UCLN(int a, int b)
        {
            if (a % b == 0)
                return b;

            return UCLN(b, a % b);
        }

        public void RutGon()
        {
            int uSCLN = UCLN(tuso, mauso);
            tuso = tuso / uSCLN;
            mauso = mauso / uSCLN;
        }
        public string toString()
        {
            return tuso + "/" + mauso;
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo phanSoTong = new PhanSo();
            phanSoTong.tuso = b.tuso * a.mauso + b.mauso * a.tuso;
            phanSoTong.mauso = b.mauso * a.mauso;
            return phanSoTong;
        }
    }
}

