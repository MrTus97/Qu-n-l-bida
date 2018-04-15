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

namespace QuanLyBilliard.GUI
{
    public partial class FrmNhanVien : Form
    {
        BL_NhanVien blNhanVien;
        public FrmNhanVien()
        {
            InitializeComponent();
            blNhanVien = new BL_NhanVien(this);
        }

        private void FrmNhanVien2_Load(object sender, EventArgs e)
        {
            blNhanVien.HienThiNhanVien();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tennhanvien = txtTenNhanVien.Text;
            string ngaysinh = dtpNgaySinh.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSoDienThoai.Text;
            string gioitinh = "Nam";
            string capbac = "1";
            string tendangnhap = null;
            string catruc = txtCaTruc.Text;
            blNhanVien.ThemNhanVien(tennhanvien,ngaysinh,cmnd,sdt,gioitinh,capbac,catruc,tendangnhap);
            blNhanVien.HienThiNhanVien();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void X_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idNhanVien = txtIDNhanVien.Text;
            string tennhanvien = txtTenNhanVien.Text;
            string ngaysinh = dtpNgaySinh.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSoDienThoai.Text;
            string gioitinh = "Nam";
            string capbac = "1";
            string tendangnhap = null;
            string catruc = txtCaTruc.Text;
            blNhanVien.SuaThongTinNhanVien(idNhanVien, tennhanvien, ngaysinh, cmnd, sdt, gioitinh, capbac, catruc, tendangnhap);
            blNhanVien.HienThiNhanVien();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idNhanVien = txtIDNhanVien.Text;
       
            blNhanVien.XoaNhanVien(idNhanVien);
            blNhanVien.HienThiNhanVien();

        }
    }
}
