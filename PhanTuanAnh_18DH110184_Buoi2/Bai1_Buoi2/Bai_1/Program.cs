using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A, B;
            double x, y;
            Console.Write("Nhap x cua diem A: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y cua diem A: ");
            y = double.Parse(Console.ReadLine());
            A = new Point(x, y);

            Console.Write("\nNhap x cua diem B: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y cua diem B: ");
            y = double.Parse(Console.ReadLine());
            B = new Point(x, y);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("A({0}, {1})", A.getX(), A.getY());
            Console.WriteLine("B({0}, {1})", B.getX(), B.getY());
            Console.WriteLine("-------------------------------");

            Vector AB = new Vector(A, B);
            Console.WriteLine("Vector AB({0}, {1})", AB.getX(), AB.getY());
           
            Console.WriteLine("Do dai doan thang AB la " + AB.Distance());
            Console.ReadKey();
        }
    }
}
