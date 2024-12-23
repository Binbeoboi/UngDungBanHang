﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngDungBanHang.Data;
using UngDungBanHang.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace UngDungBanHang.Controller
{
    public class NhanVienController
    {
        public List<NhanVien> Get()
        {
            List<NhanVien> lst = new List<NhanVien>();
            string sql = "SELECT nv.*, pb.Ten, cv.Ten FROM tbNhanVien nv JOIN tbPhongBan pb ON nv.PhongBan = pb.Ma " +
                "JOIN tbChucVu cv ON nv.ChucVu = cv.Ma";
            using(SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NhanVien nhan = new NhanVien();
                    nhan.Ma = reader.GetString(0);
                    nhan.Ten = reader.GetString(1);
                    nhan.GioiTinh = reader.GetString(2);
                    nhan.NgaySinh = DateTime.Parse(reader.GetString(3));
                    nhan.DiaChi = reader.GetString(4);
                    nhan.SDT = reader.GetString(5);
                    nhan.Email = reader.GetString(6);
                    nhan.Luong = reader.GetInt32(7);
                    nhan.PhongBan = reader.GetInt32(8);
                    nhan.ChucVu = reader.GetInt32(9);
                    nhan.TenPhongBan = reader.GetString(10);
                    nhan.TenChucVu = reader.GetString(11);
                    lst.Add(nhan);
                }
                return lst;
            }
        }

        public bool Them(NhanVien nv)
        {
            string sql = "INSERT INTO tbNhanVien VALUES (@Ma, @Ten, @GioiTinh, @NgaySinh, @DiaChi, @SDT, @Email, @Luong, @PhongBan, @ChucVu)";
            using(SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Ma", nv.Ma);
                cmd.Parameters.AddWithValue("@Ten", nv.Ten);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                cmd.Parameters.AddWithValue("@PhongBan", nv.PhongBan);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Xoa(string id)
        {
            string sql = "DELETE FROM tbNhanVien WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Ma", id);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public bool Sua(NhanVien nv)
        {
            string sql = "UPDATE tbNhanVien SET Ten = @Ten," +
                " GioiTinh = @GioiTinh, NgaySinh = @NgaySinh," +
                " DiaChi = @DiaChi, SDT = @SDT, Email = @Email," +
                " Luong = @Luong, PhongBan = @PhongBan" +
                ", ChucVu = @ChucVu WHERE Ma = @Ma";
            using (SqlConnection cnn = Connection.CreateConnection())
            {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@Ma", nv.Ma);
                cmd.Parameters.AddWithValue("@Ten", nv.Ten);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh.ToString("dd/MM/yyyy"));
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", nv.SDT);
                cmd.Parameters.AddWithValue("@Email", nv.Email);
                cmd.Parameters.AddWithValue("@Luong", nv.Luong);
                cmd.Parameters.AddWithValue("@PhongBan", nv.PhongBan);
                cmd.Parameters.AddWithValue("@ChucVu", nv.ChucVu);
                return cmd.ExecuteNonQuery() == 1;
            }
        }

        public NhanVien Tim(string id)
        {
            NhanVien nv = Get().SingleOrDefault(n => n.Ma.CompareTo(id) == 0);
            return nv != null ? nv : null;
        }
        public object[] HienThiThongTin(NhanVien nv)
        {
            return new object[] { nv.Ma, nv.Ten, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.Email, nv.TenPhongBan, nv.TenChucVu, nv.Luong };
        }
    }
}
