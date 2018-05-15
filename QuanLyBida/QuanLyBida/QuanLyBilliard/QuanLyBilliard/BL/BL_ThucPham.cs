using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System.Data;
using System;
using System.Collections.Generic;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI.NHAPHANG;

namespace QuanLyBilliard.BL
{
    class BL_ThucPham
    {
        DA_ThucPham daThucPham = new DA_ThucPham();
        FrmSuDungDichVu frmSuDungDichVu;
        FrmDanhMucMatHang frmDanhMucMatHang;
        private FrmTuyChonNhapHang frmTuyChonNhapHang;

        public BL_ThucPham(FrmSuDungDichVu f)
        {
            frmSuDungDichVu = f;
        }
        public BL_ThucPham(FrmDanhMucMatHang f)
        {
            
            frmDanhMucMatHang = f;
        }

        public BL_ThucPham(FrmTuyChonNhapHang frmTuyChonNhapHang)
        {
            this.frmTuyChonNhapHang = frmTuyChonNhapHang;
        }

        public DataTable getDuLieu(int id)
        {
            return daThucPham.getDuLieu(id);
        }

        public void ThemMatHang(string tenthucpham, string dvt, string text3, string text4, string text5)
        {
            float dongia = float.Parse(text4);
            int idNhaCungCap = Int32.Parse(text5);
            int idLoaiThucPham = Int32.Parse(text3);
            daThucPham.ThemMatHang(tenthucpham,dvt,idLoaiThucPham,dongia,idNhaCungCap);
        }

        public void loadloaiThucPham()
        {
            frmDanhMucMatHang.cbxLoaiThucPham.DataSource = daThucPham.getDuLieu();
            frmDanhMucMatHang.cbxLoaiThucPham.DisplayMember = "TenLoaiThucPham";
            frmDanhMucMatHang.cbxLoaiThucPham.ValueMember = "ID_LOAITHUCPHAM";

        }

        public DataTable HienThiDuLieu()
        {
            return daThucPham.HienThiDuLieu();
        }

        public void CapNhatMatHang(string id,string ten, string dvt, string text3, string text4, string text5)
        {
            int id_thucpham = Int32.Parse(id);
            float dongia = float.Parse(text4);
            int idNhaCungCap = Int32.Parse(text5);
            int idLoaiThucPham = Int32.Parse(text3);
            daThucPham.CapNhatMatHang(id_thucpham, ten, dvt, idLoaiThucPham, dongia, idNhaCungCap);
        }

        public void xoaMatHang(string text)
        {
            int id = Convert.ToInt32(text);
            daThucPham.XoaMatHang(id);
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
