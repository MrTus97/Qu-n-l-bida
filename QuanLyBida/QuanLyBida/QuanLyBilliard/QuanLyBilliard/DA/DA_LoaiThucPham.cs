using QuanLyBilliard.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
