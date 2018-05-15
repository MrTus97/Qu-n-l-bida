using System;
using System.Collections.Generic;
using System.Data;
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
            string sql = "Select * from NhaCungCap";
            return ldc.getDuLieu(sql);
        }

        public int CapNhatNhaCungCap(int id, string text2)
        {
           string sql = "update nhacungcap set tennhacungcap ='"+text2+ "' where id_NHACUNGCAP =" + id;
            return ldc.ExecuteNonQuery(sql);
        }

        public int ThemNhaCungCap(string txtTenNhaCungCap)
        {
            string sql = "insert into nhacungcap values('" + txtTenNhaCungCap + "')";
            return ldc.ExecuteNonQuery(sql);
        }

        public int XoaNhaCungCap(int id)
        {
            string sql = "delete nhacungcap where id_NHACUNGCAP =" + id;
            return ldc.ExecuteNonQuery(sql);
        }

        internal DataTable TimKiemNhaCungCap(string text)
        {
            string sql = "select * from nhacungcap where id_nhacungcap like '%" + text + "%' or tennhacungcap like N'%" + text + "%'";
            return ldc.getDuLieu(sql);
        }
    }
}
