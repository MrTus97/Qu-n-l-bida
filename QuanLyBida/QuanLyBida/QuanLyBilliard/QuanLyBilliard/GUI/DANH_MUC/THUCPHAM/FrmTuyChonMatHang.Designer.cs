namespace QuanLyBilliard.GUI.DANH_MUC.THUCPHAM
{
    partial class FrmTuyChonMatHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIDMatHang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxNhaCungCap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.cbxLoaiThucPham = new System.Windows.Forms.ComboBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtIDMatHang = new System.Windows.Forms.TextBox();
            this.txtTenThucPham = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbIDMatHang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbxNhaCungCap);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtDonGia);
            this.panel2.Controls.Add(this.cbxLoaiThucPham);
            this.panel2.Controls.Add(this.txtDonViTinh);
            this.panel2.Controls.Add(this.txtIDMatHang);
            this.panel2.Controls.Add(this.txtTenThucPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 456);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnGhiDuLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 53);
            this.panel1.TabIndex = 40;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(408, 18);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            // 
            // btnGhiDuLieu
            // 
            this.btnGhiDuLieu.Location = new System.Drawing.Point(310, 18);
            this.btnGhiDuLieu.Name = "btnGhiDuLieu";
            this.btnGhiDuLieu.Size = new System.Drawing.Size(75, 23);
            this.btnGhiDuLieu.TabIndex = 0;
            this.btnGhiDuLieu.Text = "Ghi Dữ Liệu";
            this.btnGhiDuLieu.Click += new System.EventHandler(this.btnGhiDuLieu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Loại Thực Phẩm";
            // 
            // lbIDMatHang
            // 
            this.lbIDMatHang.AutoSize = true;
            this.lbIDMatHang.Location = new System.Drawing.Point(99, 58);
            this.lbIDMatHang.Name = "lbIDMatHang";
            this.lbIDMatHang.Size = new System.Drawing.Size(75, 13);
            this.lbIDMatHang.TabIndex = 31;
            this.lbIDMatHang.Text = "ID Thực phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên Thực Phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Đơn Giá";
            // 
            // cbxNhaCungCap
            // 
            this.cbxNhaCungCap.FormattingEnabled = true;
            this.cbxNhaCungCap.Location = new System.Drawing.Point(189, 266);
            this.cbxNhaCungCap.Name = "cbxNhaCungCap";
            this.cbxNhaCungCap.Size = new System.Drawing.Size(293, 21);
            this.cbxNhaCungCap.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Nhà Cung Cấp";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(189, 225);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(293, 20);
            this.txtDonGia.TabIndex = 38;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // cbxLoaiThucPham
            // 
            this.cbxLoaiThucPham.FormattingEnabled = true;
            this.cbxLoaiThucPham.Location = new System.Drawing.Point(190, 102);
            this.cbxLoaiThucPham.Name = "cbxLoaiThucPham";
            this.cbxLoaiThucPham.Size = new System.Drawing.Size(293, 21);
            this.cbxLoaiThucPham.TabIndex = 35;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(189, 182);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(293, 20);
            this.txtDonViTinh.TabIndex = 37;
            this.txtDonViTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonViTinh_KeyPress);
            // 
            // txtIDMatHang
            // 
            this.txtIDMatHang.Location = new System.Drawing.Point(190, 55);
            this.txtIDMatHang.Name = "txtIDMatHang";
            this.txtIDMatHang.Size = new System.Drawing.Size(293, 20);
            this.txtIDMatHang.TabIndex = 36;
            // 
            // txtTenThucPham
            // 
            this.txtTenThucPham.Location = new System.Drawing.Point(189, 143);
            this.txtTenThucPham.Name = "txtTenThucPham";
            this.txtTenThucPham.Size = new System.Drawing.Size(293, 20);
            this.txtTenThucPham.TabIndex = 36;
            // 
            // FrmTuyChonMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 456);
            this.Controls.Add(this.panel2);
            this.Name = "FrmTuyChonMatHang";
            this.Text = "FrmTuyChonMatHang";
            this.Load += new System.EventHandler(this.FrmTuyChonMatHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox cbxNhaCungCap;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtDonGia;
        public System.Windows.Forms.ComboBox cbxLoaiThucPham;
        public System.Windows.Forms.TextBox txtDonViTinh;
        public System.Windows.Forms.TextBox txtTenThucPham;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnGhiDuLieu;
        public System.Windows.Forms.Label lbIDMatHang;
        public System.Windows.Forms.TextBox txtIDMatHang;
    }
}