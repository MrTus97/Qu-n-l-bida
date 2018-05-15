using QuanLyBilliard.BL;
using QuanLyBilliard.GUI.NHAPHANG;
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
    public partial class FrmNhapHang : Form
    {
        BL_NhapHang blNhapHang;
        public FrmNhapHang()
        {
            InitializeComponent();
            
        }

        public void FrmNhapHang_Load(object sender, EventArgs e)
        {
            blNhapHang = new BL_NhapHang(this);
            DataTable result = blNhapHang.LayDuLieuHoaDonNhap();
            RefeshHoaDonNhap(result);
           
        }

        public void RefeshHoaDonNhap(DataTable result)
        {
            dgvHoaDonNhap.Rows.Clear();
            foreach(DataRow row in result.Rows)
            {
                dgvHoaDonNhap.Rows.Add(row.ItemArray);
            }
        }

        public void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)dgvHoaDonNhap.CurrentRow.Cells[0].Value;
            dgvChiTietHDNhap.Tag = id;
            DataTable result = blNhapHang.LayDuLieuChiTietHoaDonNhap(id);
            RefeshChiTietHoaDonNhap(result);
        }

        public void RefeshChiTietHoaDonNhap(DataTable result)
        {
            dgvChiTietHDNhap.Rows.Clear();
            foreach(DataRow row in result.Rows)
            {
                dgvChiTietHDNhap.Rows.Add(row.ItemArray);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmTuyChonNhapHang f = new FrmTuyChonNhapHang(0);
            f.ShowDialog();
            DataTable result = blNhapHang.LayDuLieuHoaDonNhap();
            RefeshHoaDonNhap(result);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvChiTietHDNhap.Tag != null)
            {
                FrmTuyChonNhapHang f = new FrmTuyChonNhapHang((int)dgvChiTietHDNhap.Tag);
                f.ShowDialog();
                DataTable result = blNhapHang.LayDuLieuHoaDonNhap();
                RefeshHoaDonNhap(result);
            }
            else
            {
                MessageBox.Show("Bạn phải chọn hóa đơn cần cập nhật trước khi bấm vào nút này");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                blNhapHang.XoaHoaDonNhap((int)dgvChiTietHDNhap.Tag);
                DataTable x = blNhapHang.LayDuLieuHoaDonNhap();
                RefeshHoaDonNhap(x);
            }
        }
    }
}
