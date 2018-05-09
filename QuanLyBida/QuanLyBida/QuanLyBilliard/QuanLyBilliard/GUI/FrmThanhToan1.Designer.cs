using System.Windows.Forms;

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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.lbDenNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lbTuNgay = new System.Windows.Forms.Label();
            this.cbLocHoaDon = new System.Windows.Forms.ComboBox();
            this.txtIDHoaDon = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_HOADON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_BAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_NHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_KHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiengio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgiagio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienthucpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamgiathucpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaThanhToan = new System.Windows.Forms.DataGridViewCheckBoxColumn();

            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1028, 486);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.cbLocHoaDon);
            this.panelControl1.Controls.Add(this.txtIDHoaDon);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.dataGridView1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1004, 462);
            this.panelControl1.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "qq";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(491, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Tất cả";
            // 
            // textBox1
            // 
            //this.textBox1.Location = new System.Drawing.Point(843, 7);
            //this.textBox1.Name = "textBox1";
            //this.textBox1.Size = new System.Drawing.Size(68, 21);
            //this.textBox1.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(774, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Số Hóa đơn";
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpDenNgay);
            this.panel1.Controls.Add(this.lbDenNgay);
            this.panel1.Controls.Add(this.dtpTuNgay);
            this.panel1.Controls.Add(this.lbTuNgay);
            this.panel1.Location = new System.Drawing.Point(6, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 25);
            this.panel1.TabIndex = 7;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.Location = new System.Drawing.Point(397, 3);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(156, 21);
            this.dtpDenNgay.TabIndex = 15;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // lbDenNgay
            // 
            this.lbDenNgay.AutoSize = true;
            this.lbDenNgay.Location = new System.Drawing.Point(327, 9);
            this.lbDenNgay.Name = "lbDenNgay";
            this.lbDenNgay.Size = new System.Drawing.Size(54, 13);
            this.lbDenNgay.TabIndex = 14;
            this.lbDenNgay.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Location = new System.Drawing.Point(137, 3);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(156, 21);
            this.dtpTuNgay.TabIndex = 13;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // lbTuNgay
            // 
            this.lbTuNgay.AutoSize = true;
            this.lbTuNgay.Location = new System.Drawing.Point(67, 9);
            this.lbTuNgay.Name = "lbTuNgay";
            this.lbTuNgay.Size = new System.Drawing.Size(47, 13);
            this.lbTuNgay.TabIndex = 12;
            this.lbTuNgay.Text = "Từ ngày";
            // 
            // cbLocHoaDon
            // 
            this.cbLocHoaDon.FormattingEnabled = true;
            this.cbLocHoaDon.Items.AddRange(new object[] {
            "Hôm nay",
            "Khoảng thời gian",
            "Tất cả"});
            this.cbLocHoaDon.Location = new System.Drawing.Point(75, 7);
            this.cbLocHoaDon.Name = "cbLocHoaDon";
            this.cbLocHoaDon.Size = new System.Drawing.Size(156, 21);
            this.cbLocHoaDon.TabIndex = 6;
            this.cbLocHoaDon.Text = "Hôm nay";
            this.cbLocHoaDon.SelectedIndexChanged += new System.EventHandler(this.cbLocHoaDon_SelectedIndexChanged);
            this.cbLocHoaDon.TextChanged += new System.EventHandler(this.cbLocHoaDon_TextChanged);
            // 
            // txtIDHoaDon
            // 
            this.txtIDHoaDon.Location = new System.Drawing.Point(843, 7);
            this.txtIDHoaDon.Name = "txtIDHoaDon";
            this.txtIDHoaDon.Size = new System.Drawing.Size(68, 21);
            this.txtIDHoaDon.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(774, 10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Tìm theo số hóa đơn";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(924, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Tìm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);

            // 
            // simpleButton2
            // 

            //this.simpleButton2.Location = new System.Drawing.Point(653, 5);
            //this.simpleButton2.Name = "simpleButton2";
            //this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            //this.simpleButton2.TabIndex = 3;
            //this.simpleButton2.Text = "Lọc hóa đơn";

            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HOADON,
            this.ID_BAN,
            this.ID_NHANVIEN,
            this.ID_KHACHHANG,
            this.tiengio,
            this.giamgiagio,
            this.tienthucpham,
            this.giamgiathucpham,
            this.tongtien,
            this.DaThanhToan});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(2, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 395);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_HOADON
            // 
            this.ID_HOADON.HeaderText = "Số hóa đơn";
            this.ID_HOADON.Name = "ID_HOADON";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(2, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 395);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(422, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lọc theo";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1028, 486);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            // ID_BAN
            // 
            this.ID_BAN.HeaderText = "Bàn";
            this.ID_BAN.Name = "ID_BAN";
            // 
            // ID_NHANVIEN
            // 
            this.ID_NHANVIEN.HeaderText = "Nhân viên";
            this.ID_NHANVIEN.Name = "ID_NHANVIEN";
            // 
            // ID_KHACHHANG
            // 
            this.ID_KHACHHANG.HeaderText = "Khách";
            this.ID_KHACHHANG.Name = "ID_KHACHHANG";
            // 
            // tiengio
            // 
            this.tiengio.HeaderText = "Tiền giờ";
            this.tiengio.Name = "tiengio";
            // 
            // giamgiagio
            // 
            this.giamgiagio.HeaderText = "Giảm giá giờ";
            this.giamgiagio.Name = "giamgiagio";
            // 
            // tienthucpham
            // 
            this.tienthucpham.HeaderText = "Tiền thực phẩm";
            this.tienthucpham.Name = "tienthucpham";
            // 
            // giamgiathucpham
            // 
            this.giamgiathucpham.HeaderText = "Giảm giá thực phẩm";
            this.giamgiathucpham.Name = "giamgiathucpham";
            // 
            // tongtien
            // 
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // DaThanhToan
            // 
            this.DaThanhToan.HeaderText = "Đã thanh toán";
            this.DaThanhToan.Name = "DaThanhToan";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lọc theo";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1028, 486);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1008, 466);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 486);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmThanhToan";
            this.Text = "FrmThanhToan";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbLocHoaDon;
        private System.Windows.Forms.TextBox txtIDHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOADON;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_BAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NHANVIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_KHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiengio;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgiagio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienthucpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamgiathucpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaThanhToan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label lbDenNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lbTuNgay;
        private ComboBox comboBox1;
        private object textBox1;
        private object simpleButton2;
    }
}