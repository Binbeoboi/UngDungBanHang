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
    public partial class FormGioHang : Form
    {
        GioHangController controller = new GioHangController();
        public FormGioHang()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();
        KhachHang kh = new KhachHang();
        public FormGioHang(Form1 form, KhachHang kh)
        {
            InitializeComponent();
            this.form = form;
            this.kh = kh;
        }
        public void FormGioHang_Load(object sender, EventArgs e)
        {
            Init();
        } 
        public void Init()
        {
            fnlGioHang.Controls.Clear();
            int i = 0;
            controller.Get().Where(n => n.MaKhachHang.CompareTo(kh.Ma) == 0).ToList().ForEach(x =>
            {
                UserGioHang user = new UserGioHang(x, i, form, this, kh);
                user.Margin = new Padding(0, 5, 0, 5);
                fnlGioHang.Controls.Add(user);
                i++;
            });
        }
    }
}
