using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBilliard.BL;

namespace QuanLyBilliard.GUI
{
    public partial class FrmDanhMucKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BL_KhachHang blKhachHang;
        public FrmDanhMucKhachHang()
        {
            InitializeComponent();
            blKhachHang = new BL_KhachHang(this);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKhachHang.Text == "")
            {
                errorProvider1.SetError(txtTenKhachHang, "Bạn chưa nhập Tên Khách Hàng");
            }
            else if (txtSoDienThoai.Text == "")
            {
                errorProvider1.SetError(txtSoDienThoai, "Bạn chưa nhập Số Điện Thoại");
            }
            
            else
            {
                int gioitinh;
                if (rbnNam.Checked)
                {
                    gioitinh = 1;
                }
                else gioitinh = 0;
                string loaikhachhang = cbxLoaiKhachHang.SelectedValue.ToString();
                string ngaysinh = dtpNgaySinh.Text.ToString();
                blKhachHang.themKhachHang( txtTenKhachHang.Text, txtSoDienThoai.Text,ngaysinh,gioitinh, loaikhachhang);
                dataGridView1.DataSource = blKhachHang.HienThiDuLieu();
            }
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenKhachHang, "");
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtSoDienThoai, "");
        }

        private void FrmDanhMucKhachHang_Load(object sender, EventArgs e)
        {
            blKhachHang.loadLoaiKhachHang();
            dataGridView1.DataSource = blKhachHang.HienThiDuLieu();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            int gioitinh;
            if (rbnNam.Checked)
            {
                gioitinh = 1;
            }
            else gioitinh = 0;
            string loaikhachhang = cbxLoaiKhachHang.SelectedValue.ToString();
            string ngaysinh = dtpNgaySinh.Text.ToString();
            blKhachHang.CapNhatKhachHang(textBox1.Text, txtTenKhachHang.Text, txtSoDienThoai.Text, ngaysinh, gioitinh, loaikhachhang);
            dataGridView1.DataSource = blKhachHang.HienThiDuLieu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["ID_KHACHHANG"].Value.ToString();
            txtSoDienThoai.Text = dataGridView1.CurrentRow.Cells["SODIENTHOAI"].Value.ToString();
            txtTenKhachHang.Text = dataGridView1.CurrentRow.Cells["Tenkhachhang"].Value.ToString();
            dtpNgaySinh.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cbxLoaiKhachHang.Text = dataGridView1.CurrentRow.Cells["ID_LOAIKHACHHANG"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" )
            {
                MessageBox.Show("Bạn phải chọn trường cần xóa");
            }
            else
            {
                blKhachHang.xoaKhachHang(textBox1.Text);
            }
            dataGridView1.DataSource = blKhachHang.HienThiDuLieu();
        }
    }
}