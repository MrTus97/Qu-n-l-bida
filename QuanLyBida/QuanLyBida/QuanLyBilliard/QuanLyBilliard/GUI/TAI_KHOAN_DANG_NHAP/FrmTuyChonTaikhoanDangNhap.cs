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

namespace QuanLyBilliard.GUI.TAI_KHOAN_DANG_NHAP
{
    public partial class FrmTuyChonTaikhoanDangNhap : Form
    {
        private int loaiTuyChon; // 1 là tạo mới, 2 là cập nhật
        private BL_NhanVien blNhanVien;
        private BL_Quyen blQuyen;
        private BL_TaiKhoanDangNhap blTaiKhoanDangNhap;
        private DataGridViewRow row = null;

        public FrmTuyChonTaikhoanDangNhap(int v)
        {
            InitializeComponent();
            this.loaiTuyChon = v;

        }

        public FrmTuyChonTaikhoanDangNhap(int v, DataGridViewRow tag)
        {
            InitializeComponent();
            loaiTuyChon = v;
            row = tag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTuyChonTaikhoanDangNhap_Load(object sender, EventArgs e)
        {
            blNhanVien = new BL_NhanVien(this);
            blQuyen = new BL_Quyen(this);
            blTaiKhoanDangNhap = new BL_TaiKhoanDangNhap(this);
            //Lấy quyền
            DataTable quyen = blQuyen.LayDanhSachQuyen();
            cbQuyen.DataSource = quyen;
            cbQuyen.DisplayMember = "TENQUYEN";
            cbQuyen.ValueMember = "ID_QUYEN";

            if (loaiTuyChon == 1)
            {
                this.Text = "THÊM MỚI TÀI KHOẢN";
                //Lấy nhân viên
                DataTable nhanVienChuaCoTaiKhoan = blNhanVien.LayNhanVienChuaCoTaiKhoan();
                cbNhanVien.DataSource = nhanVienChuaCoTaiKhoan;
                cbNhanVien.DisplayMember = "TENNHANVIEN";
                cbNhanVien.ValueMember = "ID_NHANVIEN";
            }
            else
            {
                this.Text = "CẬP NHẬT TÀI KHOẢN";
                cbNhanVien.Enabled = false;
                //Nhân viên
                cbNhanVien.SelectedText = row.Cells["TENNHANVIEN"].Value.ToString();
                cbNhanVien.SelectedValue = Int32.Parse(row.Cells["ID_NHANVIEN"].Value.ToString());
                txtTenDangNhap.Text = row.Cells["TENDANGNHAP"].Value.ToString();
                cbQuyen.SelectedValue = Int32.Parse(row.Cells["ID_QUYEN"].Value.ToString());
                //cbQuyen.SelectedText = row.Cells["TENQUYEN"].Value.ToString();
            }
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            int nhanvien = (int)cbNhanVien.SelectedValue;
            int quyen = (int)cbQuyen.SelectedValue;
            string tendangnhap = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            string xacnhan = txtXacNhanMatKhau.Text;
            if (matkhau != xacnhan)
            {
                MessageBox.Show("Không trùng mật khẩu");
            }
            else
            {
                MaHoaMatKhau mahoa = new MaHoaMatKhau();
                matkhau = mahoa.MaHoa(matkhau);
                int result = blTaiKhoanDangNhap.GhiDuLieu(nhanvien, tendangnhap, matkhau, quyen, loaiTuyChon);
                if (result == -1)
                {
                    MessageBox.Show("Tên đăng nhập đã bị trùng, vui lòng chọn tên khác");
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
