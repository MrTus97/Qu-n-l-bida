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
    class DA_NhanVien
    {
        LopDungChung ldc = new LopDungChung();

        public DataTable LayNhanvien()
        {
            string sql = "select * from nhanvien";
            return ldc.getDuLieu(sql);
        }

        public DataTable getDuLieu()
        {
            string sql = "select * from CAPBAC";
            return ldc.getDuLieu(sql);
        }

        internal DataTable LayNhanVienChuaCoTaiKhoan()
        {
            string sql = "select id_nhanvien,TENNHANVIEN from nhanvien where ID_NHANVIEN not in (select ID_NHANVIEN from dangnhap)";
            return ldc.getDuLieu(sql);
        }

        public DataTable layDuLieuLenDataGridView()
        {
            string sql = "select TENNHANVIEN,CMND,SODIENTHOAI,EMAIL,NGAYSINH,GIOITINH,TENCAPBAC,ID_NHANVIEN,nv.ID_CAPBAC from NHANVIEN nv left join CAPBAC cb on nv.ID_CAPBAC = cb.ID_CAPBAC";
            return ldc.getDuLieu(sql);
        }

        public string QuenMatKhau(string text)
        {
            try
            {
                string sql = "select matkhau from dangnhap where tendangnhap = '" + text + "'";
                object result = ldc.ExecuteScalar(sql);
                if (result == null)
                {
                    return "";
                }
                MaHoaMatKhau mh = new MaHoaMatKhau();
                return mh.GiaiMa(result.ToString());
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public int XoaNhanVien(int idNhanVien)
        {
            try
            {
                string sql = "Delete NHANVIEN where ID_NhanVien = " + idNhanVien;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }

        }


        public int ThemNhanVien(string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, int idCapBac, string email)
        {
            try
            {
                string sql = "insert into NhanVien values( N'" + tennhanvien + "',convert(datetime,'" + ngaysinh + "',103),'" + cmnd + "','" + sdt + "'," + gioitinh + ", " + idCapBac + ",N'NULL','"+ email+"') ";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }

        public int SuaThongTinNhanVien(int IdNhanVien, string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, string idCapBac, string email)
        {
            try
            {
                string sql = "update NHANVIEN set TENNHANVIEN=N'" + tennhanvien + "',ngaysinh = convert(datetime,'" + ngaysinh + "',103), cmnd = '" + cmnd + "', sodienthoai = '" + sdt + "',Email=N'" + email + "' where ID_NhanVien = '" + IdNhanVien + "'";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }
    }
}
