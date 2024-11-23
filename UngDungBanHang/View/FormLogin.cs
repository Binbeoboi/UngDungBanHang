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
using UngDungBanHang.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace UngDungBanHang.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        string chuoiPassword = "";
        bool checkshow = false;
        bool checkMax = true;
        KhachHangController kh = new KhachHangController();
        KhachHang khachHang = new KhachHang();
        public bool CheckDangNhap()
        {
            bool check = false;
            foreach (var item in kh.Get())
            {
                if(txtUserName.Text.CompareTo(item.Email) == 0 && txtPassword.Text.CompareTo(item.Password) == 0)
                {
                    check = true;
                    khachHang = item;
                    break;
                }
            };
            return check;
        }
        public bool CheckAdmin()
        {
            bool check = false;
            if(txtUserName.Text.Equals("Admin") && txtPassword.Text.Equals("Admin"))
            {
                check = true;
            }
            return check;
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

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtUserName.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            txtUserName.ForeColor = Color.Black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            if (txtPassword.Text == "Password" && txtPassword.ForeColor == Color.DarkGray)
            {
                //btnShow.Visible = true;
                txtPassword.Text = string.Empty;
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            btnLogin.Select();
        }



        private void btnShow_Click(object sender, EventArgs e)
        {
            bool check = txtPassword.UseSystemPasswordChar;
            bool checkDaoNguoc = !check;
            string currentText = txtPassword.Text;
            txtPassword.UseSystemPasswordChar = checkDaoNguoc;
            txtPassword.Text = currentText;
            txtPassword.SelectionStart = txtPassword.Text.Length;
            if (!checkshow)
            {
                btnShow.Image = Image.FromFile($@"{LinkConnection.linkImgIcon}\show.png");
                checkshow = true;
            }
            else
            {
                btnShow.Image = Image.FromFile($@"{LinkConnection.linkImgIcon}\hide.png");
                checkshow = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            chuoiPassword = txtPassword.Text;
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text == string.Empty)
            {
                txtUserName.Text = "Username";
                txtUserName.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                txtUserName.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "Password";
                txtPassword.Font = new Font("Segoe UI", 12, FontStyle.Regular);
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(CheckDangNhap() && !CheckAdmin())
            {
                new Form1(khachHang).ShowDialog();
            }
            else if(!CheckDangNhap() && CheckAdmin())
            {
                new FormAdmin().ShowDialog();   
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Nhập lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length > 1 && (txtPassword.Text != "Password" && txtPassword.ForeColor != Color.DarkGray))
            {
                btnShow.Visible = true;
            }
            else if(txtPassword.Text.Length == 0)
            {
                btnShow.Visible = false;
            }
        }
    }
}
