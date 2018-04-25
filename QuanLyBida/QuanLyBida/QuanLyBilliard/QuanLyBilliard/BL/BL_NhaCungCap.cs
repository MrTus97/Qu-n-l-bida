using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.BL
{
    class BL_NhaCungCap
    {
        DA_NhaCungCap daNhaCungCap;
        FrmDanhMucMatHang frmDanhMucMatHang;

        public BL_NhaCungCap(FrmDanhMucMatHang f)
        {
            daNhaCungCap = new DA.DA_NhaCungCap();
            frmDanhMucMatHang = f;
        }

        public void loainhacungcap()
        {
            frmDanhMucMatHang.cbxNhaCungCap.DataSource = daNhaCungCap.getDuLieu();
            frmDanhMucMatHang.cbxNhaCungCap.DisplayMember = "TenNhaCungCap";
            frmDanhMucMatHang.cbxNhaCungCap.ValueMember = "ID_NhaCungCap";
        }
    }
    
}
