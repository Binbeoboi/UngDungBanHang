namespace UngDungBanHang.View
{
    partial class FormThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbThongKeXeBanChay = new System.Windows.Forms.ListBox();
            this.chartXeBanChay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartKhachHangMuaNhieuNhat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbKhachHangMuaNhieuNhat = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbThongKeTuoiKhachHang = new System.Windows.Forms.ListBox();
            this.chartThongKeDoTuoiKhachHang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlContent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartXeBanChay)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKhachHangMuaNhieuNhat)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeDoTuoiKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.panel3);
            this.pnlContent.Controls.Add(this.panel2);
            this.pnlContent.Controls.Add(this.panel1);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1535, 1100);
            this.pnlContent.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1535, 361);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chartXeBanChay);
            this.groupBox1.Controls.Add(this.lbThongKeXeBanChay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1535, 361);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THỐNG KÊ XE BÁN CHẠY NHẤT";
            // 
            // lbThongKeXeBanChay
            // 
            this.lbThongKeXeBanChay.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbThongKeXeBanChay.FormattingEnabled = true;
            this.lbThongKeXeBanChay.ItemHeight = 21;
            this.lbThongKeXeBanChay.Location = new System.Drawing.Point(3, 25);
            this.lbThongKeXeBanChay.Name = "lbThongKeXeBanChay";
            this.lbThongKeXeBanChay.Size = new System.Drawing.Size(527, 333);
            this.lbThongKeXeBanChay.TabIndex = 0;
            // 
            // chartXeBanChay
            // 
            chartArea3.Name = "ChartArea1";
            this.chartXeBanChay.ChartAreas.Add(chartArea3);
            this.chartXeBanChay.Dock = System.Windows.Forms.DockStyle.Right;
            legend3.Name = "Legend1";
            this.chartXeBanChay.Legends.Add(legend3);
            this.chartXeBanChay.Location = new System.Drawing.Point(767, 25);
            this.chartXeBanChay.Name = "chartXeBanChay";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Xe";
            this.chartXeBanChay.Series.Add(series3);
            this.chartXeBanChay.Size = new System.Drawing.Size(765, 333);
            this.chartXeBanChay.TabIndex = 1;
            this.chartXeBanChay.Text = "chart1";
            title3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "TitleXeBanChay";
            title3.Text = "Top xe bán chạy nhất";
            this.chartXeBanChay.Titles.Add(title3);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1535, 361);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbKhachHangMuaNhieuNhat);
            this.groupBox2.Controls.Add(this.chartKhachHangMuaNhieuNhat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1535, 361);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THỐNG KÊ KHÁCH HÀNG MUA NHIỀU NHẤT";
            // 
            // chartKhachHangMuaNhieuNhat
            // 
            chartArea2.Name = "ChartArea1";
            this.chartKhachHangMuaNhieuNhat.ChartAreas.Add(chartArea2);
            this.chartKhachHangMuaNhieuNhat.Dock = System.Windows.Forms.DockStyle.Right;
            legend2.Name = "Legend1";
            this.chartKhachHangMuaNhieuNhat.Legends.Add(legend2);
            this.chartKhachHangMuaNhieuNhat.Location = new System.Drawing.Point(767, 25);
            this.chartKhachHangMuaNhieuNhat.Name = "chartKhachHangMuaNhieuNhat";
            this.chartKhachHangMuaNhieuNhat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.Name = "Khách hàng";
            this.chartKhachHangMuaNhieuNhat.Series.Add(series2);
            this.chartKhachHangMuaNhieuNhat.Size = new System.Drawing.Size(765, 333);
            this.chartKhachHangMuaNhieuNhat.TabIndex = 1;
            this.chartKhachHangMuaNhieuNhat.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "TitleKhachHangMuaNhieuNhat";
            title2.Text = "Top khách hàng mua nhiều nhất";
            this.chartKhachHangMuaNhieuNhat.Titles.Add(title2);
            // 
            // lbKhachHangMuaNhieuNhat
            // 
            this.lbKhachHangMuaNhieuNhat.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbKhachHangMuaNhieuNhat.FormattingEnabled = true;
            this.lbKhachHangMuaNhieuNhat.ItemHeight = 21;
            this.lbKhachHangMuaNhieuNhat.Location = new System.Drawing.Point(3, 25);
            this.lbKhachHangMuaNhieuNhat.Name = "lbKhachHangMuaNhieuNhat";
            this.lbKhachHangMuaNhieuNhat.Size = new System.Drawing.Size(527, 333);
            this.lbKhachHangMuaNhieuNhat.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 722);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1535, 361);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbThongKeTuoiKhachHang);
            this.groupBox3.Controls.Add(this.chartThongKeDoTuoiKhachHang);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1535, 361);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THỐNG KÊ KHÁCH HÀNG MỤC TIÊU";
            // 
            // lbThongKeTuoiKhachHang
            // 
            this.lbThongKeTuoiKhachHang.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbThongKeTuoiKhachHang.FormattingEnabled = true;
            this.lbThongKeTuoiKhachHang.ItemHeight = 21;
            this.lbThongKeTuoiKhachHang.Location = new System.Drawing.Point(3, 25);
            this.lbThongKeTuoiKhachHang.Name = "lbThongKeTuoiKhachHang";
            this.lbThongKeTuoiKhachHang.Size = new System.Drawing.Size(527, 333);
            this.lbThongKeTuoiKhachHang.TabIndex = 2;
            // 
            // chartThongKeDoTuoiKhachHang
            // 
            chartArea1.Name = "ChartArea1";
            this.chartThongKeDoTuoiKhachHang.ChartAreas.Add(chartArea1);
            this.chartThongKeDoTuoiKhachHang.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chartThongKeDoTuoiKhachHang.Legends.Add(legend1);
            this.chartThongKeDoTuoiKhachHang.Location = new System.Drawing.Point(767, 25);
            this.chartThongKeDoTuoiKhachHang.Name = "chartThongKeDoTuoiKhachHang";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Độ tuổi";
            this.chartThongKeDoTuoiKhachHang.Series.Add(series1);
            this.chartThongKeDoTuoiKhachHang.Size = new System.Drawing.Size(765, 333);
            this.chartThongKeDoTuoiKhachHang.TabIndex = 1;
            this.chartThongKeDoTuoiKhachHang.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "TitleDoTuoiKhachHang";
            title1.Text = "Thống kê độ tuổi khách hàng";
            this.chartThongKeDoTuoiKhachHang.Titles.Add(title1);
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1535, 1100);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            this.pnlContent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartXeBanChay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartKhachHangMuaNhieuNhat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartThongKeDoTuoiKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartXeBanChay;
        private System.Windows.Forms.ListBox lbThongKeXeBanChay;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKhachHangMuaNhieuNhat;
        private System.Windows.Forms.ListBox lbKhachHangMuaNhieuNhat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbThongKeTuoiKhachHang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThongKeDoTuoiKhachHang;
    }
}