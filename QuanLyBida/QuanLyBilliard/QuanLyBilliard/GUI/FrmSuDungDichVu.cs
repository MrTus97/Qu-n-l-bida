using QuanLyBilliard.BL;
using QuanLyBilliard.DTO;
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
    public partial class FrmSuDungDichVu : Form
    {
        BackgroundWorker backgroundWorker1;
        BL_HoaDon blHoaDon;
        BL_Ban blBan;
        BL_LoaiThucPham blLoaiThucPham;
        public FrmSuDungDichVu()
        {
            InitializeComponent();
            blBan = new BL_Ban(this);
            blHoaDon = new BL_HoaDon(this);
            blLoaiThucPham = new BL_LoaiThucPham(this);
            
        }

        private void FrmSuDungDichVu_Load(object sender, EventArgs e)
        {
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            //if (backgroundWorker1.IsBusy != true)
            //{
            //    // Start the asynchronous operation.
            //    backgroundWorker1.RunWorkerAsync();
            //}
            blBan.HienThiBan();
            blLoaiThucPham.LoadLoaiThucPham();
            

        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            if ((btnDaiDienBan.Tag as Ban !=null) && (btnDaiDienBan.Tag as Ban).TrangThai)
            {
                DateTime thoiGianHienTai = DateTime.Now;
                DateTime thoiGianBatBan = (btnDaiDienBan.Tag as Ban).GioVao;
                int second = Math.Abs(thoiGianHienTai.Second - thoiGianBatBan.Second);
                int minutes = Math.Abs(thoiGianHienTai.Minute - thoiGianBatBan.Minute);
                int hour = Math.Abs(thoiGianHienTai.Hour - thoiGianBatBan.Hour);
                txtSoGioChoi.Text = hour.ToString() + ":" + minutes.ToString() + ":" + second.ToString();
            }
        }
        /// <summary>
        /// Hàm luôn chạy của background woker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(1);
                }
            }
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            Ban ban = btnDaiDienBan.Tag as Ban;
            blBan.BatGio(ban);
            //backgroundWorker1.RunWorkerAsync();
            blBan.HienThiBan();
            blBan.Enabel(true);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Ban ban = btnDaiDienBan.Tag as Ban;
            HoaDon hd = btnHoaDon.Tag as HoaDon;
            blBan.KetThuc(ban, hd);
            blBan.HienThiBan();
            blBan.Enabel(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            float tongtien = 0;
            //Trước hết cần phải kiểm tra hàng đó có trong danh sách bill chưa, nếu có rồi thì update số lượng, còn chưa thì mới insert => kiểm tra và làm 1 lần trong csdl
            int id_hoadon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
            int soluong = Int32.Parse(cbSoLuong.Text);
            int id_thucpham = Int32.Parse(btnDaiDienThucPham.Text);
            blHoaDon.ThemMatHang(id_hoadon, soluong, id_thucpham);
            blHoaDon.ShowBill((btnHoaDon.Tag as HoaDon), out tongtien);
            txtTienNuoc.Text = tongtien.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDaiDienThucPham.Text = dataGridView1.CurrentRow.Cells["ID_THUCPHAM"].Value.ToString();
        }
        
        

    }
}
