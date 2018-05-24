using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.GUI.DANH_MUC;
using System.Data;
using System.Windows.Forms;
using QuanLyBilliard.GUI.DANH_MUC.THUCPHAM;

namespace QuanLyBilliard.BL
{
    class BL_NhaCungCap
    {
        DA_NhaCungCap daNhaCungCap = new DA_NhaCungCap();
        private FrmDanhMucNhaCungCap frmDanhMucNhaCungCap;
        private FrmTuyChonNhaCungCap frmTuyChonNhaCungCap;
        private FrmTuyChonMatHang frmTuyChonMatHang;

        public BL_NhaCungCap(FrmDanhMucNhaCungCap frmDanhMucNhaCungCap)
        {
            this.frmDanhMucNhaCungCap = frmDanhMucNhaCungCap;
        }


        public BL_NhaCungCap(FrmTuyChonNhaCungCap frmTuyChonNhaCungCap)
        {
            this.frmTuyChonNhaCungCap = frmTuyChonNhaCungCap;
        }

        public BL_NhaCungCap(FrmTuyChonMatHang frmTuyChonMatHang)
        {
            this.frmTuyChonMatHang = frmTuyChonMatHang;
        }


        public DataTable LayDuLieuNhaCungCap()
        {
            return daNhaCungCap.LayDuLieuNhaCungCap();
        }

        public int CapNhatNhaCungCap(string text1, string text2)
        {
            try
            {
                int id = Convert.ToInt32(text1);
                return daNhaCungCap.CapNhatNhaCungCap(id, text2);
            }
            catch (Exception)
            {
                return BATLOI.SAI_DINH_DANG;
            }
            
        }

        public int ThemNhaCungCap(string txtTenNhaCungCap)
        {
            return daNhaCungCap.ThemNhaCungCap(txtTenNhaCungCap);
        }

        public int XoaNhaCungCap(int id)
        {
            return daNhaCungCap.XoaNhaCungCap(id);
        }

        public DataTable TimNhaCungCap(string text)
        {
            return daNhaCungCap.TimKiemNhaCungCap(text);
        }

        public bool KiemTraTrungNhaCungCap(string txtTenNhaCungCap)
        {
            DataTable dt = daNhaCungCap.KiemTraTrungNhaCungCap(txtTenNhaCungCap);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
    
}
