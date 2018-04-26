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
        float tongtien = 0;
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
        /// <summary>
        /// Khởi chạy background worker và hiển thị bàn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSuDungDichVu_Load(object sender, EventArgs e)
        {
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += BackgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += BackgroundWorker1_ProgressChanged;
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }
            blBan.HienThiBan();
            blLoaiThucPham.LoadLoaiThucPham();
            blBan.Enabel(false);
            dtBatDau.Enabled = false;
            btnBatDau.Enabled = false;
            

        }


        /// <summary>
        /// Tính giờ chơi để hiển thị tại hóa đơn
        /// Không hiểu vì sao mà đối tượng bàn lấy được tất cả các giá trị nhưng không lấy được giờ vào, bắt buộc phải truy xuất đến sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            if ((btnDaiDienBan.Tag as Ban !=null) && (btnDaiDienBan.Tag as Ban).TrangThai)
            {
                    DateTime thoiGianHienTai = DateTime.Now;
                    DateTime thoiGianBatBan = DateTime.Parse(dtpNgay.Text);
                    int minutes = thoiGianHienTai.Minute - thoiGianBatBan.Minute;
                    int hour = Math.Abs(thoiGianHienTai.Hour - thoiGianBatBan.Hour);
                    txtSoGioChoi.Text = hour.ToString() + ":" + minutes.ToString();
                    float tiengio = blBan.TinhTien(hour, minutes);
                    txtTienGio.Text = tiengio.ToString();
                    txtTongCong.Text = (tiengio + float.Parse(txtTienNuoc.Text)).ToString();
            }
        }

        /// <summary>
        /// Hàm chạy của background worker
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

        /// <summary>
        /// Bật giờ tạo bill và thay đổi hiển thị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            Ban ban = btnDaiDienBan.Tag as Ban;
            blBan.BatGio(ban.ID_Ban);
            blBan.HienThiBan();
            blBan.Enabel(true);
        }

        /// <summary>
        /// Kết thúc, nghỉ chơi, có thể thanh toán hoặc không
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            HoaDon hd = btnHoaDon.Tag as HoaDon;
            blBan.KetThuc(hd, cbNhanVien.SelectedValue.ToString());
            //Cái này chỉ mới kết thúc tại cơ sở dữ liệu chứ chưa kết thúc tại btnDaiDienBan
            (btnDaiDienBan.Tag as Ban).TrangThai = false;
            blBan.HienThiBan();
            blBan.Enabel(false);
            FrmHoaDon f = new FrmHoaDon(hd.ID_HoaDon);
            //f.HienThiHoaDon(hd.ID_HoaDon);
            f.ShowDialog();
            
        }


        /// <summary>
        /// Thêm thực phẩm vào hóa đơn bằng nút thêm với số lượng ở combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnDaiDienThucPham.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn thực phẩm để thêm");
            }
            else if (cbSoLuong.Text == "0")
            {
                MessageBox.Show("Không thể thêm mặt hàng với số lượng là 0");
            }
            else
            {
                //Trước hết cần phải kiểm tra hàng đó có trong danh sách bill chưa, nếu có rồi thì update số lượng, còn chưa thì mới insert => kiểm tra và làm 1 lần trong csdl
                int id_hoadon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                int soluong = Int32.Parse(cbSoLuong.Text);
                int id_thucpham = Int32.Parse(btnDaiDienThucPham.Text);
                blHoaDon.ThemMatHang(id_hoadon, soluong, id_thucpham);
                blHoaDon.ShowBill((btnHoaDon.Tag as HoaDon), out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }
            
        }


        /// <summary>
        /// Bắt sự kiện khi chọn thực phẩm để tương tác với nó, ở đây là thêm vào hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDaiDienThucPham.Text = dataGridView1.CurrentRow.Cells["ID_THUCPHAM"].Value.ToString();
        }


        /// <summary>
        /// Bắt sự kiện khi click vào thực phẩm đã có trong hóa đơn để tương tác với nó, ở đây là thay đổi số lượng hoặc xóa khỏi hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.CurrentRow;
            btnDaiDienHangHoaDon.Tag = row;
            btnDaiDienHangHoaDon.Text = row.Cells[4].Value.ToString();
        }
        /// <summary>
        /// Xóa thực phẩm ra khỏi hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnDaiDienHangHoaDon.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn món thực phẩm cần xóa");
            }
            else
            {
                string idThucPham = (btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[4].Value.ToString();
                string soluong = (btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[2].Value.ToString();
                int idHoaDon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                blHoaDon.XoaMatHang(idHoaDon, idThucPham, soluong);
                blHoaDon.ShowBill(btnHoaDon.Tag as HoaDon, out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }
        }

        /// <summary>
        /// Đổi số lượng thực phẩm có trong hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnDoiSoLuong_Click(object sender, EventArgs e)
        {
            if (btnDaiDienHangHoaDon.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn món thực phẩm cần sửa số lượng");
            }
            else
            {
               
                string idThucPham = (btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[4].Value.ToString();
                string soluong = (btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[2].Value.ToString();
                int idHoaDon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                //blHoaDon.DoiSoLuong(idHoaDon, idThucPham, soluong);

                FrmDoiSoLuong f = new FrmDoiSoLuong(idThucPham, soluong, idHoaDon);

                f.ShowDialog();
                
                blHoaDon.ShowBill(btnHoaDon.Tag as HoaDon, out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }

        }

        /// <summary>
        /// Tăng số lượng thực phẩm lên 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (btnDaiDienHangHoaDon.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn món thực phẩm cần sửa số lượng");
            }
            else
            {
                int idThucPham = Convert.ToInt32((btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[4].Value.ToString());
                int idHoaDon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                int soluong = Convert.ToInt32((btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[2].Value.ToString());

                blHoaDon.DoiSoLuong(idHoaDon, idThucPham,soluong+ 1);
                blHoaDon.ShowBill(btnHoaDon.Tag as HoaDon, out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }
        }

        /// <summary>
        /// Giảm số lượng thực phẩm xuống 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (btnDaiDienHangHoaDon.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn món thực phẩm cần sửa số lượng");
            }
            else if (dataGridView2.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                MessageBox.Show("Không thể giảm mặt hàng này vì số lượng còn 1");
            }
            else
            {
                int soluong = Convert.ToInt32((btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[2].Value.ToString());

                int idThucPham = Convert.ToInt32((btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[4].Value.ToString());
                int idHoaDon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                blHoaDon.DoiSoLuong(idHoaDon, idThucPham, soluong-1);
                blHoaDon.ShowBill(btnHoaDon.Tag as HoaDon, out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }
        }


        /// <summary>
        /// In thử bill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void simpleButton3_Click(object sender, EventArgs e)
        {
            
            HoaDon hd = btnHoaDon.Tag as HoaDon;
            FrmHoaDon f = new FrmHoaDon(hd.ID_HoaDon);
            string nhanvien = cbNhanVien.SelectedValue.ToString();
            string khachhang = cbKhachHang.SelectedValue.ToString();
            blHoaDon.GanGiaTriInThuBill(hd.ID_HoaDon,nhanvien, khachhang);
            f.ShowDialog();
        }
        /// <summary>
        /// Hiển thị các hóa đơn đã được tạo và đã kết thúc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btnThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan f = new FrmThanhToan();
            f.ShowDialog();
        }


        /// <summary>
        /// Không có ý nghĩa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChuyenBan_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("VL");
        }


        /// <summary>
        /// Chuyển bàn này sang bàn khác
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            FrmChuyenBan f = new FrmChuyenBan();
            f.ShowDialog();
            blBan.HienThiBan();
        }


        /// <summary>
        /// Thêm món ăn vào hóa đơn bằng thao tác double click vào thực phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnHoaDon.Text == "")
            {
                MessageBox.Show("Bạn phải bật bàn trước khi gọi món");
            }else
            {
                btnDaiDienThucPham.Text = dataGridView1.CurrentRow.Cells["ID_THUCPHAM"].Value.ToString();
                int id_hoadon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                int soluong = 1;
                int id_thucpham = Int32.Parse(btnDaiDienThucPham.Text);
                blHoaDon.ThemMatHang(id_hoadon, soluong, id_thucpham);
                blHoaDon.ShowBill((btnHoaDon.Tag as HoaDon), out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }
            
        }
    }
}
