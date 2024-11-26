using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungBanHang.Controller;
using UngDungBanHang.Data;
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class FormThongTinCaNhan : Form
    {
        string path = "";
        KhachHangController khController = new KhachHangController();
        public FormThongTinCaNhan()
        {
            InitializeComponent();
        }
        KhachHang kh = new KhachHang();
        public FormThongTinCaNhan(KhachHang kh)
        {
            InitializeComponent();
            this.kh = kh;
        }
        bool CheckChinhSua = false;
        public void Init(KhachHang kh)
        {
            txtMa.Text = kh.Ma;
            txtName.Text = kh.Ten == null ? "?" : kh.Ten;
            txtDiaChi.Text = kh.DiaChi == null ? "?" : kh.DiaChi;
            txtEmail.Text = kh.Email == null ? "?" : kh.Email;
            txtPassword.Text = kh.Password == null ? "?" : kh.Password;
            txtSDT.Text = kh.Sdt == null ? "?" : kh.Sdt;
            dtpNgaySinh.Value = kh.NgaySinh == null ? DateTime.Now : kh.NgaySinh;
            ptbAvatar.Image = Image.FromFile(kh.GioiTinh == "Nam" ? Data.LinkConnection.linkImgIcon + "/user.png" : Data.LinkConnection.linkImgIcon + "/female.png");
            if(kh.GioiTinh.CompareTo("Nam") == 0)
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
        }
        private void FormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            KhachHang khachHang = khController.Tim(kh.Ma);
            Init(khachHang);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Img file|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbAvatar.Image = Image.FromFile(ofd.FileName);
                    path = Path.GetFileName(ofd.FileName);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Đã có lỗi {ex.Message}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (!CheckChinhSua)
            {
                txtDiaChi.Enabled = true;
                txtEmail.Enabled = true;
                txtName.Enabled = true;
                txtPassword.Enabled = true;
                txtSDT.Enabled = true;
                btnChinhSua.Text = "Hủy bỏ";
                btnLuu.Enabled = true;
                CheckChinhSua = true;
                rbtnNam.Enabled = true;
                rbtnNu.Enabled = true;
                dtpNgaySinh.Enabled = true;
            }
            else
            {
                txtDiaChi.Enabled = false;
                txtEmail.Enabled = false;
                txtName.Enabled = false;
                txtPassword.Enabled = false;
                txtSDT.Enabled = false;
                btnChinhSua.Text = "Chỉnh sửa";
                btnLuu.Enabled = false;
                CheckChinhSua = false;
                rbtnNam.Enabled = false;
                rbtnNu.Enabled = false;
                dtpNgaySinh.Enabled= false;
            }
        }
        public KhachHang GetKhachHang()
        {
            return new KhachHang()
            {
                Ma = txtMa.Text,
                Ten = txtName.Text,
                DiaChi = txtDiaChi.Text,
                GioiTinh = rbtnNam.Checked == true ? "Nam" : "Nữ",
                Password = txtPassword.Text,
                NgaySinh = dtpNgaySinh.Value,
                Email = txtEmail.Text,
                Sdt = txtSDT.Text, 
            };
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn lưu thay đổi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                KhachHang khachHang = GetKhachHang();
                if (khController.Sua(khachHang))
                {
                    MessageBox.Show("Sửa thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Init(khachHang);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã có lỗi {ex.Message}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}
