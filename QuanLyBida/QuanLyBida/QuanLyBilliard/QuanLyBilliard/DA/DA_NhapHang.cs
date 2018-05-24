using QuanLyBilliard.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_NhapHang
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable LayDuLieuHoaDonNhap()
        {
            string sql = "select * from hoadonnhap";
            return ldc.getDuLieu(sql);
        }

        public DataTable LayDuLieuChiTietHoaDonNhap(int id)
        {
            string sql = "select TENTHUCPHAM,hdn.SOLUONG,GIANHAP,hdn.tongtien,hdn.ID_THUCPHAM from CHITIET_HOADONNHAP hdn inner join THUCPHAM tp on tp.ID_THUCPHAM = hdn.ID_THUCPHAM where ID_HOADONNHAP =" + id;
            return ldc.getDuLieu(sql);

        }

        public int TaoMoiHoaDonNhap(string tenHoaDon, DateTime ngayTaoHoaDon, int tongtien)
        {
            try
            {
                string sql = "insert into HOADONNHAP values(N'" + tenHoaDon + "',convert(datetime,'" + ngayTaoHoaDon + "',103)," + tongtien + ")";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }

        public int LayMaHoaDonNhapHangMoiNhat()
        {
            try
            {
                string sql = "select top 1 ID_HOADONNHAP from HOADONNHAP order by ID_HOADONNHAP desc";
                return (int)ldc.ExecuteScalar(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }

        public int TaoMoiChiTietHoaDonNhap(int soHoaDon, int v1, int v2, int v3, int v4)
        {
            try
            {
                string sql = "insert into CHITIET_HOADONNHAP values(" + soHoaDon + "," + v1 + "," + v2 + "," + v3 + "," + v4 + ")";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }

        public int XoaHoaDonNhap(int tag)
        {
            try
            {
                int i = XoaChiTietHoaDonNhap(tag);
                if (i == -1) return -1;
                int k = XoaBangHoaDonNhap(tag);
                if (k == -1) return -1;
                return i + k;
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }
        public int XoaChiTietHoaDonNhap(int tag)
        {
            try
            {
                string sql = "delete CHITIET_HOADONNHAP where ID_HOADONNHAP = " + tag;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }

        }
        public int XoaBangHoaDonNhap(int tag)
        {
            try
            {
                string sql = "delete HOADONNHAP where ID_HOADONNHAP = " + tag;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }

        }

        public DataTable LayDuLieuHoaDonNhap(int v)
        {
            string sql = "select * from HOADONNHAP where ID_HOADONNHAP = " + v;
            return ldc.getDuLieu(sql);
        }

        public int CapNhatHoaDonNhap(int soHoaDon, string tenHoaDon, DateTime ngayTaoHoaDon, int tongtien)
        {
            try
            {
                string sql = "update hoadonnhap set tenhoadonnhap =N'" + tenHoaDon + "',ngaynhap = convert(datetime,'" + ngayTaoHoaDon + "',103),tongtien =" + tongtien + " where id_hoadonnhap =" + soHoaDon;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        internal int XoaMatHangChiTietNhap(int v, int idMatHang)
        {
            try
            {
                string sql = "delete CHITIET_HOADONNHAP where ID_HOADONNHAP=" + v + " and ID_THUCPHAM=" + idMatHang;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        internal int DoiSoLuongChiTietHoaDonNhap(int v1, int idMatHang, int v2)
        {
            try
            {
                string sql = "update CHITIET_HOADONNHAP where SOLUONG = SOLUONG +" + v2 + " where ID_HOADONNHAP = " + v1 + " and ID_THUCPHAM = " + idMatHang;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }
    }
}
