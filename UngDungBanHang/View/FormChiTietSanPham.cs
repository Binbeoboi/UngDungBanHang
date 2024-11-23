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
    public partial class FormChiTietSanPham : Form
    {
        GioHangController gioHangController = new GioHangController();
        XeController xeController = new XeController();
        EnumAdmin type;
        public FormChiTietSanPham()
        {
            InitializeComponent();
        }
        Form1 frm = new Form1();
        string maSanPham = null;
        KhachHang kh = new KhachHang();
        public FormChiTietSanPham(string maSanPham, Form1 form, KhachHang kh)
        {
            InitializeComponent();
            this.maSanPham = maSanPham;
            this.frm = form;
            this.kh = kh;
        }
        string id = null;
        FormAdmin admin = new FormAdmin();
        public FormChiTietSanPham(Xe xe, EnumAdmin type, FormAdmin formAdmin)
        {
            InitializeComponent();
            this.xe = xe;  
            this.type = type;
            this.admin = formAdmin;
        }

        Xe xe = null;
        public FormChiTietSanPham(Xe xe, Form1 form, KhachHang kh)
        {
            InitializeComponent();
            this.frm = form;
            this.xe = xe;
            this.kh = kh;
        }

        private void FormChiTietSanPham_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maSanPham))
            {
                xe = xeController.Tim(maSanPham);
                btnThemGioHang.Text = "MUA HÀNG";
            }
            switch (type)
            {
                case EnumAdmin.Admin: 
                    btnThemGioHang.Text = "TRỞ VỀ";
                    btnThemGioHang.Click -= new EventHandler(btnThemGioHang_Click);
                    btnThemGioHang.Click += new EventHandler(btnTroVe_Click);
                    break;
                default: btnThemGioHang.Visible = false;break;
            }
            ptbAnhXe.Image = Image.FromFile($@"C:\Learn\CSharp Learn\UngDungBanHang\UngDungBanHang\Img SanPham\{xe.Anh}");
            lblTenXe.Text = xe.Ten;
            lblHangSanXuat.Text = xe.TenHangSanXuat;
            lblGiaBan.Text = xe.GiaBan.ToString("N0") + " đ";
            lblHopSo.Text = xe.TenHopSo.ToString();
            lblTinhTrang.Text = xe.TenTinhTrang.ToString();
            lblNam.Text = xe.Nam.ToString();
            lblHang.Text = xe.TenHangSanXuat;
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            FormQuanLyXe form = new FormQuanLyXe(admin);
            admin.OpenForm(form);
        }
        private void btnThemGioHang_Click(object sender, EventArgs e)
        {

                if(MessageBox.Show("Bạn có muốn thêm vào giỏ hàng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                if (gioHangController.Them(new GioHang($"{xe.Ma}", DateTime.Now, kh.Ma)))
                {
                    FormGioHang formGioHang = new FormGioHang(frm, kh);
                    frm.OpenForm(formGioHang);
                }
                else
                {
                    MessageBox.Show("Đã có lỗi khi thêm vào giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
        }
    }
}
