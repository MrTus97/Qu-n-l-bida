namespace QuanLyBilliard.GUI.DANH_MUC.KHACHHANG
{
    partial class FrmLoaiKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.dgvLoaiKhachHang = new System.Windows.Forms.DataGridView();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ID_LOAIKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOAIKHACHHANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIAGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIATHUCPHAm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiKhachHang
            // 
            this.dgvLoaiKhachHang.AllowUserToAddRows = false;
            this.dgvLoaiKhachHang.AllowUserToDeleteRows = false;
            this.dgvLoaiKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_LOAIKHACHHANG,
            this.TENLOAIKHACHHANG,
            this.GIAMGIAGIO,
            this.GIAMGIATHUCPHAm});
            this.dgvLoaiKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLoaiKhachHang.Location = new System.Drawing.Point(0, 39);
            this.dgvLoaiKhachHang.Name = "dgvLoaiKhachHang";
            this.dgvLoaiKhachHang.ReadOnly = true;
            this.dgvLoaiKhachHang.Size = new System.Drawing.Size(939, 442);
            this.dgvLoaiKhachHang.TabIndex = 0;
            this.dgvLoaiKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiKhachHang_CellClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Glyph = global::QuanLyBilliard.Properties.Resources.Button_Add_icon;
            this.btnThem.Id = 0;
            this.btnThem.LargeGlyph = global::QuanLyBilliard.Properties.Resources.Button_Add_icon;
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Glyph = global::QuanLyBilliard.Properties.Resources.edit_file_icon;
            this.btnSua.Id = 1;
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Glyph = global::QuanLyBilliard.Properties.Resources.delete_file_icon;
            this.btnXoa.Id = 2;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(939, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 481);
            this.barDockControlBottom.Size = new System.Drawing.Size(939, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(939, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // ID_LOAIKHACHHANG
            // 
            this.ID_LOAIKHACHHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_LOAIKHACHHANG.HeaderText = "ID LOẠI KHÁCH";
            this.ID_LOAIKHACHHANG.Name = "ID_LOAIKHACHHANG";
            this.ID_LOAIKHACHHANG.ReadOnly = true;
            this.ID_LOAIKHACHHANG.Width = 101;
            // 
            // TENLOAIKHACHHANG
            // 
            this.TENLOAIKHACHHANG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENLOAIKHACHHANG.HeaderText = "TÊN LOẠI KHÁCH HÀNG";
            this.TENLOAIKHACHHANG.Name = "TENLOAIKHACHHANG";
            this.TENLOAIKHACHHANG.ReadOnly = true;
            // 
            // GIAMGIAGIO
            // 
            this.GIAMGIAGIO.HeaderText = "GIẢM GIỜ";
            this.GIAMGIAGIO.Name = "GIAMGIAGIO";
            this.GIAMGIAGIO.ReadOnly = true;
            // 
            // GIAMGIATHUCPHAm
            // 
            this.GIAMGIATHUCPHAm.HeaderText = "GIẢM GIÁ THỰC PHẨM";
            this.GIAMGIATHUCPHAm.Name = "GIAMGIATHUCPHAm";
            this.GIAMGIATHUCPHAm.ReadOnly = true;
            // 
            // FrmLoaiKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 481);
            this.Controls.Add(this.dgvLoaiKhachHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmLoaiKhachHang";
            this.Text = "FrmLoaiKhachHang";
            this.Load += new System.EventHandler(this.FrmLoaiKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiKhachHang;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LOAIKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOAIKHACHHANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIAGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIATHUCPHAm;
    }
}