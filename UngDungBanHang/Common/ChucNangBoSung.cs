using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UngDungBanHang.Controller;
using UngDungBanHang.Model;

namespace UngDungBanHang.Common
{
    public class ChucNangBoSung
    {
        public static string TuyenChonNhanVienTuVan()
        {
            NhanVienController controller = new NhanVienController();
            Random randomNhanVien = new Random();
            var listItem = controller.Get().Where(n => n.PhongBan == 3).ToList();
            int index = randomNhanVien.Next(listItem.Count);
            return listItem[index].Ma;

        }
        private static int LaySoDuoiLonNhat()
        {
            XeController controller = new XeController();
            List<int> listItem = new List<int>();
            controller.Get().ForEach(n =>
            {
                int soDuoi = int.Parse(n.Ma.Replace("MXE00", ""));
                listItem.Add(soDuoi);
            });
            listItem.Sort();
            return listItem[listItem.Count - 1];
        }
        public static string TaoMaMoi()
        {
            int soDuoi = LaySoDuoiLonNhat() + 1;
            return "MXE00" + soDuoi.ToString();
        }
        private static int LaySoDuoiLonNhatMaNhanVien()
        {
            NhanVienController controller = new NhanVienController();
            List<int> listItem = new List<int>();
            controller.Get().ForEach(n =>
            {
                int soDuoi = int.Parse(n.Ma.Replace("MNV00", ""));
                listItem.Add(soDuoi);
            });
            listItem.Sort();
            return listItem[listItem.Count - 1];
        }
        public static string TaoMaNhanVienMoi()
        {
            int soDuoi = LaySoDuoiLonNhatMaNhanVien() + 1;
            return "MNV00" + soDuoi.ToString();
        }
        private static int LaySoDuoiLonNhatMaKhachHang()
        {
            KhachHangController controller = new KhachHangController();
            List<int> listItem = new List<int>();
            controller.Get().ForEach(n =>
            {
                int soDuoi = int.Parse(n.Ma.Replace("MKH00", ""));
                listItem.Add(soDuoi);
            });
            listItem.Sort();
            return listItem[listItem.Count - 1];
        }
        public static string TaoMaKhachHangMoi()
        {
            int soDuoi = LaySoDuoiLonNhatMaKhachHang() + 1;
            return "MKH00" + soDuoi.ToString();
        }
    }
}
