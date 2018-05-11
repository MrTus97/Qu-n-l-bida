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
            cbCapBac.DisplayMember = "TenCapBac";
            cbCapBac.ValueMember = "ID_CapBac";
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
            string capbac = cbCapBac.SelectedValue.ToString();
            string catruc = txtCaTruc.Text;
            blNhanVien.ThemNhanVien(tennhanvien,ngaysinh,cmnd,sdt,gioitinh,capbac,catruc);
            loadDuLieu();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void X_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            string capbac = cbCapBac.SelectedValue.ToString();
            string catruc = txtCaTruc.Text;
            blNhanVien.SuaThongTinNhanVien(textBox1.Text,tennhanvien, ngaysinh, cmnd, sdt, gioitinh, capbac, catruc);
            loadDuLieu();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if(textBox1.Text == "" )
            {
                MessageBox.Show("Ban phải chọn trường cần xóa");
            }
            else
            blNhanVien.XoaNhanVien(textBox1.Text);
            loadDuLieu();

        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dtgNhanVien.CurrentRow.Cells["IDNhanVien"].Value.ToString();
            txtTenNhanVien.Text = dtgNhanVien.CurrentRow.Cells["TenNhanVien"].Value.ToString();
            txtCMND.Text = dtgNhanVien.CurrentRow.Cells["Cmnd"].Value.ToString();
            txtSoDienThoai.Text = dtgNhanVien.CurrentRow.Cells["SoDienThoai"].Value.ToString();
            txtCaTruc.Text = dtgNhanVien.CurrentRow.Cells["CaTruc"].Value.ToString();
            dtpNgaySinh.Text = dtgNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            cbCapBac.Text = dtgNhanVien.CurrentRow.Cells["IDCapBac"].Value.ToString();
            if (dtgNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString()=="Nam")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }
    }
}
