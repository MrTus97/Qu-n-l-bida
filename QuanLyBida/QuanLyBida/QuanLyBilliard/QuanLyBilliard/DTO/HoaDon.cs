using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DTO
{
    public class HoaDon
    {
        public int ID_HoaDon { get; set; }
        public int ID_Ban { get; set; }
        public int ID_NhanVien { get; set; }
        public int ID_KhachHang { get; set; }
        public int ID_GiamGia { get; set; }
        public float GiamGiaGio { get; set; }
        public float GiamGiaThucPham { get; set; }
        public DateTime TongGioChoi { get; set; }
        public bool DaThanhToan { get; set; }
        public HoaDon(DataRow row)
        {
            this.ID_HoaDon = (int)row["ID_HOADON"];
            this.ID_Ban = (int)row["ID_BAN"];
            //Console.WriteLine(row["ID_NhanVien"]);
            if (row["ID_NHANVIEN"].ToString() == "")
            {
                this.ID_NhanVien = -1;
            }
            else
            {
                this.ID_NhanVien = Convert.ToInt32(row["ID_NHANVIEN"].ToString());
            }
            if (row["ID_KHACHHANG"].ToString() == "")
            {
                this.ID_KhachHang = -1;
            }
            else
            {
                this.ID_KhachHang = Convert.ToInt32(row["ID_KHACHHANG"].ToString());
            }
            if (row["ID_GIAMGIA"].ToString() == "")
            {
                this.ID_GiamGia = -1;
            }
            else
            {
                this.ID_GiamGia = Convert.ToInt32(row["ID_GIAMGIA"].ToString());
            }
            if (row["GIAMGIAGIO"].ToString() == "0")
            {
                this.ID_NhanVien = 0;
            }
            else
            {
                this.GiamGiaGio = float.Parse(row["GIAMGIAGIO"].ToString());
            }
            if (row["GIAMGIATHUCPHAM"].ToString() == "0")
            {
                this.GiamGiaThucPham = 0;
            }
            else
            {
                this.GiamGiaThucPham = float.Parse(row["GIAMGIATHUCPHAM"].ToString());

            }

            this.TongGioChoi = DateTime.Parse(row["TONGGIOCHOI"].ToString());
            this.DaThanhToan = (bool)row["DATHANHTOAN"];
        }
        public HoaDon(int idHoaDOn,int IdBan,int idNHanVien,int idKhachHang,int idGiamGia,float giamGiaGio,float giamGiaThucPham,DateTime tongGioChoi,bool daThanhToan)
        {
            this.ID_HoaDon = idHoaDOn;
            this.ID_Ban = IdBan;
            this.ID_NhanVien = idNHanVien;
            this.ID_KhachHang = idKhachHang;
            this.ID_GiamGia = idGiamGia;
            this.GiamGiaGio = giamGiaGio;
            this.GiamGiaThucPham = giamGiaThucPham;
            this.TongGioChoi = tongGioChoi;
            this.DaThanhToan = daThanhToan;
        }

    }
}
