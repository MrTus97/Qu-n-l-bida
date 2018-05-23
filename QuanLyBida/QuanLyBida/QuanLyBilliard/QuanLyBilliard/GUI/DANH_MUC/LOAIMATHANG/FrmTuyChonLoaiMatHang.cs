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
    public partial class FrmTuyChonLoaiMatHang : Form
    {
        private BL_LoaiThucPham blLoaiThucPham;
        private DataGridViewRow dataGridViewRow;
        private int v;


        public FrmTuyChonLoaiMatHang(int v)
        {
            InitializeComponent();
            this.v = v;
            this.Text = "THÊM MỚI LOẠI HÀNG";
            txtIDLoaiMatHang.Visible = false;
            lbIDLoaiMatHang.Visible = false;
        }

        public FrmTuyChonLoaiMatHang(int v, DataGridViewRow dataGridViewRow)
        {
            InitializeComponent();
            this.Text = "CẬP NHẬT LOẠI HÀNG";
            this.v = v;
            this.dataGridViewRow = dataGridViewRow;
            txtIDLoaiMatHang.Enabled = false;
            //bing dữ liệu
            txtIDLoaiMatHang.Text = dataGridViewRow.Cells["ID_LOAITHUCPHAM"].Value.ToString();
            txtTenLoaiMatHang.Text = dataGridViewRow.Cells["TENLOAITHUCPHAM"].Value.ToString();
        }


        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            int kq;
            if (txtTenLoaiMatHang.Text == "")
            {
                kq = -1;
            }
            else if (v == 1)
            {
                    kq = blLoaiThucPham.ThemLoaiThucPham(txtTenLoaiMatHang.Text);
                
            }else
            {
                kq =blLoaiThucPham.SuaLoaiThucPham(Int32.Parse(txtIDLoaiMatHang.Text), txtTenLoaiMatHang.Text);
            }

            if (kq == -1)
            {
                MessageBox.Show("Chưa nhập đủ dữ liệu");
            }
            else if (kq == -2)
            {
                MessageBox.Show("Trùng dữ liệu");
            }
            else if (kq < 0)
            {
                MessageBox.Show("Thất bại");
            }else
            {
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTuyChonLoaiMatHang_Load(object sender, EventArgs e)
        {
            blLoaiThucPham = new BL_LoaiThucPham(this);
        }
    }
}
