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
using UngDungBanHang.Enum;
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class FormQuanLyXe : Form
    {
        XeController xeController = new XeController();
        public FormQuanLyXe()
        {
            InitializeComponent();
        }
        FormAdmin frm = new FormAdmin();
        public FormQuanLyXe(FormAdmin frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void FormQuanLyXe_Load(object sender, EventArgs e)
        {
            HienThi(xeController.Get());
        }

        public void HienThi(List<Xe> xeLst)
        {
            dgvXe.Rows.Clear();
            xeLst.ForEach(n => dgvXe.Rows.Add(xeController.HienThiThongTin(n)));
        }

        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            btnThem.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\plus - Copy.png");
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\plus.png");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSanPham form = new FormThemSanPham();
            frm.OpenForm(form);
        }

        private void txtTimKiemXe_Enter(object sender, EventArgs e)
        {
            txtTimKiemXe.Text = string.Empty;
            txtTimKiemXe.ForeColor = Color.Black;
        }

        private void txtTimKiemXe_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiemXe.Text == string.Empty || txtTimKiemXe.Text == "  Searching car...")
            {
                HienThi(xeController.Get());
            }

            HienThi(xeController.TimTheoTen(txtTimKiemXe.Text));
        }

        private void txtTimKiemXe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemXe.Text))
            {
                txtTimKiemXe.Text = "  Searching car...";
                txtTimKiemXe.ForeColor= Color.DarkGray;
                HienThi(xeController.Get());
            }
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgvXe.Columns["ColXoa"].Index)
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                string id = dgvXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (xeController.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormQuanLyXe_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công sản phẩm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(e.ColumnIndex == dgvXe.Columns["ColChiTiet"].Index)
            {
                string id = dgvXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                Xe xe = xeController.Get().SingleOrDefault(n => n.Ma == id);
                FormChiTietSanPham form = new FormChiTietSanPham(xe, EnumAdmin.Admin, frm);
                frm.OpenForm(form);
            }
            else if(e.ColumnIndex == dgvXe.Columns["ColSua"].Index)
            {
                string id = dgvXe.Rows[e.RowIndex].Cells[0].Value.ToString();
                Xe xe = xeController.Get().SingleOrDefault(n => n.Ma == id);
                FormThemSanPham form = new FormThemSanPham(xe, frm);
                frm.OpenForm(form);
            }
        }
    }
}
