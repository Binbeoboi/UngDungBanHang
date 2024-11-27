namespace UngDungBanHang.View
{
    partial class FormQuanLyDonHang
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDonHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimKiemXe = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.ColMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNhanVienTuVan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrangThai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColXoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHopDong = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtTimKiemXe);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 66);
            this.panel1.TabIndex = 0;
            // 
            // txtTimKiemXe
            // 
            this.txtTimKiemXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemXe.BackColor = System.Drawing.Color.White;
            this.txtTimKiemXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiemXe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemXe.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiemXe.Location = new System.Drawing.Point(1299, 21);
            this.txtTimKiemXe.Name = "txtTimKiemXe";
            this.txtTimKiemXe.Size = new System.Drawing.Size(214, 22);
            this.txtTimKiemXe.TabIndex = 11;
            this.txtTimKiemXe.Text = "  Searching car...";
            this.txtTimKiemXe.TextChanged += new System.EventHandler(this.txtTimKiemXe_TextChanged);
            this.txtTimKiemXe.Enter += new System.EventHandler(this.txtTimKiemXe_Enter);
            this.txtTimKiemXe.Leave += new System.EventHandler(this.txtTimKiemXe_Leave);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(1269, 49);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(242, 1);
            this.panel6.TabIndex = 10;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1269, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 798);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvDonHang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1535, 798);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMa,
            this.ColTenXe,
            this.ColThoiGian,
            this.ColNhanVienTuVan,
            this.ColTrangThai,
            this.ColKhachHang,
            this.ColXoa,
            this.ColSua,
            this.ColChiTiet,
            this.ColHopDong});
            this.dgvDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonHang.EnableHeadersVisualStyles = false;
            this.dgvDonHang.Location = new System.Drawing.Point(3, 21);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.Size = new System.Drawing.Size(1529, 774);
            this.dgvDonHang.TabIndex = 0;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // ColMa
            // 
            this.ColMa.DataPropertyName = "Ma";
            this.ColMa.HeaderText = "Mã";
            this.ColMa.Name = "ColMa";
            this.ColMa.ReadOnly = true;
            // 
            // ColTenXe
            // 
            this.ColTenXe.DataPropertyName = "TenXe";
            this.ColTenXe.HeaderText = "Tên xe";
            this.ColTenXe.Name = "ColTenXe";
            this.ColTenXe.ReadOnly = true;
            // 
            // ColThoiGian
            // 
            this.ColThoiGian.DataPropertyName = "ThoiGian";
            this.ColThoiGian.HeaderText = "Thời gian";
            this.ColThoiGian.Name = "ColThoiGian";
            this.ColThoiGian.ReadOnly = true;
            // 
            // ColNhanVienTuVan
            // 
            this.ColNhanVienTuVan.DataPropertyName = "TenNhanVien";
            this.ColNhanVienTuVan.HeaderText = "Nhân viên tư vấn";
            this.ColNhanVienTuVan.Name = "ColNhanVienTuVan";
            this.ColNhanVienTuVan.ReadOnly = true;
            // 
            // ColTrangThai
            // 
            this.ColTrangThai.DataPropertyName = "TrangThai";
            this.ColTrangThai.HeaderText = "Trạng thái";
            this.ColTrangThai.Name = "ColTrangThai";
            this.ColTrangThai.ReadOnly = true;
            // 
            // ColKhachHang
            // 
            this.ColKhachHang.DataPropertyName = "TenKhachHang";
            this.ColKhachHang.HeaderText = "Khách hàng";
            this.ColKhachHang.Name = "ColKhachHang";
            this.ColKhachHang.ReadOnly = true;
            // 
            // ColXoa
            // 
            this.ColXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColXoa.HeaderText = "Xóa";
            this.ColXoa.Name = "ColXoa";
            this.ColXoa.ReadOnly = true;
            this.ColXoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColXoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColXoa.Text = "Xóa";
            this.ColXoa.ToolTipText = "Xóa";
            this.ColXoa.UseColumnTextForButtonValue = true;
            // 
            // ColSua
            // 
            this.ColSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColSua.HeaderText = "Sửa";
            this.ColSua.Name = "ColSua";
            this.ColSua.ReadOnly = true;
            this.ColSua.Text = "Sửa";
            this.ColSua.ToolTipText = "Sửa";
            this.ColSua.UseColumnTextForButtonValue = true;
            // 
            // ColChiTiet
            // 
            this.ColChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColChiTiet.HeaderText = "Chi tiết";
            this.ColChiTiet.Name = "ColChiTiet";
            this.ColChiTiet.ReadOnly = true;
            this.ColChiTiet.Text = "Chi Tiết";
            this.ColChiTiet.ToolTipText = "Chi tiết";
            this.ColChiTiet.UseColumnTextForButtonValue = true;
            // 
            // ColHopDong
            // 
            this.ColHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColHopDong.HeaderText = "Hợp đồng";
            this.ColHopDong.Name = "ColHopDong";
            this.ColHopDong.ReadOnly = true;
            this.ColHopDong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColHopDong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColHopDong.Text = "Hợp đồng";
            this.ColHopDong.ToolTipText = "Hợp đồng";
            this.ColHopDong.UseColumnTextForButtonValue = true;
            // 
            // FormQuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 864);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormQuanLyDonHang";
            this.Text = "FormQuanLyDonHang";
            this.Load += new System.EventHandler(this.FormQuanLyDonHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimKiemXe;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNhanVienTuVan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhachHang;
        private System.Windows.Forms.DataGridViewButtonColumn ColXoa;
        private System.Windows.Forms.DataGridViewButtonColumn ColSua;
        private System.Windows.Forms.DataGridViewButtonColumn ColChiTiet;
        private System.Windows.Forms.DataGridViewButtonColumn ColHopDong;
    }
}