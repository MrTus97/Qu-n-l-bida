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

namespace QuanLyBilliard.GUI.DANH_MUC.THUCPHAM
{
    public partial class FrmMatHang : Form
    {
        private BL_ThucPham blThucPham;
        public FrmMatHang()
        {
            InitializeComponent();
            blThucPham = new BL_ThucPham(this);
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Tag = dgvMatHang.CurrentRow;
        }

        private void FrmMatHang_Load(object sender, EventArgs e)
        {
            DataTable dt = blThucPham.layDuLieuLenDataGridView();
            Refesh(dt);
            
        }

        private void Refesh(DataTable dt)
        {
            dgvMatHang.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvMatHang.Rows.Add(row.ItemArray);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTuyChonMatHang f = new FrmTuyChonMatHang(1);
            f.ShowDialog();
            DataTable dt = blThucPham.LayDanhSachLoaiThucPham();
            Refesh(dt);
            btnSua.Tag = null;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }
            else
            {
                FrmTuyChonMatHang f = new FrmTuyChonMatHang(2, btnSua.Tag as DataGridViewRow);
                f.ShowDialog();
                DataTable dt = blThucPham.LayDanhSachLoaiThucPham();
                Refesh(dt);
                btnSua.Tag = null;

            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    int k = blThucPham.xoaMatHang((btnSua.Tag as DataGridViewRow).Cells["IDTHUCPHAM"].Value.ToString());
                    if (k < 0)
                    {
                        MessageBox.Show("Mặt hàng này đã xuất hiện trong hóa đơn. Không thể xóa !!");
                    }
                    DataTable dt = blThucPham.LayDanhSachLoaiThucPham();
                    Refesh(dt);
                    btnSua.Tag = null;
                }


            }
        }
    }
}
