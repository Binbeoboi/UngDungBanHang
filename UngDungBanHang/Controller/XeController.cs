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
    public class XeController
    {
        public List<Xe> Get()
        {
            string query = "SELECT xe.*, tt.Ten, tl.Ten FROM tbXe xe JOIN tbTinhTrang tt ON xe.TinhTrang = tt.Ma " +
                "JOIN tbTheLoaiXe tl ON xe.HopSo = tl.Ma";
            List<Xe> list = new List<Xe>();
            try
            {
                using(SqlConnection cnn = Connection.CreateConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new Xe()
                        {
                            Ma = reader.GetString(0),
                            Ten = reader.GetString(1),
                            HopSo = reader.GetInt32(2),
                            TinhTrang = reader.GetInt32(3),
                            Nam = reader.GetInt32(4),
                            SoLuong = reader.GetInt32(5),
                            GiaNhap = reader.GetInt32(6),
                            GiaBan = reader.GetInt32(7),
                            Anh = reader.GetString(8),
                            HangSanXuat = reader.GetString(9),
                            TenHopSo = reader.GetString(10),
                            TenTinhTrang = reader.GetString(11),
                        }) ;
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

        public bool Them(Xe xe)
        {
            string query = "INSERT INTO tbXe VALUES(@Ma, @Ten, @HopSo, @TinhTrang, @Nam, @SoLuong, @GiaNhap, @GiaBan, @Anh, @HangSanXuat)";
            using(SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", xe.Ma);
                cmd.Parameters.AddWithValue("@Ten", xe.Ten);
                cmd.Parameters.AddWithValue("@HopSo", xe.HopSo);
                cmd.Parameters.AddWithValue("@TinhTrang", xe.TinhTrang);
                cmd.Parameters.AddWithValue("@Nam", xe.Nam);
                cmd.Parameters.AddWithValue("@SoLuong", xe.SoLuong);
                cmd.Parameters.AddWithValue("@GiaNhap", xe.GiaNhap);
                cmd.Parameters.AddWithValue("@GiaBan", xe.GiaBan);
                cmd.Parameters.AddWithValue("@Anh", xe.Anh);
                cmd.Parameters.AddWithValue("@HangSanXuat", xe.HangSanXuat);

                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Xoa(string id)
        {
            string query = "DELETE FROM tbXe WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", id);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Sua(Xe xe)
        {
            string query = "UPDATE tbXe SET Ten = @Ten, HopSo = @HopSo, TinhTrang = @TinhTrang, Nam = @Nam, SoLuong = @SoLuong, GiaNhap = @GiaNhap, GiaBan = @GiaBan, Anh = @Anh, HangSanXuat = @HangSanXuat WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", xe.Ma);
                cmd.Parameters.AddWithValue("@Ten", xe.Ten);
                cmd.Parameters.AddWithValue("@HopSo", xe.HopSo);
                cmd.Parameters.AddWithValue("@TinhTrang", xe.TinhTrang);
                cmd.Parameters.AddWithValue("@Nam", xe.Nam);
                cmd.Parameters.AddWithValue("@SoLuong", xe.SoLuong);
                cmd.Parameters.AddWithValue("@GiaNhap", xe.GiaNhap);
                cmd.Parameters.AddWithValue("@GiaBan", xe.GiaBan);
                cmd.Parameters.AddWithValue("@Anh", xe.Anh);
                cmd.Parameters.AddWithValue("@HangSanXuat", xe.HangSanXuat);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public Xe Tim(string id)
        {
            Xe xe = new Xe();
            xe = Get().SingleOrDefault(n => n.Ma.ToLower().Trim().Equals(id.ToLower().Trim()));
            return xe;
        }

        public List<Xe> TimTheoTen(string name)
        {
            List<Xe> listXe = new List<Xe>();
            listXe = Get().Where(n => n.Ten.ToLower().Trim().Contains(name.ToLower().Trim())).ToList();
            return listXe;
        }
    }
}
