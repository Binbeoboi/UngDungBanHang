using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UngDungBanHang.Model
{
    public class DonHang
    {
       public int Ma{get;set;}
       public string MaXe{get;set;}
       public DateTime ThoiGian{get;set;}
       public string NhanVienTuVan{get;set;}
       public bool TrangThai{get;set;}
       public string MaKhachHang{ get; set; }
       public string TenXe { get; set; }
       public string TenNhanVien { get; set; }
       public string TenKhachHang { get; set; }
    }
}
