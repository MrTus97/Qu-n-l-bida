namespace QuanLyBilliard.GUI.DANH_MUC
{
    partial class FrmDanhMucNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDanhMucNhaCungCap));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.ToolStripTextBox();
            this.lbTimKiem = new System.Windows.Forms.ToolStripLabel();
            this.dgvDanhMucNhaCungCap = new System.Windows.Forms.DataGridView();
            this.ID_NHACUNGCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHACUNGCAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNhaCungCap)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.toolStripSeparator1,
            this.toolStripButton1,
            this.txtTimKiem,
            this.lbTimKiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(711, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 12F);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(67, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 12F);
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(59, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 12F);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 25);
            this.txtTimKiem.Visible = false;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // lbTimKiem
            // 
            this.lbTimKiem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbTimKiem.Name = "lbTimKiem";
            this.lbTimKiem.Size = new System.Drawing.Size(57, 22);
            this.lbTimKiem.Text = "Tìm kiếm";
            this.lbTimKiem.Visible = false;
            // 
            // dgvDanhMucNhaCungCap
            // 
            this.dgvDanhMucNhaCungCap.AllowUserToAddRows = false;
            this.dgvDanhMucNhaCungCap.AllowUserToDeleteRows = false;
            this.dgvDanhMucNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_NHACUNGCAP,
            this.TENNHACUNGCAP});
            this.dgvDanhMucNhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMucNhaCungCap.Location = new System.Drawing.Point(0, 25);
            this.dgvDanhMucNhaCungCap.Name = "dgvDanhMucNhaCungCap";
            this.dgvDanhMucNhaCungCap.ReadOnly = true;
            this.dgvDanhMucNhaCungCap.RowHeadersVisible = false;
            this.dgvDanhMucNhaCungCap.Size = new System.Drawing.Size(711, 292);
            this.dgvDanhMucNhaCungCap.TabIndex = 1;
            this.dgvDanhMucNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucNhaCungCap_CellClick);
            this.dgvDanhMucNhaCungCap.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucNhaCungCap_CellDoubleClick);
            // 
            // ID_NHACUNGCAP
            // 
            this.ID_NHACUNGCAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID_NHACUNGCAP.HeaderText = "ID NHÀ CUNG CẤP";
            this.ID_NHACUNGCAP.Name = "ID_NHACUNGCAP";
            this.ID_NHACUNGCAP.ReadOnly = true;
            this.ID_NHACUNGCAP.Width = 97;
            // 
            // TENNHACUNGCAP
            // 
            this.TENNHACUNGCAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENNHACUNGCAP.HeaderText = "TÊN NHÀ CUNG CẤP";
            this.TENNHACUNGCAP.Name = "TENNHACUNGCAP";
            this.TENNHACUNGCAP.ReadOnly = true;
            // 
            // FrmDanhMucNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 317);
            this.Controls.Add(this.dgvDanhMucNhaCungCap);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDanhMucNhaCungCap";
            this.Text = "NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.FrmDanhMucNhaCungCap_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucNhaCungCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.DataGridView dgvDanhMucNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_NHACUNGCAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHACUNGCAP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lbTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtTimKiem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}