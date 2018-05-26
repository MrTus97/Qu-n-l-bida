namespace QuanLyBilliard.GUI
{
    partial class FrmDanhMucBanKhuVuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucBanKhuVuc));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabLoaiBan = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbTenLoai = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThemLoaiBan = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiBan = new System.Windows.Forms.Button();
            this.btnXoaLoaiBan = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvLoaiBan = new System.Windows.Forms.DataGridView();
            this.idloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabBan = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLoaiBan = new System.Windows.Forms.ComboBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBan = new System.Windows.Forms.DataGridView();
            this.LoaiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Ban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_LOAIBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabLoaiBan.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiBan)).BeginInit();
            this.TabBan.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1350, 425);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.splitter1);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1326, 401);
            this.panelControl1.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 397);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabPane1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1322, 397);
            this.panel1.TabIndex = 0;
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabLoaiBan);
            this.tabPane1.Controls.Add(this.TabBan);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabLoaiBan,
            this.TabBan});
            this.tabPane1.RegularSize = new System.Drawing.Size(1322, 397);
            this.tabPane1.SelectedPage = this.TabBan;
            this.tabPane1.Size = new System.Drawing.Size(1322, 397);
            this.tabPane1.TabIndex = 32;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabLoaiBan
            // 
            this.tabLoaiBan.Caption = "DANH MỤC LOẠI BÀN";
            this.tabLoaiBan.Controls.Add(this.panel5);
            this.tabLoaiBan.Controls.Add(this.panel6);
            this.tabLoaiBan.Controls.Add(this.panel7);
            this.tabLoaiBan.Controls.Add(this.dgvLoaiBan);
            this.tabLoaiBan.Name = "tabLoaiBan";
            this.tabLoaiBan.Size = new System.Drawing.Size(1304, 352);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbGia);
            this.panel5.Controls.Add(this.lbTenLoai);
            this.panel5.Controls.Add(this.txtGia);
            this.panel5.Controls.Add(this.txtTenLoai);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(827, 241);
            this.panel5.TabIndex = 37;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(89, 84);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(22, 13);
            this.lbGia.TabIndex = 12;
            this.lbGia.Text = "Giá";
            // 
            // lbTenLoai
            // 
            this.lbTenLoai.AutoSize = true;
            this.lbTenLoai.Location = new System.Drawing.Point(89, 57);
            this.lbTenLoai.Name = "lbTenLoai";
            this.lbTenLoai.Size = new System.Drawing.Size(44, 13);
            this.lbTenLoai.TabIndex = 12;
            this.lbTenLoai.Text = "Tên loại";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(264, 81);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(233, 21);
            this.txtGia.TabIndex = 14;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGia_KeyPress);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(264, 54);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(233, 21);
            this.txtTenLoai.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThemLoaiBan);
            this.panel6.Controls.Add(this.btnCapNhatLoaiBan);
            this.panel6.Controls.Add(this.btnXoaLoaiBan);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 289);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(827, 63);
            this.panel6.TabIndex = 36;
            // 
            // btnThemLoaiBan
            // 
            this.btnThemLoaiBan.AllowDrop = true;
            this.btnThemLoaiBan.BackColor = System.Drawing.Color.Silver;
            this.btnThemLoaiBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiBan.Image = global::QuanLyBilliard.Properties.Resources.pencil_add_icon;
            this.btnThemLoaiBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemLoaiBan.Location = new System.Drawing.Point(92, 14);
            this.btnThemLoaiBan.Name = "btnThemLoaiBan";
            this.btnThemLoaiBan.Size = new System.Drawing.Size(70, 31);
            this.btnThemLoaiBan.TabIndex = 19;
            this.btnThemLoaiBan.Text = "Thêm";
            this.btnThemLoaiBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemLoaiBan.UseVisualStyleBackColor = false;
            this.btnThemLoaiBan.Click += new System.EventHandler(this.btnThemLoaiBan_Click);
            // 
            // btnCapNhatLoaiBan
            // 
            this.btnCapNhatLoaiBan.BackColor = System.Drawing.Color.Silver;
            this.btnCapNhatLoaiBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatLoaiBan.Image = global::QuanLyBilliard.Properties.Resources.edit_file_icon;
            this.btnCapNhatLoaiBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhatLoaiBan.Location = new System.Drawing.Point(251, 14);
            this.btnCapNhatLoaiBan.Name = "btnCapNhatLoaiBan";
            this.btnCapNhatLoaiBan.Size = new System.Drawing.Size(94, 31);
            this.btnCapNhatLoaiBan.TabIndex = 20;
            this.btnCapNhatLoaiBan.Text = "Cập Nhật";
            this.btnCapNhatLoaiBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhatLoaiBan.UseVisualStyleBackColor = false;
            this.btnCapNhatLoaiBan.Click += new System.EventHandler(this.btnCapNhatLoaiBan_Click);
            // 
            // btnXoaLoaiBan
            // 
            this.btnXoaLoaiBan.BackColor = System.Drawing.Color.Silver;
            this.btnXoaLoaiBan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiBan.Image = global::QuanLyBilliard.Properties.Resources.delete_file_icon;
            this.btnXoaLoaiBan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaLoaiBan.Location = new System.Drawing.Point(469, 14);
            this.btnXoaLoaiBan.Name = "btnXoaLoaiBan";
            this.btnXoaLoaiBan.Size = new System.Drawing.Size(66, 31);
            this.btnXoaLoaiBan.TabIndex = 21;
            this.btnXoaLoaiBan.Text = "Xóa";
            this.btnXoaLoaiBan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaLoaiBan.UseVisualStyleBackColor = false;
            this.btnXoaLoaiBan.Click += new System.EventHandler(this.btnXoaLoaiBan_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(827, 48);
            this.panel7.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15F);
            this.label6.Location = new System.Drawing.Point(272, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "DANH MỤC LOẠI BÀN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvLoaiBan
            // 
            this.dgvLoaiBan.AllowUserToAddRows = false;
            this.dgvLoaiBan.AllowUserToDeleteRows = false;
            this.dgvLoaiBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idloai,
            this.TenLoai,
            this.Gia});
            this.dgvLoaiBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvLoaiBan.Location = new System.Drawing.Point(827, 0);
            this.dgvLoaiBan.Name = "dgvLoaiBan";
            this.dgvLoaiBan.ReadOnly = true;
            this.dgvLoaiBan.RowHeadersVisible = false;
            this.dgvLoaiBan.Size = new System.Drawing.Size(477, 352);
            this.dgvLoaiBan.TabIndex = 34;
            this.dgvLoaiBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiBan_CellClick);
            // 
            // idloai
            // 
            this.idloai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idloai.HeaderText = "ID loại";
            this.idloai.Name = "idloai";
            this.idloai.ReadOnly = true;
            this.idloai.Width = 62;
            // 
            // TenLoai
            // 
            this.TenLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenLoai.HeaderText = "Tên loại";
            this.TenLoai.Name = "TenLoai";
            this.TenLoai.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // TabBan
            // 
            this.TabBan.Caption = "DANH MỤC BÀN";
            this.TabBan.Controls.Add(this.panel4);
            this.TabBan.Controls.Add(this.panel2);
            this.TabBan.Controls.Add(this.panel3);
            this.TabBan.Controls.Add(this.dgvBan);
            this.TabBan.Controls.Add(this.textBox1);
            this.TabBan.Font = new System.Drawing.Font("Arial", 10F);
            this.TabBan.Name = "TabBan";
            this.TabBan.Size = new System.Drawing.Size(1304, 352);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbxLoaiBan);
            this.panel4.Controls.Add(this.txtTenBan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(827, 241);
            this.panel4.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Loại Bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Bàn";
            // 
            // cbxLoaiBan
            // 
            this.cbxLoaiBan.FormattingEnabled = true;
            this.cbxLoaiBan.Location = new System.Drawing.Point(234, 46);
            this.cbxLoaiBan.Name = "cbxLoaiBan";
            this.cbxLoaiBan.Size = new System.Drawing.Size(233, 24);
            this.cbxLoaiBan.TabIndex = 13;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(234, 86);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(233, 23);
            this.txtTenBan.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.btnCapNhat);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 63);
            this.panel2.TabIndex = 32;
            // 
            // btnThem
            // 
            this.btnThem.AllowDrop = true;
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyBilliard.Properties.Resources.pencil_add_icon;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(92, 14);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(70, 31);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Silver;
            this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Image = global::QuanLyBilliard.Properties.Resources.edit_file_icon;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(251, 14);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(94, 31);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Silver;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyBilliard.Properties.Resources.delete_file_icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(469, 14);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 31);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(827, 48);
            this.panel3.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F);
            this.label1.Location = new System.Drawing.Point(272, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC BÀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvBan
            // 
            this.dgvBan.AllowUserToAddRows = false;
            this.dgvBan.AllowUserToDeleteRows = false;
            this.dgvBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiBan,
            this.TenBan,
            this.ID_Ban,
            this.ID_LOAIBAN});
            this.dgvBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvBan.Location = new System.Drawing.Point(827, 0);
            this.dgvBan.Name = "dgvBan";
            this.dgvBan.ReadOnly = true;
            this.dgvBan.RowHeadersVisible = false;
            this.dgvBan.Size = new System.Drawing.Size(477, 352);
            this.dgvBan.TabIndex = 27;
            this.dgvBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBan_CellClick);
            // 
            // LoaiBan
            // 
            this.LoaiBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoaiBan.HeaderText = "Loại Bàn";
            this.LoaiBan.Name = "LoaiBan";
            this.LoaiBan.ReadOnly = true;
            this.LoaiBan.Width = 89;
            // 
            // TenBan
            // 
            this.TenBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenBan.HeaderText = "Tên Bàn";
            this.TenBan.Name = "TenBan";
            this.TenBan.ReadOnly = true;
            // 
            // ID_Ban
            // 
            this.ID_Ban.HeaderText = "Column1";
            this.ID_Ban.Name = "ID_Ban";
            this.ID_Ban.ReadOnly = true;
            this.ID_Ban.Visible = false;
            // 
            // ID_LOAIBAN
            // 
            this.ID_LOAIBAN.HeaderText = "ID_LOAIBAN";
            this.ID_LOAIBAN.Name = "ID_LOAIBAN";
            this.ID_LOAIBAN.ReadOnly = true;
            this.ID_LOAIBAN.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 28;
            this.textBox1.Visible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1350, 425);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1330, 405);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmDanhMucBanKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 425);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDanhMucBanKhuVuc";
            this.Text = "DANH MỤC BÀN, KHU VỰC";
            this.Load += new System.EventHandler(this.FrmDanhMucBanKhuVuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabLoaiBan.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiBan)).EndInit();
            this.TabBan.ResumeLayout(false);
            this.TabBan.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabLoaiBan;
        private DevExpress.XtraBars.Navigation.TabNavigationPage TabBan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbxLoaiBan;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ban;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LOAIBAN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbTenLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnThemLoaiBan;
        private System.Windows.Forms.Button btnCapNhatLoaiBan;
        private System.Windows.Forms.Button btnXoaLoaiBan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvLoaiBan;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn idloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
    }
}