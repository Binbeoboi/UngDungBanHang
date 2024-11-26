using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungBanHang.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UngDungBanHang.View
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        bool checkMax = true;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSanPham_MouseEnter(object sender, EventArgs e)
        {
            btnSanPham.BackColor = Color.White;
            btnSanPham.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\car4 - Copy.png");
            btnSanPham.ForeColor = Color.Black;
        }

        private void btnSanPham_MouseLeave(object sender, EventArgs e)
        {
            btnSanPham.BackColor = Color.FromArgb(18,18,18);
            btnSanPham.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\car3.png");
            btnSanPham.ForeColor = Color.White;
        }

        private void btnDonHang_MouseEnter(object sender, EventArgs e)
        {
            btnDonHang.BackColor = Color.White;
            btnDonHang.ForeColor = Color.Black;
            btnDonHang.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\shopping-bag - Copy.png");
        }

        private void btnDonHang_MouseLeave(object sender, EventArgs e)
        {
            btnDonHang.BackColor = Color.FromArgb(18,18,18);
            btnDonHang.ForeColor= Color.White;
            btnDonHang.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\shopping-bag.png");
        }

        private void btnGioHang_MouseEnter(object sender, EventArgs e)
        {
            btnGioHang.BackColor = Color.White;
            btnGioHang.ForeColor = Color.Black;
            btnGioHang.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\grocery-store - Copy.png");
        }

        private void btnGioHang_MouseLeave(object sender, EventArgs e)
        {
            btnGioHang.ForeColor = Color.White;
            btnGioHang.BackColor = Color.FromArgb(18,18,18);
            btnGioHang.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\grocery-store.png");
        }

        private void btnNhanVien_MouseEnter(object sender, EventArgs e)
        {
            btnNhanVien.ForeColor = Color.Black;
            btnNhanVien.BackColor = Color.White;
            btnNhanVien.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\man - Copy.png");
        }

        private void btnNhanVien_MouseLeave(object sender, EventArgs e)
        {
            btnNhanVien.BackColor = Color.FromArgb(18, 18, 18);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\man.png");
        }

        private void btnKhachHang_MouseEnter(object sender, EventArgs e)
        {
            btnKhachHang.ForeColor= Color.Black;
            btnKhachHang.BackColor = Color.White;
            btnKhachHang.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\customer - Copy.png");
        }

        private void btnKhachHang_MouseLeave(object sender, EventArgs e)
        {
            btnKhachHang.BackColor = Color.FromArgb(18, 18, 18);
            btnKhachHang.ForeColor = Color.White;
            btnKhachHang.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\customer.png");
        }
        public void OpenForm(Form child)
        {
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(child);
            pnlBody.Tag = child;

            child.BringToFront();
            child.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            FormQuanLyXe frm = new FormQuanLyXe(this);
            OpenForm(frm);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            FormQuanLyDonHang frm = new FormQuanLyDonHang(this);
            OpenForm(frm);
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien frm = new FormNhanVien(this);
            OpenForm(frm);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang frm = new FormQuanLyKhachHang(this);
            OpenForm(frm);
        }

        private void btnThongKe_MouseEnter(object sender, EventArgs e)
        {
            btnThongKe.ForeColor = Color.Black;
            btnThongKe.BackColor = Color.White;
            btnThongKe.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\line-chart.png");
        }

        private void btnThongKe_MouseLeave(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(18, 18, 18);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\line-chart - Copy.png");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe form = new FormThongKe();
            OpenForm(form);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            FormQuanLyGioHang form = new FormQuanLyGioHang(this);
            OpenForm(form);
        }

        private void btnDangXuat_MouseEnter(object sender, EventArgs e)
        {
            btnDangXuat.ForeColor = Color.Black;
            btnDangXuat.BackColor = Color.White;
            btnDangXuat.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\logout.png");
        }

        private void btnDangXuat_MouseLeave(object sender, EventArgs e)
        {
            btnDangXuat.BackColor = Color.FromArgb(18, 18, 18);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\logout - Copy.png");
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No) return;
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (checkMax)
            {
                this.WindowState = FormWindowState.Maximized;
                checkMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1832, 889);
                checkMax = true;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
