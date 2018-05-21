using QuanLyBilliard.BL;
using QuanLyBilliard.GUI.KHUYEN_MAI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI
{
    public partial class FrmKhuyenMai : System.Windows.Forms.Form
    {
        BL_KhuyenMai blKhuyenMai;
        public FrmKhuyenMai()
        {
            InitializeComponent();
            blKhuyenMai = new BL_KhuyenMai(this);
        }

        private void FrmKhuyenMai_Load(object sender, EventArgs e)
        {
            DataTable result = blKhuyenMai.XemKhuyenMai();
            RefeshDgvKhuyenMai(result);
        }

        public void RefeshDgvKhuyenMai(DataTable result)
        {
            dgvKhuyenMai.Rows.Clear();
            foreach (DataRow row in result.Rows)
            {
                dgvKhuyenMai.Rows.Add(row.ItemArray);
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTuyChonKhuyenMai f = new FrmTuyChonKhuyenMai("Them");
            f.ShowDialog();
            DataTable result = blKhuyenMai.XemKhuyenMai();
            RefeshDgvKhuyenMai(result);
            
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTuyChonKhuyenMai f = new FrmTuyChonKhuyenMai(btnChinhSua.Tag as DataGridViewRow);
            f.ShowDialog();
            DataTable result = blKhuyenMai.XemKhuyenMai();
            RefeshDgvKhuyenMai(result);
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChinhSua.Tag = dgvKhuyenMai.CurrentRow;
        }

        private void dgvKhuyenMai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmTuyChonKhuyenMai f = new FrmTuyChonKhuyenMai(btnChinhSua.Tag as DataGridViewRow);
            f.ShowDialog();
            DataTable result = blKhuyenMai.XemKhuyenMai();
            RefeshDgvKhuyenMai(result);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnChinhSua.Tag!= null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa khuyến mãi này ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32((btnChinhSua.Tag as DataGridViewRow).Cells[0].Value.ToString());
                    int i = blKhuyenMai.XoaKhuyenMai(id);
                    if (i == -1)
                    {
                        MessageBox.Show("Xóa không thành công !!");
                    }
                    DataTable s = blKhuyenMai.XemKhuyenMai();
                    RefeshDgvKhuyenMai(s);
                    btnChinhSua.Tag = null;
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn khuyến mãi");
            }
            
        }
    }
}
