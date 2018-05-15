using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_PhieuThu
    {
        LopDungChung ldc = new LopDungChung();

        public DataTable LayDuLieuPhieuThu()
        {
            string sql = "select * from HOADONNHAP";
            return ldc.getDuLieu(sql);
        }
    }
}
