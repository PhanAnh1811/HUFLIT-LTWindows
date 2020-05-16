using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleApp1
{
    class DataProvider
    {
        public static readonly string connectionString = "Data Source=DESKTOP-G3K9KPG;Initial Catalog=QLQuan;Integrated Security=True";

        SqlConnection connection;
        public void ListProduct()
        {
            connection = new SqlConnection(connectionString);
            string queryString = "SELECT * FROM ThucUong;";
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        public void AddProduct(string MSHH, string TenHang, int Gia, int TinhTrang)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "INSERT INTO ThucUong (MSHH, TenHang, Gia, TinhTrang)" + "VALUES (@MSHH, @TenHang, @Gia, @TinhTrang);";

            string mshh = MSHH;
            string tenHang = TenHang;
            int gia = Gia;
            int tinhTrang = TinhTrang;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHH", mshh);
            command.Parameters.AddWithValue("@TenHang", tenHang);
            command.Parameters.AddWithValue("@Gia", gia);
            command.Parameters.AddWithValue("@TinhTrang", tinhTrang);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void DeleteProduct(string MSHH)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "DELETE FROM ThucUong WHERE MSHH=@MSHH";

            string mshh = MSHH;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHH", mshh);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void RepairProduct(string MSHH)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "UPDATE ThucUong SET TenHang = @TenHang, Gia= @Gia WHERE MSHH=@MSHH";

            string mshh = MSHH;
            Console.Write("Nhap Ten Hang Hoa Can Sua: ");
            string tenHang = Console.ReadLine();
            Console.Write("Nhap Gia Can Sua: ");
            string gia = Console.ReadLine();

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHH", mshh);
            command.Parameters.AddWithValue("@TenHang", tenHang);
            command.Parameters.AddWithValue("@Gia", gia);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void ListBill()
        {
            connection = new SqlConnection(connectionString);
            string queryString = "SELECT * FROM HoaDon;";
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}",
                    reader[0], reader[1]);
            }
            reader.Close();
        }

        public void CreateBill(string MSDH, string dateTime)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "INSERT INTO HoaDon (MSDH, NgayDat) VALUES (@MSDH, @NgayDat);";

            string msdh = MSDH;
            string ngayDat = dateTime;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSDH", msdh);
            command.Parameters.AddWithValue("@NgayDat", ngayDat);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void CreateDetailBill(string MSHD, string MSHH, int SoLuong, int TiLeGiam)
        {
            connection = new SqlConnection(connectionString);
            string queryString = "INSERT INTO HDChiTietDatHang (MSHD, MSHH, SoLuong, TiLeGiam) VALUES (@MSHD, @MSHH, @SoLuong, @TiLeGiam);";


            string mshh = MSHH;
            string mshd = MSHD;
            int soLuong = SoLuong;
            int tiLeGiam = TiLeGiam;

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@MSHD", mshd);
            command.Parameters.AddWithValue("@MSHH", mshh);
            command.Parameters.AddWithValue("@SoLuong", soLuong);
            command.Parameters.AddWithValue("@TiLeGiam", tiLeGiam);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Close();
        }

        public void ListDetail()
        {
            connection = new SqlConnection(connectionString);
            string queryString = "SELECT * FROM HDChiTietDatHang;";
            SqlCommand command = new SqlCommand(queryString, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("\t{0}\t{1}\t{2}\t{3}",
                    reader[0], reader[1], reader[2], reader[3]);
            }
            reader.Close();
        }
    }
}
