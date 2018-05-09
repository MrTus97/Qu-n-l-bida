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
                string loaiBan = cbxLoaiBan.SelectedValue.ToString();
                blBan.themBan(loaiBan, txtTenBan.Text);
                loadBan();
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
            blBan.LoadLoaiBan();
            loadBan();
        }

        private void loadBan()
        {
            DataTable dt = blBan.layDuLieuLenDataGridView();
            dataGridView1.Rows.Clear();
            foreach(DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string loaiBan = cbxLoaiBan.SelectedValue.ToString();
            blBan.capNhatBan(textBox1.Text,loaiBan, txtTenBan.Text);
            loadBan();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["ID_BAN"].Value.ToString();
            txtTenBan.Text = dataGridView1.CurrentRow.Cells["TENBAN"].Value.ToString();
            cbxLoaiBan.SelectedValue = dataGridView1.CurrentRow.Cells["ID_LOAIBAN"].Value.ToString();
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn phải chọn trường cần xóa");
            }
            else
            {
                blBan.xoaBan(textBox1.Text);
            }
            loadBan();
        }
    }
}