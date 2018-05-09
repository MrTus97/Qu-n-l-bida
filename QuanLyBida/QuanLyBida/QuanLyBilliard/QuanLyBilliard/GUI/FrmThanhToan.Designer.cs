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
            this.cbLocHoaDon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDHoaDon = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.ID_HOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIAGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENTHUCPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIATHUCPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATHANHTOAN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDHoaDon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbLocHoaDon
            // 
            this.cbLocHoaDon.FormattingEnabled = true;
            this.cbLocHoaDon.Items.AddRange(new object[] {
            "Tất cả",
            "Hôm nay",
            "Khoảng thời gian"});
            this.cbLocHoaDon.Location = new System.Drawing.Point(85, 13);
            this.cbLocHoaDon.Name = "cbLocHoaDon";
            this.cbLocHoaDon.Size = new System.Drawing.Size(121, 21);
            this.cbLocHoaDon.TabIndex = 0;
            this.cbLocHoaDon.TextChanged += new System.EventHandler(this.cbLocHoaDon_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label1";
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.Location = new System.Drawing.Point(572, 11);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.Size = new System.Drawing.Size(134, 20);
            this.txtIDHoaDon.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(713, 11);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(85, 3);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpTuNgay.TabIndex = 4;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(411, 3);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(200, 20);
            this.dtpDenNgay.TabIndex = 4;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(824, 289);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.lbDenNgay);
            this.panel1.Controls.Add(this.lbTuNgay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 42);
            this.panel1.TabIndex = 6;
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(361, 10);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(35, 13);
            this.lbDenNgay.TabIndex = 1;
            this.lbDenNgay.Text = "label1";
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Location = new System.Drawing.Point(27, 9);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(35, 13);
            this.lbTuNgay.TabIndex = 1;
            this.lbTuNgay.Text = "label1";
            // 
            // ID_HOADON
            // 
            this.ID_HOADON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_HOADON.HeaderText = "ID hóa đơn";
            this.ID_HOADON.Name = "ID_HOADON";
            this.ID_HOADON.ReadOnly = true;
            this.ID_HOADON.Width = 86;
            // 
            // TENBAN
            // 
            this.TENBAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENBAN.HeaderText = "Tên bàn";
            this.TENBAN.Name = "TENBAN";
            this.TENBAN.ReadOnly = true;
            this.TENBAN.Width = 72;
            // 
            // TENNHANVIEN
            // 
            this.TENNHANVIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENNHANVIEN.HeaderText = "Nhân viên";
            this.TENNHANVIEN.Name = "TENNHANVIEN";
            this.TENNHANVIEN.ReadOnly = true;
            this.TENNHANVIEN.Width = 81;
            // 
            // TENKHACHHANG
            // 
            this.TENKHACHHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENKHACHHANG.HeaderText = "Khách hàng";
            this.TENKHACHHANG.Name = "TENKHACHHANG";
            this.TENKHACHHANG.ReadOnly = true;
            this.TENKHACHHANG.Width = 90;
            // 
            // TIENGIO
            // 
            this.TIENGIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIENGIO.HeaderText = "Tiền giờ";
            this.TIENGIO.Name = "TIENGIO";
            this.TIENGIO.ReadOnly = true;
            this.TIENGIO.Width = 70;
            // 
            // GIAMGIAGIO
            // 
            this.GIAMGIAGIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIAMGIAGIO.HeaderText = "Giảm giá giờ";
            this.GIAMGIAGIO.Name = "GIAMGIAGIO";
            this.GIAMGIAGIO.ReadOnly = true;
            this.GIAMGIAGIO.Width = 90;
            // 
            // TIENTHUCPHAM
            // 
            this.TIENTHUCPHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TIENTHUCPHAM.HeaderText = "Tiền thực phẩm";
            this.TIENTHUCPHAM.Name = "TIENTHUCPHAM";
            this.TIENTHUCPHAM.ReadOnly = true;
            this.TIENTHUCPHAM.Width = 97;
            // 
            // GIAMGIATHUCPHAM
            // 
            this.GIAMGIATHUCPHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIAMGIATHUCPHAM.HeaderText = "Giảm giá thực phẩm";
            this.GIAMGIATHUCPHAM.Name = "GIAMGIATHUCPHAM";
            this.GIAMGIATHUCPHAM.ReadOnly = true;
            this.GIAMGIATHUCPHAM.Width = 92;
            // 
            // tongtien
            // 
            this.tongtien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            this.tongtien.Width = 71;
            // 
            // DATHANHTOAN
            // 
            this.DATHANHTOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATHANHTOAN.HeaderText = "Đã thanh toán";
            this.DATHANHTOAN.Name = "DATHANHTOAN";
            this.DATHANHTOAN.ReadOnly = true;
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtIDHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbLocHoaDon);
            this.Name = "FrmThanhToan";
            this.Text = "FrmThanhToan";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtIDHoaDon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbLocHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit txtIDHoaDon;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIAGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENTHUCPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIATHUCPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DATHANHTOAN;
    }
}