using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class DonThuc
    {
        private double HeSo;
        private double SoMu;

        public DonThuc()
        {
            HeSo = 1;
            SoMu = 0;
        }

        public DonThuc(double HeSo, double SoMu)
        {
            this.HeSo = HeSo;
            this.SoMu = SoMu;
        }

        public override string ToString()
        {
            return " "+HeSo+"*x^"+SoMu;
        }

        public void InPut()
        {
            Console.Write("Nhap he so a: ");
            HeSo = double.Parse(Console.ReadLine());
            Console.Write("Nhap so mu: ");
            SoMu = double.Parse(Console.ReadLine());
        }

        public double Result(double x)
        {
            return HeSo * Math.Pow(x, SoMu);
        }        
    }
}
