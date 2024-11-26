namespace UngDungBanHang.View
{
    partial class UserDonHang
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
            this.ptbAnhXe = new System.Windows.Forms.PictureBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTenXe = new System.Windows.Forms.LinkLabel();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.lblSoDienThoaiNhanVien = new System.Windows.Forms.LinkLabel();
            this.cbTrangThai = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhXe)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAnhXe
            // 
            this.ptbAnhXe.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbAnhXe.Location = new System.Drawing.Point(0, 0);
            this.ptbAnhXe.Name = "ptbAnhXe";
            this.ptbAnhXe.Size = new System.Drawing.Size(132, 67);
            this.ptbAnhXe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhXe.TabIndex = 1;
            this.ptbAnhXe.TabStop = false;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(150, 18);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(66, 30);
            this.lblMa.TabIndex = 4;
            this.lblMa.Text = "label1";
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTenXe.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenXe.LinkColor = System.Drawing.Color.LightSalmon;
            this.lblTenXe.Location = new System.Drawing.Point(284, 18);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(114, 30);
            this.lblTenXe.TabIndex = 3;
            this.lblTenXe.TabStop = true;
            this.lblTenXe.Text = "linkLabel1";
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThang.Location = new System.Drawing.Point(732, 22);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(66, 30);
            this.lblNgayThang.TabIndex = 5;
            this.lblNgayThang.Text = "label1";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.ForeColor = System.Drawing.Color.Firebrick;
            this.lblGiaTien.Location = new System.Drawing.Point(1270, 22);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(66, 30);
            this.lblGiaTien.TabIndex = 6;
            this.lblGiaTien.Text = "label1";
            // 
            // lblSoDienThoaiNhanVien
            // 
            this.lblSoDienThoaiNhanVien.AutoSize = true;
            this.lblSoDienThoaiNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSoDienThoaiNhanVien.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoaiNhanVien.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSoDienThoaiNhanVien.Location = new System.Drawing.Point(1072, 22);
            this.lblSoDienThoaiNhanVien.Name = "lblSoDienThoaiNhanVien";
            this.lblSoDienThoaiNhanVien.Size = new System.Drawing.Size(114, 30);
            this.lblSoDienThoaiNhanVien.TabIndex = 3;
            this.lblSoDienThoaiNhanVien.TabStop = true;
            this.lblSoDienThoaiNhanVien.Text = "linkLabel1";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.AutoSize = true;
            this.cbTrangThai.Enabled = false;
            this.cbTrangThai.Location = new System.Drawing.Point(1491, 31);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(15, 14);
            this.cbTrangThai.TabIndex = 7;
            this.cbTrangThai.UseVisualStyleBackColor = true;
            // 
            // UserDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.lblGiaTien);
            this.Controls.Add(this.lblNgayThang);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblSoDienThoaiNhanVien);
            this.Controls.Add(this.lblTenXe);
            this.Controls.Add(this.ptbAnhXe);
            this.Name = "UserDonHang";
            this.Size = new System.Drawing.Size(1559, 67);
            this.Load += new System.EventHandler(this.UserDonHang_Load);
            this.MouseEnter += new System.EventHandler(this.UserDonHang_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserDonHang_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnhXe;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.LinkLabel lblTenXe;
        private System.Windows.Forms.Label lblNgayThang;
        private System.Windows.Forms.Label lblGiaTien;
        private System.Windows.Forms.LinkLabel lblSoDienThoaiNhanVien;
        private System.Windows.Forms.CheckBox cbTrangThai;
    }
}
