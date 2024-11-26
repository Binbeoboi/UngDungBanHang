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
        DonHangController donHangController = new DonHangController();
        public FormThongTinChiTietDonHang()
        {
            InitializeComponent();
        }
        DonHang dh = new DonHang();
        EnumHanhDong type;
        FormAdmin frm = new FormAdmin();
        public FormThongTinChiTietDonHang(DonHang dh, FormAdmin frm, EnumHanhDong type)
        {
            InitializeComponent();
            this.dh = dh;
            this.type = type;
            this.frm = frm;
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
            cbbTrangThai.SelectedIndex = dh.TrangThai == false ? 1 : 0;
            switch (type)
            {
                case EnumHanhDong.ChiTiet:
                    btnThemSua.Text = "TRỞ VỀ";
                    cbbKhachHang.Enabled = false;
                    cbbNhanVien.Enabled = false;
                    cbbTenXe.Enabled = false;
                    cbbTrangThai.Enabled = false;
                    dtpThoiGian.Enabled = false;
                    btnThemSua.Click -= new EventHandler(btnThemSua_Click);
                    btnThemSua.Click += new EventHandler(btnTroVe_Click);
                    break;
                case EnumHanhDong.Sua:
                    btnThemSua.Text = "Sửa đổi";
                    break;
            }
            
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            FormQuanLyDonHang form = new FormQuanLyDonHang(frm);
            frm.OpenForm(form);
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
        public bool IsValid()
        {
            if (cbbKhachHang.SelectedItem == null) return false;
            else if (cbbNhanVien.SelectedItem == null) return false;
            else if (cbbTenXe.SelectedItem == null) return false;
            else if (cbbTrangThai.SelectedItem == null) return false;
            return true;    
        }
        private DonHang GetDonHang()
        {
            return new DonHang()
            {
                Ma = dh.Ma,
                MaXe = cbbTenXe.SelectedValue.ToString(),
                ThoiGian = dtpThoiGian.Value,
                NhanVienTuVan = cbbNhanVien.SelectedValue.ToString(),
                MaKhachHang = cbbKhachHang.SelectedValue.ToString(),
                TrangThai = cbbTrangThai.SelectedIndex == 0 ? true : false,
            };
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
           if(!IsValid()) return;
           if (MessageBox.Show("Bạn có muốn sửa thông tin không", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

           DonHang donHang = GetDonHang();

            if (donHangController.Sua(donHang))
            {
                MessageBox.Show("Sửa đơn hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormQuanLyDonHang form = new FormQuanLyDonHang(frm);
                frm.OpenForm(form);
            }
            else
            {
                MessageBox.Show("Sửa đơn hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
