using QuanLyBilliard.DA;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using QuanLyBilliard.GUI.NHAPHANG;
using QuanLyBilliard.GUI.DANH_MUC.THUCPHAM;

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
        private FrmBaoCaoKho frmBaoCaoKho;
        private FrmLoaiMatHang frmDanhMucLoaiMatHang;
        private FrmTuyChonLoaiMatHang frmTuyChonLoaiMatHang;
        private FrmTuyChonMatHang frmTuyChonMatHang;

        public DataTable LayDanhSachLoaiThucPham()
        {
            return daLoaiThucPham.LayDanhSachLoaiThucPham();
        }

        public BL_LoaiThucPham(FrmSuDungDichVu f)
        {
            blThucPham = new BL_ThucPham(f);
            frmSuDungDichVu = f;
        }

        public BL_LoaiThucPham(FrmTuyChonNhapHang frmTuyChonNhapHang)
        {
            this.frmTuyChonNhapHang = frmTuyChonNhapHang;
        }

        internal int SuaLoaiThucPham(int v, string text)
        {
            DataTable kq = daLoaiThucPham.KiemTraTonTaiThucPham(text);
            if (kq.Rows.Count > 0) return -1;
            return daLoaiThucPham.CapNhatLoaiThucPham(v,text);
        }

        internal int ThemLoaiThucPham(string text)
        {
            DataTable kq = daLoaiThucPham.KiemTraTonTaiThucPham(text);
            if (kq.Rows.Count > 0) return -2;
            return daLoaiThucPham.ThemMoiLoaiThucPham(text);

        }

        public BL_LoaiThucPham(FrmBaoCaoKho frmBaoCaoKho)
        {
            this.frmBaoCaoKho = frmBaoCaoKho;
        }

        public BL_LoaiThucPham(FrmLoaiMatHang frmDanhMucLoaiMatHang)
        {
            this.frmDanhMucLoaiMatHang = frmDanhMucLoaiMatHang;
        }

        public BL_LoaiThucPham(FrmTuyChonLoaiMatHang frmTuyChonLoaiMatHang)
        {
            this.frmTuyChonLoaiMatHang = frmTuyChonLoaiMatHang;
        }

        public BL_LoaiThucPham(FrmTuyChonMatHang frmTuyChonMatHang)
        {
            this.frmTuyChonMatHang = frmTuyChonMatHang;
        }

        public List<LoaiThucPham> LoadLoaiThucPham()
        {
            return daLoaiThucPham.getDuLieu();
        }

        internal int XoaLoaiKhachHang(string v)
        {
            return daLoaiThucPham.XoaLoaiThucPham(v);
        }
    }
}
