namespace UngDungBanHang.View
{
    partial class UserCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCar));
            this.ptbCar = new System.Windows.Forms.PictureBox();
            this.lblTenXe = new System.Windows.Forms.Label();
            this.lblGiaXe = new System.Windows.Forms.Label();
            this.btnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCar
            // 
            this.ptbCar.Dock = System.Windows.Forms.DockStyle.Top;
            this.ptbCar.Image = ((System.Drawing.Image)(resources.GetObject("ptbCar.Image")));
            this.ptbCar.Location = new System.Drawing.Point(0, 0);
            this.ptbCar.Name = "ptbCar";
            this.ptbCar.Size = new System.Drawing.Size(341, 172);
            this.ptbCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCar.TabIndex = 0;
            this.ptbCar.TabStop = false;
            this.ptbCar.MouseEnter += new System.EventHandler(this.UserCar_MouseEnter);
            this.ptbCar.MouseLeave += new System.EventHandler(this.UserCar_MouseLeave);
            // 
            // lblTenXe
            // 
            this.lblTenXe.AutoSize = true;
            this.lblTenXe.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenXe.Location = new System.Drawing.Point(7, 182);
            this.lblTenXe.Name = "lblTenXe";
            this.lblTenXe.Size = new System.Drawing.Size(277, 23);
            this.lblTenXe.TabIndex = 1;
            this.lblTenXe.Text = "Toyota Fortuner 2.4 MT 4x2 2018";
            this.lblTenXe.MouseEnter += new System.EventHandler(this.UserCar_MouseEnter);
            this.lblTenXe.MouseLeave += new System.EventHandler(this.UserCar_MouseLeave);
            // 
            // lblGiaXe
            // 
            this.lblGiaXe.AutoSize = true;
            this.lblGiaXe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaXe.Location = new System.Drawing.Point(9, 218);
            this.lblGiaXe.Name = "lblGiaXe";
            this.lblGiaXe.Size = new System.Drawing.Size(113, 21);
            this.lblGiaXe.TabIndex = 1;
            this.lblGiaXe.Text = "774.000.000 đ";
            this.lblGiaXe.MouseEnter += new System.EventHandler(this.UserCar_MouseEnter);
            this.lblGiaXe.MouseLeave += new System.EventHandler(this.UserCar_MouseLeave);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.btnChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChiTiet.FlatAppearance.BorderSize = 0;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnChiTiet.Location = new System.Drawing.Point(263, 216);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 29);
            this.btnChiTiet.TabIndex = 2;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            this.btnChiTiet.MouseEnter += new System.EventHandler(this.UserCar_MouseEnter);
            this.btnChiTiet.MouseLeave += new System.EventHandler(this.UserCar_MouseLeave);
            // 
            // UserCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.lblGiaXe);
            this.Controls.Add(this.lblTenXe);
            this.Controls.Add(this.ptbCar);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserCar";
            this.Size = new System.Drawing.Size(341, 286);
            this.Load += new System.EventHandler(this.UserCar_Load);
            this.DoubleClick += new System.EventHandler(this.btnChiTiet_Click);
            this.MouseEnter += new System.EventHandler(this.UserCar_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserCar_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCar;
        private System.Windows.Forms.Label lblTenXe;
        private System.Windows.Forms.Label lblGiaXe;
        private System.Windows.Forms.Button btnChiTiet;
    }
}
