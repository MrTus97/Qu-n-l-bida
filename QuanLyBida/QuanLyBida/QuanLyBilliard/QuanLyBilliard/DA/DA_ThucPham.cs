using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.DTO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBilliard.DA
{
    class DA_ThucPham
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable getDuLieu(int loaiThucPham)
        {
            string sql = "select * from thucpham where ID_LOAITHUCPHAM = " + loaiThucPham + "";
            return ldc.getDuLieu(sql);
        }

        public int ThemMatHang(string tenthucpham,string dvt,int idLoaiThucPham, float dongia,int idNhaCungCap)
        {
            string sql = "insert into thucpham values(N'"+tenthucpham+"',N'"+dvt+"',"+idLoaiThucPham+","+dongia+","+idNhaCungCap+",0)";
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable getDuLieu()
        {
            string sql = "select * from loaithucpham";
            return ldc.getDuLieu(sql);
        }

        public DataTable HienThiDuLieu()
        {
            string sql = "select tp.ID_LOAITHUCPHAM,ID_THUCPHAM,TENLOAITHUCPHAM, tp.TENTHUCPHAM,tp.DVT,GIABAN,ncc.TENNHACUNGCAP,ncc.ID_NHACUNGCAP from thucpham tp,loaithucpham ltp, nhacungcap ncc where tp.ID_LoaiThucPham = ltp.id_loaithucpham and tp.id_nhacungcap = ncc.Id_nhacungcap";
            return ldc.getDuLieu(sql);
        }

        public int CapNhatMatHang(int id_thucpham, string ten, string dvt, int idLoaiThucPham, float dongia, int idNhaCungCap)
        {
            string sql = "update thucpham set tenthucpham = N'"+ten+"',dvt=N'"+dvt+"',id_loaithucpham="+idLoaiThucPham+",giaban="+dongia+",id_nhacungcap = "+idNhaCungCap+" where id_thucpham = "+id_thucpham;
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable layDuLieuThucPham(int v)
        {
            string sql = "select * from thucpham where ID_LoaiThucPham =" + v;
            return ldc.getDuLieu(sql);
        }

        public int XoaMatHang(int id)
        {
            string sql = "";
            try
            {
                sql = "delete thucpham where id_thucpham = " + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }  
        }


        public DataTable TimThucPham(string keyword)
        {
            string sql = "select * from thucpham where tenthucpham like N'%" + keyword + "%'";
            return ldc.getDuLieu(sql);
        }

        public int ThayDoiSoLuong(int mathang, int soluongnhap)
        {
            string sql = "update THUCPHAM set SOLUONG = SOLUONG+" + soluongnhap + " where ID_THUCPHAM=" + mathang;
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable layDuLieulenDataGridView()
        {
            string sql = "select TENLOAITHUCPHAM,TENTHUCPHAM,DVT,GIABAN,TENNHACUNGCAP,ID_THUCPHAM,ltp.ID_LOAITHUCPHAM,ncc.ID_NHACUNGCAP from THUCPHAM tp,LOAITHUCPHAM ltp,NHACUNGCAP ncc where tp.ID_LOAITHUCPHAM = ltp.ID_LOAITHUCPHAM and tp.ID_NHACUNGCAP=ncc.ID_NHACUNGCAP";
            return ldc.getDuLieu(sql);
        }
    }
}
