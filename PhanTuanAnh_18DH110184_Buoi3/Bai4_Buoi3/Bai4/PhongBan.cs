using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class PhongBan
    {
        private List<Nhanvien> Phong;

        public PhongBan()
        {
            Phong = new List<Nhanvien>();
        }

        public double TongLuong()
        {
            double luong = 0;
            foreach (var nv in Phong)
            {
                luong += nv.Tinhmoney();
            }
            return luong;
        }

        public void Input()
        {
            while (!false)
            {
                Nhanvien nv = new Nhanvien();
                nv.Input();
                Phong.Add(nv);
                Console.WriteLine("Them nhan vien thanh cong");
                Console.WriteLine("Ban co muon nhap tiep? Nhan phim y tu ban phim: ");
                string pick = Console.ReadLine();
                if (pick != "y")
                {
                    break;
                }
            }
        }
    }
}
