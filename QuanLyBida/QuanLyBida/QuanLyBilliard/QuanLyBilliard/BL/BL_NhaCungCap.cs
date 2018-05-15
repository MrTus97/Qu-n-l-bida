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

namespace QuanLyBilliard.BL
{
    class BL_NhaCungCap
    {
        DA_NhaCungCap daNhaCungCap = new DA_NhaCungCap();
        FrmDanhMucMatHang frmDanhMucMatHang;
        private FrmDanhMucNhaCungCap frmDanhMucNhaCungCap;
        private FrmTuyChonNhaCungCap frmTuyChonNhaCungCap;

        public BL_NhaCungCap(FrmDanhMucNhaCungCap frmDanhMucNhaCungCap)
        {
            this.frmDanhMucNhaCungCap = frmDanhMucNhaCungCap;
        }

        public BL_NhaCungCap(FrmDanhMucMatHang f)
        {
            frmDanhMucMatHang = f;
        }

        public BL_NhaCungCap(FrmTuyChonNhaCungCap frmTuyChonNhaCungCap)
        {
            this.frmTuyChonNhaCungCap = frmTuyChonNhaCungCap;
        }

        public void loainhacungcap()
        {
            frmDanhMucMatHang.cbxNhaCungCap.DataSource = daNhaCungCap.LayDuLieuNhaCungCap();
            frmDanhMucMatHang.cbxNhaCungCap.DisplayMember = "TenNhaCungCap";
            frmDanhMucMatHang.cbxNhaCungCap.ValueMember = "ID_NhaCungCap";
        }

        public DataTable LayDuLieuNhaCungCap()
        {
            return daNhaCungCap.LayDuLieuNhaCungCap();
        }

        public int CapNhatNhaCungCap(string text1, string text2)
        {
            int id = Convert.ToInt32(text1);
            return daNhaCungCap.CapNhatNhaCungCap(id, text2);
        }

        public int ThemNhaCungCap(string txtTenNhaCungCap)
        {
            return daNhaCungCap.ThemNhaCungCap(txtTenNhaCungCap);
        }

        public int XoaNhaCungCap(int id)
        {
            return daNhaCungCap.XoaNhaCungCap(id);
        }

        internal DataTable TimNhaCungCap(string text)
        {
            return daNhaCungCap.TimKiemNhaCungCap(text);
        }
    }
    
}
