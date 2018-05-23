using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_DangNhap
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable LayDuLieu(string tendangnhap, string matkhau)
        {
            string sql = "select * from DANGNHAP where tendangnhap ='" + tendangnhap + "' and matkhau ='" + matkhau + "'";
            return ldc.getDuLieu(sql);
        }

        public int LayQuyen(string tendangnhap)
        {
            try
            {
                string sql = "select ID_QUYEN From dangnhap where TENDANGNHAP ='" + tendangnhap + "'";
                return (int)ldc.ExecuteScalar(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        public string LayMatKhau(string tendangnhap)
        {
            try
            {
                string sql = "select matkhau from dangnhap where tendangnhap='" + tendangnhap + "'";
                return (string)ldc.ExecuteScalar(sql);
            }
            catch (SqlException)
            {
                return null;
            }
        }


        public int DoiMatKhau(string tendangnhap, string matkhaumoi)
        {
            try
            {
                string sql = "update dangnhap set matkhau ='" + matkhaumoi + "' where tendangnhap='" + tendangnhap + "'";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }
    }
}
