using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.GUI;
using QuanLyBilliard.DA;
using QuanLyBilliard.GUI.TAI_KHOAN_DANG_NHAP;

namespace QuanLyBilliard.BL
{
    class BL_TaiKhoanDangNhap
    {
        private FrmTaiKhoanDangNhap frmTaiKhoanDangNhap;
        private DA_TaiKhoanDangNhap daTaiKhoanDangNhap = new DA_TaiKhoanDangNhap();
        private FrmTuyChonTaikhoanDangNhap frmTuyChonTaikhoanDangNhap;

        public BL_TaiKhoanDangNhap(FrmTaiKhoanDangNhap frmTaiKhoanDangNhap)
        {
            this.frmTaiKhoanDangNhap = frmTaiKhoanDangNhap;
        }

        public BL_TaiKhoanDangNhap(FrmTuyChonTaikhoanDangNhap frmTuyChonTaikhoanDangNhap)
        {
            this.frmTuyChonTaikhoanDangNhap = frmTuyChonTaikhoanDangNhap;
        }

        public DataTable LayThongTinTaiKhoanDangNhap()
        {
            return daTaiKhoanDangNhap.LayThongTinTaiKhoanDangNhap();
        }

        public int GhiDuLieu(int nhanvien, string tendangnhap, string matkhau, int quyen, int loaiTuyChon)
        {
            //Kiểm tra tên đăng nhập
            DataTable result = daTaiKhoanDangNhap.KiemTraTenDangNhap(tendangnhap);
            if (result.Rows.Count == 0)
            {
                if (loaiTuyChon == 1)
                {
                    return daTaiKhoanDangNhap.ThemMoiTaiKhoan(nhanvien, tendangnhap, matkhau, quyen);
                }
                else
                {
                    return daTaiKhoanDangNhap.CapNhapTaiKhoan(nhanvien, tendangnhap, matkhau, quyen);
                }
            }
            else
            {
                //Thông báo trùng tên đăng nhập
                return -1;
            }
           
        }

        public int XoaDuLieu(string tendangnhap)
        {
            return daTaiKhoanDangNhap.XoaDuLieu(tendangnhap);
        }
    }
}
