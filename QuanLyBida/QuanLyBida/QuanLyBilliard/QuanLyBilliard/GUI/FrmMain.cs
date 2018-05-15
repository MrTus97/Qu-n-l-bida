using QuanLyBilliard.GUI.DANH_MUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //Hệ thống
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            btnThoat.Enabled = true;
            //Nhập xuất
            btnDanhMucNhaCungCap.Enabled = true;
            btnNhapHangVaoKho.Enabled = true;
            btnBaoCaoKhoHang.Enabled = true;
            btnTaoPhieuThu.Enabled = true;
            btnTaoPhieuChi.Enabled = true;
            btnDanhMucThuChi.Enabled = true;
            //Nhân sự
            btnCapBac.Enabled = true;
            btnNhanVien.Enabled = true;

            btnTamUng.Enabled = true;
            btnTinhCong.Enabled = true;
            //Quản trị
            btnKhuyenMai.Enabled = true;
            btnAbout.Enabled = true;
            btnCauHinhTichDiem.Enabled = true;

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

        public void Form1_Load(object sender, EventArgs e)
        {
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
                FrmKhuyenMai f = new FrmKhuyenMai();
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
            if (!FormXuatHienChua("FrmDanhMucMatHang"))
            {
                FrmDanhMucMatHang f = new FrmDanhMucMatHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhMucKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmDanhMucKhachHang"))
            {
                FrmDanhMucKhachHang f = new FrmDanhMucKhachHang();
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
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = false;
            btnDanhMucKhachHang.Enabled = false;
            btnThongKeDoanhThu.Enabled = false;
            btnSuDungDichVu.Enabled = false;
            //Hệ thống
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            btnThoat.Enabled = true;
            //Nhập xuất
            btnDanhMucNhaCungCap.Enabled = true;
            btnNhapHangVaoKho.Enabled = true;
            btnBaoCaoKhoHang.Enabled = true;
            btnTaoPhieuThu.Enabled = true;
            btnTaoPhieuChi.Enabled = true;
            btnDanhMucThuChi.Enabled = true;
            //Nhân sự
            btnCapBac.Enabled = false;
            btnNhanVien.Enabled = false;

            btnTamUng.Enabled = false;
            btnTinhCong.Enabled = false;
            //Quản trị
            btnKhuyenMai.Enabled = false;
            btnAbout.Enabled = false;
            btnCauHinhTichDiem.Enabled = false;
        }

        private void QuyenThuNgan()
        {
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
            btnSuDungDichVu.Enabled = true;
            //Hệ thống
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            btnThoat.Enabled = true;
            //Nhập xuất
            btnDanhMucNhaCungCap.Enabled = false;
            btnNhapHangVaoKho.Enabled = false;
            btnBaoCaoKhoHang.Enabled = false;
            btnTaoPhieuThu.Enabled = true;
            btnTaoPhieuChi.Enabled = true;
            btnDanhMucThuChi.Enabled = true;
            //Nhân sự
            btnCapBac.Enabled = false;
            btnNhanVien.Enabled = false;
            btnTamUng.Enabled = false;
            btnTinhCong.Enabled = false;
            //Quản trị
            btnKhuyenMai.Enabled = false;
            btnAbout.Enabled = false;
            btnCauHinhTichDiem.Enabled = false;
        }

        private void QuyenQuanLy()
        {
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
            btnSuDungDichVu.Enabled = true;
            //Hệ thống
            btnDoiMatKhau.Enabled = true;
            btnDangXuat.Enabled = true;
            btnThoat.Enabled = true;
            //Nhập xuất
            btnDanhMucNhaCungCap.Enabled = true;
            btnNhapHangVaoKho.Enabled = true;
            btnBaoCaoKhoHang.Enabled = true;
            btnTaoPhieuThu.Enabled = true;
            btnTaoPhieuChi.Enabled = true;
            btnDanhMucThuChi.Enabled = true;
            //Nhân sự
            btnCapBac.Enabled = true;
            btnNhanVien.Enabled = true;
            btnTamUng.Enabled = true;
            btnTinhCong.Enabled = true;
            //Quản trị
            btnKhuyenMai.Enabled = false;
            btnAbout.Enabled = false;
            btnCauHinhTichDiem.Enabled = false;
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
            XtraReport1 x = new XtraReport1();
            x.CreateDocument();
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
            About f = new About();
            f.ShowDialog();
        }

        private void btnTaoPhieuThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmPhieuThu"))
            {
                FrmPhieuThu f = new FrmPhieuThu();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
