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
using UngDungBanHang.Data;
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class UserDonHang : UserControl
    {
        public UserDonHang()
        {
            InitializeComponent();
        }
        DonHang donHang = new DonHang();
        XeController xeController = new XeController();
        NhanVienController nhanVienController = new NhanVienController();
        int index = 0;
        public UserDonHang(DonHang donHang, int index)
        {
            InitializeComponent();
            this.donHang = donHang;
            this.index = index;
        }

        private void UserDonHang_Load(object sender, EventArgs e)
        {
            this.BackColor = index % 2 == 0 ? Color.White: Color.WhiteSmoke;
            Xe xe = xeController.Tim(donHang.MaXe);
            ptbAnhXe.Image = Image.FromFile(LinkConnection.linkImgSanPham + "\\" + xe.Anh);
            lblGiaTien.Text = xe.GiaBan.ToString("N0") +"đ";
            lblNgayThang.Text = donHang.ThoiGian.ToString();
            lblSoDienThoaiNhanVien.Text = nhanVienController.Tim(donHang.NhanVienTuVan).SDT;
            lblTenXe.Text = donHang.TenXe.ToString();
            lblMa.Text = donHang.MaXe.ToString();   
            cbTrangThai.Checked = donHang.TrangThai == true ? true : false; 
        }
    }
}
