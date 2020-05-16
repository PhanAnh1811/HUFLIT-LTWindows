using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            ListPhanSo listPs = new ListPhanSo();

            listPs.addPs();
            listPs.OutPut();

            Console.WriteLine("Tong cua n phan so = {0}",listPs.SumPs());
            Console.ReadKey();
        }
    }
}
