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
    public partial class FrmDanhMucNhaCungCap : Form
    {
        private BL_NhaCungCap blNhaCungCap;
        public FrmDanhMucNhaCungCap()
        {
            InitializeComponent();
            blNhaCungCap = new BL_NhaCungCap(this);
        }

        private void FrmDanhMucNhaCungCap_Load(object sender, EventArgs e)
        {
            DataTable result = blNhaCungCap.LayDuLieuNhaCungCap();
            RefeshNhaCungCap(result);

        }

        private void RefeshNhaCungCap(DataTable result)
        {
            
            dgvDanhMucNhaCungCap.Rows.Clear();
            foreach(DataRow row in result.Rows)
            {
                dgvDanhMucNhaCungCap.Rows.Add(row.ItemArray);
            }
        }

        private void dgvDanhMucNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Tag = dgvDanhMucNhaCungCap.CurrentRow;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmTuyChonNhaCungCap f = new FrmTuyChonNhaCungCap();
            f.ShowDialog();
            DataTable result = blNhaCungCap.LayDuLieuNhaCungCap();
            RefeshNhaCungCap(result);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }else
            {
                FrmTuyChonNhaCungCap f = new FrmTuyChonNhaCungCap(btnSua.Tag as DataGridViewRow);
                f.ShowDialog();
                DataTable result = blNhaCungCap.LayDuLieuNhaCungCap();
                RefeshNhaCungCap(result);
            }
            
        }

        private void dgvDanhMucNhaCungCap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmTuyChonNhaCungCap f = new FrmTuyChonNhaCungCap(btnSua.Tag as DataGridViewRow);
            f.ShowDialog();
            DataTable result = blNhaCungCap.LayDuLieuNhaCungCap();
            RefeshNhaCungCap(result);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này không ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {

                    int id = Convert.ToInt32((btnSua.Tag as DataGridViewRow).Cells[0].Value.ToString());
                    int kq = blNhaCungCap.XoaNhaCungCap(id);
                    if (kq < 0)
                    {
                        MessageBox.Show("Thất bại !!");
                    }
                    DataTable result = blNhaCungCap.LayDuLieuNhaCungCap();
                    RefeshNhaCungCap(result);
                }
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = blNhaCungCap.TimNhaCungCap(txtTimKiem.Text);
            RefeshNhaCungCap(dt);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = blNhaCungCap.TimNhaCungCap(txtTimKiem.Text);
            RefeshNhaCungCap(dt);
        }
    }
}
