using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    class BL_KhachHang
    {
        FrmDanhMucKhachHang frmDanhMucKhachHang;
        FrmSuDungDichVu frmSuDungDichVu;
        DA_KhachHang daKhachHang = new DA_KhachHang();
        public BL_KhachHang(FrmDanhMucKhachHang f)
        {
            frmDanhMucKhachHang = f;
        }
        public BL_KhachHang(FrmSuDungDichVu f)
        {
            frmSuDungDichVu = f;
        }
        

        public void loadLoaiKhachHang()
        {
            frmDanhMucKhachHang.cbxLoaiKhachHang.DataSource = daKhachHang.getDuLieu();
            frmDanhMucKhachHang.cbxLoaiKhachHang.DisplayMember = "TenLoaiKhachHang";
            frmDanhMucKhachHang.cbxLoaiKhachHang.ValueMember = "ID_LoaiKhachHang";
        }

        public DataTable HienThiDuLieu()
        {
            return daKhachHang.HienThiDuLieu();
        }

        public void themKhachHang(string tenkhachhang, string sdt, string ngaysinh, int gioitinh, string loaikhachhang)
        {
            int idLoaiKhacHhang = Int32.Parse(loaikhachhang);
            daKhachHang.themKhachHang(tenkhachhang, sdt, ngaysinh, gioitinh, idLoaiKhacHhang);
        }

        public void CapNhatKhachHang(string id, string tenkhachhang, string sdt, string ngaysinh, int gioitinh, string loaikhachhang)
        {
            int idLoaiKhacHhang = Int32.Parse(loaikhachhang);
            int idKhachHang = Int32.Parse(id);
            daKhachHang.CapNhatKhachHang(idKhachHang, tenkhachhang, sdt, ngaysinh, gioitinh, idLoaiKhacHhang);
        }

        public void xoaKhachHang(string text)
        {
            int id = Int32.Parse(text);
            daKhachHang.xoaKhachHang(id);
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
