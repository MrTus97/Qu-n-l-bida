using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DTO
{
    class LoaiThucPham
    {
        public int id { get; set; }
        public string tenloai { get; set; }
        public LoaiThucPham(DataRow row)
        {
            this.id = (int)row["ID_LOAITHUCPHAM"];
            this.tenloai = row["TENLOAITHUCPHAM"].ToString();
        }
    }
}
