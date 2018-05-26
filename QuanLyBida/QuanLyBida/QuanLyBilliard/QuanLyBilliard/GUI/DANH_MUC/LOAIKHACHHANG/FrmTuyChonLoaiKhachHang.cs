using QuanLyBilliard.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI.DANH_MUC.KHACHHANG
{
    public partial class FrmTuyChonLoaiKhachHang : Form
    {
        private int loai; //1 la them
        private BL_LoaiKhachHang blLoaiKhachHang;
        private DataGridViewRow dataGridViewRow;

        public FrmTuyChonLoaiKhachHang(int v)
        {
            InitializeComponent();

            this.loai = v;

            this.Text = "THÊM MỚI LOẠI KHÁCH HÀNG";
            txtIDLoaiKhach.Visible = false;
            label1.Visible = false;
        }

        public FrmTuyChonLoaiKhachHang(int v, DataGridViewRow dataGridViewRow) 
        {
            InitializeComponent();
            this.loai = v;
            this.dataGridViewRow = dataGridViewRow;
            this.Text = "CẬP NHẬT LOẠI KHÁCH HÀNG";
            txtIDLoaiKhach.Enabled = false;
            //Bing dữ liệu
            txtIDLoaiKhach.Text = dataGridViewRow.Cells["ID_LOAIKHACHHANG"].Value.ToString();
            txtTenLoaiKhachHang.Text = dataGridViewRow.Cells["TENLOAIKHACHHANG"].Value.ToString();
            txtGiamGiaGio.Text = dataGridViewRow.Cells["GIAMGIAGIO"].Value.ToString();
            txtGiamGiaNuoc.Text = dataGridViewRow.Cells["GIAMGIATHUCPHAm"].Value.ToString();
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            int kq = 0;
            try
            {
                int giamgiagio = Int32.Parse(txtGiamGiaGio.Text);
                int giamgianuoc = Int32.Parse(txtGiamGiaNuoc.Text);
                if (loai == 1)
                {
                    kq = blLoaiKhachHang.ThemMoiLoaiKhachHang(txtTenLoaiKhachHang.Text, giamgiagio, giamgianuoc);
                }
                else
                {
                    kq = blLoaiKhachHang.CapNhatLoaiKhachHang(txtIDLoaiKhach.Text, txtTenLoaiKhachHang.Text, giamgiagio, giamgianuoc);
                }
                
            }
            catch (Exception)
            {
                kq = BATLOI.SAI_DINH_DANG;
            }

            if (kq < 0)
            {
                BATLOI.HienThiLoi(kq);
            }
            else { this.Close(); }
        }

        private void FrmTuyChonLoaiKhachHang_Load(object sender, EventArgs e)
        {
            blLoaiKhachHang = new BL_LoaiKhachHang(this);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
