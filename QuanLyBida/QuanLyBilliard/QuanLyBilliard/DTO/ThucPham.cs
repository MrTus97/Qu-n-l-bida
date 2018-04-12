using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DTO
{
    class ThucPham
    {
        public int ID_ThucPham { get; set; }
        public string TenThucPham { get; set; }
        public float GiaBan { get; set; }
        public int ID_LoaiThucPham { get; set; }
        public int soluong;
        public int ID_NhaCungCap { get; set; }
        public ThucPham(DataRow row)
        {
            this.ID_ThucPham = (int)row["ID_THUCPHAM"];
            this.TenThucPham = row["TENTHUCPHAM"].ToString();
            this.GiaBan = (float)row["GIABAN"];
            this.ID_LoaiThucPham = (int)row["ID_LOAITHUCPHAM"];
            this.ID_NhaCungCap = (int)row["ID_NHACUNGCAP"];
            this.soluong = (int)row["SOLUONG"];
        }
    }
}
