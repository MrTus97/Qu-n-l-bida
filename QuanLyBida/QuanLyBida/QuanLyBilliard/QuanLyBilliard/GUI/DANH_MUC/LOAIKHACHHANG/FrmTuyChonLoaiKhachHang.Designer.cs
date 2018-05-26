namespace QuanLyBilliard.GUI.DANH_MUC.KHACHHANG
{
    partial class FrmTuyChonLoaiKhachHang
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
            this.txtGiamGiaNuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiamGiaGio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLoaiKhachHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDLoaiKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnGhiDuLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 53);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(233, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGhiDuLieu
            // 
            this.btnGhiDuLieu.Location = new System.Drawing.Point(139, 6);
            this.btnGhiDuLieu.Name = "btnGhiDuLieu";
            this.btnGhiDuLieu.Size = new System.Drawing.Size(75, 23);
            this.btnGhiDuLieu.TabIndex = 0;
            this.btnGhiDuLieu.Text = "Ghi Dữ Liệu";
            this.btnGhiDuLieu.Click += new System.EventHandler(this.btnGhiDuLieu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtGiamGiaNuoc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGiamGiaGio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTenLoaiKhachHang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIDLoaiKhach);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 156);
            this.panel2.TabIndex = 1;
            // 
            // txtGiamGiaNuoc
            // 
            this.txtGiamGiaNuoc.Location = new System.Drawing.Point(139, 88);
            this.txtGiamGiaNuoc.Name = "txtGiamGiaNuoc";
            this.txtGiamGiaNuoc.Size = new System.Drawing.Size(169, 20);
            this.txtGiamGiaNuoc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "giảm giá nước";
            // 
            // txtGiamGiaGio
            // 
            this.txtGiamGiaGio.Location = new System.Drawing.Point(139, 62);
            this.txtGiamGiaGio.Name = "txtGiamGiaGio";
            this.txtGiamGiaGio.Size = new System.Drawing.Size(169, 20);
            this.txtGiamGiaGio.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "giảm giá giờ";
            // 
            // txtTenLoaiKhachHang
            // 
            this.txtTenLoaiKhachHang.Location = new System.Drawing.Point(139, 36);
            this.txtTenLoaiKhachHang.Name = "txtTenLoaiKhachHang";
            this.txtTenLoaiKhachHang.Size = new System.Drawing.Size(169, 20);
            this.txtTenLoaiKhachHang.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại khách hàng";
            // 
            // txtIDLoaiKhach
            // 
            this.txtIDLoaiKhach.Location = new System.Drawing.Point(139, 10);
            this.txtIDLoaiKhach.Name = "txtIDLoaiKhach";
            this.txtIDLoaiKhach.Size = new System.Drawing.Size(169, 20);
            this.txtIDLoaiKhach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID loại khách hàng";
            // 
            // FrmTuyChonLoaiKhachHang
            // 
            this.AcceptButton = this.btnGhiDuLieu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(320, 209);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmTuyChonLoaiKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTuyChonLoaiKhachHang";
            this.Load += new System.EventHandler(this.FrmTuyChonLoaiKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnGhiDuLieu;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private System.Windows.Forms.TextBox txtTenLoaiKhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDLoaiKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiamGiaNuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiamGiaGio;
        private System.Windows.Forms.Label label3;
    }
}