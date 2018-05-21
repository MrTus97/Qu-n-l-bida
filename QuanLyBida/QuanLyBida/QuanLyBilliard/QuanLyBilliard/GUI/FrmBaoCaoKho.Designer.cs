namespace QuanLyBilliard.GUI
{
    partial class FrmBaoCaoKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCaoKho));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.dgvBaoCao_IDThucPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBaoCao_TenThucPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBaoCao_DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBaoCao_IDLoaiThucPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBaoCao_GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBaoCao_IDNhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBaoCao_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.treeView1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(200, 481);
            this.panelControl1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(196, 477);
            this.treeView1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 481);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dgvBaoCao);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(203, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(666, 481);
            this.panelControl2.TabIndex = 2;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBaoCao_IDThucPham,
            this.dgvBaoCao_TenThucPham,
            this.dgvBaoCao_DVT,
            this.dgvBaoCao_IDLoaiThucPham,
            this.dgvBaoCao_GiaBan,
            this.dgvBaoCao_IDNhaCungCap,
            this.dgvBaoCao_SoLuong});
            this.dgvBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCao.Location = new System.Drawing.Point(2, 2);
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.Size = new System.Drawing.Size(662, 477);
            this.dgvBaoCao.TabIndex = 0;
            // 
            // dgvBaoCao_IDThucPham
            // 
            this.dgvBaoCao_IDThucPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvBaoCao_IDThucPham.HeaderText = "ID THỰC PHẨM";
            this.dgvBaoCao_IDThucPham.Name = "dgvBaoCao_IDThucPham";
            this.dgvBaoCao_IDThucPham.ReadOnly = true;
            this.dgvBaoCao_IDThucPham.Width = 96;
            // 
            // dgvBaoCao_TenThucPham
            // 
            this.dgvBaoCao_TenThucPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBaoCao_TenThucPham.HeaderText = "TÊN THỰC PHẨM";
            this.dgvBaoCao_TenThucPham.Name = "dgvBaoCao_TenThucPham";
            this.dgvBaoCao_TenThucPham.ReadOnly = true;
            // 
            // dgvBaoCao_DVT
            // 
            this.dgvBaoCao_DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvBaoCao_DVT.HeaderText = "DVT";
            this.dgvBaoCao_DVT.Name = "dgvBaoCao_DVT";
            this.dgvBaoCao_DVT.ReadOnly = true;
            this.dgvBaoCao_DVT.Width = 51;
            // 
            // dgvBaoCao_IDLoaiThucPham
            // 
            this.dgvBaoCao_IDLoaiThucPham.HeaderText = "ID loại thực phẩm";
            this.dgvBaoCao_IDLoaiThucPham.Name = "dgvBaoCao_IDLoaiThucPham";
            this.dgvBaoCao_IDLoaiThucPham.ReadOnly = true;
            this.dgvBaoCao_IDLoaiThucPham.Visible = false;
            // 
            // dgvBaoCao_GiaBan
            // 
            this.dgvBaoCao_GiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvBaoCao_GiaBan.HeaderText = "GIÁ BÁN";
            this.dgvBaoCao_GiaBan.Name = "dgvBaoCao_GiaBan";
            this.dgvBaoCao_GiaBan.ReadOnly = true;
            this.dgvBaoCao_GiaBan.Width = 68;
            // 
            // dgvBaoCao_IDNhaCungCap
            // 
            this.dgvBaoCao_IDNhaCungCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvBaoCao_IDNhaCungCap.HeaderText = "ID Nhà Cung Cấp";
            this.dgvBaoCao_IDNhaCungCap.Name = "dgvBaoCao_IDNhaCungCap";
            this.dgvBaoCao_IDNhaCungCap.ReadOnly = true;
            this.dgvBaoCao_IDNhaCungCap.Visible = false;
            // 
            // dgvBaoCao_SoLuong
            // 
            this.dgvBaoCao_SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvBaoCao_SoLuong.HeaderText = "Số lượng";
            this.dgvBaoCao_SoLuong.Name = "dgvBaoCao_SoLuong";
            this.dgvBaoCao_SoLuong.ReadOnly = true;
            this.dgvBaoCao_SoLuong.Width = 69;
            // 
            // FrmBaoCaoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 481);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBaoCaoKho";
            this.Text = "Báo cáo kho";
            this.Load += new System.EventHandler(this.FrmBaoCaoKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBaoCao_IDThucPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBaoCao_TenThucPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBaoCao_DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBaoCao_IDLoaiThucPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBaoCao_GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBaoCao_IDNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBaoCao_SoLuong;
    }
}