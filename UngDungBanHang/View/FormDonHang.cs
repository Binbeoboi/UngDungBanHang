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
            init();
        }

        private void init()
        {
            int index = 0;
            controller.Get().Where(n => n.MaKhachHang == kh.Ma).ToList().ForEach(n =>
            {
                UserDonHang user = new UserDonHang(n, index);
                fnlDonHang.Controls.Add(user);
                index++;
            });
        }
    }
}
