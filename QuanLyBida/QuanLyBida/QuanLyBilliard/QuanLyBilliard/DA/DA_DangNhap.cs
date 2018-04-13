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
    }
}
