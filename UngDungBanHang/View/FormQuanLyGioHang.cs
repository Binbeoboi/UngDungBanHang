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
using UngDungBanHang.Model;

namespace UngDungBanHang.View
{
    public partial class FormQuanLyGioHang : Form
    {
        GioHangController controller = new GioHangController();
        public FormQuanLyGioHang()
        {
            InitializeComponent();
        }
        FormAdmin frm = new FormAdmin();
        public FormQuanLyGioHang(FormAdmin frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        private void FormQuanLyGioHang_Load(object sender, EventArgs e)
        {
            Init(controller.Get());
        }

        private void Init(List<GioHang> gioHangs)
        {
            dgvGioHang.Rows.Clear();
            gioHangs.ForEach(n =>
            {
                dgvGioHang.Rows.Add(controller.HienThiThongTin(n));
            });
        }

        private void txtTimKiemXe_Enter(object sender, EventArgs e)
        {
            if(txtTimKiemGioHang.Text == "  Searching ..." && txtTimKiemGioHang.ForeColor == Color.DarkGray)
            {
                txtTimKiemGioHang.Text = "";
                txtTimKiemGioHang.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemGioHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                
                var data = txtTimKiemGioHang.Text == "" ? controller.Get() : controller.Get().Where(n => n.TenXe.ToLower().Trim().Contains(txtTimKiemGioHang.Text.ToLower().Trim())).ToList();
                Init(data);
            }

        }
    }
}
