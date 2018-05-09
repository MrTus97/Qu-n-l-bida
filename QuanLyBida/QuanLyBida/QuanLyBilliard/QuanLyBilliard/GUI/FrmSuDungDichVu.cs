using DevExpress.XtraEditors;
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
        #region khai báo
        float tongtien = 0;
        BackgroundWorker backgroundWorker1;
        BL_HoaDon blHoaDon;
        BL_Ban blBan;
        BL_LoaiThucPham blLoaiThucPham;
        BL_ThucPham blThucPham;
        BL_NhanVien blNhanVien;
        BL_KhachHang blKhachHang;
        int idBanHienTai;
        const int TABLE_WIDTH = 70;
        const int TABLE_HEIGHT = 120;
        #endregion
        public FrmSuDungDichVu()
        {
            InitializeComponent();
            blBan = new BL_Ban(this);
            blHoaDon = new BL_HoaDon(this);
            blLoaiThucPham = new BL_LoaiThucPham(this);
            blThucPham = new BL_ThucPham(this);
            blNhanVien = new BL_NhanVien(this);
            blKhachHang = new BL_KhachHang(this);
            
        }
        /// <summary>
        /// Khởi chạy background worker - hiển thị bàn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSuDungDichVu_Load(object sender, EventArgs e)
        {
            #region Khai báo cho background
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
            #endregion
            #region Hiển thị những thứ cơ bản khi load form lên
            HienThiBan();
            blLoaiThucPham.LoadLoaiThucPham();
            Enabel(false);
            dtBatDau.Enabled = false;
            btnBatDau.Enabled = false;
            #endregion
        }
        /// <summary>
        /// Hiển thị tất cả các bàn có trong cơ sở dữ liệu
        /// </summary>
        public void HienThiBan()
        {
            //Xóa hết các bàn hiện tại để tải lại bàn mới
            flpBan.Controls.Clear();
            List<Ban> lst = blBan.LayBan();
            foreach (Ban table in lst)
            {
                // Tạo ra các button bàn, các thuộc tính của bàn như text và cách hiển thị màu của nó
                SimpleButton btn = new SimpleButton() { Width = TABLE_WIDTH, Height = TABLE_HEIGHT };
                
                //Set text
                string tenban;
                if (table.TrangThai)
                {
                    tenban = table.TenBan + "\n(ON)";
                }
                else tenban = table.TenBan + "\n(OFF)";
                btn.Text = tenban ;
                //SetColor
                btn.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                btn.LookAndFeel.UseDefaultLookAndFeel = false;
                if (table.TrangThai)
                {
                    btn.Appearance.Image = Properties.Resources.on;
                }
                else btn.Appearance.Image = Properties.Resources.off;


                //Catch Event
                btn.Click += new EventHandler(btn_Click);
                btn.DoubleClick += Btn_DoubleClick;
                btn.ContextMenuStrip = ContextMenuBan;
                btn.Tag = table;

                // Add control (as button) in flowLayout
                flpBan.Controls.Add(btn);

            }
        }



        /// <summary>
        /// Bật bàn hoặc tắt bàn bằng cách double click vào bàn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DoubleClick(object sender, EventArgs e)
        {
            Ban ban = ((sender as SimpleButton).Tag as Ban);
            if (!ban.TrangThai)
            {
                blBan.BatGio(ban.ID_Ban);
                HienThiBan();
                Enabel(true);
            }
            else
            {
                KetThuc();
            }
        }
        /// <summary>
        /// Hiển thị bàn đang click lên thanh detail ở bên phải
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Click(object sender, EventArgs e)
        {
            Ban ban = (sender as SimpleButton).Tag as Ban;
            lbTenBan.Text = ban.TenBan;
            //Lấy 1 button để lưu dữ liệu của 1 bàn khi click vào bàn
            btnDaiDienBan.Tag = ban;
            btnDaiDienBan.Text = ban.TenBan;
            // Khi đã click vào 1 bàn lấy được object bàn thì cũng phải lấy được object hoadon của nó luôn
            //Nếu bàn đã được bật thì mới lấy hóa đơn và show nó lên, còn không thì ko show gì cả
            if (ban.TrangThai)
            {
                float tongtien = 0f;
                DataTable dt = blBan.LayHoaDon(ban);
                HoaDon hoadon = new HoaDon(dt.Rows[0]);
                btnHoaDon.Tag = hoadon;
                btnHoaDon.Text = hoadon.ID_HoaDon.ToString();
                //Show các mặt hàng có trong hóa đơn và tính tổng tiền
                blHoaDon.ShowBill(hoadon, out tongtien);
                // Show số hóa đơn
                txtSoHD.Text = hoadon.ID_HoaDon.ToString();
                //Show ngày lập hóa đơn 
                DateTime NgayLapHoaDon = blBan.LayGioVao(ban.ID_Ban);
                dtpNgay.Text = NgayLapHoaDon.ToString();
                dtBatDau.Text = NgayLapHoaDon.TimeOfDay.ToString("hh");
                dtBatDau.Text += ":";
                dtBatDau.Text += NgayLapHoaDon.TimeOfDay.ToString("mm");
                //tổng tiền
                txtTienNuoc.Text = tongtien.ToString();
                txtTongCong.Text = tongtien.ToString();
                //Số lượng
                cbSoLuong.Text = "1";
                //Nhân viên
                cbNhanVien.DataSource = blNhanVien.LayNhanVien();
                cbNhanVien.DisplayMember = "TENNHANVIEN";
                cbNhanVien.ValueMember = "ID_NHANVIEN";
                //Khách hàng
                cbKhachHang.DataSource = blKhachHang.LayKhachHang();
                cbKhachHang.DisplayMember = "TENKHACHHANG";
                cbKhachHang.ValueMember = "ID_KHACHHANG";
                Enabel(true);
            }
            else
            {
                Enabel(false);
                //Hiển thị giờ hiện tại của hệ thống.
                dtKetThuc.Text = DateTime.Now.TimeOfDay.ToString();
            }
        }
        /// <summary>
        /// Gán các giá trị enable của bàn bật (true) và tắt (false)
        /// </summary>
        /// <param name="v"></param>
        public void Enabel(bool v)
        {
            if (v)
            {
                //Enable
                dataGridView2.Enabled = true;
                btnBatDau.Enabled = false;
                dtBatDau.Enabled = false;
                btnKetThuc.Enabled = true;
                dtKetThuc.Enabled = true;
                panel4.Enabled = true;

            }
            else
            {
                dataGridView2.Enabled = false;
                txtSoGioChoi.Text = "";
                btnBatDau.Enabled = true;
                dtBatDau.Enabled = true;
                btnKetThuc.Enabled = false;
                dtKetThuc.Enabled = false;
                panel4.Enabled = false;
                //Xóa dữ liệu ở bàn đang bật đi
                txtSoHD.Text = "";
                // Xóa ngày giờ lập hóa đơn
                dtpNgay.Text = "";
                dtBatDau.Text = "";
                dataGridView2.Rows.Clear();
                dtBatDau.Text = DateTime.Now.TimeOfDay.ToString();
            }
        }

        /// <summary>
        /// Báo cáo của background woker - tính tổng giờ chơi hiển thị tại hóa đơn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Không hiểu vì sao mà đối tượng bàn lấy được tất cả các giá trị nhưng không lấy được giờ vào, bắt buộc phải truy xuất đến sql
        /// </remarks>
        public void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            if ((btnDaiDienBan.Tag as Ban !=null) && (btnDaiDienBan.Tag as Ban).TrangThai)
            {
                //Thời gian
                DateTime thoiGianHienTai = DateTime.Now;
                DateTime thoiGianBatBan = DateTime.Parse(dtpNgay.Text);
                int minutes = thoiGianHienTai.Minute - thoiGianBatBan.Minute;              
                int hour = thoiGianHienTai.Hour - thoiGianBatBan.Hour;
                int day = thoiGianHienTai.Day - thoiGianBatBan.Day;
                
                //Làm tròn
                if (minutes < 0)
                {
                    //Phút sau nhỏ hơn phút trước
                    minutes = 60 + minutes;
                    if (hour > 0)
                    {
                        hour--;
                    }else
                    {
                        hour = 24 + hour - 1;
                        day--;
                    }
                    //Làm tròn phút để tính tiền
                    if (minutes%10 >=5) minutes = (minutes/10+1)*10;
                }
               
                float tiengio = blBan.TinhTien(day,hour, minutes);
                txtTienGio.Text = tiengio.ToString();

                //Hiển thị
                txtSoGioChoi.Text = hour.ToString() + ":" + minutes.ToString();
                
                txtTongCong.Text = (tiengio + float.Parse(txtTienNuoc.Text)).ToString();
            }
        }
        public void TinhTienGio()
        {

        }

        /// <summary>
        /// Hàm làm việc liên tục của background worker, đây như là một thread riêng biệt
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
        /// Bật giờ - tạo bill  - Hiển thị
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBatDau_Click(object sender, EventArgs e)
        {
            Ban ban = btnDaiDienBan.Tag as Ban;
            blBan.BatGio(ban.ID_Ban);
            HienThiBan();
            Enabel(true);
        }

        /// <summary>
        /// Kết thúc, nghỉ chơi, có thể thanh toán hoặc không
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            KetThuc();
        }

        /// <summary>
        /// Khi bấm kết thúc hoặc click đúp chuột để tắt bàn
        /// </summary>
        public void KetThuc()
        {
            HoaDon hd = btnHoaDon.Tag as HoaDon;
            string nhanvien = cbNhanVien.SelectedValue.ToString();
            string khachhang = cbKhachHang.SelectedValue.ToString();
            string tiengio = txtTienGio.Text;
            string tienthucpham = txtTienNuoc.Text;
            (btnDaiDienBan.Tag as Ban).TrangThai = false;
            blBan.KetThuc(hd, nhanvien, khachhang,tiengio,tienthucpham);
            HienThiBan();
            Enabel(false);
            FrmHoaDon f = new FrmHoaDon(hd.ID_HoaDon, true);
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
            FrmHoaDon f = new FrmHoaDon(hd.ID_HoaDon,false);
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
            idBanHienTai = (btnDaiDienBan.Tag as Ban).ID_Ban;
            FrmChuyenBan f = new FrmChuyenBan(idBanHienTai);
            f.ShowDialog();
            HienThiBan();
        }
        /// <summary>
        /// Thêm món ăn vào hóa đơn bằng thao tác double click vào thực phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnDaiDienBan.Text == "Đại diện bàn")
            {
                MessageBox.Show("Bạn phải chọn bàn trước khi gọi món");
            }else
            if (btnHoaDon.Text == "Đại diện hóa đơn")
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

        /// <summary>
        /// Tìm kiếm thực phẩm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            DataTable dt = blThucPham.TimThucPham(keyword);
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row["TENTHUCPHAM"],row["DVT"],row["GIABAN"],row["ID_THUCPHAM"]);
            }
        }

        private void txtGiamGiaGio_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
