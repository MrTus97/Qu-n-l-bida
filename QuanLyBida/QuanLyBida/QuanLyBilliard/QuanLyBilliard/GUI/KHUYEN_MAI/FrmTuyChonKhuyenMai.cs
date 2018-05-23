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

namespace QuanLyBilliard.GUI.KHUYEN_MAI
{
    public partial class FrmTuyChonKhuyenMai : Form
    {
        BL_KhuyenMai blKhuyenMai;
        public FrmTuyChonKhuyenMai()
        {
            InitializeComponent();
            
        }

        public FrmTuyChonKhuyenMai(string v)
        {
            InitializeComponent();

            
        }

        public FrmTuyChonKhuyenMai(DataGridViewRow dataRow)
        {
            InitializeComponent();
            if (dataRow == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }else
            {
                txtIDKhuyenMai.Text = dataRow.Cells[0].Value.ToString();
                txtTenKhuyenMai.Text = dataRow.Cells[1].Value.ToString();
                txtGiamGiaGio.Text = dataRow.Cells[2].Value.ToString();
                txtGiamGiaThucPham.Text = dataRow.Cells[3].Value.ToString();
                dtpNgayBatDau.Text = dataRow.Cells[4].Value.ToString();
                dtpNgayKetThuc.Text = dataRow.Cells[5].Value.ToString();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id= txtIDKhuyenMai.Text;
            string ten = txtTenKhuyenMai.Text;
            string giamGiaGio = txtGiamGiaGio.Text;
            string giamGiaThucPham = txtGiamGiaThucPham.Text;
            string ngayBatDau = dtpNgayBatDau.Text;
            string ngayKetThuc = dtpNgayKetThuc.Text;
            if (id == "")
            {
                int kq = blKhuyenMai.ThemKhuyenMai(id,ten,giamGiaGio,giamGiaThucPham,ngayBatDau,ngayKetThuc);
                if (kq > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }else
            {
                int kq = blKhuyenMai.SuaKhuyenMai(id, ten, giamGiaGio, giamGiaThucPham, ngayBatDau, ngayKetThuc);
                if (kq > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
        }

        private void FrmTuyChonKhuyenMai_Load(object sender, EventArgs e)
        {
            if (txtIDKhuyenMai.Text == "")
            {
                richTextBox1.Text = "TẠO MỚI KHUYẾN MÃI";
                txtIDKhuyenMai.Visible = false;
                label1.Visible = false;
            }
            else
            {
                richTextBox1.Text = "CHỈNH SỬA THÔNG TIN KHUYẾN MÃI";
                txtIDKhuyenMai.Visible = true;
                txtIDKhuyenMai.Enabled = false;
                label1.Visible = true;
            }
            blKhuyenMai = new BL_KhuyenMai(this);
        }



        private void txtGiamGiaGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Giảm giá giờ là kí tự số ", "Thông Báo ");
            }
        }
    }
}
