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
        public FrmHoaDon()
        {
            InitializeComponent();
            blHoaDon = new BL_HoaDon(this);
            blBan = new BL_Ban(this);

        }
        public FrmHoaDon(HoaDon hd)
        {

        }

        public void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HienThiHoaDon(int id_hoadon)
        {
            blHoaDon.HienThiHoaDonTrenBill(id_hoadon);
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (btnThanhToan.Text == "Thanh Toán")
            {
                int result = blHoaDon.ThanhToan(Value_SoHD.Text);
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
                blBan.KetThuc(Value_SoHD.Text);
            }
        }
    }
}
