using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_KhuyenMai
    {
        LopDungChung ldc = new LopDungChung();

        public DataTable XemKhuyenMai()
        {
            string sql = "select * from giamgia";
            return ldc.getDuLieu(sql);
        }

        public int ThemKhuyenMai(string ten, float gio_km, float nuoc_km, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                string sql = "insert into giamgia values(N'" + ten + "'," + gio_km + "," + nuoc_km + ",convert(datetime,'" + ngayBatDau + "',103),convert(datetime,'" + ngayKetThuc + "',103))";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        public int SuaKhuyenMai(int id_km, string ten, float gio_km, float nuoc_km, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                string sql = "update giamgia set TENGIAMGIA = N'" + ten + "',GIAMGIAGIO =" + gio_km + ",GIAMGIATHUCPHAM =" + nuoc_km + ",NGAYBATDAU = convert(datetime,'" + ngayBatDau + "',103),NGAYKETTHUC= convert(datetime,'" + ngayKetThuc + "',103) where ID_GIAMGIA=" + id_km;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        public int XoaKhuyenMai(int id)
        {
            try
            {
                string sql = "delete giamgia where id_giamgia =" + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return -1;
            }

        }
    }
}
