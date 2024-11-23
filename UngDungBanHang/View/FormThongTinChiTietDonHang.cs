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
using UngDungBanHang.Enum;
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class FormThongTinChiTietDonHang : Form
    {
        XeController xeController = new XeController();
        KhachHangController khachHangController = new KhachHangController();
        NhanVienController nhanVienController = new NhanVienController();
        public FormThongTinChiTietDonHang()
        {
            InitializeComponent();
        }
        DonHang dh = new DonHang();
        EnumHanhDong type;
        public FormThongTinChiTietDonHang(DonHang dh, EnumHanhDong type)
        {
            InitializeComponent();
            this.dh = dh;
            this.type = type;
        }
        private void FormThongTinChiTietDonHang_Load(object sender, EventArgs e)
        {
            pnlBody.Parent = pictureBox1;
            cbbKhachHang.DataSource = khachHangController.Get();
            cbbNhanVien.DataSource = nhanVienController.Get();
            cbbTenXe.DataSource = xeController.Get();
            ptbSanPham.Image = Image.FromFile(Data.LinkConnection.linkImgSanPham + "\\" + xeController.Tim(dh.MaXe).Anh);
            txtMa.Text = dh.Ma.ToString();
            cbbTenXe.SelectedValue = dh.MaXe;
            cbbNhanVien.SelectedValue = dh.NhanVienTuVan;
            cbbKhachHang.SelectedValue = dh.MaKhachHang;
            dtpThoiGian.Value = dh.ThoiGian;
            cbbTrangThai.SelectedIndex = dh.TrangThai == false ? 0 : 1;
            switch (type)
            {
                case EnumHanhDong.ChiTiet:
                    btnThemSua.Text = "TRỞ VỀ";
                    cbbKhachHang.Enabled = false;
                    cbbNhanVien.Enabled = false;
                    cbbTenXe.Enabled = false;
                    cbbTrangThai.Enabled = false;
                    dtpThoiGian.Enabled = false;
                    break;
                case EnumHanhDong.Sua:

                    break;
            }
            
        }

        private void btnThemSua_MouseEnter(object sender, EventArgs e)
        {
            btnThemSua.ForeColor = Color.Black;
        }

        private void btnThemSua_MouseLeave(object sender, EventArgs e)
        {
            btnThemSua.ForeColor= Color.White;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.Black;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor= Color.White;
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
           
        }
    }
}
