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

namespace QuanLyBilliard.GUI
{
    public partial class FrmNhanVien : Form
    {
        BL_NhanVien blNhanVien;
        public FrmNhanVien()
        {
            InitializeComponent();
            blNhanVien = new BL_NhanVien(this);
        }

        private void FrmNhanVien2_Load(object sender, EventArgs e)
        {
            cbCapBac.DataSource = blNhanVien.LoadCapBac();
            cbCapBac.DisplayMember = "TENCAPBAC";
            cbCapBac.ValueMember = "ID_CAPBAC";
            radioButton1.Checked = true;
            loadDuLieu();
        }

        private void loadDuLieu()
        {
            DataTable dt = blNhanVien.layDuLieuLenDataGridView();
            dtgNhanVien.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string gt;
                if (row[5].ToString() == "True")
                {
                    gt = "Nam";
                }
                else gt = "Nữ";
                dtgNhanVien.Rows.Add(row[0], row[1], row[2], row[3], row[4],gt, row[6], row[7], row[8]);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tennhanvien = txtTenNhanVien.Text;
            string ngaysinh = dtpNgaySinh.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtSoDienThoai.Text;
            int gioitinh;
            if(radioButton1.Checked)
            {
                gioitinh = 1;
            }
            else
            {
                gioitinh = 0;
            }
            string capbac;
            if (cbCapBac.SelectedValue != null)
            {
                capbac = cbCapBac.SelectedValue.ToString();
            }
            else
            {
                capbac = "NULL";
            }
            
            string email = txtCaTruc.Text;
            int i = blNhanVien.ThemNhanVien(tennhanvien,ngaysinh,cmnd,sdt,gioitinh,capbac, email);
            if (i < 0)
            {
                BATLOI.HienThiLoi(i);
            }
            loadDuLieu();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void X_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textBox1.Text != "")
            {
                string tennhanvien = txtTenNhanVien.Text;
                string ngaysinh = dtpNgaySinh.Text;
                string cmnd = txtCMND.Text;
                string sdt = txtSoDienThoai.Text;
                int gioitinh;
                if (radioButton1.Checked)
                {
                    gioitinh = 1;
                }
                else
                {
                    gioitinh = 0;
                }
                string capbac;
                if (cbCapBac.SelectedValue == null)
                {
                    capbac = "NULL";
                }else
                {
                    capbac = cbCapBac.SelectedValue.ToString();
                }
                
                string email = txtCaTruc.Text;
                blNhanVien.SuaThongTinNhanVien(textBox1.Text, tennhanvien, ngaysinh, cmnd, sdt, gioitinh, capbac, email);
                loadDuLieu();
                textBox1.Text = "";
            }
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(textBox1.Text == "" )
            {
                MessageBox.Show("Ban phải chọn trường cần xóa");
            }
            else
            {
                int i = blNhanVien.XoaNhanVien(textBox1.Text);
                if (i == -1)
                {
                    MessageBox.Show("Xóa không thành công !!");
                }
                loadDuLieu();
            }
            
           
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtgNhanVien.CurrentRow.Cells["IDNhanVien"].Value.ToString();
            txtTenNhanVien.Text = dtgNhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            txtCMND.Text = dtgNhanVien.CurrentRow.Cells["Cmnd"].Value.ToString();
            txtSoDienThoai.Text = dtgNhanVien.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            txtCaTruc.Text = dtgNhanVien.CurrentRow.Cells["Email"].Value.ToString();
            dtpNgaySinh.Text = dtgNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            //cbCapBac.SelectedText = dtgNhanVien.CurrentRow.Cells["CapBac"].Value.ToString();
            cbCapBac.SelectedValue = dtgNhanVien.CurrentRow.Cells["IDCapBac"].Value;
            if (dtgNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString()=="Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sai định dạng", "Thông Báo ");
            }
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sai định dạng", "Thông Báo ");
            }
        }

        private void cbCapBac_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
