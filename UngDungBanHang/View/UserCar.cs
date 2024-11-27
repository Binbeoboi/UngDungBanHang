using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class UserCar : UserControl
    {
        public UserCar()
        {
            InitializeComponent();
        }
        Xe xe = new Xe();
        Form1 frm = new Form1();
        KhachHang kh = new KhachHang();
        public UserCar(Xe xe, Form1 form, KhachHang kh)
        {
            InitializeComponent();
            this.xe = xe;
            this.frm = form;
            this.kh = kh;
        }
        private void UserCar_Load(object sender, EventArgs e)
        {
            Init();

        }

        private void Init()
        {
            lblGiaXe.Text = xe.GiaBan.ToString("N0") + "đ";
            lblTenXe.Text = xe.Ten.ToString();
            ptbCar.Image = Image.FromFile($@"{Application.StartupPath.Substring(0, Application.StartupPath.Length - 10)}\Img SanPham\{xe.Anh}");
        }

        private void UserCar_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.Silver;
        }

        private void UserCar_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.DarkGray;
            lblTenXe.ForeColor = Color.White;
            lblGiaXe.ForeColor = Color.White;
        }

        private void UserCar_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
            lblTenXe.ForeColor = Color.Black;
            lblGiaXe.ForeColor = Color.Black;
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FormChiTietSanPham formChiTiet = new FormChiTietSanPham(xe, frm, kh);
            frm.OpenForm(formChiTiet);
        }
    }
}
