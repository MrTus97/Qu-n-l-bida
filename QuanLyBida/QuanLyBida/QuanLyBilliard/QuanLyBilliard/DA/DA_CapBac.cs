using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_CapBac
    {
        LopDungChung ldc = new LopDungChung();
        private string idcapbac;

        public int ThemCapBac(string tencapbac, float hesoluong)
        {
            string sql = "INSERT INTO CAPBAC VALUES(N'"+tencapbac+"',"+hesoluong+")";
            return ldc.ExecuteNonQuery(sql);
        }

        public  DataTable HienThiCapBac()
        {
            string sql = "select * from capbac";
            return ldc.getDuLieu(sql);
        }

        internal int SuaCapBac(int id, string tencapbac, float hsl)
        {
            string sql = "update capbac set tencapbac = '"+tencapbac+"',hesoluong="+hsl+" where id_capbac="+id;
            return ldc.ExecuteNonQuery(sql);
        }

        public int XoaCapBac(int id)
        {
            string sql = "Delete CAPBAC where ID_CapBac = " + id;
            return ldc.ExecuteNonQuery(sql);
        }
    }
}
