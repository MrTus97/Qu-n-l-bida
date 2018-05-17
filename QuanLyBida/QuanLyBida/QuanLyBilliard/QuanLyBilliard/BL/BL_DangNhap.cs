using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System.Data;
using System.Windows.Forms;
using System;

namespace QuanLyBilliard.BL
{
    class BL_DangNhap
    {
        DA_DangNhap daDangNhap =  new DA_DangNhap();
        FrmDangNhap frmDangNhap;
        private FrmDoiMatKhau frmDoiMatKhau;

        public BL_DangNhap(FrmDangNhap f)
        {
            frmDangNhap = f;
        }

        public BL_DangNhap(FrmDoiMatKhau frmDoiMatKhau)
        {
            this.frmDoiMatKhau = frmDoiMatKhau;
            
        }

        public int DangNhap(string tendangnhap, string matkhau)
        {
            DataTable dt = daDangNhap.LayDuLieu(tendangnhap, matkhau);
            return dt.Rows.Count;
        }
        public void HienThiFormMain(string tendangnhap)
        {
            int i = daDangNhap.LayQuyen(tendangnhap);
            FrmMain f = new FrmMain(i,tendangnhap);
            f.Show();
        }

        public string LayMatKhau(string tendangnhap)
        {
            return daDangNhap.LayMatKhau(tendangnhap);
        }

        public int DoiMatKhau(string tendangnhap, string matkhaumoi)
        {
            return daDangNhap.DoiMatKhau(tendangnhap,matkhaumoi);
        }
    }
}
