using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungBanHang.Controller;
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class FormThemSanPham : Form
    {
        TinhTrangController tinhTrangController = new TinhTrangController();
        HangXeController hangXeController = new HangXeController();
        HopSoController hopSoController = new HopSoController();
        XeController xeController = new XeController();
        string fileAnh = "";
        public FormThemSanPham()
        {
            InitializeComponent();
        }
        Xe xe = null;
        FormAdmin frm = new FormAdmin();
        public FormThemSanPham(Xe xe, FormAdmin frm)
        {
            InitializeComponent();
            this.xe = xe;
            this.frm = frm;
        }
        private void FormThemSanPham_Load(object sender, EventArgs e)
        {
            if(xe != null)
            {
                txtMa.Text = xe.Ma;
                txtTenXe.Text = xe.Ten;
                cbbHopSo.SelectedValue = xe.HopSo;
                cbbHangXe.SelectedValue = xe.HangSanXuat;
                cbbTinhTrang.SelectedValue = xe.TinhTrang;
                nubDoiXe.Value = xe.Nam;
                nudBan.Value = xe.GiaBan;
                nudNhap.Value = xe.GiaNhap;
                nudSoLuong.Value = xe.SoLuong;
                fileAnh = xe.Anh;
                ptbSanPham.Image = Image.FromFile(Data.LinkConnection.linkImgSanPham + "\\" + xe.Anh);
                btnThemSua.Text = "SỬA ĐỔI";
                btnThemSua.Click -= new EventHandler(btnThemSua_Click);
                btnThemSua.Click += new EventHandler(btnSua_Click);
            }
            else
            {
                txtMa.Text = Common.ChucNangBoSung.TaoMaMoi();
            }
            pnlBody.Parent = imgcover1;
            cbbTinhTrang.DataSource = tinhTrangController.Get();
            cbbHangXe.DataSource = hangXeController.Get();
            cbbHopSo.DataSource = hopSoController.Get();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa sản phẩm này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRong())
            {
                return;
            }
            Xe item = GetXe();
            if (xeController.Sua(item))
            {
                MessageBox.Show("Sửa thông tin xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm.OpenForm(new FormQuanLyXe(frm));
                Reset();
            }
            else
            {
                MessageBox.Show("Sửa thông tin xe không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemSua_MouseEnter(object sender, EventArgs e)
        {
            btnThemSua.ForeColor = Color.Black;
        }

        private void btnThemSua_MouseLeave(object sender, EventArgs e)
        {
            btnThemSua.ForeColor = Color.White;
        }

        private void btnReset_MouseEnter(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.Black;
        }

        private void btnReset_MouseLeave(object sender, EventArgs e)
        {
            btnReset.ForeColor = Color.White;
        }

        private void btnOpenAnh_MouseEnter(object sender, EventArgs e)
        {
            btnOpenAnh.ForeColor = Color.Black;
        }

        private void btnOpenAnh_MouseLeave(object sender, EventArgs e)
        {
            btnOpenAnh.ForeColor = Color.White;
        }

        private void btnOpenAnh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "File img | *.png; *.jpg; *.jpeg";
                if (file.ShowDialog() == DialogResult.OK) 
                {
                    fileAnh = Path.GetFileName(file.FileName);
                    ptbSanPham.Image = Image.FromFile(file.FileName);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Đã có lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool CheckRong()
        {
            if (string.IsNullOrEmpty(txtTenXe.Text))
            {
                MessageBox.Show("Ô tên bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(cbbHangXe.Text))
            {
                MessageBox.Show("Ô hãng xe bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(cbbHopSo.Text))
            {
                MessageBox.Show("Ô hộp số bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(cbbTinhTrang.Text))
            {
                MessageBox.Show("Ô tình trạng bị rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(fileAnh))
            {
                MessageBox.Show("Hãy chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private Xe GetXe()
        {
            return new Xe()
            {
                Ma = txtMa.Text,
                Ten = txtTenXe.Text,
                HopSo = int.Parse(cbbHopSo.SelectedValue.ToString()),
                TinhTrang = int.Parse(cbbTinhTrang.SelectedValue.ToString()),
                Nam = int.Parse(nubDoiXe.Value.ToString()),
                SoLuong = int.Parse(nudSoLuong.Value.ToString()),
                GiaNhap = int.Parse(nudNhap.Value.ToString()),
                GiaBan = int.Parse(nudBan.Value.ToString()),
                Anh = fileAnh,
                HangSanXuat = int.Parse(cbbHangXe.SelectedValue.ToString()),
            };
        }
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thêm sản phẩm mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            if (!CheckRong())
            {
                return;
            }
            Xe item = GetXe();
            if (xeController.Them(item))
            {
                MessageBox.Show("Thêm xe thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Reset();
            }
            else
            {
                MessageBox.Show("Thêm xe không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            txtMa.Text = Common.ChucNangBoSung.TaoMaMoi();
            txtTenXe.Text = string.Empty;
            this.Controls.OfType<ComboBox>().ToList().ForEach(n => n.Text = "");
            this.Controls.OfType<NumericUpDown>().ToList().ForEach(n => n.Value = 0);
            ptbSanPham.Image = Image.FromFile(Data.LinkConnection.linkImgIcon + "\\car.png");
            fileAnh = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
