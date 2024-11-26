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
    public partial class FormNhanVien : Form
    {
        NhanVienController nhanVienCotroller = new NhanVienController();
        public FormNhanVien()
        {
            InitializeComponent();
        }
        FormAdmin frm = new FormAdmin();
        public FormNhanVien(FormAdmin frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            Init(nhanVienCotroller.Get());
        }

        private void Init(List<NhanVien> lst)
        {
            dgvNhanVien.Rows.Clear();
            lst.ForEach(n =>
            {
                dgvNhanVien.Rows.Add(nhanVienCotroller.HienThiThongTin(n));
            });
        }

        private void txtTimKiemNhanVien_Enter(object sender, EventArgs e)
        {
            if(txtTimKiemNhanVien.Text == "  Searching car..." && txtTimKiemNhanVien.ForeColor == Color.DarkGray)
            {
                txtTimKiemNhanVien.Text = string.Empty;
                txtTimKiemNhanVien.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemNhanVien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                Init(txtTimKiemNhanVien.Text == string.Empty ? nhanVienCotroller.Get() : nhanVienCotroller.Get().Where(n => n.Ten.ToLower().Trim().Contains(txtTimKiemNhanVien.Text)).ToList());
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgvNhanVien.Columns["ColXoa"].Index)
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                string id = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (nhanVienCotroller.Xoa(id))
                {
                    MessageBox.Show("Xóa thành công nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (e.ColumnIndex == dgvNhanVien.Columns["ColChiTiet"].Index)
            {
                string id = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                NhanVien nv = nhanVienCotroller.Get().SingleOrDefault(n => n.Ma == id);
                FormThemSuaNhanVien form = new FormThemSuaNhanVien(nv, frm, EnumHanhDong.ChiTiet);
                frm.OpenForm(form);
            }
            else if (e.ColumnIndex == dgvNhanVien.Columns["ColSua"].Index)
            {
                string id = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                NhanVien nv = nhanVienCotroller.Get().SingleOrDefault(n => n.Ma == id);
                FormThemSuaNhanVien form = new FormThemSuaNhanVien(nv, frm, EnumHanhDong.Sua);
                frm.OpenForm(form);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSuaNhanVien form = new FormThemSuaNhanVien(EnumHanhDong.Them);
            frm.OpenForm(form);
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
