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
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(int i)
        {
            InitializeComponent();
            quyen = i;
           
        }

        private void QuyenAdmin()
        {
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
            btnThongKeMatHang.Enabled = true;
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
            btnCaLamViec.Enabled = true;
            btnTamUng.Enabled = true;
            btnTinhCong.Enabled = true;
            btnTinhLuong.Enabled = true;
            //Quản trị
            btnPhanQuyen.Enabled = true;
            btnXoaDuLieu.Enabled = true;
            btnCauHinhHeThong.Enabled = true;
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
            if(!FormXuatHienChua("FrmDanhMucKhachHang"))
            {
                FrmDanhMucKhachHang f = new FrmDanhMucKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            
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
            btnThongKeMatHang.Enabled = true;
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
            btnCaLamViec.Enabled = false;
            btnTamUng.Enabled = false;
            btnTinhCong.Enabled = false;
            btnTinhLuong.Enabled = false;
            //Quản trị
            btnPhanQuyen.Enabled = false;
            btnXoaDuLieu.Enabled = false;
            btnCauHinhHeThong.Enabled = false;
            btnCauHinhTichDiem.Enabled = false;
        }

        private void QuyenThuNgan()
        {
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
            btnThongKeMatHang.Enabled = false;
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
            btnCaLamViec.Enabled = false;
            btnTamUng.Enabled = false;
            btnTinhCong.Enabled = false;
            btnTinhLuong.Enabled = false;
            //Quản trị
            btnPhanQuyen.Enabled = false;
            btnXoaDuLieu.Enabled = false;
            btnCauHinhHeThong.Enabled = false;
            btnCauHinhTichDiem.Enabled = false;
        }

        private void QuyenQuanLy()
        {
            //Hoạt động
            btnDanhMucMatHang.Enabled = true;
            btnDanhMucBan.Enabled = true;
            btnDanhMucKhachHang.Enabled = true;
            btnThongKeDoanhThu.Enabled = true;
            btnThongKeMatHang.Enabled = true;
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
            btnCaLamViec.Enabled = true;
            btnTamUng.Enabled = true;
            btnTinhCong.Enabled = true;
            btnTinhLuong.Enabled = true;
            //Quản trị
            btnPhanQuyen.Enabled = false;
            btnXoaDuLieu.Enabled = false;
            btnCauHinhHeThong.Enabled = false;
            btnCauHinhTichDiem.Enabled = false;
        }

        private void btnDanhMucBan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!FormXuatHienChua("FrmDanhMucBanKhuVuc"))
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
    }
}
