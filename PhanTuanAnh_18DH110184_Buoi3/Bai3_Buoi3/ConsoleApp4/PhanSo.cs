using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public int TuSo
        {
            get { return tuSo; }
            set { tuSo = value; }
        }

        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }

        public PhanSo()
        {
            this.tuSo = 0;
            this.mauSo = 1;
        }

        public void Nhap()
        {
            Console.Write("Nhap tu so: ");
            tuSo = Convert.ToInt16(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            mauSo = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("-----------------------------");
        }

        public static int UocSoChung(int a, int b)
        {
            if (b == 0)
                return a;
            return UocSoChung(b, a % b);
        }
        public override string ToString()
        {
            Console.WriteLine("--------------------------------");
            return "Phan so = [" + tuSo + "/" + mauSo + "]";
        }
        public void RutGon()
        {
            int USCLN = UocSoChung(tuSo, mauSo);
            tuSo = tuSo / USCLN;
            mauSo = mauSo / USCLN;
        }

        public double GiaTriThapPhan()
        {
            return tuSo * 1.0 / mauSo;
        }

        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo TongPs = new PhanSo();
            TongPs.tuSo = a.tuSo * b.mauSo + a.mauSo * b.tuSo;
            TongPs.mauSo = a.mauSo * b.mauSo;
            return TongPs;
        }
    }
}
