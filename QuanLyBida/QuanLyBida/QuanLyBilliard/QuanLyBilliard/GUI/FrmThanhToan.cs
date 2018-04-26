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
    public partial class FrmThanhToan : Form
    {
        BL_HoaDon blHoaDon;
        public FrmThanhToan()
        {
            InitializeComponent();
            blHoaDon = new BL_HoaDon(this);
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            DataTable dt = blHoaDon.HienThiTatCacHoaDon();
            dataGridView1.DataSource = dt;

            //foreach(DataRow row in dt.Rows)
            //{
            //    dataGridView1.Rows.Add(row);
            //}
        }
    }
}
