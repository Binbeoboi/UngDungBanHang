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
    public partial class FormQuanLyKhachHang : Form
    {
        KhachHangController khachHangController = new KhachHangController();
        public FormQuanLyKhachHang()
        {
            InitializeComponent();
        }
        FormAdmin frm = new FormAdmin();
        public FormQuanLyKhachHang(FormAdmin frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void FormQuanLyKhachHang_Load(object sender, EventArgs e)
        {
            Init(khachHangController.Get());
        }

        private void Init(List<KhachHang> lst)
        {
            dgvKhachHang.Rows.Clear();
            lst.ForEach(n =>
            {
                dgvKhachHang.Rows.Add(khachHangController.HienThiThongTin(n));
            });
        }

        private void txtTimKiemKhachHang_Enter(object sender, EventArgs e)
        {
            if(txtTimKiemKhachHang.Text == "  Searching ..." && txtTimKiemKhachHang.ForeColor == Color.DarkGray)
            {
                txtTimKiemKhachHang.Text = string.Empty;
                txtTimKiemKhachHang.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemKhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                var data = txtTimKiemKhachHang.Text == string.Empty ? khachHangController.Get() : khachHangController.Get().Where(n => n.Ten.ToLower().Trim().Contains(txtTimKiemKhachHang.Text.ToLower().Trim())).ToList();
                Init(data);
            }
        }

        private void txtTimKiemKhachHang_Leave(object sender, EventArgs e)
        {
            if(txtTimKiemKhachHang.Text == string.Empty)
            {
                txtTimKiemKhachHang.Text = "  Searching ...";
                txtTimKiemKhachHang.ForeColor = Color.DarkGray;
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaKhachHang form = new FormThemSuaKhachHang(frm, Enum.EnumHanhDong.Them);
            frm.OpenForm(form);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgvKhachHang.Columns["ColXoa"].Index)
            {
                if (MessageBox.Show("Bạn có muốn xóa đơn hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                string id = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (khachHangController.Xoa(id))
                {
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormQuanLyKhachHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Bạn đã xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == dgvKhachHang.Columns["ColChiTiet"].Index)
            {
                string id = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
                var data = khachHangController.Get().SingleOrDefault(n => n.Ma == id);
                FormThemSuaKhachHang form = new FormThemSuaKhachHang(data, frm, EnumHanhDong.ChiTiet);
                frm.OpenForm(form);
            }
        }

        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            btnThem.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\plus - Copy.png");
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.Image = Image.FromFile(LinkConnection.linkImgIcon + "\\plus.png");
        }
    }
}
