using QuanLyBilliard.DA;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    class BL_Ban
    {
        DA_Ban daTable;
        DA_HoaDon daHoaDon;
        FrmSuDungDichVu frmSuDungDichVu;
        FrmChuyenBan frmChuyenBan;
        BL_HoaDon blHoaDon;
        BL_NhanVien blNhanVien;
        BL_KhachHang blKhachHang;
        const int TABLE_WIDTHHEIGHT = 100;
        FrmHoaDon frmHoaDon;
        

        public BL_Ban(FrmSuDungDichVu f)
        {
            daTable = new DA_Ban();
            daHoaDon = new DA_HoaDon();
            blHoaDon = new BL_HoaDon(f);
            blNhanVien = new BL_NhanVien(f);
            blKhachHang = new BL_KhachHang(f);
            frmSuDungDichVu = f;
        }

        public List<Ban> LayBan()
        {
            return daTable.LayBan();
        }

        public BL_Ban(FrmChuyenBan f)
        {
            frmChuyenBan = f;
            daTable = new DA_Ban();
            blHoaDon = new BL_HoaDon(f);
            
        }
        
        public BL_Ban(FrmHoaDon f)
        {
            frmHoaDon = f;
            daTable = new DA_Ban();
        }

       

        internal void ChuyenBan(string v1, string v2)
        {
            int curr = Int32.Parse(v1);
            int taget = Int32.Parse(v2);
            daTable.chuyenBan(curr, taget);
        }

        public int KetThuc(string text)
        {

            int idhoadon = Int32.Parse(text);
            return daTable.TATBAN(idhoadon);
        }
        public int KetThuc(int idhoadon)
        {
            return daTable.TATBAN(idhoadon);
        }

        /// <summary>
        /// Hiển thị tất cả các bàn có trong cơ sở dữ liệu
        /// </summary>
        public void HienThiBan()
        {
            //Xóa hết các bàn hiện tại để tải lại bàn mới
            frmSuDungDichVu.flpBan.Controls.Clear();
            List<Ban> lst = daTable.LayBan();
            foreach (Ban table in lst)
            {
                // Tạo ra các button bàn, các thuộc tính của bàn như text và cách hiển thị màu của nó
                Button btn = new Button() { Width = TABLE_WIDTHHEIGHT, Height = TABLE_WIDTHHEIGHT };
                btn.Text = table.TenBan;
                if (table.TrangThai)
                {
                    btn.BackColor = Color.Aqua;
                }
                else btn.BackColor = Color.Brown;
                //Catch Event
                btn.Click += new EventHandler(btn_Click);
                btn.Tag = table;
                // Add control (as button) in flowLayout
                frmSuDungDichVu.flpBan.Controls.Add(btn);
            }
        }
        /// <summary>
        /// Xử lý khi bấm nút tính tiền
        /// </summary>
        /// <param name="hd"></param>
        /// <param name="idnv"></param>
        /// <param name="kh"></param>
        /// <returns></returns>
        public int KetThuc(HoaDon hd,string idnv,string kh)
        {
            //Chuyển đổi dữ liệu cho phù hợp
            int khachhang = Convert.ToInt32(kh);
            int idNhanVien = Int32.Parse(idnv);

            //Gọi hàm để tính cột tiền giờ
            /*1. Chọn bàn
             *2. Lấy giờ vào
             *3. Lấy giờ hiện tại
             *4. Tính giờ chơi
             *5. Tính tiền
             */
            DateTime giovao = Convert.ToDateTime(daTable.LayGioVao(hd.ID_Ban));
            DateTime gioRa = DateTime.Now;
            int hour = gioRa.Hour - giovao.Hour;
            int minute = gioRa.Minute - giovao.Minute;
            float tiengio = TinhTien(hour, minute);
            //Gọi hàm để tính cột tiền thực phẩm
            int tienthucpham = daHoaDon.TinhTongTienThucPham(hd.ID_HoaDon);
            return daTable.TATBAN(hd,idNhanVien,khachhang,tiengio,tienthucpham);
        }
        /// <summary>
        /// Bật giờ theo id bàn
        /// </summary>
        /// <param name="id"></param>
        public void BatGio(int id)
        {
            daTable.BATBAN(id);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Ban ban = (sender as Button).Tag as Ban;
            frmSuDungDichVu.lbTenBan.Text = ban.TenBan;
            //Lấy 1 button để lưu dữ liệu của 1 bàn khi click vào bàn
            frmSuDungDichVu.btnDaiDienBan.Tag = ban;
            
            frmSuDungDichVu.btnDaiDienBan.Text = ban.TenBan;
            // Khi đã click vào 1 bàn lấy được object bàn thì cũng phải lấy được object hoadon của nó luôn
            //Nếu bàn đã được bật thì mới lấy hóa đơn và show nó lên, còn không thì ko show gì cả
            if (ban.TrangThai)
            {
                float tongtien = 0f;
                DataTable dt = daHoaDon.LayHoaDon(ban);
                HoaDon hoadon = new HoaDon(dt.Rows[0]);
                frmSuDungDichVu.btnHoaDon.Tag = hoadon;
                frmSuDungDichVu.btnHoaDon.Text = hoadon.ID_HoaDon.ToString();
                //Show các mặt hàng có trong hóa đơn và tính tổng tiền
                blHoaDon.ShowBill(hoadon, out tongtien);
                // Show số hóa đơn
                frmSuDungDichVu.txtSoHD.Text = hoadon.ID_HoaDon.ToString();
                //Show ngày lập hóa đơn
                DateTime NgayLapHoaDon = daTable.LayGioVao(ban.ID_Ban);
                frmSuDungDichVu.dtpNgay.Text = NgayLapHoaDon.ToString();
                frmSuDungDichVu.dtBatDau.Text = NgayLapHoaDon.Date.ToShortTimeString();
                //Show tổng tiền
                frmSuDungDichVu.txtTienNuoc.Text = tongtien.ToString();
                frmSuDungDichVu.txtTongCong.Text = tongtien.ToString();
                //Số lượng
                frmSuDungDichVu.cbSoLuong.Text = "1";
                //Nhân viên
                frmSuDungDichVu.cbNhanVien.DataSource = blNhanVien.LayNhanVien();
                frmSuDungDichVu.cbNhanVien.DisplayMember = "TENNHANVIEN";
                frmSuDungDichVu.cbNhanVien.ValueMember = "ID_NHANVIEN";
                //Khách hàng
                frmSuDungDichVu.cbKhachHang.DataSource = blKhachHang.LayKhachHang();
                frmSuDungDichVu.cbKhachHang.DisplayMember = "TENKHACHHANG";
                frmSuDungDichVu.cbKhachHang.ValueMember = "ID_KHACHHANG";
                Enabel(true);
            }
            else
            {
                Enabel(false);
            }
        }

        public float TinhTien(int hour, int minutes)
        {
            float dongia = daTable.LayGiaBan((frmSuDungDichVu.btnDaiDienBan.Tag as Ban).ID_LoaiBan);
            float tiengio = (hour * dongia) + ((float) minutes * dongia/60);
            return tiengio;
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
                frmSuDungDichVu.btnBatDau.Enabled = false;
                frmSuDungDichVu.dtBatDau.Enabled = false;
                frmSuDungDichVu.btnKetThuc.Enabled = true;
                frmSuDungDichVu.dtKetThuc.Enabled = true;
                frmSuDungDichVu.panel4.Enabled = true;
                
            }
            else
            {
                frmSuDungDichVu.txtSoGioChoi.Text = "";
                frmSuDungDichVu.btnBatDau.Enabled = true;
                frmSuDungDichVu.dtBatDau.Enabled = true;
                frmSuDungDichVu.btnKetThuc.Enabled = false;
                frmSuDungDichVu.dtKetThuc.Enabled = false;
                frmSuDungDichVu.panel4.Enabled = false;
                //Xóa dữ liệu ở bàn đang bật đi
                frmSuDungDichVu.txtSoHD.Text = "";
                // Xóa ngày giờ lập hóa đơn
                frmSuDungDichVu.dtpNgay.Text = "";
                frmSuDungDichVu.dtBatDau.Text = "";
                frmSuDungDichVu.dataGridView2.Rows.Clear();
                frmSuDungDichVu.dtBatDau.Text = DateTime.Now.TimeOfDay.ToString();
            }
        }
    }
}
