using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "select ID_QUYEN From dangnhap where TENDANGNHAP ='"+ tendangnhap + "'";
            return (int)ldc.ExecuteScalar(sql);
        }

        internal string LayMatKhau(string tendangnhap)
        {
            string sql = "select matkhau from dangnhap where tendangnhap='" + tendangnhap+"'";
            return (string)ldc.ExecuteScalar(sql);
        }


        public int DoiMatKhau(string tendangnhap, string matkhaumoi)
        {
            string sql = "update dangnhap set matkhau ='" + matkhaumoi + "' where tendangnhap='" + tendangnhap + "'";
            return ldc.ExecuteNonQuery(sql);
        }
    }
}
