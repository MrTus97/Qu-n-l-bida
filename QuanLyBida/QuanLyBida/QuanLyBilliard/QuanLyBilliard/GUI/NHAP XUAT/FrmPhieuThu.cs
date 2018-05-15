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
    public partial class FrmPhieuThu : Form
    {
        BL_PhieuThu blPhieuThu;
        public FrmPhieuThu()
        {
            InitializeComponent();
            blPhieuThu = new BL_PhieuThu(this);
        }

        private void FrmPhieuThu_Load(object sender, EventArgs e)
        {
            DataTable result = blPhieuThu.LayDuLieuPhieuThu();
            RefeshDgvPhieuThu(result);
        }

        private void RefeshDgvPhieuThu(DataTable result)
        {
            dgvPhieuThu.Rows.Clear();
            foreach(DataRow r in result.Rows)
            {
                dgvPhieuThu.Rows.Add(r.ItemArray);
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTuyChonPhieuThu f = new FrmTuyChonPhieuThu();
            f.ShowDialog();
        }
    }
}
