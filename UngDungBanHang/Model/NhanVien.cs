using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungBanHang.Model
{
    public class NhanVien
    {
        public string Ma{get;set;}
        public string Ten{get;set;}
        public string GioiTinh{get;set;}
        public DateTime NgaySinh{get;set;}
        public string DiaChi{get;set;}
        public string SDT{get;set;}
        public string Email{get;set;}
        public int Luong{get;set;}
        public string Anh{get;set;}
        public int PhongBan{get;set;}
        public int ChucVu{ get; set; }
        public string TenPhongBan { get; set; }
        public string TenChucVu { get; set; }
    }
}
