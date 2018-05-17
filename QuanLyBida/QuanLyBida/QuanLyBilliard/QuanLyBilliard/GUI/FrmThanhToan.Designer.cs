namespace QuanLyBilliard.GUI
{
    partial class FrmThanhToan
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
            this.pnLoc = new System.Windows.Forms.Panel();
            this.lbLocTheo = new System.Windows.Forms.Label();
            this.cbLocHoaDon = new System.Windows.Forms.ComboBox();
            this.btnTim = new DevExpress.XtraEditors.SimpleButton();
            this.lbTimKiem = new System.Windows.Forms.Label();
            this.txtIDHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.pnNgay = new System.Windows.Forms.Panel();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.DATHANHTOAN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIATHUCPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTHUCPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIAGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_HOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDHoaDon.Properties)).BeginInit();
            this.pnNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLoc
            // 
            this.pnLoc.Controls.Add(this.lbLocTheo);
            this.pnLoc.Controls.Add(this.cbLocHoaDon);
            this.pnLoc.Controls.Add(this.btnTim);
            this.pnLoc.Controls.Add(this.lbTimKiem);
            this.pnLoc.Controls.Add(this.txtIDHoaDon);
            this.pnLoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLoc.Location = new System.Drawing.Point(0, 0);
            this.pnLoc.Name = "pnLoc";
            this.pnLoc.Size = new System.Drawing.Size(824, 42);
            this.pnLoc.TabIndex = 6;
            // 
            // lbLocTheo
            // 
            this.lbLocTheo.AutoSize = true;
            this.lbLocTheo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLocTheo.Location = new System.Drawing.Point(12, 13);
            this.lbLocTheo.Name = "lbLocTheo";
            this.lbLocTheo.Size = new System.Drawing.Size(58, 16);
            this.lbLocTheo.TabIndex = 5;
            this.lbLocTheo.Text = "Lọc theo";
            // 
            // cbLocHoaDon
            // 
            this.cbLocHoaDon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLocHoaDon.FormattingEnabled = true;
            this.cbLocHoaDon.Items.AddRange(new object[] {
            "Tất cả",
            "Hôm nay",
            "Khoảng thời gian"});
            this.cbLocHoaDon.Location = new System.Drawing.Point(76, 10);
            this.cbLocHoaDon.Name = "cbLocHoaDon";
            this.cbLocHoaDon.Size = new System.Drawing.Size(144, 24);
            this.cbLocHoaDon.TabIndex = 4;
            this.cbLocHoaDon.TextChanged += new System.EventHandler(this.cbLocHoaDon_TextChanged);
            // 
            // btnTim
            // 
            this.btnTim.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.Appearance.Options.UseFont = true;
            this.btnTim.Location = new System.Drawing.Point(759, 9);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(53, 23);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.AutoSize = true;
            this.lbTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTimKiem.Location = new System.Drawing.Point(512, 13);
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(61, 16);
            this.lbTimKiem.TabIndex = 6;
            this.lbTimKiem.Text = "Tìm kiếm";
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.Location = new System.Drawing.Point(579, 10);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDHoaDon.Properties.Appearance.Options.UseFont = true;
            this.txtIDHoaDon.Size = new System.Drawing.Size(174, 22);
            this.txtIDHoaDon.TabIndex = 7;
            // 
            // pnNgay
            // 
            this.pnNgay.Controls.Add(this.dtpTuNgay);
            this.pnNgay.Controls.Add(this.dtpDenNgay);
            this.pnNgay.Controls.Add(this.lbDenNgay);
            this.pnNgay.Controls.Add(this.lbTuNgay);
            this.pnNgay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNgay.Location = new System.Drawing.Point(0, 42);
            this.pnNgay.Name = "pnNgay";
            this.pnNgay.Size = new System.Drawing.Size(824, 40);
            this.pnNgay.TabIndex = 5;
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Location = new System.Drawing.Point(178, 10);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpTuNgay.TabIndex = 13;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Location = new System.Drawing.Point(504, 10);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpDenNgay.TabIndex = 14;
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDenNgay.Location = new System.Drawing.Point(429, 15);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(69, 16);
            this.lbDenNgay.TabIndex = 11;
            this.lbDenNgay.Text = "Đến ngày";
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuNgay.Location = new System.Drawing.Point(73, 15);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(61, 16);
            this.lbTuNgay.TabIndex = 12;
            this.lbTuNgay.Text = "Từ ngày";
            // 
            // DATHANHTOAN
            // 
            this.DATHANHTOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATHANHTOAN.HeaderText = "Đã thanh toán";
            this.DATHANHTOAN.Name = "DATHANHTOAN";
            this.DATHANHTOAN.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Width = 71;
            // 
            // GIAMGIATHUCPHAM
            // 
            this.GIAMGIATHUCPHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIAMGIATHUCPHAM.HeaderText = "Giảm giá thực phẩm";
            this.GIAMGIATHUCPHAM.Name = "GIAMGIATHUCPHAM";
            this.GIAMGIATHUCPHAM.ReadOnly = true;
            this.GIAMGIATHUCPHAM.Width = 92;
            // 
            // TIENTHUCPHAM
            // 
            this.TIENTHUCPHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIENTHUCPHAM.HeaderText = "Tiền thực phẩm";
            this.TIENTHUCPHAM.Name = "TIENTHUCPHAM";
            this.TIENTHUCPHAM.ReadOnly = true;
            this.TIENTHUCPHAM.Width = 97;
            // 
            // GIAMGIAGIO
            // 
            this.GIAMGIAGIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIAMGIAGIO.HeaderText = "Giảm giá giờ";
            this.GIAMGIAGIO.Name = "GIAMGIAGIO";
            this.GIAMGIAGIO.ReadOnly = true;
            this.GIAMGIAGIO.Width = 70;
            // 
            // TIENGIO
            // 
            this.TIENGIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIENGIO.HeaderText = "Tiền giờ";
            this.TIENGIO.Name = "TIENGIO";
            this.TIENGIO.ReadOnly = true;
            this.TIENGIO.Width = 65;
            // 
            // TENKHACHHANG
            // 
            this.TENKHACHHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENKHACHHANG.HeaderText = "Khách hàng";
            this.TENKHACHHANG.Name = "TENKHACHHANG";
            this.TENKHACHHANG.ReadOnly = true;
            this.TENKHACHHANG.Width = 83;
            // 
            // TENNHANVIEN
            // 
            this.TENNHANVIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENNHANVIEN.HeaderText = "Nhân viên";
            this.TENNHANVIEN.Name = "TENNHANVIEN";
            this.TENNHANVIEN.ReadOnly = true;
            this.TENNHANVIEN.Width = 75;
            // 
            // TENBAN
            // 
            this.TENBAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENBAN.HeaderText = "Tên bàn";
            this.TENBAN.Name = "TENBAN";
            this.TENBAN.ReadOnly = true;
            this.TENBAN.Width = 51;
            // 
            // ID_HOADON
            // 
            this.ID_HOADON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_HOADON.HeaderText = "ID hóa đơn";
            this.ID_HOADON.Name = "ID_HOADON";
            this.ID_HOADON.ReadOnly = true;
            this.ID_HOADON.Width = 79;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HOADON,
            this.TENBAN,
            this.TENNHANVIEN,
            this.TENKHACHHANG,
            this.TIENGIO,
            this.GIAMGIAGIO,
            this.TIENTHUCPHAM,
            this.GIAMGIATHUCPHAM,
            this.tongtien,
            this.DATHANHTOAN});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(824, 309);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 397);
            this.Controls.Add(this.pnNgay);
            this.Controls.Add(this.pnLoc);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmThanhToan";
            this.Text = "FrmThanhToan";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            this.pnLoc.ResumeLayout(false);
            this.pnLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDHoaDon.Properties)).EndInit();
            this.pnNgay.ResumeLayout(false);
            this.pnNgay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnLoc;
        private System.Windows.Forms.Panel pnNgay;
        private System.Windows.Forms.Label lbLocTheo;
        private System.Windows.Forms.ComboBox cbLocHoaDon;
        private DevExpress.XtraEditors.SimpleButton btnTim;
        private System.Windows.Forms.Label lbTimKiem;
        private DevExpress.XtraEditors.TextEdit txtIDHoaDon;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DATHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIATHUCPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTHUCPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIAGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOADON;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}