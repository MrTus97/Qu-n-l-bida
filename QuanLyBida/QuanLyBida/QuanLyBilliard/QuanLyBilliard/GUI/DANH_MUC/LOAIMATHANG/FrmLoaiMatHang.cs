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
    public partial class FrmLoaiMatHang : Form
    {
        private BL_LoaiThucPham blLoaiThucPham;
        public FrmLoaiMatHang()
        {
            InitializeComponent();
            blLoaiThucPham = new BL_LoaiThucPham(this);
        }

        private void FrmDanhMucLoaiMatHang_Load(object sender, EventArgs e)
        {
            DataTable dt = blLoaiThucPham.LayDanhSachLoaiThucPham();
            Refesh(dt);
        }

        private void Refesh(DataTable dt)
        {
            dgvLoaiMatHang.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dgvLoaiMatHang.Rows.Add(row.ItemArray);
            }
        }

        private void dgvLoaiMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Tag = dgvLoaiMatHang.CurrentRow;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTuyChonLoaiMatHang f = new FrmTuyChonLoaiMatHang(1);
            f.ShowDialog();
            DataTable dt = blLoaiThucPham.LayDanhSachLoaiThucPham();
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
                FrmTuyChonLoaiMatHang f = new FrmTuyChonLoaiMatHang(2, btnSua.Tag as DataGridViewRow);
                f.ShowDialog();
                DataTable dt = blLoaiThucPham.LayDanhSachLoaiThucPham();
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
                    int k = blLoaiThucPham.XoaLoaiKhachHang((btnSua.Tag as DataGridViewRow).Cells["ID_LOAITHUCPHAM"].Value.ToString());
                    if (k < 0)
                    {
                        MessageBox.Show("Vui lòng xóa những mặt hàng có trong loại này trước khi xóa nó !!");
                    }
                 DataTable dt = blLoaiThucPham.LayDanhSachLoaiThucPham();
                    Refesh(dt);
                    btnSua.Tag = null;
                }


            }
        }
    }
}
