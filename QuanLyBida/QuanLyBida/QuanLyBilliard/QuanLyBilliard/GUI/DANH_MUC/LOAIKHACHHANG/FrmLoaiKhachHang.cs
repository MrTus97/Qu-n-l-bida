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

namespace QuanLyBilliard.GUI.DANH_MUC.KHACHHANG
{
    public partial class FrmLoaiKhachHang : Form
    {
        private BL_LoaiKhachHang blLoaiKhachHang; 
        public FrmLoaiKhachHang()
        {
            InitializeComponent();
            blLoaiKhachHang = new BL_LoaiKhachHang(this);
        }

        private void FrmLoaiKhachHang_Load(object sender, EventArgs e)
        {
            DataTable result = blLoaiKhachHang.LayDanhSachLoaiKhachHang();
            RefeshLoaiKhachHang(result);
        }

        private void RefeshLoaiKhachHang(DataTable result)
        {
            dgvLoaiKhachHang.Rows.Clear();
            foreach (DataRow row in result.Rows)
            {
                dgvLoaiKhachHang.Rows.Add(row.ItemArray);
            }
        }

        private void dgvLoaiKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Tag = dgvLoaiKhachHang.CurrentRow;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTuyChonLoaiKhachHang f = new FrmTuyChonLoaiKhachHang(1);
            f.ShowDialog();
            DataTable result = blLoaiKhachHang.LayDanhSachLoaiKhachHang();
            RefeshLoaiKhachHang(result);
            btnSua.Tag = null;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(btnSua.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }else
            {
                FrmTuyChonLoaiKhachHang f = new FrmTuyChonLoaiKhachHang(2, btnSua.Tag as DataGridViewRow);
                f.ShowDialog();
                DataTable result = blLoaiKhachHang.LayDanhSachLoaiKhachHang();
                RefeshLoaiKhachHang(result);
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
                    int re = blLoaiKhachHang.XoaLoaiKhachHang((btnSua.Tag as DataGridViewRow).Cells["ID_LOAIKHACHHANG"].Value.ToString());
                    if (re < 0)
                    {
                        MessageBox.Show("Thất bại");
                    }else
                    {
                        DataTable result = blLoaiKhachHang.LayDanhSachLoaiKhachHang();
                        RefeshLoaiKhachHang(result);
                        btnSua.Tag = null;
                    }
                    
                }

            }
        }
    }
}
