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
    public partial class FormTrungBayXe : Form
    {
        XeController xeController = new XeController();
        public FormTrungBayXe()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        KhachHang kh = new KhachHang();
        public FormTrungBayXe(Form1 form, KhachHang kh)
        {
            InitializeComponent();
            this.form = form;
            this.kh = kh;
        }
        public void GetDoiXe()
        {
            cbbDoiXe.Items.Clear();
            cbbDoiXe.Items.Add("Mặc định");
            List<string> lstNam = xeController.Get().Select(n => n.Nam.ToString()).ToList();
            HashSet<string> set = new HashSet<string>(lstNam);
            foreach (string n in set)
            {
                cbbDoiXe.Items.Add(n);
            }
        }
        public void Default()
        {
            txtTimKiemXe.Text = "  Searching car...";
            txtTimKiemXe.ForeColor = Color.DarkGray;
            lblKetQua.Visible = false;
            cbbDoiXe.SelectedIndex = -1;
            cbbHangXe.SelectedIndex = -1;
            cbbPhanKhucGia.SelectedIndex = -1;
        }
        private void FormTrungBayXe_Load(object sender, EventArgs e)
        {
            InThongTin(xeController.Get());
            GetDoiXe();
            GetHangXe();
            //lblPhanKhucGia.Parent = cbbPhanKhucGia;
        }

        private void GetHangXe()
        {
            cbbHangXe.Items.Clear();
            cbbHangXe.Items.Add("Tất cả");
            List<string> lstHangXe = xeController.Get().Select(n => n.HangSanXuat.ToString()).ToList();
            HashSet<string> set = new HashSet<string>(lstHangXe);
            foreach (string n in set)
            {
                cbbHangXe.Items.Add(n);
            }
        }

        private void InThongTin(List<Xe> xe)
        {
            pnlTrungBayXe.Controls.Clear();
            xe.ForEach(x =>
            {
                UserCar user = new UserCar(x, form, kh);
                user.Margin = new Padding(5,20, 5, 20);
                pnlTrungBayXe.Controls.Add(user);
            });
            
        }

        private void txtTimKiemXe_MouseEnter(object sender, EventArgs e)
        {
            txtTimKiemXe.Text = string.Empty;
            txtTimKiemXe.ForeColor = Color.Black;
        }

        private void txtTimKiemXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbPhanKhucGia_DropDown(object sender, EventArgs e)
        {
            cbbPhanKhucGia.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            cbbPhanKhucGia.ForeColor = Color.Black;

        }

    

        private void cbbPhanKhucGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhanKhucGia.SelectedIndex == 0)
            {
                FormTrungBayXe_Load(sender, e);

            }
            else if(cbbPhanKhucGia.SelectedIndex == 1)
            {
                List<Xe> lst = xeController.Get().OrderBy(n => n.GiaBan).ToList();
                InThongTin(lst);

            }
            else
            {
                List<Xe> lst = xeController.Get().OrderByDescending(n => n.GiaBan).ToList();
                InThongTin(lst);

            }
        }

        private void lblPhanKhucGia_MouseEnter(object sender, EventArgs e)
        {
            cbbPhanKhucGia.BackColor = Color.FromArgb(229, 241, 251);
        }

        private void cbbDoiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Xe> lst = xeController.Get().Where(n => n.Nam.CompareTo(int.Parse(cbbDoiXe.Text)) == 0).ToList();
                InThongTin(lst);
            }
            catch 
            {
                FormTrungBayXe_Load(sender, e);
            }
            
        }

        private void cbbHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<Xe> lst = xeController.Get().Where(n => n.HangSanXuat.CompareTo(cbbHangXe.Text) == 0).ToList();
                
                if(lst.Count > 0)
                {
                    InThongTin(lst);
                }
                else
                {
                    FormTrungBayXe_Load(sender, e);
                }
            }
            catch
            {
                FormTrungBayXe_Load(sender, e);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiemXe_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtTimKiemXe.Text))
                {
                    InThongTin(xeController.Get());
                    lblKetQua.Visible = false;
                    return;
                }

                var data = xeController.TimTheoTen(txtTimKiemXe.Text);
                lblKetQua.Visible = true;
                lblKetQua.Text = $"Kết quả tìm kiếm: {data.Count} kết quả";
                InThongTin(data);
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Default();
            panel2.Focus();
        }
    }
}
