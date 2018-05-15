using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.GUI;
using QuanLyBilliard.DA;
using QuanLyBilliard.GUI.NHAPHANG;

namespace QuanLyBilliard.BL
{
    class BL_NhapHang
    {
        const int SOLUONGNHAP = 1;
        const int GIANHAP = 2;
        const int TONGTIEN = 3;
        const int ID_MATHANG = 4;
        private FrmNhapHang frmNhapHang;
        private DA_NhapHang daNhapHang = new DA_NhapHang();
        private FrmTuyChonNhapHang frmTuyChonNhapHang;
        private DA_ThucPham daThucPham = new DA_ThucPham();
        public BL_NhapHang(FrmNhapHang frmNhapHang)
        {
            this.frmNhapHang = frmNhapHang;
        }

        public BL_NhapHang(FrmTuyChonNhapHang frmTuyChonNhapHang)
        {
            this.frmTuyChonNhapHang = frmTuyChonNhapHang;
        }

        public DataTable LayDuLieuHoaDonNhap()
        {
            return daNhapHang.LayDuLieuHoaDonNhap();
        }

        public DataTable LayDuLieuChiTietHoaDonNhap(int id)
        {
            return daNhapHang.LayDuLieuChiTietHoaDonNhap(id);
        }

        public int TuyChonNhapHang(int soHoaDon, string tenHoaDon, DateTime ngayTaoHoaDon, DataTable matHangNhap)
        {
            int change = 0;
            int tongtien = 0;
            foreach (DataRow row in matHangNhap.Rows)
            {
                tongtien += Int32.Parse(row[3].ToString()); ;
            }
            if (soHoaDon == 0)
            {
                daNhapHang.TaoMoiHoaDonNhap(tenHoaDon, ngayTaoHoaDon, tongtien);
                int soHoaDonNhap = (int)daNhapHang.LayMaHoaDonNhapHangMoiNhat();
                foreach (DataRow row in matHangNhap.Rows)
                {
                    int mathang = Int32.Parse(row[ID_MATHANG].ToString());
                    int gianhap = Int32.Parse(row[GIANHAP].ToString());
                    int soluongnhap = Int32.Parse(row[SOLUONGNHAP].ToString());
                    int tongtien1sp = Int32.Parse(row[TONGTIEN].ToString());
                    daThucPham.ThayDoiSoLuong(mathang, soluongnhap);
                    change +=daNhapHang.TaoMoiChiTietHoaDonNhap(soHoaDonNhap, mathang,soluongnhap,gianhap,tongtien1sp);
                }
            }
            else
            {
                daNhapHang.CapNhatHoaDonNhap(soHoaDon, tenHoaDon, ngayTaoHoaDon, tongtien);
                daNhapHang.XoaChiTietHoaDonNhap(soHoaDon);
                foreach (DataRow row in matHangNhap.Rows)
                {
                    int mathang = Int32.Parse(row[ID_MATHANG].ToString());
                    int gianhap = Int32.Parse(row[GIANHAP].ToString());
                    int soluongnhap = Int32.Parse(row[SOLUONGNHAP].ToString());
                    int tongtien1sp = Int32.Parse(row[TONGTIEN].ToString());
                    daThucPham.ThayDoiSoLuong(mathang, soluongnhap);
                    change+= daNhapHang.TaoMoiChiTietHoaDonNhap(soHoaDon, mathang, soluongnhap, gianhap, tongtien1sp);
                    
                }
            }
            return change;

        }

        public DataTable LayDuLieuHoaDonNhap(int v)
        {
            return daNhapHang.LayDuLieuHoaDonNhap(v);
        }

        public int XoaHoaDonNhap(int tag)
        {
            return daNhapHang.XoaHoaDonNhap(tag);
        }
    }
}
