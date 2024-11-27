using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungBanHang.Data
{
    public class LinkConnection
    {
        //public static string linkConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=UngDungMuaBanXe;Integrated Security=True";
        //public static string linkImgIcon = @"C:\Learn\CSharp Learn\UngDungBanHang\UngDungBanHang\Img icon";
        //public static string linkImgSanPham = @"C:\Learn\CSharp Learn\UngDungBanHang\UngDungBanHang\Img SanPham";

        public static string linkConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={Application.StartupPath}\UngDungMuaBanXe.mdf;Integrated Security=True;Connect Timeout=30";
        public static string linkImgIcon = $@"{Application.StartupPath.Substring(0, Application.StartupPath.Length - 10)}\Img icon";
        public static string linkImgSanPham = $@"{Application.StartupPath.Substring(0, Application.StartupPath.Length - 10)}\Img SanPham";
    }
}
