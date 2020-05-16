using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
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

            TrungDiem AB = new TrungDiem(A, B);
            Point I=AB.TD();
            Console.WriteLine("Trung diem I cua AB: I({0},{1})", I.getX(), I.getY());

            Console.ReadKey();
        }
    }
}
