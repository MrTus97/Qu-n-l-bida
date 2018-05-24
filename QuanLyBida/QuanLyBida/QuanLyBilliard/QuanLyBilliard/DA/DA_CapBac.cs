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
    class DA_CapBac
    {
        LopDungChung ldc = new LopDungChung();


        public int ThemCapBac(string tencapbac, float hesoluong)
        {
            try
            {
                string sql = "INSERT INTO CAPBAC VALUES(N'" + tencapbac + "'," + hesoluong + ")";
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }


        public int SuaCapBac(int id, string tencapbac, float hsl)
        {
            try
            {
                string sql = "update capbac set tencapbac = '" + tencapbac + "',hesoluong=" + hsl + " where id_capbac=" + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }
        }

        public int XoaCapBac(int id)
        {
            try
            {
                string sql = "Delete CAPBAC where ID_CapBac = " + id;
                return ldc.ExecuteNonQuery(sql);
            }
            catch (SqlException)
            {
                return BATLOI.SQL;
            }

        }

        public DataTable LayDanhSachCapBac()
        {
            string sql = "select * from capbac";
            return ldc.getDuLieu(sql);
        }
    }
}
