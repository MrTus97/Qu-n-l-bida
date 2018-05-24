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
    class DA_NhaCungCap
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable LayDuLieuNhaCungCap()
        {
            try
            {
                string sql = "Select * from NhaCungCap";
                return ldc.getDuLieu(sql);
            }
            catch (SqlException)
            {
                return (DataTable)BATLOI.SQL_OTHER;
            }
            
        }

        public int CapNhatNhaCungCap(int id, string text2)
        {
            try
            {
                string sql = "update nhacungcap set tennhacungcap =N'" + text2 + "' where id_NHACUNGCAP =" + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }

        public int ThemNhaCungCap(string txtTenNhaCungCap)
        {
            try
            {
                string sql = "insert into nhacungcap values(N'" + txtTenNhaCungCap + "')";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }

        public int XoaNhaCungCap(int id)
        {
            try
            {
                string sql = "delete nhacungcap where id_NHACUNGCAP =" + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (Exception)
            {
                return BATLOI.SQL;
            }

        }

        public DataTable TimKiemNhaCungCap(string text)
        {
            try
            {
                string sql = "select * from nhacungcap where id_nhacungcap like '%" + text + "%' or tennhacungcap like N'%" + text + "%'";
                return ldc.getDuLieu(sql);
            }
            catch (SqlException)
            {
                return (DataTable)BATLOI.SQL_OTHER;
            }
        }

        public DataTable KiemTraTrungNhaCungCap(string txtTenNhaCungCap)
        {
            try
            {
                string sql = "select * from NHACUNGCAP where tennhacungcap =N'" + txtTenNhaCungCap + "'";
                return ldc.getDuLieu(sql);
            }
            catch (SqlException)
            {
                return (DataTable)BATLOI.SQL_OTHER;
            }
            
        }
    }
}
