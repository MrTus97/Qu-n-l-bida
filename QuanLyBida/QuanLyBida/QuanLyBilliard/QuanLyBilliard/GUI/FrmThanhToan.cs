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
            panel1.Visible = false;
            DataTable dt = blHoaDon.HienThiTatCacHoaDon();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["DATHANHTOAN"].Selected)
            {
                
                if (dataGridView1.CurrentRow.Cells["DATHANHTOAN"].Value.ToString() == "True")
                {
                    Console.WriteLine("DA THANH TOAN");
                }else Console.WriteLine("CHUA THANH TOAN");
            }
            else Console.WriteLine("3");

        }



        private void cbLocHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (cbLocHoaDon.Text == "Tất cả")
            {
                panel1.Visible = false;
            }
            else if (cbLocHoaDon.Text == "Hôm nay")
            {
                panel1.Visible = true;
                dtpDenNgay.Visible = false;
                lbDenNgay.Visible = false;
                btnOK.Visible = false;
                lbTuNgay.Text = "Ngày hiện tại";
                dtpTuNgay.Text = DateTime.Now.ToShortDateString();
                dtpTuNgay.Enabled = false;

                DataTable result = blHoaDon.ThongKeHoaDon(dtpTuNgay.Text);
                HienThiHoaDonLenDataGridView(result);
            }
            else
            {
                panel1.Visible = true;

                lbTuNgay.Visible = true;
                lbTuNgay.Text = "Từ ngày";
                dtpTuNgay.Visible = true;
                dtpTuNgay.Enabled = true;
                dtpTuNgay.Text = DateTime.Now.ToShortDateString();

                lbDenNgay.Visible = true;
                lbDenNgay.Text = "Đến ngày";
                dtpDenNgay.Visible = true;
                dtpDenNgay.Text = DateTime.Now.ToShortDateString();

                DataTable result = blHoaDon.ThongKeHoaDon(dtpTuNgay.Text,dtpDenNgay.Text);
                HienThiHoaDonLenDataGridView(result);
            }
        }
        public void HienThiHoaDonLenDataGridView(DataTable result)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in result.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTime tungay = Convert.ToDateTime(dtpTuNgay.Text);
            DateTime denngay = Convert.ToDateTime(dtpDenNgay.Text);

            if (tungay > denngay )
            {

                MessageBox.Show("\"Từ ngày\" không thể lớn hơn \"đến ngày\"");
                dtpTuNgay.Text = dtpDenNgay.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                DataTable result = blHoaDon.ThongKeHoaDon(dtpTuNgay.Text, dtpDenNgay.Text);
                HienThiHoaDonLenDataGridView(result);
            }
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            DateTime tungay = Convert.ToDateTime(dtpTuNgay.Text);
            DateTime denngay = Convert.ToDateTime(dtpDenNgay.Text);
            if (denngay > DateTime.Now.Date)
            {
                MessageBox.Show("\"Đến ngày\" không thể lớn hơn ngày hiện tại của hệ thống");
                dtpDenNgay.Text = DateTime.Now.ToShortDateString();
            }
            else
            if (tungay > denngay)
            {
                MessageBox.Show("\"Từ ngày\" không thể lớn hơn \"đến ngày\"");
                dtpTuNgay.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                DataTable result = blHoaDon.ThongKeHoaDon(dtpTuNgay.Text, dtpDenNgay.Text);
                HienThiHoaDonLenDataGridView(result);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int sohd = Convert.ToInt32(txtIDHoaDon.Text);
                DataTable result = blHoaDon.TimKiemHoaDonShowLenThanhToan(sohd);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại hóa đơn này");
                }
                else
                {
                    HienThiHoaDonLenDataGridView(result);
                }
                
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập vào số hóa đơn");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["DATHANHTOAN"].Selected)
            {
                bool trangthai = !Convert.ToBoolean(dataGridView1.CurrentCell.Value.ToString());
                int sohd = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_HOADON"].Value.ToString());
                blHoaDon.ThanhToanHoaDon(sohd, trangthai);
            }        
        }
    }
}
