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
    public partial class FrmDanhMucMatHang : DevExpress.XtraEditors.XtraForm
    {
        BL_ThucPham blThucPham;
        BL_NhaCungCap blNhaCungCap;
        public FrmDanhMucMatHang()
        {
            InitializeComponent();
            blThucPham = new BL_ThucPham(this);
            blNhaCungCap = new BL_NhaCungCap(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(cbxLoaiThucPham.Text=="")
            {
                errorProvider1.SetError(cbxLoaiThucPham, "Bạn chưa nhập Loại Thực Phẩm");
            }
            else if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Bạn chưa nhập Đơn Giá");
            }
            else if (txtDonViTinh.Text == "")
            {
                errorProvider1.SetError(txtDonViTinh, "Bạn chưa nhập Đơn Vị Tính");
            }
            else if (txtTenThucPham.Text == "")
            {
                errorProvider1.SetError(txtTenThucPham, "Bạn chưa nhập Tên Thực Phẩm");
            }
            else if (cbxNhaCungCap.Text == "")
            {
                errorProvider1.SetError(cbxNhaCungCap, "Bạn chưa nhập Nhà Cung Cấp");
            }
            else
            {
                
            }
        }
        public void ThemThucPham()
        {
            
        }

        private void cbxLoaiThucPham_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxLoaiThucPham, "");
        }

        private void txtTenThucPham_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenThucPham, "");
        }

        private void txtDonViTinh_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDonViTinh, "");
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtDonGia, "");
        }

        private void cbxNhaCungCap_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxNhaCungCap, "");
        }

      

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                errorProvider1.SetError(txtDonGia, "Bạn chưa nhập Đơn Giá");
            }
            else if (txtDonViTinh.Text == "")
            {
                errorProvider1.SetError(txtDonViTinh, "Bạn chưa nhập Đơn Vị Tính");
            }
            else if (txtTenThucPham.Text == "")
            {
                errorProvider1.SetError(txtTenThucPham, "Bạn chưa nhập Tên Thực Phẩm");
            }
            else
            {
                string nhacungcap = cbxNhaCungCap.SelectedValue.ToString();
                string loaithucpham = cbxLoaiThucPham.SelectedValue.ToString();
                blThucPham.ThemMatHang( txtTenThucPham.Text,txtDonViTinh.Text, loaithucpham, txtDonGia.Text, nhacungcap);
                loadThucPham();

            }
        }

        private void FrmDanhMucMatHang_Load(object sender, EventArgs e)
        {
            blThucPham.loadloaiThucPham();
            blNhaCungCap.loainhacungcap();
            loadThucPham();
            
        }

        private void loadThucPham()
        {
            DataTable dt = blThucPham.layDuLieuLenDataGridView();
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string nhacungcap = cbxNhaCungCap.SelectedValue.ToString();
            string loaithucpham = cbxLoaiThucPham.SelectedValue.ToString();
            blThucPham.CapNhatMatHang(textBox1.Text,txtTenThucPham.Text, txtDonViTinh.Text, loaithucpham, txtDonGia.Text, nhacungcap);
            loadThucPham();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["IDTHUCPHAM"].Value.ToString();
            txtDonGia.Text = dataGridView1.CurrentRow.Cells["GIABAN"].Value.ToString();
            txtDonViTinh.Text = dataGridView1.CurrentRow.Cells["DONVITINH"].Value.ToString();
            txtTenThucPham.Text = dataGridView1.CurrentRow.Cells["TENTHUCPHAM"].Value.ToString();
            cbxLoaiThucPham.SelectedValue = dataGridView1.CurrentRow.Cells["ID_LOAITHUCPHAM"].Value.ToString();
            cbxNhaCungCap.SelectedValue = dataGridView1.CurrentRow.Cells["ID_NhaCungCap"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mặt hàng cần xóa");
            }
            else
            {
                blThucPham.xoaMatHang(textBox1.Text);
            }
            loadThucPham();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDonViTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sai định dạng ", "Thông Báo ");
            }
        }
    }
}