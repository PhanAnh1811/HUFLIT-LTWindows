using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        public static int HamMu(int x, int y)
        {
            int res = 1;
            for (int i = 1; i <= y; i++)
            {
                res = res * x;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen y: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------");
            Console.Write("Ket qua {0} mu {1} la: {2}", x, y, HamMu(x,y));
            Console.ReadKey();
        }
    }
}
