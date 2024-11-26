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
    public class KhachHangController
    {
        public List<KhachHang> Get()
        {
            string query = "SELECT * FROM tbKhachHang";
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                using (SqlConnection cnn = Connection.CreateConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(new KhachHang()
                        {
                            Ma = reader.GetString(0),
                            Ten = reader.GetString(1),
                            GioiTinh = reader.GetString(2),
                            NgaySinh = DateTime.Parse(reader.GetString(3)),
                            DiaChi = reader.GetString(4),
                            Sdt = reader.GetString(5),
                            Email = reader.GetString(6),
                            Password = reader.GetString(7),
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
        public Dictionary<string, string> GetTaiKhoan()
        {
            string query = "SELECT Email, Password FROM tbKhachHang";
            Dictionary<string, string> list = new Dictionary<string, string>();
            try
            {
                using (SqlConnection cnn = Connection.CreateConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0), reader.GetString(1));
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

        public bool Them(KhachHang kh)
        {
            string query = "INSERT INTO tbKhachHang VALUES(@Ma, @Ten, @GioiTinh, @NgaySinh, @DiaChi, @Sdt, @Email, @Password)";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", kh.Ma);
                cmd.Parameters.AddWithValue("@Ten", kh.Ten);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", kh.Sdt);
                cmd.Parameters.AddWithValue("@Email", kh.Email);
                cmd.Parameters.AddWithValue("@Password", kh.Password);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Xoa(string id)
        {
            string query = "DELETE FROM tbKhachHang WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", id);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Sua(KhachHang kh)
        {
            string query = "UPDATE tbKhachHang SET Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, Sdt = @Sdt, Email = @Email, Password = @Password WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.AddWithValue("@Ma", kh.Ma);
                cmd.Parameters.AddWithValue("@Ten", kh.Ten);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi);
                cmd.Parameters.AddWithValue("@Sdt", kh.Sdt);
                cmd.Parameters.AddWithValue("@Email", kh.Email);
                cmd.Parameters.AddWithValue("@Password", kh.Password);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public KhachHang Tim(string id)
        {
            KhachHang kh = new KhachHang();
            kh = Get().SingleOrDefault(n => n.Ma.ToLower().Trim().Equals(id.ToLower().Trim()));
            return kh;
        }
        public object[] HienThiThongTin(KhachHang kh)
        {
            return new object[] {kh.Ma, kh.Ten, kh.GioiTinh, kh.NgaySinh.ToString("dd/MM/yyyy"), kh.DiaChi, kh.Sdt, kh.Email, kh.Password };
        }
        public int LayTuoiKhachHang(KhachHang kh)
        {
            return DateTime.Now.Year - kh.NgaySinh.Year;
        }
        
    }
}
