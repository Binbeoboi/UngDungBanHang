using Microsoft.Reporting.WinForms;
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
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class FormHopDong : Form
    {
        KhachHang kh = new KhachHang();
        Xe xe = new Xe();
        KhachHangController KhachHangController = new KhachHangController();
        XeController xeController = new XeController();
        public FormHopDong()
        {
            InitializeComponent();
        }
        DonHang dh = new DonHang();
        public FormHopDong(DonHang dh)
        {
            InitializeComponent();
            this.dh = dh;   
        }
        private void FormHopDong_Load(object sender, EventArgs e)
        {
            kh = KhachHangController.Tim(dh.MaKhachHang);
            xe = xeController.Tim(dh.MaXe);
            reportHopDong.LocalReport.ReportEmbeddedResource = "UngDungBanHang.View.ReportHopDong.rdlc";
            ReportParameter[] reportParameters = new ReportParameter[]
            {
                         new ReportParameter("ReportNgayThang", dh.ThoiGian.ToString("dd/MM/yyyy")),
                         new ReportParameter("ReportTenKhachHang", dh.TenKhachHang),
                         new ReportParameter("ReportNgaySinh", kh.NgaySinh.ToString("dd/MM/yyyy")),
                         new ReportParameter("ReportSdt", kh.Sdt),
                         new ReportParameter("ReportTenXe", xe.Ten),
                         new ReportParameter("ReportGiaTien", xe.GiaBan.ToString("N0" +" đồng")),
            };
            this.reportHopDong.LocalReport.SetParameters(reportParameters);
            this.reportHopDong.RefreshReport();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
