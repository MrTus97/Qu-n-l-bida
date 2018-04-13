using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_ThucPham
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable getDuLieu(int loaiThucPham)
        {
            string sql = "select * from thucpham where ID_LOAITHUCPHAM = " + loaiThucPham + "";
            //string sql = "select TENTHUCPHAM,DVT,GIABAN from thucpham where ID_LOAITHUCPHAM = " + loaiThucPham+"";
            DataTable dt = ldc.getDuLieu(sql);
            return dt;
        }
    }
}
