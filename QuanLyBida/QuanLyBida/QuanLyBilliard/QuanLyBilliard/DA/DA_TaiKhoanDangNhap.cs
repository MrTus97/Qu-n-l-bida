using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_TaiKhoanDangNhap
    {
        LopDungChung ldc = new LopDungChung();

        public DataTable LayThongTinTaiKhoanDangNhap()
        {
            string sql = "select dn.id_nhanvien,tendangnhap,tennhanvien,cmnd,email,tenquyen,q.ID_QUYEN from dangnhap dn,nhanvien nv,quyen q where dn.id_nhanvien = nv.id_nhanvien and dn.ID_QUYEN = q.ID_QUYEN ";
            return ldc.getDuLieu(sql);
        }

        public int ThemMoiTaiKhoan(int nhanvien, string tendangnhap, string matkhau, int quyen)
        {
            string sql = "insert into dangnhap values("+nhanvien+",'"+tendangnhap+"','"+matkhau+"',"+quyen+")";
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable KiemTraTenDangNhap(string tendangnhap)
        {
            string sql = "select * from dangnhap where tendangnhap ='" + tendangnhap + "'";
            return ldc.getDuLieu(sql);
        }

        internal int CapNhapTaiKhoan(int nhanvien, string tendangnhap, string matkhau, int quyen)
        {
            string sql = "update dangnhap set tendangnhap = '" + tendangnhap + "',matkhau ='" + matkhau + "',quyen=" + quyen + " where ID_NhanVien =" + nhanvien;
            return ldc.ExecuteNonQuery(sql);
        }

        public int XoaDuLieu(string tendangnhap)
        {
            string sql = "delete dangnhap where tendangnhap ='" + tendangnhap + "'";
            return ldc.ExecuteNonQuery(sql);
        }
    }
}
