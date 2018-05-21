using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyBilliard.BL
{
    class BL_NhanVien
    {
        DA_NhanVien daNhanVien;
        FrmNhanVien frmNhanVien;
 
 
        private FrmSuDungDichVu f;
        private FrmQuenMatKhau frmQuenMatKhau;

        public BL_NhanVien(FrmNhanVien f)
        {
            frmNhanVien = f;
            daNhanVien = new DA_NhanVien();

        }

        public DataTable LoadCapBac()
        {
            return daNhanVien.getDuLieu();
        }

        public BL_NhanVien(FrmSuDungDichVu f)
        {
            this.f = f;
            daNhanVien = new DA_NhanVien();
        }

        public DataTable layDuLieuLenDataGridView()
        {
            return daNhanVien.layDuLieuLenDataGridView();
        }

        public string QuenMatKhau(string text)
        {
            return daNhanVien.QuenMatKhau(text);
        }

        public BL_NhanVien(FrmQuenMatKhau frmQuenMatKhau)
        {
            this.frmQuenMatKhau = frmQuenMatKhau;
            daNhanVien = new DA_NhanVien();
        }

        //public void ThemNhanVien(string tennhanvien, string ngaysinh, string cmnd, string sdt, string gioitinh, string capbac, string catruc, string tendangnhap)
        //{

        //    int gt;
        //    if (gioitinh == "Nam")
        //    {
        //        gt = 1;
        //    }
        //    else gt = 0;
        //    int cp = Int32.Parse(capbac);
        //    int result = daNhanVien.ThemNhanVien(tennhanvien, ngaysinh, cmnd, sdt, gt, cp, catruc, tendangnhap);
        //    if (result > 0)
        //    {
        //        MessageBox.Show("Thanh cong");
        //    } else { MessageBox.Show("That bai"); }
        //}

        public void ThemNhanVien(string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, string capbac, string catruc)
        {
            int idCapBac = Int32.Parse(capbac);
            daNhanVien.ThemNhanVien(tennhanvien,ngaysinh,cmnd,sdt,gioitinh,idCapBac,catruc);
        }

        /// <summary>
        /// Hiển thị tất cả các nhân viên lên datagridview
        /// </summary>
        public void HienThiNhanVien()
        {
            //Load dữ liệu lên datagridview
            DataTable dt = daNhanVien.LayNhanvien();
        }

        //public void SuaThongTinNhanVien(string txtIDNhanVien, string tennhanvien, string ngaysinh, string cmnd, string sdt, string gioitinh, string capbac, string catruc, string tendangnhap)
        //{
        //    int idNhanVien = Int32.Parse(txtIDNhanVien);
        //    int gt;
        //    if (gioitinh == "Nam")
        //    {
        //        gt = 1;
        //    }
        //    else gt = 0;
        //    int cp = Int32.Parse(capbac);
        //    daNhanVien.SuaThongTinNhanVien(idNhanVien, tennhanvien, ngaysinh, cmnd, sdt, gt, cp, catruc, tendangnhap);
        //}

        public void SuaThongTinNhanVien(string text,string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, string capbac, string catruc)
        {
            int IdNhanVien = Int32.Parse(text);
            int IdCapBac = Int32.Parse(capbac);
            daNhanVien.SuaThongTinNhanVien(IdNhanVien,tennhanvien, ngaysinh, cmnd, sdt, gioitinh, IdCapBac, catruc);
        }

        public int XoaNhanVien(string idNhanVien)
        {
            int id = Int32.Parse(idNhanVien);
            return daNhanVien.XoaNhanVien(id);
            
        }   

        public DataTable LayNhanVien()
        {
            return daNhanVien.LayNhanvien();
        }
    }
}
