using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungBanHang.Model
{
    public class GioHang
    {
        public int Ma{get;set;}
        public string MaSanPham{get;set;}
        public DateTime NgayThang{get;set;}
        public string MaKhachHang{ get; set; }

        public GioHang(string maSanPham, DateTime ngayThang, string maKhachHang)
        {
            Ma = 1;
            MaSanPham = maSanPham;
            NgayThang = ngayThang;
            MaKhachHang = maKhachHang;
        }

        public GioHang()
        {
        }
    }
}
