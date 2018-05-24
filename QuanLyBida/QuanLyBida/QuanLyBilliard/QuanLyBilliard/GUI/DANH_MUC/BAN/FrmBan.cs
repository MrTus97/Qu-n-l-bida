using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBilliard.BL;

namespace QuanLyBilliard.GUI
{
    public partial class FrmDanhMucBanKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        BL_Ban blBan;
        public FrmDanhMucBanKhuVuc()
        {
            InitializeComponent();
            blBan = new BL_Ban(this);
        }

        private void cbxLoaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenBan.Text == "")
            {
                errorProvider1.SetError(txtTenBan, "Bạn chưa nhập Tên Bàn");
            }
            else
            {
                int loaiBan = (int)cbxLoaiBan.SelectedValue;
                blBan.themBan(loaiBan, txtTenBan.Text);
                RefreshBan();
            }
        }

        private void cbxLoaiBan_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxLoaiBan, "");
        }

        private void txtTenBan_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenBan, "");
        }

  
        private void FrmDanhMucBanKhuVuc_Load(object sender, EventArgs e)
        {
            //Panel bàn
            blBan.LoadLoaiBan();
            RefreshBan();
            //panel loại bàn
            loadLoaiBan();
            

        }

        private void loadLoaiBan()
        {
            DataTable dt = blBan.LayDanhSachLoaiBan();
            dgvLoaiBan.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvLoaiBan.Rows.Add(row.ItemArray);
            }
        }

        private void RefreshBan()
        {
            DataTable dt = blBan.layDuLieuLenDataGridView();
            dgvBan.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                dgvBan.Rows.Add(row.ItemArray);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string loaiBan = cbxLoaiBan.SelectedValue.ToString();
            blBan.capNhatBan(textBox1.Text,loaiBan, txtTenBan.Text);
            RefreshBan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvBan.CurrentRow.Cells["ID_BAN"].Value.ToString();
            txtTenBan.Text = dgvBan.CurrentRow.Cells["TENBAN"].Value.ToString();
            cbxLoaiBan.SelectedValue = dgvBan.CurrentRow.Cells["ID_LOAIBAN"].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int kq = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn phải chọn trường cần xóa");
            }
            else
            {
                kq = blBan.xoaBan(textBox1.Text);
            }
            RefreshBan();
            if (kq < 0)
            {
                BATLOI.HienThiLoi(kq);
            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnThemLoaiBan_Click(object sender, EventArgs e)
        {
            blBan.ThemLoaiBan(txtTenLoai.Text,txtGia.Text);
            RefeshLoaiBan();
        }

        private void btnCapNhatLoaiBan_Click(object sender, EventArgs e)
        {
            blBan.CapNhatLoaiBan(txtTenLoai.Text,txtGia.Text, Convert.ToInt32( lbTenLoai.Tag));
            RefeshLoaiBan();
        }

        private void RefeshLoaiBan()
        {
            loadLoaiBan();
        }

        private void btnXoaLoaiBan_Click(object sender, EventArgs e)
        {
            int kq = 0;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nó không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int idban = Convert.ToInt32(lbTenLoai.Tag);
                kq = blBan.XoaLoaiBan(idban);
                RefeshLoaiBan();
            }
            if (kq < 0)
            {
                BATLOI.HienThiLoi(kq);
            }
        }

        private void dgvLoaiBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTenLoai.Tag = dgvLoaiBan.CurrentRow.Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoaiBan.CurrentRow.Cells[1].Value.ToString();
            txtGia.Text = dgvLoaiBan.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dgvBan.CurrentRow.Cells["ID_BAN"].Value.ToString();
            cbxLoaiBan.SelectedValue = dgvBan.CurrentRow.Cells["ID_LOAIBAN"].Value.ToString();
            txtTenBan.Text = dgvBan.CurrentRow.Cells["TENBAN"].Value.ToString();
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                BATLOI.HienThiLoi(BATLOI.SAI_DINH_DANG);
            }
        }
    }
}