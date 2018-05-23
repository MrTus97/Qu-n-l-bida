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
    public partial class FrmCapBac : DevExpress.XtraEditors.XtraForm
    {
        BL_CapBac blCapBac;
        public FrmCapBac()
        {
            InitializeComponent();
            blCapBac = new BL_CapBac(this);
            DataTable result = blCapBac.LayDanhSachCapBac();
            RefeshCapBac(result);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTencapbac.Text = dgvCapBac.CurrentRow.Cells[1].Value.ToString();
            txtHesoluong.Text = dgvCapBac.CurrentRow.Cells[2].Value.ToString();
            textEdit1.Text = dgvCapBac.CurrentRow.Cells[0].Value.ToString();
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tencapbac = txtTencapbac.Text;
            string hesoluong = txtHesoluong.Text;
            int kq = blCapBac.ThemCapBac(tencapbac, hesoluong);
            if (kq < 0)
            {
                MessageBox.Show("Thất bại !!");
            }
            DataTable result = blCapBac.LayDanhSachCapBac();
            RefeshCapBac(result);
        }

        private void RefeshCapBac(DataTable result)
        {
            dgvCapBac.Rows.Clear();
            foreach(DataRow row in result.Rows)
            {
                dgvCapBac.Rows.Add(row.ItemArray);
            }
        }

        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idcapbac = textEdit1.Text;
            int i = blCapBac.XoaCapBac(idcapbac);
            if (i < 0)
            {
                MessageBox.Show("Không thể xóa!!");
            }
            DataTable result = blCapBac.LayDanhSachCapBac();
            RefeshCapBac(result);
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tencapbac = txtTencapbac.Text;
            string hesoluong = txtHesoluong.Text;
            string idcapbac = textEdit1.Text;
            int kq = blCapBac.SuaCapBac(idcapbac, tencapbac, hesoluong);
            if (kq < 0)
            {
                MessageBox.Show("Thất bại !!!");
            }
            else
            {
                txtTencapbac.Text = "";
                txtHesoluong.Text = "";
            }
            DataTable result = blCapBac.LayDanhSachCapBac();
            RefeshCapBac(result);
        }
    }
}