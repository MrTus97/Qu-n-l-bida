using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBilliard.GUI.DANH_MUC.KHACHHANG;

namespace QuanLyBilliard.BL
{
    class BL_KhachHang
    {
        FrmSuDungDichVu frmSuDungDichVu;
        DA_KhachHang daKhachHang = new DA_KhachHang();
        private FrmTuyChonLoaiKhachHang frmTuyChonLoaiKhachHang;
        private FrmKhachHang frmKhachHang;
        private FrmTuyChonKhachHang frmTuyChonKhachHang;

        public BL_KhachHang(FrmSuDungDichVu f)
        {
            frmSuDungDichVu = f;
        }

        public BL_KhachHang(FrmTuyChonLoaiKhachHang frmTuyChonLoaiKhachHang)
        {
            this.frmTuyChonLoaiKhachHang = frmTuyChonLoaiKhachHang;
        }

        public BL_KhachHang(FrmKhachHang frmKhachHang)
        {
            this.frmKhachHang = frmKhachHang;
        }

        public BL_KhachHang(FrmTuyChonKhachHang frmTuyChonKhachHang)
        {
            this.frmTuyChonKhachHang = frmTuyChonKhachHang;
        }

        public DataTable HienThiDuLieu()
        {
            return daKhachHang.HienThiDuLieu();
        }

        public int themKhachHang(string tenkhachhang, string sdt, string ngaysinh, int gioitinh, int loaikhachhang)
        {
            return daKhachHang.themKhachHang(tenkhachhang, sdt, ngaysinh, gioitinh, loaikhachhang);
        }

        public int CapNhatKhachHang(int idKhachHang, string tenkhachhang, string sdt, string ngaysinh, int gioitinh, int loaikhachhang)
        {
            return daKhachHang.CapNhatKhachHang(idKhachHang, tenkhachhang, sdt, ngaysinh, gioitinh, loaikhachhang);
        }

        public int xoaKhachHang(string text)
        {
            try
            {
                int id = Int32.Parse(text);
                return daKhachHang.xoaKhachHang(id);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public DataTable LayKhachHang()
        {
            return daKhachHang.LayKhachHang();
        }

        public DataTable layDuLieuLenDataGridView()
        {
            return daKhachHang.layDuLieuLenDataGridView();
        }
    }
}
