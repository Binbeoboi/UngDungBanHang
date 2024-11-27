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
    public partial class FormQuanLyDonHang : Form
    {
        DonHangController dh = new DonHangController();
        public FormQuanLyDonHang()
        {
            InitializeComponent();
        }
        FormAdmin frm = new FormAdmin();
        public FormQuanLyDonHang(FormAdmin frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void FormQuanLyDonHang_Load(object sender, EventArgs e)
        {
            HienThiThongTin(dh.Get());
        }

        private void HienThiThongTin(List<DonHang> dhang)
        {
            dgvDonHang.Rows.Clear();
            dhang.ForEach(n => {
                dgvDonHang.Rows.Add(dh.HienThiThongTin(n));
            });
        }

        private void txtTimKiemXe_Leave(object sender, EventArgs e)
        {
            if(txtTimKiemXe.Text == string.Empty)
            {
                txtTimKiemXe.Text = "  Searching car...";
                txtTimKiemXe.ForeColor = Color.DarkGray;
                HienThiThongTin(dh.Get());
            }
        }

        private void txtTimKiemXe_Enter(object sender, EventArgs e)
        {
            if(txtTimKiemXe.Text == "  Searching car..." && txtTimKiemXe.ForeColor == Color.DarkGray)
            {
                txtTimKiemXe.Text = string.Empty;
                txtTimKiemXe.ForeColor = Color.Black;
            }

        }

        private void txtTimKiemXe_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiemXe.Text))
            {
                HienThiThongTin(dh.Get());
                return;
            }
            var data = dh.Get().Where(n => n.TenNhanVien.ToLower().Trim().Contains(txtTimKiemXe.Text.ToLower().Trim())
            || n.TenKhachHang.ToLower().Trim().Contains(txtTimKiemXe.Text.ToLower().Trim())
            || n.TenXe.ToLower().Trim().Contains(txtTimKiemXe.Text.ToLower().Trim())).ToList();

            HienThiThongTin(data);
        }


        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == dgvDonHang.Columns["ColXoa"].Index)
            {
                if (MessageBox.Show("Bạn có muốn xóa đơn hàng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                int id = int.Parse(dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (dh.Xoa(id))
                {
                    MessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormQuanLyDonHang_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Bạn đã xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if(e.ColumnIndex == dgvDonHang.Columns["ColChiTiet"].Index)
            {
                int id = int.Parse(dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                var data = dh.Get().SingleOrDefault(n => n.Ma == id);
                FormThongTinChiTietDonHang form = new FormThongTinChiTietDonHang(data, frm, EnumHanhDong.ChiTiet);
                frm.OpenForm(form);
            }
            if (e.ColumnIndex == dgvDonHang.Columns["ColSua"].Index)
            {
                int id = int.Parse(dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                var data = dh.Get().SingleOrDefault(n => n.Ma == id);
                FormThongTinChiTietDonHang form = new FormThongTinChiTietDonHang(data, frm, EnumHanhDong.Sua);
                frm.OpenForm(form);
            }
            if (e.ColumnIndex == dgvDonHang.Columns["ColHopDong"].Index)
            {
                int id = int.Parse(dgvDonHang.Rows[e.RowIndex].Cells[0].Value.ToString());
                var data = dh.Get().SingleOrDefault(n => n.Ma == id);
                FormHopDong form = new FormHopDong(data);
                form.ShowDialog();  
            }
        }
    }
}
