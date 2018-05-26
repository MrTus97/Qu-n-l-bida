using QuanLyBilliard.GUI.DANH_MUC;
using QuanLyBilliard.GUI.DANH_MUC.KHACHHANG;
using QuanLyBilliard.GUI.DANH_MUC.THUCPHAM;
using System;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        const int ADMIN = 1;
        const int QUANLY = 2;
        const int THUNGAN = 3;
        const int THUKHO = 4;
        int quyen;
        string tendangnhap;

        public FrmMain(int i, string tendangnhap)
        {
            InitializeComponent();
            quyen = i;
            this.tendangnhap = tendangnhap;

        }

        private void QuyenAdmin()
        {
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
            btnSuDungDichVu.Enabled = true;
            btnDanhMucNhaCungCap.Enabled = true;
            //Hệ thống
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            //Nhập xuất
            btnNhapHangVaoKho.Enabled = true;
            btnBaoCaoKhoHang.Enabled = true;
            //Nhân sự
            btnCapBac.Enabled = true;
            btnNhanVien.Enabled = true;
            btnTaiKhoan.Enabled = true;
            //Quản trị
            btnKhuyenMai.Enabled = true;
            btnAbout.Enabled = true;

        }
        public bool FormXuatHienChua(string text)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(text))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }
       
        public void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmSuDungDichVu"))
            {
                FrmSuDungDichVu f = new FrmSuDungDichVu(quyen);
                f.MdiParent = this;
                f.Show();
            }
        }


        public void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        public void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();

        }
        public void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmSuDungDichVu"))
            {
                FrmSuDungDichVu f = new FrmSuDungDichVu(quyen);
                f.MdiParent = this;
                f.Show();
            }
        }

        public void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmKhuyenMai"))
            {
                FrmTaiKhoan f = new FrmTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }


        public void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmNhanVien"))
            {
                FrmNhanVien f = new FrmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void btnCapBac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmCapBac"))
            {
                FrmCapBac f = new FrmCapBac();
                f.MdiParent = this;
                f.Show();
            }


        }
        public void btnDanhMucMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmMatHang"))
            {
                FrmMatHang f = new FrmMatHang();
                f.MdiParent = this;
                f.Show();
            }
        }



        private void btnDanhMucKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmKhachHang"))
            {
                FrmKhachHang f = new FrmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            barAiDangDangNhap.Caption = tendangnhap;
            switch (quyen)
            {
                case BL.BL_Quyen.ADMIN:
                    QuyenAdmin();
                    break;
                case BL.BL_Quyen.QUANLY:
                    QuyenQuanLy();

                    break;
                case BL.BL_Quyen.THUNGAN:
                    QuyenThuNgan();
                    break;
                case BL.BL_Quyen.THUKHO:
                    QuyenThuKho();
                    break;
            }
        }

        private void QuyenThuKho()
        {
            //Danh mục
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = false;
            btnDanhMucKhachHang.Enabled = false;
            btnDanhMucNhaCungCap.Enabled = true;
            // Sử dụng dịch vụ
            btnSuDungDichVu.Enabled = false;
            //Thống kê
            btnThongKeDoanhThu.Enabled = false;
            //Quản lý kho
            btnNhapHangVaoKho.Enabled = true;
            btnBaoCaoKhoHang.Enabled = true;
            //Tài khoản
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;   
            //Nhân sự
            btnCapBac.Enabled = false;
            btnNhanVien.Enabled = false;
            btnTaiKhoan.Enabled = false;
            //Quản trị
            btnKhuyenMai.Enabled = false;
            btnAbout.Enabled = false;
        }

        private void QuyenThuNgan()
        {
            //Danh mục
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnDanhMucNhaCungCap.Enabled = false;
            
            
            //Sử dụng dịch vụ
            btnSuDungDichVu.Enabled = true;
            //Thống kê
            btnThongKeDoanhThu.Enabled = true;
            // Tài khoản
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            
            btnNhapHangVaoKho.Enabled = false;
            btnBaoCaoKhoHang.Enabled = false;
            //Nhân sự
            btnCapBac.Enabled = false;
            btnNhanVien.Enabled = false;
            btnTaiKhoan.Enabled = false;
            //Quản trị
            btnKhuyenMai.Enabled = false;
            btnAbout.Enabled = false;
        }

        private void QuyenQuanLy()
        {
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnDanhMucNhaCungCap.Enabled = true;

            //Thống kê
            btnThongKeDoanhThu.Enabled = true;

            //Sử dụng dịch vụ
            btnSuDungDichVu.Enabled = true;
            //Hệ thống
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            //quản lý kho
            
            btnNhapHangVaoKho.Enabled = true;
            btnBaoCaoKhoHang.Enabled = true;
            //Nhân sự
            btnCapBac.Enabled = true;
            btnNhanVien.Enabled = true;
            btnTaiKhoan.Enabled = false;
            //Quản trị
            btnKhuyenMai.Enabled = false;
            btnAbout.Enabled = false;
        }

        private void btnDanhMucBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmDanhMucBanKhuVuc"))
            {
                FrmDanhMucBanKhuVuc f = new FrmDanhMucBanKhuVuc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThongKeDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmThanhToan"))
            {
                FrmThanhToan f = new FrmThanhToan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDanhMucNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmDanhMucNhaCungCap"))
            {
                FrmDanhMucNhaCungCap f = new FrmDanhMucNhaCungCap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoCaoKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmBaoCaoKho"))
            {
                FrmBaoCaoKho f = new FrmBaoCaoKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmDoiMatKhau"))
            {
                FrmDoiMatKhau f = new FrmDoiMatKhau(tendangnhap);
                //f.MdiParent = this;
                f.ShowDialog();
            }
        }

        private void btnNhapHangVaoKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmNhapHang"))
            {
                FrmNhapHang f = new FrmNhapHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //About f = new About();
            //f.ShowDialog();
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmTaiKhoanDangNhap"))
            {
                FrmTaiKhoanDangNhap f = new FrmTaiKhoanDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit();
        }

        private void barButtonItem2_ItemClick_2(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không", "Xác nhận",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void btnLoaiMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmLoaiKhachHang"))
            {
                FrmLoaiKhachHang f = new FrmLoaiKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLoaiThucPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmLoaiMatHang"))
            {
                FrmLoaiMatHang f = new FrmLoaiMatHang();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
