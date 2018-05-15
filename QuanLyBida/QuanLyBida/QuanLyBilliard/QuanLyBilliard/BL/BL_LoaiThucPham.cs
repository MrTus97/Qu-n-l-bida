using QuanLyBilliard.DA;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using QuanLyBilliard.GUI.NHAPHANG;

namespace QuanLyBilliard.BL
{
    class BL_LoaiThucPham
    {
        DA_ThucPham daThucPham = new DA_ThucPham();
        BL_ThucPham blThucPham;
        DA_LoaiThucPham daLoaiThucPham = new DA.DA_LoaiThucPham();
        FrmSuDungDichVu frmSuDungDichVu;
        const int TABLE_WIDTHHEIGHT = 100;
        LopDungChung ldc = new LopDungChung();
        private FrmTuyChonNhapHang frmTuyChonNhapHang;

        public BL_LoaiThucPham(FrmSuDungDichVu f)
        {
            blThucPham = new BL_ThucPham(f);
            frmSuDungDichVu = f;
        }

        public BL_LoaiThucPham(FrmTuyChonNhapHang frmTuyChonNhapHang)
        {
            this.frmTuyChonNhapHang = frmTuyChonNhapHang;
        }

        public List<LoaiThucPham> LoadLoaiThucPham()
        {
            return daLoaiThucPham.getDuLieu();
        }
        
    }
}
