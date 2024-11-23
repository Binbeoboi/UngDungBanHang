using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngDungBanHang.Data;
using UngDungBanHang.Model;

namespace UngDungBanHang.Controller
{
    public class GioHangController
    {
        public List<GioHang> Get()
        {
            string query = "SELECT * FROM tbGioHang";
            List<GioHang> list = new List<GioHang>();
            try
            {
                using (SqlConnection cnn = Connection.CreateConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new GioHang()
                        {
                            Ma = reader.GetInt32(0),
                            MaSanPham = reader.GetString(1),
                            NgayThang = DateTime.Parse(reader.GetString(2)),    
                            MaKhachHang = reader.GetString(3),
                        });
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                return null;
            }
        }

        public bool Them(GioHang gioHang)
        {
            string query = "INSERT INTO tbGioHang (MaSanPham, NgayThang, MaKhachHang) VALUES (@MaSanPham, @NgayThang, @MaKhachHang)";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@MaSanPham", gioHang.MaSanPham);
                cmd.Parameters.AddWithValue("@NgayThang", gioHang.NgayThang.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@MaKhachHang", gioHang.MaKhachHang);


                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Xoa(int id)
        {
            string query = "DELETE FROM tbGioHang WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", id);
                return cmd.ExecuteNonQuery() == 1;
            }
        }
        public bool Sua(GioHang gioHang)
        {
            string query = "UPDATE tbGioHang SET MaSanPham = @MaSanPham, NgayThang = @NgayThang, MaKhachHang = @MaKhachHang WHERE Ma =  @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", gioHang.Ma);
                cmd.Parameters.AddWithValue("@MaSanPham", gioHang.MaSanPham);
                cmd.Parameters.AddWithValue("@NgayThang", gioHang.NgayThang.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@MaKhachHang", gioHang.MaKhachHang);


                return cmd.ExecuteNonQuery() == 1;
            }
        }
    }
}
