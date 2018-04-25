using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System.Data;
using System;

namespace QuanLyBilliard.BL
{
    class BL_ThucPham
    {
        DA_ThucPham daThucPham;
        FrmSuDungDichVu frmSuDungDichVu;
        FrmDanhMucMatHang frmDanhMucMatHang;
        public BL_ThucPham(FrmSuDungDichVu f)
        {
            daThucPham = new DA.DA_ThucPham();
            frmSuDungDichVu = f;
        }
        public BL_ThucPham(FrmDanhMucMatHang f)
        {
            daThucPham = new DA.DA_ThucPham();
            frmDanhMucMatHang = f;
        }
        public void getDuLieu(int id)
        {
            DataTable dt = daThucPham.getDuLieu(id);
            frmSuDungDichVu.dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                frmSuDungDichVu.dataGridView1.Rows.Add(row["TENTHUCPHAM"], row["DVT"], row["GIABAN"], row["ID_THUCPHAM"]);

            }
            //frmMain.dataGridView1.DataSource = daThucPham.getDuLieu(id);
        }

        public void ThemMatHang(string tenthucpham, string dvt, string text3, string text4, string text5)
        {
            float dongia = float.Parse(text4);
            int idNhaCungCap = Int32.Parse(text5);
            int idLoaiThucPham = Int32.Parse(text3);
            daThucPham.ThemMatHang(tenthucpham,dvt,idLoaiThucPham,dongia,idNhaCungCap);
        }

        public void loadLoaiThucPham()
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

        //public void loadNhaCungCap()
        //{
        //    frmDanhMucMatHang.cbxNhaCungCap.DataSource = daThucPham.getDuLieu();
        //    frmDanhMucMatHang.cbxNhaCungCap.DisplayMember = "TenLoaiThucPham";
        //    frmDanhMucMatHang.cbxNhaCungCap.ValueMember = "ID_LOAITHUCPHAM";
        //}
    }
}
