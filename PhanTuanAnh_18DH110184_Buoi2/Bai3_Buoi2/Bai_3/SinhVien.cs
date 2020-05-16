using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class SinhVien
    {
        private string hoTen;
        private int namSinh;

        public string getHoTen()
        {
            return hoTen;
        }

        public int getNamSinh()
        {
            return namSinh;
        }

        public SinhVien() { }

        public SinhVien(string hoTen,int namSinh)
        {
            this.hoTen = hoTen;
            this.namSinh = namSinh;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
        }

        public int Tuoi()
        {
            System.DateTime time = System.DateTime.Now;
            int tuoi = time.Year;
            return tuoi - namSinh;
        }
        public void Output()
        {
            Console.WriteLine("Ho ten sinh vien: " + hoTen);
            Console.WriteLine("Nam sinh: "+namSinh);
            Console.WriteLine("Tuoi: " + Tuoi());
        }
    }
}
