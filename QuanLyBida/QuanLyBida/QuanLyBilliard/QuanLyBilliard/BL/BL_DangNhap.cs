using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    class BL_DangNhap
    {
        DA_DangNhap daDangNhap;
        FrmDangNhap frmDangNhap;
        public BL_DangNhap(FrmDangNhap f)
        {
            frmDangNhap = f;
            daDangNhap = new DA_DangNhap();
        }
        public int DangNhap(string tendangnhap, string matkhau)
        {
            DataTable dt = daDangNhap.LayDuLieu(tendangnhap, matkhau);
            return dt.Rows.Count;
        }
        public void HienThiFormMain()
        {
            FrmMain f = new FrmMain();
            f.Show();
        }
    }
}
