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
                richTextBox1.Text = "Cập nhật nhà cung cấp";
            }else
            {
                label1.Visible = false;
                txtIDNhaCungCap.Visible = false;
                richTextBox1.Text = "Thêm mới nhà cung cấp";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            if (dataGridViewRow != null)
            {
                int i = blNhaCungCap.CapNhatNhaCungCap(txtIDNhaCungCap.Text,txtTenNhaCungCap.Text);
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật thành công!!");
                }else
                {
                    MessageBox.Show("Cập nhật Thất bại!!");
                }
            }
            else
            {
                int i = blNhaCungCap.ThemNhaCungCap(txtTenNhaCungCap.Text);
                if (i > 0)
                {
                    MessageBox.Show("Thêm thành công!!");
                }
                else
                {
                    MessageBox.Show("Thêm Thất bại!!");
                }
            }
        }
    }
}
