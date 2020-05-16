using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class SinhVien
    {
        public string maSo;
        public string hoTen;
        public string diaChi;
        public int year;

        public string GetMaSo()
        {
            return maSo;
        }

        public string GetHoTen()
        {
            return hoTen;
        }

        public string GetDiaChi()
        {
            return diaChi;
        }

        public int GetYear()
        {
            return year;
        }

        public SinhVien() { }

        public SinhVien(string maSo, string hoTen, string diaChi, int year)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            this.year = year;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            string hoTen = Console.ReadLine();
            Console.Write("Nhap ma so sinh vien: ");
            string maSo = Console.ReadLine();
 
            Console.Write("Nhap dia chi sinh vien: ");
            string diaChi = Console.ReadLine();
            Console.Write("Nhap sinh vien nam thu may: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("--------------Thong tin sinh vien-------------------------");
        }

        public void Output()
        {
            
            Console.WriteLine("Ho ten: "+hoTen+"\nMa so: "+maSo+"\nDia chi: "+diaChi+"\nSinh vien nam: "+year);
        }
    }
}
