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
        /// <summary>
        /// Hiển thị tất cả các hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            cbLocHoaDon.Text = "Tất cả";
            DataTable result = blHoaDon.HienThiTatCacHoaDon();
            HienThiHoaDonLenDataGridView(result);
        }
        /// <summary>
        /// Hàm test cellclick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Hiển thị lại hóa đơn khi có sự thay đổi về tùy chọn lọc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbLocHoaDon_TextChanged(object sender, EventArgs e)
        {
            //Chọn tất cả
            if (cbLocHoaDon.Text == "Tất cả")
            {
                panel1.Visible = false;
                DataTable result = blHoaDon.HienThiTatCacHoaDon();
                HienThiHoaDonLenDataGridView(result);
            }
            //Lọc theo ngày hiện tại
            else if (cbLocHoaDon.Text == "Hôm nay")
            {
                panel1.Visible = true;
                dtpDenNgay.Visible = false;
                lbDenNgay.Visible = false;
                
                lbTuNgay.Text = "Ngày hiện tại";
                dtpTuNgay.Text = DateTime.Now.ToShortDateString();
                dtpTuNgay.Enabled = false;

                DataTable result = blHoaDon.ThongKeHoaDon(dtpTuNgay.Text,dtpTuNgay.Text);
                HienThiHoaDonLenDataGridView(result);
            }
            // Lọc từ ngày này đến ngày kia
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

        /// <summary>
        /// Hiển thị dữ liệu từ bảng result lên datagridview
        /// </summary>
        /// <param name="result">DataTable lấy từ csdl</param>
        public void HienThiHoaDonLenDataGridView(DataTable result)
        {
            float tongTienGio = 0;
            float tongGiamGiaGio = 0;
            float tienThucPham = 0;
            float giamGiaThucPham = 0;
            float tongTien = 0;
            dataGridView1.Rows.Clear();
            foreach (DataRow row in result.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
                if (row[4].ToString() != "")
                    tongTienGio += float.Parse(row[4].ToString());
                if (row[5].ToString() != "") 
                tongGiamGiaGio += float.Parse(row[5].ToString());
                if (row[6].ToString() != "")
                    tienThucPham += float.Parse(row[6].ToString());
                if (row[7].ToString() != "")
                    giamGiaThucPham += float.Parse(row[7].ToString());
                if (row[8].ToString() != "")
                    tongTien += float.Parse(row[8].ToString());
            }
            dataGridView1.Rows.Add("", "", "", "Tổng tiền", tongTienGio, tongGiamGiaGio, tienThucPham, giamGiaThucPham, tongTien,null);
        }

        /// <summary>
        /// Hiển thị lại datagridview khi thay đổi dữ liệu của dtpTuNgay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Hiển thị lại datagridview khi thay đổi dữ liệu của dtpDenNgay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Tìm hóa đơn có số hóa đơn nằm trong textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int sohd = Convert.ToInt32(txtIDHoaDon.Text);
                DataTable result = blHoaDon.TimKiemHoaDonShowLenThanhToan(sohd);
                if (result.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại hóa đơn này hoặc nhập sai kiểu dữ liệu");
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

        /// <summary>
        /// Thay đổi trạng thái thanh toán của một hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <example> 
        /// Hóa đơn 50 đang trạng thái đã thanh toán có checkbox selected = true
        /// Bỏ chọn checkbox selected = false
        /// => Thay đổi trong cơ sở dữ liệu là hóa đơn đó chưa được thanh toán
        /// </example>
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
