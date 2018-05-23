namespace QuanLyBilliard.GUI.DANH_MUC.THUCPHAM
{
    partial class FrmTuyChonLoaiMatHang
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
            this.txtTenLoaiMatHang = new System.Windows.Forms.TextBox();
            this.lbTenLoaiMatHang = new System.Windows.Forms.Label();
            this.txtIDLoaiMatHang = new System.Windows.Forms.TextBox();
            this.lbIDLoaiMatHang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnGhiDuLieu = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenLoaiMatHang);
            this.panel2.Controls.Add(this.lbTenLoaiMatHang);
            this.panel2.Controls.Add(this.txtIDLoaiMatHang);
            this.panel2.Controls.Add(this.lbIDLoaiMatHang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 135);
            this.panel2.TabIndex = 3;
            // 
            // txtTenLoaiMatHang
            // 
            this.txtTenLoaiMatHang.Location = new System.Drawing.Point(139, 36);
            this.txtTenLoaiMatHang.Name = "txtTenLoaiMatHang";
            this.txtTenLoaiMatHang.Size = new System.Drawing.Size(169, 20);
            this.txtTenLoaiMatHang.TabIndex = 1;
            // 
            // lbTenLoaiMatHang
            // 
            this.lbTenLoaiMatHang.AutoSize = true;
            this.lbTenLoaiMatHang.Location = new System.Drawing.Point(13, 39);
            this.lbTenLoaiMatHang.Name = "lbTenLoaiMatHang";
            this.lbTenLoaiMatHang.Size = new System.Drawing.Size(92, 13);
            this.lbTenLoaiMatHang.TabIndex = 0;
            this.lbTenLoaiMatHang.Text = "Tên loại mặt hàng";
            // 
            // txtIDLoaiMatHang
            // 
            this.txtIDLoaiMatHang.Location = new System.Drawing.Point(139, 10);
            this.txtIDLoaiMatHang.Name = "txtIDLoaiMatHang";
            this.txtIDLoaiMatHang.Size = new System.Drawing.Size(169, 20);
            this.txtIDLoaiMatHang.TabIndex = 1;
            // 
            // lbIDLoaiMatHang
            // 
            this.lbIDLoaiMatHang.AutoSize = true;
            this.lbIDLoaiMatHang.Location = new System.Drawing.Point(13, 13);
            this.lbIDLoaiMatHang.Name = "lbIDLoaiMatHang";
            this.lbIDLoaiMatHang.Size = new System.Drawing.Size(91, 13);
            this.lbIDLoaiMatHang.TabIndex = 0;
            this.lbIDLoaiMatHang.Text = "ID Loại Mặt Hàng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnGhiDuLieu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 53);
            this.panel1.TabIndex = 4;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(233, 6);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
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
            // FrmTuyChonLoaiMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 135);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmTuyChonLoaiMatHang";
            this.Text = "FrmTuyChonLoaiMatHang";
            this.Load += new System.EventHandler(this.FrmTuyChonLoaiMatHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenLoaiMatHang;
        private System.Windows.Forms.Label lbTenLoaiMatHang;
        private System.Windows.Forms.TextBox txtIDLoaiMatHang;
        private System.Windows.Forms.Label lbIDLoaiMatHang;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnGhiDuLieu;
    }
}