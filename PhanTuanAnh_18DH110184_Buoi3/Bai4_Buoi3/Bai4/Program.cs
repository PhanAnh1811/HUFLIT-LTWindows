using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhongBan phong = new PhongBan();
            phong.Input();
            Console.WriteLine("Tong luong: " + phong.TongLuong());
            Console.ReadKey();
        }
    }
}
