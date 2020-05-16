using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2
{
    class Point
    {
        private double x, y;

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public Point() { }

        public Point (double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public void Input()
        {
            Console.Write("Nhap x cua diem A: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y cua diem A: ");
            y = double.Parse(Console.ReadLine());
            Console.Write("\nNhap x cua diem B: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Nhap y cua diem B: ");
            y = double.Parse(Console.ReadLine());
        }
    }
}
