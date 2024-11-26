using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UngDungBanHang.Model;
using UngDungBanHang.View;

namespace UngDungBanHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KhachHang kh = new KhachHang();
        public Form1(KhachHang kh)
        {
            InitializeComponent();
            this.kh = kh;
        }

        bool checkMax = true;
        public void HoverButton(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.FromArgb(201, 81, 0);
            btn.FlatAppearance.BorderColor = Color.FromArgb(201, 81, 0);
            btn.FlatAppearance.BorderSize = 2;
        }
        public void HoverButtonLeave(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
            //btn.FlatAppearance.BorderColor = Color.FromArgb(201, 81, 0);
            btn.FlatAppearance.BorderSize = 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (checkMax)
            {
                this.WindowState = FormWindowState.Maximized;
                checkMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(1559, 1000);
                checkMax = true;
            }
        }

        public void OpenForm(Form child)
        {
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;

            pnlBody.Controls.Clear();
            pnlBody.Controls.Add(child);
            pnlBody.Tag = child;

            child.BringToFront();
            child.Show();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            FormTrangChu frm = new FormTrangChu();
            OpenForm(frm);
        }

        private void btnMauXe_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            FormTrungBayXe frm = new FormTrungBayXe(this, kh);
            OpenForm(frm);
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            FormGioHang frm = new FormGioHang(this, kh);
            OpenForm(frm);
        }

        private void ptbLogo_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            btnTrangChu_Click(sender, e);
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            btnTrangChu_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            FormGioHang frm = new FormGioHang(this, kh);
            OpenForm(frm);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoIntro.uiMode = "none";
            videoIntro.URL = $@"C:\Learn\CSharp Learn\UngDungBanHang\UngDungBanHang\VideoIntro\Introducing VinFast Electric Vehicles.mp4";
        }

        private void videoIntro_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            lblTitleMain.Visible = true;
            ptbLogo.Visible = true;
        }

        private void videoIntro_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(e.newState == (int)WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Start();
            }
        }
        //418, 244
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (ptbLogoMain.Location.Y >= 244 && lblTitleMain.Location.Y >= 418)
            {
                ptbLogoMain.Visible = true;
                lblTitleMain.Visible = true;
                ptbLogoMain.Top -= 10;
                lblTitleMain.Top -= 10;
            }

        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            FormThongTinCaNhan form =  new FormThongTinCaNhan(kh);
            OpenForm(form);
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            videoIntro.Ctlcontrols.stop();
            FormDonHang frm = new FormDonHang(kh);
            OpenForm(frm);
        }
    }
}
