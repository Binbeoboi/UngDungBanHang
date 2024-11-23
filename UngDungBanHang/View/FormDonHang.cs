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
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }
        DonHangController controller = new DonHangController();
        KhachHang kh = new KhachHang();
        public FormDonHang(KhachHang kh)
        {
            InitializeComponent();
            this.kh = kh;
        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            init(controller.Get());
        }

        private void init(List<DonHang> donHangs)
        {
            fnlDonHang.Controls.Clear();
            int index = 0;
            donHangs.Where(n => n.MaKhachHang == kh.Ma).ToList().ForEach(n =>
            {
                UserDonHang user = new UserDonHang(n, index);
                fnlDonHang.Controls.Add(user);
                index++;
            });
        }

        private void txtTimKiemXe_Enter(object sender, EventArgs e)
        {
            txtTimKiemXe.Text = string.Empty;
            txtTimKiemXe.ForeColor = Color.Black;

        }

        private void txtTimKiemXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiemXe_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                var ketQua = controller.Get().Where(n => n.TenXe.ToLower().Contains(txtTimKiemXe.Text.ToLower())).ToList();
                init(ketQua);
            }
                
        }
    }
}
