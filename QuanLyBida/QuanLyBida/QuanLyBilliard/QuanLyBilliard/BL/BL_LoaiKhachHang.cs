using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.GUI.DANH_MUC.KHACHHANG;
using QuanLyBilliard.DA;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    class BL_LoaiKhachHang
    {
        private FrmLoaiKhachHang frmLoaiKhachHang;
        private DA_LoaiKhachHang daLoaiKhachHang = new DA_LoaiKhachHang();
        private FrmTuyChonLoaiKhachHang frmTuyChonLoaiKhachHang;
        private FrmTuyChonKhachHang frmTuyChonKhachHang;

        public BL_LoaiKhachHang(FrmLoaiKhachHang frmLoaiKhachHang)
        {
            this.frmLoaiKhachHang = frmLoaiKhachHang;
        }

        public BL_LoaiKhachHang(FrmTuyChonLoaiKhachHang frmTuyChonLoaiKhachHang)
        {
            this.frmTuyChonLoaiKhachHang = frmTuyChonLoaiKhachHang;
        }

        public BL_LoaiKhachHang(FrmTuyChonKhachHang frmTuyChonKhachHang)
        {
            this.frmTuyChonKhachHang = frmTuyChonKhachHang;
        }

        public DataTable LayDanhSachLoaiKhachHang()
        {
            return daLoaiKhachHang.LayDanhSachLoaiKhachHang();
        }



        internal int ThemMoiLoaiKhachHang(string txtTenLoaiKhachHang,int giamgio,int giamnuoc)
        {
            DataTable kq = daLoaiKhachHang.KiemTraTrungTenLoaiKhachHang(txtTenLoaiKhachHang);
            if (kq.Rows.Count > 0) return -1;
            return daLoaiKhachHang.ThemMoiLoaiKhachHang(txtTenLoaiKhachHang,giamgio,giamnuoc);
        }

        internal int CapNhatLoaiKhachHang(string khach,string text, int giamgiagio, int giamgianuoc)
        {
            DataTable kq = daLoaiKhachHang.KiemTraTrungTenLoaiKhachHang(text);
            if (kq.Rows.Count > 0) return -1;
            int id = Int32.Parse(khach);
            return daLoaiKhachHang.CapNhatLoaiKhachHang(id, text, giamgiagio, giamgianuoc);
        }

        public int XoaLoaiKhachHang(string v)
        {
            try
            {
                int id = Int32.Parse(v);
                return daLoaiKhachHang.XoaLoaiKhachHang(id);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
