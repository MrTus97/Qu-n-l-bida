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
    }
}
