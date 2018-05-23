using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System.Data;
using System;
using System.Collections.Generic;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI.NHAPHANG;
using QuanLyBilliard.GUI.DANH_MUC.THUCPHAM;

namespace QuanLyBilliard.BL
{
    class BL_ThucPham
    {
        DA_ThucPham daThucPham = new DA_ThucPham();
        FrmSuDungDichVu frmSuDungDichVu;
        private FrmTuyChonNhapHang frmTuyChonNhapHang;
        private FrmBaoCaoKho frmBaoCaoKho;
        private FrmMatHang frmMatHang;
        private FrmTuyChonMatHang frmTuyChonMatHang;

        public BL_ThucPham(FrmSuDungDichVu f)
        {
            frmSuDungDichVu = f;
        }

        public BL_ThucPham(FrmTuyChonNhapHang frmTuyChonNhapHang)
        {
            this.frmTuyChonNhapHang = frmTuyChonNhapHang;
        }

        public BL_ThucPham(FrmBaoCaoKho frmBaoCaoKho)
        {
            this.frmBaoCaoKho = frmBaoCaoKho;
        }

        public BL_ThucPham(FrmMatHang frmMatHang)
        {
            this.frmMatHang = frmMatHang;
        }

        public BL_ThucPham(FrmTuyChonMatHang frmTuyChonMatHang)
        {
            this.frmTuyChonMatHang = frmTuyChonMatHang;
        }

        internal DataTable LayDanhSachLoaiThucPham()
        {
            return daThucPham.layDuLieulenDataGridView();
        }

        public DataTable getDuLieu(int id)
        {
            return daThucPham.getDuLieu(id);
        }

        public int ThemMatHang(string tenthucpham, string dvt, int idLoaiThucPham, string text4, int idNhaCungCap)
        {
            float dongia = float.Parse(text4);
            return daThucPham.ThemMatHang(tenthucpham,dvt,idLoaiThucPham,dongia,idNhaCungCap);
        }

        public DataTable LayDuLieuThucPham(int idLoaiThucPham)
        {
            return daThucPham.layDuLieuThucPham(idLoaiThucPham);
        }


        public DataTable HienThiDuLieu()
        {
            return daThucPham.HienThiDuLieu();
        }

        public int CapNhatMatHang(int id,string ten, string dvt, int loaithucpham, int giaban, int nhacungcap)
        {
            float dongia = float.Parse(giaban.ToString());
            return daThucPham.CapNhatMatHang(id, ten, dvt, loaithucpham, dongia, nhacungcap);
        }

        public int xoaMatHang(string text)
        {
            int id = Convert.ToInt32(text);
            return daThucPham.XoaMatHang(id);
        }


        public DataTable TimThucPham(string keyword)
        {
            return daThucPham.TimThucPham(keyword);
        }

        public DataTable layDuLieuLenDataGridView()
        {
            return daThucPham.layDuLieulenDataGridView();
        }

        //public void loadNhaCungCap()
        //{
        //    frmDanhMucMatHang.cbxNhaCungCap.DataSource = daThucPham.getDuLieu();
        //    frmDanhMucMatHang.cbxNhaCungCap.DisplayMember = "TenLoaiThucPham";
        //    frmDanhMucMatHang.cbxNhaCungCap.ValueMember = "ID_LOAITHUCPHAM";
        //}
    }
}
