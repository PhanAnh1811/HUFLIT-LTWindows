using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Buoi6
{
    class Program
    {
        static void Add()
        {
            DataProvider Data = new DataProvider();
            Console.Write("Nhap ma so hang hoa: ");
            string mshh = Console.ReadLine();
            Console.Write("Nhap ten hang: ");
            string tenHang = Console.ReadLine();
            Console.Write("Nhap Gia: ");
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
            Console.Write("Nhap MSHH Can Sua: ");
            string mshh = Console.ReadLine();
            Data.RepairProduct(mshh);
            Data.ListProduct();
        }
    
        static void AddBill(string msdh)
        {
            DataProvider Data = new DataProvider();
            Data.CreateBill(msdh, "08/05/2020");
          
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            DataProvider Data = new DataProvider();
            Console.WriteLine("DANH SACH CAC THUC UONG");
            Data.ListProduct();
            Console.Write("Nhap ma so hoa don: ");
            string msdh = Console.ReadLine();
            Console.Write("Vui long nhap ma so thuc uong ban muon order: ");
            string mshh = Console.ReadLine();
            Console.Write("Vui long nhap so luong ban muon order: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Vui long nhap ti le giam: ");
            int tiLeGiam = int.Parse(Console.ReadLine());

            AddBill(msdh);
            Data.CreateDetailBill(msdh, mshh, soLuong, tiLeGiam);
            Data.Detail();
        }
    }
}