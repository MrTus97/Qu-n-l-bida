using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_KhachHang
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable getDuLieu()
        {
            string sql = null;
            try
            {
                sql = "select * from loaikhachhang";
            }
            catch (SqlException )
            {
                Console.WriteLine("getdulieu ");
            }
            return ldc.getDuLieu(sql);
        }

        public DataTable HienThiDuLieu()
        {
            string sql = "select lkh.ID_LOAIKHACHHANG, TENLOAIKHACHHANG, kh.ID_KHACHHANG, kh.TENKHACHHANG,kh.SODIENTHOAI,kh.NGAYSINH, kh.GIOITINH from LOAIKHACHHANG lkh, KHACHHANG kh where lkh.ID_LOAIKHACHHANG = kh.ID_LOAIKHACHHANG";
            return ldc.getDuLieu(sql);
        }

        public int themKhachHang(string tenkhachhang, string sdt, string ngaysinh, int gioitinh, int idLoaiKhacHhang)
        {
            string sql = "insert into KHACHHANG values (N'"+tenkhachhang+"','"+sdt+"',convert(datetime,'"+ngaysinh+"',103),"+gioitinh+",0,"+idLoaiKhacHhang+")";
            return ldc.ExecuteNonQuery(sql);
        }

        public int CapNhatKhachHang(int idKhachHang, string tenkhachhang, string sdt, string ngaysinh, int gioitinh, int idLoaiKhacHhang)
        {
            string sql = "update khachhang set tenkhachhang = N'"+tenkhachhang+"', sodienthoai = '"+sdt+"', ngaysinh = convert(datetime,'"+ngaysinh+"',103), gioitinh= '"+gioitinh+"', id_loaikhachhang = "+idLoaiKhacHhang+" where id_khachhang = "+idKhachHang+"";
            return ldc.ExecuteNonQuery(sql);
        }

        public int xoaKhachHang(int id)
        {
            string sql = "delete khachhang where id_khachhang = "+id+"";
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable LayKhachHang()
        {
            string sql = "select * from khachhang";
            return ldc.getDuLieu(sql);
        }

        public DataTable layDuLieuLenDataGridView()
        {
            string sql = "select TENLOAIKHACHHANG,TENKHACHHANG,SODIENTHOAI,NGAYSINH,GIOITINH,ID_KHACHHANG,lkh.ID_LOAIKHACHHANG from KHACHHANG kh, LOAIKHACHHANG lkh where kh.ID_LOAIKHACHHANG = lkh.ID_LOAIKHACHHANG";
            return ldc.getDuLieu(sql);
        }
    }
}
