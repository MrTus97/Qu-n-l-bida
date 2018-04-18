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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCapBac_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tencapbac = txtTencapbac.Text;
            string hesoluong = txtHesoluong.Text;
            blCapBac.SuaCapBac(tencapbac, hesoluong);
            blCapBac.HienThiCapBac();
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string idcapbac = textEdit1.Text;
            blCapBac.XoaCapBac(idcapbac);
            blCapBac.HienThiCapBac();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tencapbac = txtTencapbac.Text;
            string hesoluong = txtHesoluong.Text;
            string idcapbac = textEdit1.Text;
            blCapBac.SuaCapBac(idcapbac, tencapbac, hesoluong);
            blCapBac.HienThiCapBac();
                

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTencapbac.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtHesoluong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textEdit1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
       
    }
}