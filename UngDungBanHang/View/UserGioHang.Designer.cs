namespace UngDungBanHang.View
{
    partial class UserGioHang
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserGioHang));
            this.ptbAnhXe = new System.Windows.Forms.PictureBox();
            this.lblTenXe = new System.Windows.Forms.LinkLabel();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.btnMua = new System.Windows.Forms.PictureBox();
            this.btnXoa = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAnhXe
            // 
            this.ptbAnhXe.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbAnhXe.Location = new System.Drawing.Point(0, 0);
            this.ptbAnhXe.Name = "ptbAnhXe";
            this.ptbAnhXe.Size = new System.Drawing.Size(110, 67);
            this.ptbAnhXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhXe.TabIndex = 0;
            this.ptbAnhXe.TabStop = false;
            this.ptbAnhXe.MouseEnter += new System.EventHandler(this.UserGioHang_MouseEnter);
            this.ptbAnhXe.MouseLeave += new System.EventHandler(this.UserGioHang_MouseLeave);
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTenXe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenXe.LinkColor = System.Drawing.Color.LightSalmon;
            this.lblTenXe.Location = new System.Drawing.Point(256, 17);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(114, 30);
            this.lblTenXe.TabIndex = 1;
            this.lblTenXe.TabStop = true;
            this.lblTenXe.Text = "linkLabel1";
            this.lblTenXe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblTenXe_LinkClicked);
            this.lblTenXe.Click += new System.EventHandler(this.lblTenXe_Click);
            this.lblTenXe.MouseEnter += new System.EventHandler(this.UserGioHang_MouseEnter);
            this.lblTenXe.MouseLeave += new System.EventHandler(this.UserGioHang_MouseLeave);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(144, 18);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(66, 30);
            this.lblMa.TabIndex = 2;
            this.lblMa.Text = "label1";
            this.lblMa.MouseEnter += new System.EventHandler(this.UserGioHang_MouseEnter);
            this.lblMa.MouseLeave += new System.EventHandler(this.UserGioHang_MouseLeave);
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThang.Location = new System.Drawing.Point(761, 17);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(66, 30);
            this.lblNgayThang.TabIndex = 2;
            this.lblNgayThang.Text = "label1";
            this.lblNgayThang.MouseEnter += new System.EventHandler(this.UserGioHang_MouseEnter);
            this.lblNgayThang.MouseLeave += new System.EventHandler(this.UserGioHang_MouseLeave);
            // 
            // btnMua
            // 
            this.btnMua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMua.Image = ((System.Drawing.Image)(resources.GetObject("btnMua.Image")));
            this.btnMua.Location = new System.Drawing.Point(981, 12);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(44, 40);
            this.btnMua.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMua.TabIndex = 3;
            this.btnMua.TabStop = false;
            this.toolTip1.SetToolTip(this.btnMua, "Chỉnh sửa giỏ hàng");
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            this.btnMua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnChinhSua_MouseDown);
            this.btnMua.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnChinhSua_MouseUp);
            // 
            // btnXoa
            // 
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(1058, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(42, 40);
            this.btnXoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXoa.TabIndex = 3;
            this.btnXoa.TabStop = false;
            this.toolTip1.SetToolTip(this.btnXoa, "Xóa giỏ hàng");
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnXoa_MouseDown);
            this.btnXoa.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnXoa_MouseUp);
            // 
            // UserGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnMua);
            this.Controls.Add(this.lblNgayThang);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTenXe);
            this.Controls.Add(this.ptbAnhXe);
            this.Name = "UserGioHang";
            this.Size = new System.Drawing.Size(1135, 67);
            this.Load += new System.EventHandler(this.UserGioHang_Load);
            this.DoubleClick += new System.EventHandler(this.lblTenXe_Click);
            this.MouseEnter += new System.EventHandler(this.UserGioHang_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserGioHang_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnhXe;
        private System.Windows.Forms.LinkLabel lblTenXe;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblNgayThang;
        private System.Windows.Forms.PictureBox btnMua;
        private System.Windows.Forms.PictureBox btnXoa;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
