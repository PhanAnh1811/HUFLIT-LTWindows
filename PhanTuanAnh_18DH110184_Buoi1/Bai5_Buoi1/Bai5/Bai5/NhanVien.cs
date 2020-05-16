using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class NhanVien
    {
        private string hoTen;
        private double money;
        private int ngayVang;

        public string getHoTen()
        {
            return hoTen;
        }

        public double getMoney()
        {
            return money;
        }

        public int getNgayVang()
        {
            return ngayVang;
        }

        public NhanVien()
        {
            this.hoTen = "";
            this.money = 0;
            this.ngayVang = 0;
        }

        public NhanVien(string hoTen, double money, int ngayVang)
        {
            this.hoTen = hoTen;
            this.money = money;
            this.ngayVang = ngayVang;
        }
        public double Tinhmoney()
        {
            int trutien = ngayVang * 100000;
            return money - trutien;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten nhan vien: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap muc luong nhan vien: ");
            money = double.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            ngayVang = int.Parse(Console.ReadLine());
            Console.WriteLine("1 ngay vang bi tru 100.000VND");
            Console.WriteLine("------------------------------------------");
        }

        public void Output()
        {
            Console.WriteLine("Ho va ten nhan vien: " + hoTen);
            Console.WriteLine("Muc luong: " + money);
            Console.WriteLine("So ngay vang: " + ngayVang);
            Console.WriteLine("Tien luong con lai: " + Tinhmoney());

        }
    }
}
