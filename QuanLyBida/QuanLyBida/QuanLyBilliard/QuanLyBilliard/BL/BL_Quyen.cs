using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.GUI.TAI_KHOAN_DANG_NHAP;
using QuanLyBilliard.DA;

namespace QuanLyBilliard.BL
{
    class BL_Quyen
    {
        private DA_Quyen daQuyen = new DA_Quyen();
        public const int ADMIN = 1;
        public const int QUANLY = 2;
        public const int THUNGAN = 3;
        public const int THUKHO = 4;
        private FrmTuyChonTaikhoanDangNhap frmTuyChonTaikhoanDangNhap;

        public BL_Quyen(FrmTuyChonTaikhoanDangNhap frmTuyChonTaikhoanDangNhap)
        {
            this.frmTuyChonTaikhoanDangNhap = frmTuyChonTaikhoanDangNhap;
        }

        public DataTable LayDanhSachQuyen()
        {
            return daQuyen.LayDanhSachQuyen();
        }
    }
}
