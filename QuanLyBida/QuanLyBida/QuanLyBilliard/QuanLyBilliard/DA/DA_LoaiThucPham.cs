using QuanLyBilliard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_LoaiThucPham
    {
        LopDungChung ldc = new LopDungChung();
        public List<LoaiThucPham> getDuLieu()
        {
            string sql = "SELECT * FROM LOAITHUCPHAM";
            DataTable dt = ldc.getDuLieu(sql);
            List<LoaiThucPham> lst = new List<LoaiThucPham>();
            foreach (DataRow row in dt.Rows)
            {
                LoaiThucPham table = new LoaiThucPham(row);
                lst.Add(table);
            }
            return lst;
        }

        internal DataTable LayDanhSachLoaiThucPham()
        {
            string sql = "SELECT * FROM LOAITHUCPHAM";
            return ldc.getDuLieu(sql);
        }

        internal int ThemMoiLoaiThucPham(string text)
        {
            try
            {
                string sql = "insert into LOAITHUCPHAM values(N'" + text + "')";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        internal int CapNhatLoaiThucPham(int v, string text)
        {
            try
            {
                string sql = "update LOAITHUCPHAM set TENLOAITHUCPHAM =N'" + text + "' where id_loaithucpham =" + v;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        internal int XoaLoaiThucPham(string v)
        {
            try
            {
                string sql = "delete LOAITHUCPHAM where id_loaithucpham =" + v;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        internal DataTable KiemTraTonTaiThucPham(string text)
        {
            string sql = "select * from LOAITHUCPHAM where TENLOAITHUCPHAM ='" + text + "'";
            return ldc.getDuLieu(sql);
        }
    }
}
