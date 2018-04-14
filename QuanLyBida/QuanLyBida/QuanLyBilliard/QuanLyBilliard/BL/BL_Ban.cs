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
        const int TABLE_WIDTHHEIGHT = 100;
        public BL_Ban(FrmSuDungDichVu f)
        {
            daTable = new DA_Ban();
            daHoaDon = new DA_HoaDon();
            blHoaDon = new BL_HoaDon(f);
            frmSuDungDichVu = f;
        }
        public BL_Ban(FrmChuyenBan f)
        {
            frmChuyenBan = f;
            daTable = new DA_Ban();
            blHoaDon = new BL_HoaDon(f);
            
        }

        internal void ChuyenBan(string v1, string v2)
        {
            int curr = Int32.Parse(v1);
            int taget = Int32.Parse(v2);
            daTable.chuyenBan(curr, taget);
        }

        /// <summary>
        /// Hiển thị lại bàn khi có sự thay đổi
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
        public void HienThiBanTat()
        {
            frmChuyenBan.flpBanTat.Controls.Clear();
            List<Ban> lst = daTable.LayBan();
            List<Ban> chuabat = new List<Ban>();
            List<Ban> batroi = new List<Ban>();
            foreach (Ban table in lst)
            {
                // Tạo ra các button bàn, các thuộc tính của bàn như text và cách hiển thị màu của nó
                if (!table.TrangThai)
                {
                    chuabat.Add(table);
                    Button btn = new Button() { Width = TABLE_WIDTHHEIGHT, Height = TABLE_WIDTHHEIGHT };
                    btn.Text = table.TenBan;
                    btn.BackColor = Color.Brown;
                    btn.Click += new EventHandler(btnChonBanChuyen_Click);

                    btn.Tag = table;
                    frmChuyenBan.flpBanTat.Controls.Add(btn);  
                }
                else
                {
                    batroi.Add(table);
                }
            }
            frmChuyenBan.cbBanChuyen.DataSource = chuabat;
            frmChuyenBan.cbBanChuyen.DisplayMember = "TenBan";
            frmChuyenBan.cbBanChuyen.ValueMember = "ID_Ban";

            frmChuyenBan.cbBanHienTai.DataSource = batroi;
            
            frmChuyenBan.cbBanHienTai.DisplayMember = "TenBan";
            frmChuyenBan.cbBanHienTai.ValueMember = "ID_Ban";
            //frmChuyenBan.cbBanHienTai.SelectedValue = (frmSuDungDichVu.btnDaiDienBan.Tag as Ban).ID_Ban;

        }

        public void btnChonBanChuyen_Click(object sender, EventArgs e)
        {
            frmChuyenBan.cbBanChuyen.Text = "";
            frmChuyenBan.cbBanChuyen.SelectedValue = ((sender as Button).Tag as Ban).ID_Ban;
            //frmChuyenBan.cbBanChuyen.SelectedText = ((sender as Button).Tag as Ban).TenBan;
        }

        public void KetThuc(Ban ban, HoaDon hd)
        {
            daTable.TATBAN(ban, hd);
        }

        public void BatGio(Ban ban)
        {
            daTable.BATBAN(ban);
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
                //Show bill thực chất là show datagridview
                blHoaDon.ShowBill(hoadon, out tongtien);

                frmSuDungDichVu.txtSoHD.Text = hoadon.ID_HoaDon.ToString();
                DateTime NgayLapHoaDon = daTable.LayGioVao(ban.ID_Ban);
                frmSuDungDichVu.dtpNgay.Text = NgayLapHoaDon.ToString();
                frmSuDungDichVu.dtBatDau.Text = NgayLapHoaDon.Date.ToShortTimeString();
                frmSuDungDichVu.txtTienNuoc.Text = tongtien.ToString();
                frmSuDungDichVu.txtTongCong.Text = tongtien.ToString();
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
            float tiengio = (hour * dongia) + (minutes / 60 * dongia);
            return tiengio;
        }

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
                frmSuDungDichVu.btnThanhToan.Enabled = false;
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
