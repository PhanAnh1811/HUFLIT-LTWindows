using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            DaThuc dt = new DaThuc();
            dt.Input();
            Console.WriteLine(dt[0].ToString());
            Console.WriteLine(dt.ToString());
            Console.WriteLine("Nhap x can tinh gia tri bieu thuc: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua cua x = {0} -> {1}", x, dt.Result(x));
            Console.ReadKey();
        }
    }
}
