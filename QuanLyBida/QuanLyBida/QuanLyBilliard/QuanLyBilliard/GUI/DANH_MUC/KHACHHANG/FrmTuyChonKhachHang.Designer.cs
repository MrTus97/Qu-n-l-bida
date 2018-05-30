namespace QuanLyBilliard.GUI.DANH_MUC.KHACHHANG
{
    partial class FrmTuyChonKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbnNU = new System.Windows.Forms.RadioButton();
            this.rbnNam = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDKhachHang = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxLoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.txtIDKhachHang = new System.Windows.Forms.TextBox();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnGhiDuLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(303, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            // 
            // btnGhiDuLieu
            // 
            this.btnGhiDuLieu.Location = new System.Drawing.Point(222, 6);
            this.btnGhiDuLieu.Name = "btnGhiDuLieu";
            this.btnGhiDuLieu.Size = new System.Drawing.Size(75, 23);
            this.btnGhiDuLieu.TabIndex = 2;
            this.btnGhiDuLieu.Text = "Ghi Dữ Liệu";
            this.btnGhiDuLieu.Click += new System.EventHandler(this.btnGhiDuLieu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpNgaySinh);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbIDKhachHang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cbxLoaiKhachHang);
            this.panel2.Controls.Add(this.txtIDKhachHang);
            this.panel2.Controls.Add(this.txtSoDienThoai);
            this.panel2.Controls.Add(this.txtTenKhachHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 309);
            this.panel2.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "d";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(105, 203);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(273, 20);
            this.dtpNgaySinh.TabIndex = 30;
            this.dtpNgaySinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpNgaySinh_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbnNU);
            this.panel4.Controls.Add(this.rbnNam);
            this.panel4.Location = new System.Drawing.Point(105, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(272, 24);
            this.panel4.TabIndex = 29;
            // 
            // rbnNU
            // 
            this.rbnNU.AutoSize = true;
            this.rbnNU.Location = new System.Drawing.Point(117, 4);
            this.rbnNU.Name = "rbnNU";
            this.rbnNU.Size = new System.Drawing.Size(39, 17);
            this.rbnNU.TabIndex = 1;
            this.rbnNU.TabStop = true;
            this.rbnNU.Text = "Nữ";
            this.rbnNU.UseVisualStyleBackColor = true;
            // 
            // rbnNam
            // 
            this.rbnNam.AutoSize = true;
            this.rbnNam.Location = new System.Drawing.Point(32, 4);
            this.rbnNam.Name = "rbnNam";
            this.rbnNam.Size = new System.Drawing.Size(47, 17);
            this.rbnNam.TabIndex = 0;
            this.rbnNam.TabStop = true;
            this.rbnNam.Text = "Nam";
            this.rbnNam.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Loại Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên Khách Hàng";
            // 
            // lbIDKhachHang
            // 
            this.lbIDKhachHang.AutoSize = true;
            this.lbIDKhachHang.Location = new System.Drawing.Point(15, 30);
            this.lbIDKhachHang.Name = "lbIDKhachHang";
            this.lbIDKhachHang.Size = new System.Drawing.Size(81, 13);
            this.lbIDKhachHang.TabIndex = 23;
            this.lbIDKhachHang.Text = "ID Khách Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Giới Tính";
            // 
            // cbxLoaiKhachHang
            // 
            this.cbxLoaiKhachHang.FormattingEnabled = true;
            this.cbxLoaiKhachHang.Location = new System.Drawing.Point(106, 69);
            this.cbxLoaiKhachHang.Name = "cbxLoaiKhachHang";
            this.cbxLoaiKhachHang.Size = new System.Drawing.Size(272, 21);
            this.cbxLoaiKhachHang.TabIndex = 26;
            this.cbxLoaiKhachHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxLoaiKhachHang_KeyPress);
            // 
            // txtIDKhachHang
            // 
            this.txtIDKhachHang.Location = new System.Drawing.Point(106, 27);
            this.txtIDKhachHang.Name = "txtIDKhachHang";
            this.txtIDKhachHang.Size = new System.Drawing.Size(272, 20);
            this.txtIDKhachHang.TabIndex = 28;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(106, 161);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(272, 20);
            this.txtSoDienThoai.TabIndex = 28;
            this.txtSoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoDienThoai_KeyPress);
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(106, 113);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(272, 20);
            this.txtTenKhachHang.TabIndex = 27;
            // 
            // FrmTuyChonKhachHang
            // 
            this.AcceptButton = this.btnGhiDuLieu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(396, 344);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTuyChonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTuyChonKhachHang";
            this.Load += new System.EventHandler(this.FrmTuyChonKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.DateTimePicker dtpNgaySinh;
        public System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbnNU;
        private System.Windows.Forms.RadioButton rbnNam;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbxLoaiKhachHang;
        public System.Windows.Forms.TextBox txtSoDienThoai;
        public System.Windows.Forms.TextBox txtTenKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnGhiDuLieu;
        public System.Windows.Forms.Label lbIDKhachHang;
        public System.Windows.Forms.TextBox txtIDKhachHang;
    }
}