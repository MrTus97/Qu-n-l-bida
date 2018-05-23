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

namespace QuanLyBilliard.GUI.DANH_MUC.THUCPHAM
{
    public partial class FrmTuyChonMatHang : Form
    {
        private DataGridViewRow dataGridViewRow;
        private int v;
        private BL_ThucPham blThucPham;
        private BL_LoaiThucPham blLoaiThucPham;
        private BL_NhaCungCap blNhaCungCap;
        public FrmTuyChonMatHang(int v)
        {
            InitializeComponent();
            this.v = v;
            this.Text = "THÊM MỚI LOẠI HÀNG";
            txtIDMatHang.Visible = false;
            lbIDMatHang.Visible = false;
        }

        public FrmTuyChonMatHang(int v, DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this.v = v;
            this.dataGridViewRow = dataGridViewRow;
            txtIDMatHang.Enabled = false;
            //Bing dữ liệu 
            


        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            int kq = 0;

            if (txtTenThucPham.Text == "" || txtDonGia.Text == "" || txtDonViTinh.Text =="")
            {
                kq = BATLOI.THIEU_DU_LIEU;
            }
            else if (v == 1)
            {
                try
                {
                    
                    string tenThucPham = txtTenThucPham.Text.ToString();
                    string dvt = txtDonViTinh.Text.ToString();
                    int loaithucpham = (int)cbxLoaiThucPham.SelectedValue;
                    int giaban = Int32.Parse(txtDonGia.Text.ToString());
                    int nhacungcap = (int)cbxNhaCungCap.SelectedValue;
                    kq = blThucPham.ThemMatHang(txtTenThucPham.Text, txtDonViTinh.Text, loaithucpham, txtDonGia.Text, nhacungcap);
                    
                }
                catch (Exception)
                {
                    kq = BATLOI.SAI_DINH_DANG;
                }
                

            }
            else
            {
                int id = Int32.Parse(txtIDMatHang.Text.ToString());
                string tenThucPham = txtTenThucPham.Text.ToString();
                string dvt = txtDonViTinh.Text.ToString();
                int loaithucpham = (int)cbxLoaiThucPham.SelectedValue;
                int giaban = Int32.Parse(txtDonGia.Text.ToString());
                int nhacungcap = (int)cbxNhaCungCap.SelectedValue;
               
                kq = blThucPham.CapNhatMatHang(id,tenThucPham,dvt,loaithucpham,giaban,nhacungcap);
            }

            if (kq == BATLOI.THIEU_DU_LIEU)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
            else if (kq == BATLOI.TRUNG_DU_LIEU)
            {
                MessageBox.Show("Trùng dữ liệu");
            }
            else if (kq < 0)
            {
                MessageBox.Show("Thất bại");
            }
            else
            {
                this.Close();
            }
        }

        private void FrmTuyChonMatHang_Load(object sender, EventArgs e)
        {
            blThucPham = new BL_ThucPham(this);
            blLoaiThucPham = new BL_LoaiThucPham(this);
            blNhaCungCap = new BL_NhaCungCap(this);
            //Load combobox Loại Thực phẩm
            cbxLoaiThucPham.DataSource = blLoaiThucPham.LayDanhSachLoaiThucPham();
            cbxLoaiThucPham.DisplayMember = "TenLoaiThucPham";
            cbxLoaiThucPham.ValueMember = "ID_LOAITHUCPHAM";
            //Load combobox nhà cung cấp
            cbxNhaCungCap.DataSource = blNhaCungCap.LayDuLieuNhaCungCap();
            cbxNhaCungCap.DisplayMember = "TenNhaCungCap";
            cbxNhaCungCap.ValueMember = "ID_NhaCungCap";
            if (v != 1)
            {
                txtIDMatHang.Text = dataGridViewRow.Cells["IDTHUCPHAM"].Value.ToString();
                cbxLoaiThucPham.SelectedValue = Int32.Parse(dataGridViewRow.Cells["ID_LOAITHUCPHAM"].Value.ToString());
                txtTenThucPham.Text = dataGridViewRow.Cells["TenThucPham"].Value.ToString();
                txtDonViTinh.Text = dataGridViewRow.Cells["DonViTinh"].Value.ToString();
                txtDonGia.Text = dataGridViewRow.Cells["GiaBan"].Value.ToString();
                cbxNhaCungCap.SelectedValue = Int32.Parse(dataGridViewRow.Cells["ID_NHACUNGCAP"].Value.ToString());
                
            }
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
