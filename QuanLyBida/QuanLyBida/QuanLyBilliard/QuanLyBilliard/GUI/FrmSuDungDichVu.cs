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
                    //DateTime thoiGianBatBan = 
                    //int second = Math.Abs(thoiGianHienTai.Second - thoiGianBatBan.Second);
                    int minutes = thoiGianHienTai.Minute - thoiGianBatBan.Minute;
                    int hour = Math.Abs(thoiGianHienTai.Hour - thoiGianBatBan.Hour);
                    txtSoGioChoi.Text = hour.ToString() + ":" + minutes.ToString();
                    float tiengio = blBan.TinhTien(hour, minutes);
                    txtTienGio.Text = tiengio.ToString();
                    txtTongCong.Text = (tiengio + float.Parse(txtTienNuoc.Text)).ToString();
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
            blBan.HienThiBan();
            blBan.Enabel(true);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            HoaDon hd = btnHoaDon.Tag as HoaDon;
            blBan.KetThuc(hd, cbNhanVien.SelectedValue.ToString());
            //Cái này chỉ mới kết thúc tại cơ sở dữ liệu chứ chưa kết thúc tại btnDaiDienBan
            (btnDaiDienBan.Tag as Ban).TrangThai = false;
            blBan.HienThiBan();
            blBan.Enabel(false);
            FrmHoaDon f = new FrmHoaDon();
            f.HienThiHoaDon(hd.ID_HoaDon);
            f.ShowDialog();
            
        }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDaiDienThucPham.Text = dataGridView1.CurrentRow.Cells["ID_THUCPHAM"].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.CurrentRow;
            btnDaiDienHangHoaDon.Tag = row;
            btnDaiDienHangHoaDon.Text = row.Cells[4].Value.ToString();
        }

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

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Thực hiện đổi số lượng (với sl = combobox số lượng)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDoiSoLuong_Click(object sender, EventArgs e)
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
                blHoaDon.DoiSoLuong(idHoaDon, idThucPham, soluong);
                blHoaDon.ShowBill(btnHoaDon.Tag as HoaDon, out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }
            
        }
        /// <summary>
        /// Thực hiện như đổi số lượng (với sl=1)
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
                string idThucPham = (btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[4].Value.ToString();
                int idHoaDon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                blHoaDon.DoiSoLuong(idHoaDon, idThucPham, "1");
                blHoaDon.ShowBill(btnHoaDon.Tag as HoaDon, out tongtien);
                txtTienNuoc.Text = tongtien.ToString();
            }
        }
        /// <summary>
        /// Thực hiện như đổi số lượng (với sl = -1)
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
                string idThucPham = (btnDaiDienHangHoaDon.Tag as DataGridViewRow).Cells[4].Value.ToString();
                int idHoaDon = (btnHoaDon.Tag as HoaDon).ID_HoaDon;
                blHoaDon.DoiSoLuong(idHoaDon, idThucPham, "-1");
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
            FrmHoaDon f = new FrmHoaDon();
            f.btnThanhToan.Text = "Kết thúc";
            HoaDon hd = btnHoaDon.Tag as HoaDon;
            blHoaDon.GanGiaTriInThuBill(hd.ID_HoaDon,cbNhanVien.SelectedValue.ToString(), cbKhachHang.SelectedValue.ToString());
            f.HienThiHoaDon(hd.ID_HoaDon);
            f.ShowDialog();
        }

        public void btnThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan f = new FrmThanhToan();
            f.ShowDialog();

        }

        private void btnChuyenBan_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("VL");
        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            FrmChuyenBan f = new FrmChuyenBan();
            f.ShowDialog();
            blBan.HienThiBan();
        }

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
