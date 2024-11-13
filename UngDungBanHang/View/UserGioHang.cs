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
    public partial class UserGioHang : UserControl
    {
        XeController controller = new XeController();
        GioHangController gioHangController = new GioHangController();
        DonHangController donHangController = new DonHangController();
        public UserGioHang()
        {
            InitializeComponent();
        }
        GioHang gioHang = new GioHang();
        int i = 0;
        Form1 form = new Form1();
        FormGioHang formGioHang = new FormGioHang();
        KhachHang kh = new KhachHang();
        public UserGioHang(GioHang gioHang, int i, Form1 form, FormGioHang formGioHang, KhachHang kh)
        {
            InitializeComponent();
            this.gioHang = gioHang;
            this.i = i;
            this.form = form;
            this.formGioHang = formGioHang;
            this.kh = kh;
        }

        private void UserGioHang_Load(object sender, EventArgs e)
        {
            ptbAnhXe.Image = Image.FromFile($@"C:\Learn\CSharp Learn\UngDungBanHang\UngDungBanHang\Img SanPham\{controller.Tim(gioHang.MaSanPham).Anh}");
            lblMa.Text = gioHang.MaSanPham;
            lblTenXe.Text = controller.Tim(gioHang.MaSanPham).Ten;
            lblNgayThang.Text = gioHang.NgayThang.ToString("dd/MM/yyyy");
            if (i % 2 == 0)
            {
                BackColor = Color.White;
            }
            else
            {
                BackColor= Color.WhiteSmoke;
            }
        }

        private void UserGioHang_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
        }

        private void UserGioHang_MouseLeave(object sender, EventArgs e)
        {
            if(i % 2 == 0)
            {
                BackColor = Color.White;
            }
            else
            {
                BackColor = Color.WhiteSmoke;
            }
        }

        private void lblTenXe_Click(object sender, EventArgs e)
        {
            FormChiTietSanPham frm = new FormChiTietSanPham(gioHang.MaSanPham, form, kh);
            form.OpenForm(frm);

        }

        private void lblTenXe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            btnMua.BackColor = Color.Silver;
        }

        private void btnChinhSua_MouseDown(object sender, MouseEventArgs e)
        {
            btnMua.BackColor = Color.Silver;
        }

        private void btnChinhSua_MouseUp(object sender, MouseEventArgs e)
        {
            btnMua.BackColor = Color.Transparent;
        }

        private void btnXoa_MouseDown(object sender, MouseEventArgs e)
        {
            btnXoa.BackColor = Color.Silver;
        }

        private void btnXoa_MouseUp(object sender, MouseEventArgs e)
        {
            btnXoa.BackColor = Color.Transparent;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa giỏ giỏ hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                if (gioHangController.Xoa(gioHang.Ma))
                {
                    MessageBox.Show("Xóa thành công giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formGioHang.FormGioHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công giỏ hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã có lỗi {ex.Message}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn mua mặt hàng này không này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                DonHang donhang = new DonHang();
                donhang.NhanVienTuVan = Common.ChucNangBoSung.TuyenChonNhanVienTuVan();
                donhang.MaXe = gioHang.MaSanPham;
                donhang.ThoiGian = DateTime.Now;
                donhang.TrangThai = false;
                donhang.MaKhachHang = kh.Ma;
                if (donHangController.Them(donhang))
                {
                    MessageBox.Show("Thêm thành công đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formGioHang.FormGioHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm không thành công đơn hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã có lỗi {ex.Message}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
