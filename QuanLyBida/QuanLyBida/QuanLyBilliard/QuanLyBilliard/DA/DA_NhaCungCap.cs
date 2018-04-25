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
        public DataTable getDuLieu()
        {
            string sql = "Select * from NhaCungCap";
            return ldc.getDuLieu(sql);
        }
    }
}
