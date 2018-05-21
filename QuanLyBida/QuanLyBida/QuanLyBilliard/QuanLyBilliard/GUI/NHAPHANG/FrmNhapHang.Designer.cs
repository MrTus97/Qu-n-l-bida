namespace QuanLyBilliard.GUI
{
    partial class FrmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNhapHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.ID_HOADONNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENHOADONNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChiTietHDNhap = new System.Windows.Forms.DataGridView();
            this.MATHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dgvChiTietHDNhap_IdMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 22);
            this.btnThem.Text = "Thêm phiếu";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(79, 22);
            this.btnSua.Text = "Sửa phiếu";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 22);
            this.btnXoa.Text = "Xóa phiếu";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.AllowUserToAddRows = false;
            this.dgvHoaDonNhap.AllowUserToDeleteRows = false;
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HOADONNHAP,
            this.TENHOADONNHAP,
            this.NGAYNHAP,
            this.TongTien});
            this.dgvHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(0, 25);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.ReadOnly = true;
            this.dgvHoaDonNhap.RowHeadersVisible = false;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(283, 350);
            this.dgvHoaDonNhap.TabIndex = 1;
            this.dgvHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellClick);
            // 
            // ID_HOADONNHAP
            // 
            this.ID_HOADONNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_HOADONNHAP.HeaderText = "ID";
            this.ID_HOADONNHAP.Name = "ID_HOADONNHAP";
            this.ID_HOADONNHAP.ReadOnly = true;
            this.ID_HOADONNHAP.Width = 43;
            // 
            // TENHOADONNHAP
            // 
            this.TENHOADONNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENHOADONNHAP.HeaderText = "Tên hóa đơn";
            this.TENHOADONNHAP.Name = "TENHOADONNHAP";
            this.TENHOADONNHAP.ReadOnly = true;
            this.TENHOADONNHAP.Width = 87;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 71;
            // 
            // dgvChiTietHDNhap
            // 
            this.dgvChiTietHDNhap.AllowUserToAddRows = false;
            this.dgvChiTietHDNhap.AllowUserToDeleteRows = false;
            this.dgvChiTietHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATHANG,
            this.SOLUONG,
            this.DONGIANHAP,
            this.Thanhtien,
            this.c_dgvChiTietHDNhap_IdMatHang});
            this.dgvChiTietHDNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHDNhap.Location = new System.Drawing.Point(283, 25);
            this.dgvChiTietHDNhap.Name = "dgvChiTietHDNhap";
            this.dgvChiTietHDNhap.ReadOnly = true;
            this.dgvChiTietHDNhap.RowHeadersVisible = false;
            this.dgvChiTietHDNhap.Size = new System.Drawing.Size(1067, 350);
            this.dgvChiTietHDNhap.TabIndex = 2;
            // 
            // MATHANG
            // 
            this.MATHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MATHANG.HeaderText = "Mặt hàng";
            this.MATHANG.Name = "MATHANG";
            this.MATHANG.ReadOnly = true;
            // 
            // SOLUONG
            // 
            this.SOLUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.ReadOnly = true;
            this.SOLUONG.Width = 74;
            // 
            // DONGIANHAP
            // 
            this.DONGIANHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DONGIANHAP.HeaderText = "Đơn giá nhập";
            this.DONGIANHAP.Name = "DONGIANHAP";
            this.DONGIANHAP.ReadOnly = true;
            this.DONGIANHAP.Width = 96;
            // 
            // Thanhtien
            // 
            this.Thanhtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Thanhtien.HeaderText = "Thành tiền";
            this.Thanhtien.Name = "Thanhtien";
            this.Thanhtien.ReadOnly = true;
            this.Thanhtien.Width = 83;
            // 
            // c_dgvChiTietHDNhap_IdMatHang
            // 
            this.c_dgvChiTietHDNhap_IdMatHang.HeaderText = "Column1";
            this.c_dgvChiTietHDNhap_IdMatHang.Name = "c_dgvChiTietHDNhap_IdMatHang";
            this.c_dgvChiTietHDNhap_IdMatHang.ReadOnly = true;
            this.c_dgvChiTietHDNhap_IdMatHang.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(283, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 350);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // FrmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 375);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvChiTietHDNhap);
            this.Controls.Add(this.dgvHoaDonNhap);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNhapHang";
            this.Text = "FrmNhapHang";
            this.Load += new System.EventHandler(this.FrmNhapHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOADONNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENHOADONNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridView dgvChiTietHDNhap;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thanhtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dgvChiTietHDNhap_IdMatHang;
    }
}