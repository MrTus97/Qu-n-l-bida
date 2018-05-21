namespace QuanLyBilliard.GUI
{
    partial class FrmKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhuyenMai));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnChinhSua = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            this.ID_GIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGIAMGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIAGIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAMGIATHUCPHAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem4,
            this.btnChinhSua,
            this.barButtonItem6});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnChinhSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem6, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.barButtonItem4.Caption = "THÊM MỚI";
            this.barButtonItem4.Glyph = global::QuanLyBilliard.Properties.Resources.Button_Add_icon;
            this.barButtonItem4.Id = 0;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Caption = "CHỈNH SỬA";
            this.btnChinhSua.Glyph = global::QuanLyBilliard.Properties.Resources.edit_file_icon;
            this.btnChinhSua.Id = 1;
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "XÓA";
            this.barButtonItem6.Glyph = global::QuanLyBilliard.Properties.Resources.delete_file_icon;
            this.barButtonItem6.Id = 2;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(833, 32);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 385);
            this.barDockControlBottom.Size = new System.Drawing.Size(833, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 32);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 353);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(833, 32);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 353);
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.AllowUserToAddRows = false;
            this.dgvKhuyenMai.AllowUserToDeleteRows = false;
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_GIAMGIA,
            this.TENGIAMGIA,
            this.GIAMGIAGIO,
            this.GIAMGIATHUCPHAM,
            this.NGAYBATDAU,
            this.NGAYKETTHUC});
            this.dgvKhuyenMai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(0, 32);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.ReadOnly = true;
            this.dgvKhuyenMai.RowHeadersVisible = false;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(833, 353);
            this.dgvKhuyenMai.TabIndex = 10;
            this.dgvKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellClick);
            this.dgvKhuyenMai.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhuyenMai_CellDoubleClick);
            // 
            // ID_GIAMGIA
            // 
            this.ID_GIAMGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_GIAMGIA.HeaderText = "ID GIẢM GIÁ";
            this.ID_GIAMGIA.Name = "ID_GIAMGIA";
            this.ID_GIAMGIA.ReadOnly = true;
            this.ID_GIAMGIA.Width = 87;
            // 
            // TENGIAMGIA
            // 
            this.TENGIAMGIA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENGIAMGIA.HeaderText = "TÊN GIẢM GIÁ";
            this.TENGIAMGIA.Name = "TENGIAMGIA";
            this.TENGIAMGIA.ReadOnly = true;
            // 
            // GIAMGIAGIO
            // 
            this.GIAMGIAGIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIAMGIAGIO.HeaderText = "GIẢM GIÁ GIỜ";
            this.GIAMGIAGIO.Name = "GIAMGIAGIO";
            this.GIAMGIAGIO.ReadOnly = true;
            this.GIAMGIAGIO.Width = 77;
            // 
            // GIAMGIATHUCPHAM
            // 
            this.GIAMGIATHUCPHAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIAMGIATHUCPHAM.HeaderText = "GIẢM GIÁ THỰC PHẨM";
            this.GIAMGIATHUCPHAM.Name = "GIAMGIATHUCPHAM";
            this.GIAMGIATHUCPHAM.ReadOnly = true;
            this.GIAMGIATHUCPHAM.Width = 106;
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NGAYBATDAU.HeaderText = "NGÀY BẮT ĐẦU";
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.ReadOnly = true;
            this.NGAYBATDAU.Width = 82;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NGAYKETTHUC.HeaderText = "NGÀY KẾT THÚC";
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.ReadOnly = true;
            this.NGAYKETTHUC.Width = 109;
            // 
            // FrmKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 385);
            this.Controls.Add(this.dgvKhuyenMai);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKhuyenMai";
            this.Text = "Khuyến mãi";
            this.Load += new System.EventHandler(this.FrmKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btnChinhSua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_GIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGIAMGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIAGIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAMGIATHUCPHAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKETTHUC;
    }
}