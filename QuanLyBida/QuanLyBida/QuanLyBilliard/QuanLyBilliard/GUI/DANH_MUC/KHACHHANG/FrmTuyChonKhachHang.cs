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
    public partial class FrmTuyChonKhachHang : Form
    {
        private int v;
        private BL_KhachHang blKhachHang;
        private BL_LoaiKhachHang blLoaiKhachHang;
        private DataGridViewRow dataGridViewRow;

        public FrmTuyChonKhachHang()
        {
            InitializeComponent();
        }

        public FrmTuyChonKhachHang(int v)
        {
            InitializeComponent();
            this.v = v;
            this.Text = "THÊM MỚI KHÁCH HÀNG";
            txtIDKhachHang.Visible = false;
            lbIDKhachHang.Visible = false;
        }

        public FrmTuyChonKhachHang(int v, DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this.v = v;
            this.dataGridViewRow = dataGridViewRow;
            this.Text = "CẬP NHẬT KHÁCH HÀNG";
            txtIDKhachHang.Enabled = false;
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            int kq = 0;
            if (cbxLoaiKhachHang.Text == "" || txtTenKhachHang.Text == "" || txtSoDienThoai.Text == "")
            {
                kq = BATLOI.THIEU_DU_LIEU;
            }
            else if (v == 1)
            {
                try
                {
                    int loaiKhachHang = (int)cbxLoaiKhachHang.SelectedValue;
                    string tenKhachHang = txtTenKhachHang.Text.ToString();
                    int soDienThoai = Int32.Parse(txtSoDienThoai.Text.ToString());
                    string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
                    int gioitinh;
                    if (rbnNam.Checked)
                    {
                        gioitinh = 1;
                    }
                    else gioitinh = 0;
                    kq = blKhachHang.themKhachHang(txtTenKhachHang.Text, txtSoDienThoai.Text, ngaySinh, gioitinh, loaiKhachHang);
                }
                catch (Exception)
                {
                    kq = BATLOI.SAI_DINH_DANG;
                }
            }
            else
            {
                try
                {
                    int id = Int32.Parse(txtIDKhachHang.Text);
                    int loaiKhachHang = (int)cbxLoaiKhachHang.SelectedValue;
                    string tenKhachHang = txtTenKhachHang.Text.ToString();
                    int soDienThoai = Int32.Parse(txtSoDienThoai.Text.ToString());
                    string ngaySinh = dtpNgaySinh.Value.ToShortDateString();
                    int gioitinh;
                    if (rbnNam.Checked)
                    {
                        gioitinh = 1;
                    }
                    else gioitinh = 0;
                    kq = blKhachHang.CapNhatKhachHang(id, txtTenKhachHang.Text, txtSoDienThoai.Text, ngaySinh, gioitinh, loaiKhachHang);
                }
                catch (Exception)
                {
                    kq = BATLOI.SAI_DINH_DANG;
                }
            }
            if (kq < 0)
            {
                BATLOI.HienThiLoi(kq);
            }
            else { this.Close(); }
        }

        private void FrmTuyChonKhachHang_Load(object sender, EventArgs e)
        {
            blKhachHang = new BL_KhachHang(this);
            blLoaiKhachHang = new BL_LoaiKhachHang(this);
            //Lấy dữ liệu lên combobox Loại khách hàng
            cbxLoaiKhachHang.DataSource = blLoaiKhachHang.LayDanhSachLoaiKhachHang();
            cbxLoaiKhachHang.DisplayMember = "TenLoaiKhachHang";
            cbxLoaiKhachHang.ValueMember = "ID_LoaiKhachHang";
            if (v != 1)
            {
                cbxLoaiKhachHang.SelectedValue = (int)dataGridViewRow.Cells["ID_LOAIKHACHHANG"].Value;
                txtIDKhachHang.Text = dataGridViewRow.Cells["ID_KHACHHANG"].Value.ToString();
                txtTenKhachHang.Text = dataGridViewRow.Cells["TenKhachHang"].Value.ToString();
                txtSoDienThoai.Text = dataGridViewRow.Cells["SDT"].Value.ToString();
                dtpNgaySinh.Value = ((DateTime)dataGridViewRow.Cells["NgaySinh"].Value).Date;
                if (dataGridViewRow.Cells["GioiTinh"].Value.ToString() == "Nam")
                {
                    rbnNam.Checked = true;
                }
                else rbnNU.Checked = true;


            }
        }
    }
}
