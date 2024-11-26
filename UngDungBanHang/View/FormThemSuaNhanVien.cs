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
    public partial class FormThemSuaNhanVien : Form
    {
        ChucVuController chucVuController = new ChucVuController();
        PhongBanController phongBanController = new PhongBanController();
        NhanVienController nhanVienController = new NhanVienController();
        public FormThemSuaNhanVien()
        {
            InitializeComponent();
        }
        EnumHanhDong type;
        public FormThemSuaNhanVien(EnumHanhDong type)
        {
            InitializeComponent();
            this.type = type;
        }
        NhanVien nv = new NhanVien();
        FormAdmin frm = new FormAdmin();
        public FormThemSuaNhanVien(NhanVien nv, FormAdmin frm,EnumHanhDong type)
        {
            InitializeComponent();
            this.type = type;
            this.nv = nv;
            this.frm = frm;
        }
        private void FormThemSuaNhanVien_Load(object sender, EventArgs e)
        {
            pnlBody.Parent = ptbCover;
            cbbChucVu.DataSource = chucVuController.Get();
            cbbPhongBan.DataSource = phongBanController.Get();
            switch (type)
            {
                case EnumHanhDong.Them:
                    txtMa.Text = Common.ChucNangBoSung.TaoMaNhanVienMoi();
                    break;
                case EnumHanhDong.Sua:
                    txtMa.Text = nv.Ma;
                    txtTen.Text = nv.Ten;   
                    txtEmail.Text = nv.Email;
                    txtDiaChi.Text = nv.DiaChi;
                    txtSDT.Text = nv.SDT;
                    nudLuong.Value = nv.Luong;
                    cbbGioiTinh.Text = nv.GioiTinh;
                    dtpNgaySinh.Value = nv.NgaySinh;
                    cbbChucVu.SelectedValue = nv.ChucVu;
                    cbbPhongBan.SelectedValue = nv.PhongBan;

                    btnThemSua.Text = "SỬA ĐỔI";
                    btnThemSua.Click -= new EventHandler(btnThemSua_Click);
                    btnThemSua.Click += new EventHandler(btnSuaDoi_Click);
                    break;
                case EnumHanhDong.ChiTiet:
                    txtMa.Text = nv.Ma;
                    txtTen.Text = nv.Ten;
                    txtEmail.Text = nv.Email;
                    txtDiaChi.Text = nv.DiaChi;
                    txtSDT.Text = nv.SDT;
                    nudLuong.Value = nv.Luong;
                    dtpNgaySinh.Value = nv.NgaySinh;
                    cbbGioiTinh.Text = nv.GioiTinh;
                    cbbChucVu.SelectedValue = nv.ChucVu;
                    cbbPhongBan.SelectedValue = nv.PhongBan;

                    btnThemSua.Text = "TRỞ VỀ";

                    txtTen.Enabled = false;
                    txtEmail.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtSDT.Enabled = false; 
                    cbbChucVu.Enabled = false;
                    cbbGioiTinh.Enabled = false;
                    cbbPhongBan.Enabled = false;
                    dtpNgaySinh.Enabled = false;
                    nudLuong.Enabled = false;

                    btnThemSua.Click -= new EventHandler(btnThemSua_Click);
                    btnThemSua.Click += new EventHandler(btnTroVe_Click);
                    break;
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            FormNhanVien form = new FormNhanVien(frm);
            frm.OpenForm(form);
        }

        private void btnSuaDoi_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (MessageBox.Show("Bạn có muốn sửa nhân viên không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            NhanVien nhanVien = GetData();
            if (nhanVienController.Sua(nhanVien))
            {
                MessageBox.Show("Sửa nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTroVe_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Sửa nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool IsValid()
        {
            if(txtTen.Text == string.Empty || txtSDT.Text == string.Empty 
                || txtEmail.Text == string.Empty || txtDiaChi.Text == string.Empty || cbbGioiTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy nhập đầy đủ dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        public NhanVien GetData()
        {
            return new NhanVien()
            {
                Ma = txtMa.Text,
                Ten = txtTen.Text,
                GioiTinh = cbbGioiTinh.Text,
                NgaySinh = dtpNgaySinh.Value,
                DiaChi = txtDiaChi.Text,
                SDT = txtSDT.Text,
                Email = txtEmail.Text,
                Luong = int.Parse(nudLuong.Value.ToString()),
                PhongBan = int.Parse(cbbPhongBan.SelectedValue.ToString()),
                ChucVu = int.Parse(cbbChucVu.SelectedValue.ToString()),
            };
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            if (MessageBox.Show("Bạn có muốn thêm nhân viên không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            NhanVien nhanVien = GetData();
            if (nhanVienController.Them(nhanVien))
            {
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
            pnlBody.Controls.OfType<ComboBox>().ToList().ForEach(t => t.SelectedIndex = -1);
            dtpNgaySinh.Value = DateTime.Now;
            txtMa.Text = Common.ChucNangBoSung.TaoMaNhanVienMoi();
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
