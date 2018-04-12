using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DTO
{
    class NhanVien
    {
        public int ID { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public bool GioiTinh { get; set; }
        public string CaTruc { get; set; }
        public string TenDangNhap { get; set; }
        public int ID_CapBac { get; set; }
        public NhanVien(DataRow row)
        {
            this.ID = (int)row["ID_NHANVIEN"];
            this.Ten = row["TENNHANVIEN"].ToString();
            this.NgaySinh = DateTime.Parse(row["NGAYSINH"].ToString());
            this.SDT = row["SODIENTHOAI"].ToString();
            this.CMND = row["CMND"].ToString();
            this.GioiTinh = Boolean.Parse(row["GIOITINH"].ToString());
            this.CaTruc = row["CATRUC"].ToString();
            this.TenDangNhap = row["TENDANGNHAP"].ToString();
            this.ID_CapBac = (int)row["ID_CAPBAC"];
        }
    }
}
