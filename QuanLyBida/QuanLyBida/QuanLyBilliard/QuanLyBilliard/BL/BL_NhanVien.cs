using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyBilliard.BL
{
    class BL_NhanVien
    {
        DA_NhanVien daNhanVien;
        FrmNhanVien frmNhanVien;
 
 
        private FrmSuDungDichVu f;
        private FrmQuenMatKhau frmQuenMatKhau;

        public BL_NhanVien(FrmNhanVien f)
        {
            frmNhanVien = f;
            daNhanVien = new DA_NhanVien();

        }

        public BL_NhanVien(FrmSuDungDichVu f)
        {
            this.f = f;
            daNhanVien = new DA_NhanVien();
        }

        public string QuenMatKhau(string text)
        {
            return daNhanVien.QuenMatKhau(text);
        }

        public BL_NhanVien(FrmQuenMatKhau frmQuenMatKhau)
        {
            this.frmQuenMatKhau = frmQuenMatKhau;
            daNhanVien = new DA_NhanVien();
        }

        public void ThemNhanVien(string tennhanvien, string ngaysinh, string cmnd, string sdt, string gioitinh, string capbac, string catruc, string tendangnhap)
        {

            int gt;
            if (gioitinh == "Nam")
            {
                gt = 1;
            }
            else gt = 0;
            int cp = Int32.Parse(capbac);
            int result = daNhanVien.ThemNhanVien(tennhanvien, ngaysinh, cmnd, sdt, gt, cp, catruc, tendangnhap);
            if (result > 0)
            {
                MessageBox.Show("Thanh cong");
            } else { MessageBox.Show("That bai"); }
        }
        /// <summary>
        /// Hiển thị tất cả các nhân viên lên datagridview
        /// </summary>
        public void HienThiNhanVien()
        {
            //Load dữ liệu lên datagridview
            DataTable dt = daNhanVien.LayNhanvien();
            frmNhanVien.dtgNhanVien.DataSource = dt;
        }

        internal void SuaThongTinNhanVien(string txtIDNhanVien, string tennhanvien, string ngaysinh, string cmnd, string sdt, string gioitinh, string capbac, string catruc, string tendangnhap)
        {
            int idNhanVien = Int32.Parse(txtIDNhanVien);
            int gt;
            if (gioitinh == "Nam")
            {
                gt = 1;
            }
            else gt = 0;
            int cp = Int32.Parse(capbac);
            daNhanVien.SuaThongTinNhanVien(idNhanVien, tennhanvien, ngaysinh, cmnd, sdt, gt, cp, catruc, tendangnhap);
        }

        internal void XoaNhanVien(string idNhanVien)
        {
            int id = Int32.Parse(idNhanVien);
            int result = daNhanVien.XoaNhanVien(id);
            if (result > 0)
            {
                MessageBox.Show("Thanh cong");
            } else { MessageBox.Show("That bai"); }

}

        public DataTable LayNhanVien()
        {
            return daNhanVien.LayNhanvien();
        }
    }
}
