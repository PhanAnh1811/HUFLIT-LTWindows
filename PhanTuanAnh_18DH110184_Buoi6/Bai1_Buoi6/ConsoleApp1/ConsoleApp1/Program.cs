using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Add()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap ma so hang hoa: ");
            string mshh = Console.ReadLine();
            Console.Write("Nhap ten Hang: ");
            string tenHang = Console.ReadLine();
            Console.Write("Nhap gia: ");
            int gia = int.Parse(Console.ReadLine());
            Console.Write("Nhap tinh trang: ");
            int tinhTrang = int.Parse(Console.ReadLine());
            Data.AddProduct(mshh, tenHang, gia, tinhTrang);
            Data.ListProduct();
        }
        static void Delete()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap ma so hang hoa can xoa: ");
            string mshh = Console.ReadLine();
            Data.DeleteProduct(mshh);
            Data.ListProduct();
        }
        static void Repair()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap ma so hang hoa can sua: ");
            string mshh = Console.ReadLine();
            Data.RepairProduct(mshh);
            Data.ListProduct();
        }

        static void AddBill()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap ma so hoa don: ");
            string msdh = Console.ReadLine();
            Data.CreateBill(msdh, "08/05/2020");
            Data.ListBill();
        }
        static void Main(string[] args)
        {
            DataProvider Data = new DataProvider();
            Console.WriteLine("DANH SACH CAC THUC UONG");
            Data.ListProduct();
            Console.WriteLine("-------------------------------------");
            Console.Write("Nhap ma so hoa don: ");
            string msdh = Console.ReadLine();
            Console.Write("Vui long nhap ma so thuc uong ban muon order: ");
            string mshh = Console.ReadLine();
            Console.Write("Vui long nhap so luong ban muon order: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Ti le giam cua sam pham ban order: ");
            int tiLeGiam = int.Parse(Console.ReadLine());

            Data.CreateDetailBill(msdh, mshh, soLuong, tiLeGiam);
            Data.ListDetail();
        }
    }
}
