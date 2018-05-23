using QuanLyBilliard.BL;
using QuanLyBilliard.GUI.TAI_KHOAN_DANG_NHAP;
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
    public partial class FrmTaiKhoanDangNhap : Form
    {
        private BL_TaiKhoanDangNhap blTaiKhoanDangNhap;
        private BL_NhanVien blNhanVien;
        public FrmTaiKhoanDangNhap()
        {
            InitializeComponent();
            blTaiKhoanDangNhap = new BL_TaiKhoanDangNhap(this);
            blNhanVien = new BL_NhanVien(this);
        }

        private void FrmTaiKhoanDangNhap_Load(object sender, EventArgs e)
        {

            DataTable result = blTaiKhoanDangNhap.LayThongTinTaiKhoanDangNhap();
            RefeshDgvTaiKhoan(result);
        }

        private void RefeshDgvTaiKhoan(DataTable result)
        {
            dgvTaiKhoanDangNhap.Rows.Clear();
            foreach(DataRow row in result.Rows)
            {
                dgvTaiKhoanDangNhap.Rows.Add(row.ItemArray);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable nhanVienChuaCoTaiKhoan = blNhanVien.LayNhanVienChuaCoTaiKhoan();
            if (nhanVienChuaCoTaiKhoan.Rows.Count == 0)
            {
                MessageBox.Show("Bạn phải thêm nhân viên trước khi thêm tên đăng nhập");
            }else
            {
                FrmTuyChonTaikhoanDangNhap f = new FrmTuyChonTaikhoanDangNhap(1);
                f.ShowDialog();
                DataTable dt = blTaiKhoanDangNhap.LayThongTinTaiKhoanDangNhap();
                RefeshDgvTaiKhoan(dt);
            }
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa");
            }else
            {
                FrmTuyChonTaikhoanDangNhap f = new FrmTuyChonTaikhoanDangNhap(2, btnSua.Tag as DataGridViewRow);
                f.ShowDialog();
                DataTable dt = blTaiKhoanDangNhap.LayThongTinTaiKhoanDangNhap();
                RefeshDgvTaiKhoan(dt);
            }
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa");
            }
            else
            {
                blTaiKhoanDangNhap.XoaDuLieu((btnSua.Tag as DataGridViewRow).Cells["TENDANGNHAP"].ToString());
            }
        }

        private void barDockControlTop_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlBottom_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlLeft_Click(object sender, EventArgs e)
        {

        }

        private void barDockControlRight_Click(object sender, EventArgs e)
        {

        }

        private void dgvTaiKhoanDangNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTaiKhoanDangNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Tag = dgvTaiKhoanDangNhap.CurrentRow;
        }
    }
}
