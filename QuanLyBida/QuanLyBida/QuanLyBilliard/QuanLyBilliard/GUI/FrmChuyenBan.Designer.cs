namespace QuanLyBilliard.GUI
{
    partial class FrmChuyenBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChuyen = new DevExpress.XtraEditors.SimpleButton();
            this.cbBanChuyen = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cbBanHienTai = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.flpBanTat = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(689, 447);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChuyen);
            this.panel1.Controls.Add(this.cbBanChuyen);
            this.panel1.Controls.Add(this.labelControl2);
            this.panel1.Controls.Add(this.cbBanHienTai);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Controls.Add(this.flpBanTat);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 423);
            this.panel1.TabIndex = 4;
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(535, 377);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnChuyen.TabIndex = 7;
            this.btnChuyen.Text = "Chuyển";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // cbBanChuyen
            // 
            this.cbBanChuyen.FormattingEnabled = true;
            this.cbBanChuyen.Location = new System.Drawing.Point(344, 379);
            this.cbBanChuyen.Name = "cbBanChuyen";
            this.cbBanChuyen.Size = new System.Drawing.Size(121, 21);
            this.cbBanChuyen.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(254, 382);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Chuyển sang bàn";
            // 
            // cbBanHienTai
            // 
            this.cbBanHienTai.FormattingEnabled = true;
            this.cbBanHienTai.Location = new System.Drawing.Point(100, 379);
            this.cbBanHienTai.Name = "cbBanHienTai";
            this.cbBanHienTai.Size = new System.Drawing.Size(121, 21);
            this.cbBanHienTai.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 382);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Bàn hiện tại";
            // 
            // flpBanTat
            // 
            this.flpBanTat.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpBanTat.Location = new System.Drawing.Point(0, 0);
            this.flpBanTat.Name = "flpBanTat";
            this.flpBanTat.Size = new System.Drawing.Size(665, 361);
            this.flpBanTat.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(689, 447);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(669, 427);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // FrmChuyenBan
            // 
            this.AcceptButton = this.btnChuyen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 447);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmChuyenBan";
            this.Text = "FrmChuyenBan";
            this.Load += new System.EventHandler(this.FrmChuyenBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        public System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.SimpleButton btnChuyen;
        public System.Windows.Forms.ComboBox cbBanChuyen;
        public DevExpress.XtraEditors.LabelControl labelControl2;
        public System.Windows.Forms.ComboBox cbBanHienTai;
        public DevExpress.XtraEditors.LabelControl labelControl1;
        public System.Windows.Forms.FlowLayoutPanel flpBanTat;
        public DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}