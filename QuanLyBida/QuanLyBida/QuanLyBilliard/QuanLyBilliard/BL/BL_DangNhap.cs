using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    class BL_DangNhap
    {
        DA_DangNhap daDangNhap;
        FrmMain frmMain;
        FrmDangNhap frmDangNhap;
        public BL_DangNhap(FrmDangNhap f)
        {
            frmDangNhap = f;
            daDangNhap = new DA_DangNhap();
        }
        public void DangNhap(string tendangnhap, string matkhau)
        {
            DataTable dt = daDangNhap.LayDuLieu(tendangnhap, matkhau);
            if (dt.Rows.Count > 0)
            {
                frmMain = new FrmMain();
                frmMain.Show();
                frmDangNhap.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
    }
}
