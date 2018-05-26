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
using QuanLyBilliard.GUI.TAI_KHOAN_DANG_NHAP;

namespace QuanLyBilliard.BL
{
    class BL_NhanVien
    {
        DA_NhanVien daNhanVien = new DA_NhanVien();
        FrmNhanVien frmNhanVien;
 
 
        private FrmSuDungDichVu f;
        private FrmQuenMatKhau frmQuenMatKhau;
        private FrmTuyChonTaikhoanDangNhap frmTuyChonTaikhoanDangNhap;
        private FrmTaiKhoanDangNhap frmTaiKhoanDangNhap;

        public BL_NhanVien(FrmNhanVien f)
        {
            frmNhanVien = f;
            daNhanVien = new DA_NhanVien();

        }

        public DataTable LoadCapBac()
        {
            return daNhanVien.getDuLieu();
        }

        public BL_NhanVien(FrmSuDungDichVu f)
        {
            this.f = f;
            daNhanVien = new DA_NhanVien();
        }

        public DataTable layDuLieuLenDataGridView()
        {
            return daNhanVien.layDuLieuLenDataGridView();
        }

        public DataTable LayNhanVienChuaCoTaiKhoan()
        {
            return daNhanVien.LayNhanVienChuaCoTaiKhoan();
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

        public BL_NhanVien(FrmTuyChonTaikhoanDangNhap frmTuyChonTaikhoanDangNhap)
        {
            this.frmTuyChonTaikhoanDangNhap = frmTuyChonTaikhoanDangNhap;
        }

        public BL_NhanVien(FrmTaiKhoanDangNhap frmTaiKhoanDangNhap)
        {
            this.frmTaiKhoanDangNhap = frmTaiKhoanDangNhap;
        }

        public int ThemNhanVien(string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, string capbac, string email)
        {
            try
            {
                int idCapBac = Int32.Parse(capbac);
                return daNhanVien.ThemNhanVien(tennhanvien, ngaysinh, cmnd, sdt, gioitinh, idCapBac, email);
            }
            catch (Exception)
            {
                return BATLOI.SAI_DINH_DANG;
            }
        }

        /// <summary>
        /// Hiển thị tất cả các nhân viên lên datagridview
        /// </summary>
        public void HienThiNhanVien()
        {
            //Load dữ liệu lên datagridview
            DataTable dt = daNhanVien.LayNhanvien();
        }

        public int SuaThongTinNhanVien(string text,string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, string capbac, string email)
        {
            try
            {
                int IdNhanVien = Int32.Parse(text);
                return daNhanVien.SuaThongTinNhanVien(IdNhanVien, tennhanvien, ngaysinh, cmnd, sdt, gioitinh, capbac, email);
            }
            catch (Exception)
            {
                return BATLOI.SAI_DINH_DANG;
            }
            
        }

        public int XoaNhanVien(string idNhanVien)
        {
            try
            {
                int id = Int32.Parse(idNhanVien);
                return daNhanVien.XoaNhanVien(id);
            }
            catch (Exception)
            {
                return -1;
            }
            
        }   

        public DataTable LayNhanVien()
        {
            return daNhanVien.LayNhanvien();
        }
    }
}
