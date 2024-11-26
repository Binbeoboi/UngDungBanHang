using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungBanHang.Controller;

namespace UngDungBanHang.View
{
    public partial class FormThongKe : Form
    {
        DonHangController controller = new DonHangController();
        KhachHangController khachHangController = new KhachHangController();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            ThongKeXeBanChayNhat();
            ThongKeKhachHangMuaNhieuNhat();
            ThongKeDoTuoiKhachHang();
        }

        private void ThongKeDoTuoiKhachHang()
        {
            int count20 = 0;
            int count40 = 0;
            int count60 = 0;
            int count80 = 0;
            khachHangController.Get().ForEach(n =>
            {
                if(khachHangController.LayTuoiKhachHang(n) < 20)
                {
                    count20++;
                }
                else if(khachHangController.LayTuoiKhachHang(n) < 40 && khachHangController.LayTuoiKhachHang(n) >= 20)
                {
                    count40++;
                }
                else if (khachHangController.LayTuoiKhachHang(n) < 60 && khachHangController.LayTuoiKhachHang(n) >= 40)
                {
                    count60++;
                }
                else
                {
                    count80++;
                }
            });
            chartThongKeDoTuoiKhachHang.Series["Độ tuổi"].Points.AddXY("Tuổi 20", count20);
            chartThongKeDoTuoiKhachHang.Series["Độ tuổi"].Points.AddXY("Tuổi 40", count40);
            chartThongKeDoTuoiKhachHang.Series["Độ tuổi"].Points.AddXY("Tuổi 60", count60);
            chartThongKeDoTuoiKhachHang.Series["Độ tuổi"].Points.AddXY("Tuổi 80", count80);

            lbThongKeTuoiKhachHang.Items.Add("- Tuổi 20:  " + count20 + " (Người)");
            lbThongKeTuoiKhachHang.Items.Add("");
            lbThongKeTuoiKhachHang.Items.Add("- Tuổi 40:  " + count40 + " (Người)");
            lbThongKeTuoiKhachHang.Items.Add("");
            lbThongKeTuoiKhachHang.Items.Add("- Tuổi 60:  " + count60 + " (Người)");
            lbThongKeTuoiKhachHang.Items.Add("");
            lbThongKeTuoiKhachHang.Items.Add("- Tuổi 80:  " + count80 + " (Người)");
            lbThongKeTuoiKhachHang.Items.Add("");
        }

        private void ThongKeKhachHangMuaNhieuNhat()
        {
            chartKhachHangMuaNhieuNhat.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            var data = controller.Get().GroupBy(n => n.TenKhachHang).Select(g => new
            {
                TenKhachHang = g.Key,
                tongSo = g.Count()
            }).ToList();
            int i = 1;
            data.ForEach(n =>
            {
                chartKhachHangMuaNhieuNhat.Series["Khách hàng"].Points.AddXY(n.TenKhachHang, n.tongSo);
                lbKhachHangMuaNhieuNhat.Items.Add(i + "   -   " + n.TenKhachHang);
                lbKhachHangMuaNhieuNhat.Items.Add("");
                i++;
            });
        }

        private void ThongKeXeBanChayNhat()
        {
            chartXeBanChay.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            var data = controller.Get().GroupBy(n => n.TenXe).Select(g => new
            {
                TenXe = g.Key,
                tongSo = g.Count()
            }).ToList();
            int i = 1;
            data.ForEach(n =>
            {
                chartXeBanChay.Series["Xe"].Points.AddXY(n.TenXe, n.tongSo);
                lbThongKeXeBanChay.Items.Add(i + "   -   " + n.TenXe);
                lbThongKeXeBanChay.Items.Add("");
                i++;
            });
        }
    }
}
