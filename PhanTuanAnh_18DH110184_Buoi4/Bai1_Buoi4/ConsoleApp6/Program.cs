using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien nhanVien;
            Console.WriteLine("NHAP THONG TIN NHAN VIEN");
            Console.Write("Nhap Ma Nhan Vien: ");
            string maNV = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");

        NhapLai:
            Console.WriteLine("NHAP LOAI NHAN VIEN");
            Console.WriteLine("(1) La Nhan Vien Kinh Doanh");
            Console.WriteLine("(2) La Nhan Vien San Xuat");
            int loai = int.Parse(Console.ReadLine());

            switch (loai)
            {
                case 1:
                    nhanVien = new NVKinhDoanh(maNV, hoTen);
                    Console.Write("Nhap Luong Co Ban: ");
                    int luongCoBan = int.Parse(Console.ReadLine());
                    Console.Write("Nhap So Luong Hop Dong: ");
                    int soLuongHopDong = int.Parse(Console.ReadLine());

                    (nhanVien as NVKinhDoanh).LuongCoBan = luongCoBan;
                    (nhanVien as NVKinhDoanh).HopDong = soLuongHopDong;
                    break;
                case 2:
                    nhanVien = new NVSanXuat(maNV, hoTen);
                    Console.Write("Nhap Luong Co Ban: ");
                    int luongCoBanSX = int.Parse(Console.ReadLine());
                    Console.Write("Nhap Luong San Pham: ");
                    int soLuongSanPham = int.Parse(Console.ReadLine());

                    (nhanVien as NVSanXuat).LuongCoBan = luongCoBanSX;
                    (nhanVien as NVSanXuat).SoSanPham = soLuongSanPham;
                    break;
                default:
                    Console.WriteLine("Vui Long Nhap (1) va (2)");
                    goto NhapLai;
                    break;
            }
            Console.WriteLine("-----------------------------------");
            int luong = nhanVien.TinhLuong();
            Console.WriteLine("Luong Cua Nhan Vien La: " + luong);
            Console.ReadKey();

        }

    }
}

