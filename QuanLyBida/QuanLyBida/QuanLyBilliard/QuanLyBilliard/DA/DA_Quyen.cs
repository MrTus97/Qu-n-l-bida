using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_Quyen
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable LayDanhSachQuyen()
        {
            string sql = "select * from quyen";
            return ldc.getDuLieu(sql);
        }
    }
}
