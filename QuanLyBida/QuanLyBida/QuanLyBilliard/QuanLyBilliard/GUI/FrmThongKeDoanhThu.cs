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

namespace QuanLyBilliard
{
    public partial class FrmThongKeDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public FrmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void lbQuanLyPhieuXuat_Click(object sender, EventArgs e)
        {

        }

        private void lbThongKePhieuXuat_Click(object sender, EventArgs e)
        {

        }

        private void tsThoat_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Bạn Có Muốn Thoát Không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q.Equals(DialogResult.Yes))
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
        double Tong = 0;
        public double TongTien(DataTable dt)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Tong = Tong + double.Parse(dt.Rows[i][3].ToString());
            }
            return Tong;
        }

       
        private void cbKieuThongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Tong = 0;
            switch (cbKieuThongKe.Text.ToString())
            {
                case "Thống kê ngày ":
                    dtpTuNgay.Value = DateTime.Parse(dt.ToShortDateString());
                    dtpDenNgay.Value = DateTime.Parse(dt.ToShortDateString());
                    break;
                case "Theo tháng":
                    dtpTuNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month, dt.Year));
                    dtpDenNgay.Value = DateTime.Parse(String.Format("{0}/1/{1}", dt.Month + 1, dt.Year));
                    break;
                case "Theo năm":
                    dtpTuNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year));
                    dtpDenNgay.Value = DateTime.Parse(String.Format("1/1/{0}", dt.Year + 1));
                    break;
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmThongKeDoanhThu_Load(object sender, EventArgs e)
        {

        }
    }
}