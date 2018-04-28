using QuanLyBilliard.BL;
using QuanLyBilliard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI
{
    partial class FrmHoaDon : Form
    {
        BL_HoaDon blHoaDon;
        BL_Ban blBan;
        int idHoaDon;
        bool ketThuc;
        /// <summary>
        /// Tạo ra form hóa đơn và mang theo id_hoadon
        /// </summary>
        /// <param name="id"></param>
        public FrmHoaDon(int id,bool ketThuc)
        {
            InitializeComponent();
            idHoaDon = id;
            this.ketThuc = ketThuc;
            blHoaDon = new BL_HoaDon(this);
            blBan = new BL_Ban(this);
        }


        /// <summary>
        /// Nút thoát form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HienThiHoaDon(int id_hoadon)
        {
            blHoaDon.HienThiHoaDonTrenBill(id_hoadon);
        }

        /// <summary>
        /// Khi load form thì phải hiển thị những thông tin của bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            //Xử lý hiển thị.
            btnThanhToan.Enabled = false;
            if (ketThuc)
            {
                btnThanhToan.Enabled = true;
            }
            
            DataTable data = blHoaDon.LayHoaDonTheoId(idHoaDon);
            Value_SoHD.Text = data.Rows[0]["ID_HOADON"].ToString();
            DateTime giovao = DateTime.Parse(data.Rows[0]["GioVao"].ToString());
            Value_GioVao.Text = giovao.TimeOfDay.ToString();
            DateTime gioRa = DateTime.Now;
            Value_GioRa.Text = gioRa.TimeOfDay.ToString();
            Value_KhangHang.Text = data.Rows[0]["TongGioChoi"].ToString();
            Value_Ban.Text = data.Rows[0]["TenBan"].ToString();
            Value_KhangHang.Text = data.Rows[0]["TenKhachHang"].ToString();
            Value_NhanVien.Text = data.Rows[0]["TenNhanVien"].ToString();
            //Tính tiền giờ:
            int hour = gioRa.Hour - giovao.Hour;
            int minutes = gioRa.Minute - giovao.Minute;
            int gia = Int32.Parse(data.Rows[0]["GIA"].ToString());

            float tienGio = hour * gia + (minutes * gia / 60);

            //Hiển thị trên datagridview
            dataGridView2.Rows.Clear();
            dataGridView2.Rows.Add("Tiền giờ", gia, hour.ToString() +":"+minutes.ToString(), tienGio);
            float tongtien = tienGio;
            DataTable dt = blHoaDon.HienThiThucPhamCoTrongHoaDon(idHoaDon);
            foreach (DataRow row in dt.Rows)
            {
                dataGridView2.Rows.Add(row.ItemArray);
                tongtien += float.Parse(row["ThanhTien"].ToString());
            }
            ValueTongTien.Text = tongtien.ToString();
        }


        /// <summary>
        /// Set trạng thái thành đã thanh toán hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Text == "Thanh Toán")
            {
                int result = blHoaDon.ThanhToan(idHoaDon);
                if (result > 0)
                {
                    MessageBox.Show("Đã thanh toán");
                }
                else
                {
                    MessageBox.Show("Thanh Toán không thành công");
                }
                this.Close();
            }
            else
            {
                blBan.KetThuc(idHoaDon);
            }
        }
    }
}
