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
                this.ID_NhanVien = (int)row["ID_NHANVIEN"];
            }
            if (row["ID_KHACHHANG"].ToString() == "")
            {
                this.ID_KhachHang = -1;
            }
            else
            {
                this.ID_KhachHang = (int)row["ID_KHACHHANG"];
            }
            if (row["ID_GIAMGIA"].ToString() == "")
            {
                this.ID_GiamGia = -1;
            }
            else
            {
                this.ID_GiamGia = (int)row["ID_GIAMGIA"];
            }
            if (row["GIAMGIAGIO"].ToString() == "")
            {
                this.ID_NhanVien = -1;
            }
            else
            {
                this.GiamGiaGio = (float)row["GIAMGIAGIO"];
            }
            if (row["GIAMGIATHUCPHAM"].ToString() == "")
            {
                this.GiamGiaThucPham = -1;
            }
            else
            {
                this.GiamGiaThucPham = (float)row["GIAMGIATHUCPHAM"];

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
