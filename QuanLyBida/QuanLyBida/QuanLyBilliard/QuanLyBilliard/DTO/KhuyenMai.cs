using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DTO
{
    class KhuyenMai
    {
        public int idGiamGia { get; set; }
        public string tenGiamGia { get; set; }
        public float giamGiaGio { get; set; }
        public float giamGiaThucPham { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }
        public KhuyenMai(DataRow row)
        {
            this.idGiamGia = (int)row["ID_GIAMGIA"];
            this.tenGiamGia = row["TENGIAMGIA"].ToString();
            this.giamGiaGio = (float)row["GIAMGIAGIO"];
            this.giamGiaThucPham = (float)row["GIAMGIATHUCPHAM"];
            this.ngayBatDau = (DateTime)row["NGAYBATDAU"];
            this.ngayKetThuc = (DateTime)row["NGAYKETTHUC"];
        }

    }
}
