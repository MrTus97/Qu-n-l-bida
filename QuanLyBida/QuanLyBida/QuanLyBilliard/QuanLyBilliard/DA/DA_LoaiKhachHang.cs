using QuanLyBilliard.BL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_LoaiKhachHang
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable LayDanhSachLoaiKhachHang()
        {
   
                string sql = "select * from loaikhachhang";
                return ldc.getDuLieu(sql);
          
        }

        public DataTable KiemTraTrungTenLoaiKhachHang(string txtTenLoaiKhachHang)
        {
     
                string sql = "select TENLOAIKHACHHANG from LOAIKHACHHANG where TENLOAIKHACHHANG ='" + txtTenLoaiKhachHang + "'";
                return ldc.getDuLieu(sql);
        }

        internal int ThemMoiLoaiKhachHang(string txtTenLoaiKhachHang,int giamgio,int giamnuoc)
        {
            try
            {
                string sql = "insert into LOAIKHACHHANG values(N'" + txtTenLoaiKhachHang + "'," + giamgio + "," + giamnuoc + ")";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                return BATLOI.SQL;
            }
        }

        internal int CapNhatLoaiKhachHang(int id,string text, int giamgiagio, int giamgianuoc)
        {
            try
            {
                string sql = "update LOAIKHACHHANG set tenloaikhachhang =N'" + text + "',giamgiagio =" + giamgiagio + ",giamgiathucpham =" + giamgianuoc + " where ID_LOAIKHACHHANG= " + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                return BATLOI.SQL;
            }
        }

        internal int XoaLoaiKhachHang(int id)
        {
            try
            {
                string sql = "delete LOAIKHACHHANG where id_loaikhachhang=" + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                return BATLOI.SQL;
            }

        }
    }
}
