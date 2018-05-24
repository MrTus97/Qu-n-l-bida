using QuanLyBilliard.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI.DANH_MUC
{
    public partial class FrmTuyChonNhaCungCap : Form
    {
        private DataGridViewRow dataGridViewRow;
        BL_NhaCungCap blNhaCungCap;
        public FrmTuyChonNhaCungCap()
        {
            InitializeComponent();
            blNhaCungCap = new BL_NhaCungCap(this);
        }

        public FrmTuyChonNhaCungCap(DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this.dataGridViewRow = dataGridViewRow;
            blNhaCungCap = new BL_NhaCungCap(this);
        }

        private void FrmTuyChonNhaCungCap_Load(object sender, EventArgs e)
        {
            if (dataGridViewRow != null)
            {
                label1.Visible = true;
                txtIDNhaCungCap.Visible = true;
                txtIDNhaCungCap.Enabled = false;
                txtIDNhaCungCap.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtTenNhaCungCap.Text = dataGridViewRow.Cells[1].Value.ToString();
                this.Text = "Cập nhật nhà cung cấp";
            }else
            {
                label1.Visible = false;
                txtIDNhaCungCap.Visible = false;
                this.Text = "Thêm mới nhà cung cấp";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            int kq = 0;
            if (txtTenNhaCungCap.Text == "")
            {
                kq = BATLOI.THIEU_DU_LIEU;
            }
            else if (blNhaCungCap.KiemTraTrungNhaCungCap(txtTenNhaCungCap.Text))
            {
                kq = BATLOI.TRUNG_DU_LIEU;
            }
            else if (dataGridViewRow != null)
            {
                kq = blNhaCungCap.CapNhatNhaCungCap(txtIDNhaCungCap.Text,txtTenNhaCungCap.Text);
            }
            else
            {
                kq = blNhaCungCap.ThemNhaCungCap(txtTenNhaCungCap.Text);
                
            }
            if (kq < 0)
            {
                BATLOI.HienThiLoi(kq);
            }else
            {
                this.Close();
            }
        }
    }
}
