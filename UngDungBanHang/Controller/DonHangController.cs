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
    public class DonHangController
    {
        public List<DonHang> Get()
        {
            string query = "SELECT dh.*, xe.Ten, nv.Ten, kh.Ten FROM tbDonHang dh JOIN tbXe xe ON dh.MaXe = xe.Ma " +
                "JOIN tbNhanVien nv ON dh.NhanVienTuVan = nv.Ma " +
                "JOIN tbKhachHang kh ON dh.MaKhachHang = kh.Ma";
            List<DonHang> list = new List<DonHang>();
            try
            {
                using (SqlConnection cnn = Connection.CreateConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new DonHang()
                        {
                            Ma = reader.GetInt32(0),
                            MaXe = reader.GetString(1),
                            ThoiGian = DateTime.Parse(reader.GetString(2)),
                            NhanVienTuVan = reader.GetString(3),
                            TrangThai = reader.GetBoolean(4),
                            MaKhachHang = reader.GetString(5),
                            TenXe = reader.GetString(6),
                            TenNhanVien = reader.GetString(7),
                            TenKhachHang = reader.GetString(8)
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

        public bool Them(DonHang donHang)
        {
            string query = "INSERT INTO tbDonHang (MaXe, ThoiGian, NhanVienTuVan, TrangThai, MaKhachHang) VALUES (@MaXe, @ThoiGian, @NhanVienTuVan, @TrangThai, @MaKhachHang)";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@MaXe", donHang.MaXe);
                cmd.Parameters.AddWithValue("@ThoiGian", donHang.ThoiGian.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@NhanVienTuVan", donHang.NhanVienTuVan);
                cmd.Parameters.AddWithValue("@TrangThai", donHang.TrangThai);
                cmd.Parameters.AddWithValue("@MaKhachHang", donHang.MaKhachHang);


                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Xoa(int id)
        {
            string query = "DELETE FROM tbDonHang WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", id);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public object[] HienThiThongTin(DonHang donHang)
        {
            return new object[] { donHang.Ma, donHang.TenXe, donHang.ThoiGian.ToString("dd/MM/yyyy"), donHang.TenNhanVien, donHang.TrangThai, donHang.TenKhachHang };
        }
    }
}
