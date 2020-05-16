using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen to: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------");
            Songuyento NT = new Songuyento(n);
            if (NT.CheckNT())
                Console.WriteLine("{0} la so nguyen to", NT.n);

            else
                Console.WriteLine("{0} khong la so nguyen to", NT.n);

            Console.ReadKey();
        }
    }
}
