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
    public partial class FormThemSuaKhachHang : Form
    {
        KhachHangController khachHangController = new KhachHangController   ();
        public FormThemSuaKhachHang()
        {
            InitializeComponent();
        }
        FormAdmin frm = new FormAdmin();
        EnumHanhDong type;
        public FormThemSuaKhachHang(FormAdmin frm, EnumHanhDong type)
        {
            InitializeComponent();
            this.frm = frm;
            this.type = type;
        }
        KhachHang kh = new KhachHang();
        public FormThemSuaKhachHang(KhachHang kh,FormAdmin frm, EnumHanhDong type)
        {
            InitializeComponent();
            this.frm = frm;
            this.type = type;
            this.kh = kh;   
        }
        private void FormThemSuaKhachHang_Load(object sender, EventArgs e)
        {
            pnlBody.Parent = ptbCover;
            switch (type) 
            {
                case EnumHanhDong.Them:
                    txtMa.Text = Common.ChucNangBoSung.TaoMaKhachHangMoi();
                    break;
                case EnumHanhDong.ChiTiet:
                    txtMa.Text = kh.Ma;
                    txtTen.Text = kh.Ten;
                    cbbGioiTinh.Text = kh.GioiTinh;
                    dtpNgaySinh.Value = kh.NgaySinh;
                    txtDiaChi.Text = kh.DiaChi;
                    txtSDT.Text = kh.Sdt;
                    txtEmail.Text = kh.Email;
                    txtPassword.Text = kh.Password;

                    txtTen.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtEmail.Enabled = false;
                    txtSDT.Enabled = false;
                    txtPassword.Enabled = false;
                    cbbGioiTinh.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    btnThemSua.Click -= new EventHandler(btnThemSua_Click);
                    btnThemSua.Click += new EventHandler(btnTroLai_Click);
                    btnReset.Enabled = false;
                    break;
            }
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FormQuanLyKhachHang form = new FormQuanLyKhachHang(frm);
            frm.OpenForm(form);
        }

        public bool IsValid()
        {
            if (txtTen.Text == string.Empty || txtSDT.Text == string.Empty
                || txtEmail.Text == string.Empty || txtDiaChi.Text == string.Empty || cbbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public KhachHang GetData()
        {
            return new KhachHang()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                GioiTinh = cbbGioiTinh.Text,
                NgaySinh = dtpNgaySinh.Value,
                DiaChi = txtDiaChi.Text,
                Sdt = txtSDT.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
                
            };
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (MessageBox.Show("Bạn có muốn thêm khách hàng không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            KhachHang khachHang = GetData();
            if(khachHangController.Get().Any(n => n.Email.ToLower().Equals(khachHang.Email)))
            {
                MessageBox.Show("Bạn đã bị trùng email. Hãy thay đổi lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (khachHangController.Get().Any(n => n.Sdt.ToLower().Equals(khachHang.Sdt)))
            {
                MessageBox.Show("Bạn đã bị trùng số điện thoai. Hãy thay đổi lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (khachHangController.Them(khachHang))
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm khách hàng không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            pnlBody.Controls.OfType<ComboBox>().ToList().ForEach(t => t.SelectedIndex = -1);
            dtpNgaySinh.Value = DateTime.Now;
            txtMa.Text = Common.ChucNangBoSung.TaoMaKhachHangMoi();
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
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
