using System;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI;
using System.Data;
using QuanLyBilliard.DA;

namespace QuanLyBilliard.BL
{
    class BL_HoaDon
    {
        FrmSuDungDichVu frmSuDungDichVu;
        FrmChuyenBan frmChuyenBan;
        FrmHoaDon frmHoaDon;
        FrmDoiSoLuong frmDoiSoLuong;
        DA_HoaDon daHoaDon = new DA_HoaDon();
        FrmThanhToan frmThanhToan;

        public BL_HoaDon(FrmThanhToan f)
        {
            this.frmThanhToan = f;
        }
        public BL_HoaDon(FrmDoiSoLuong f)
        {
            this.frmDoiSoLuong = f;
            
        }
        /// <summary>
        /// Chọn tất cả các hóa đơn
        /// </summary>
        /// <returns></returns>
        public DataTable HienThiTatCacHoaDon()
        {
            return daHoaDon.HienThiTatCaCacHoaDon();
        }

        public BL_HoaDon(FrmSuDungDichVu f)
        {
            this.frmSuDungDichVu = f;
        }
        public BL_HoaDon(FrmChuyenBan f)
        {
            frmChuyenBan = f;
        }
        public BL_HoaDon(FrmHoaDon f)
        {
            frmHoaDon = f;
        }

        public void ShowBill(HoaDon hd, out float tongtien)
        {
            DataTable dt = daHoaDon.showBill(hd.ID_HoaDon);
            frmSuDungDichVu.dataGridView2.Rows.Clear();
            tongtien = 0f;
            foreach (DataRow row in dt.Rows)
            {
                frmSuDungDichVu.dataGridView2.Rows.Add(row.ItemArray);
                tongtien += float.Parse(row["ThanhTien"].ToString());
            }
            
        }

        public DataTable LayHoaDonTheoId(int idHoaDon)
        {
            return daHoaDon.LayHoaDon(idHoaDon);
        }

        public int ThanhToan(int id)
        {
            return daHoaDon.ThanhToan(id);
        }

        public void HienThiHoaDonTrenBill(int id_hoadon)
        {
            
            DataTable data = daHoaDon.LayHoaDon(id_hoadon);
            frmHoaDon.Value_SoHD.Text = data.Rows[0]["ID_HOADON"].ToString();
            DateTime giovao = DateTime.Parse(data.Rows[0]["GioVao"].ToString());
            frmHoaDon.Value_GioVao.Text = giovao.TimeOfDay.ToString();
            frmHoaDon.Value_GioRa.Text = DateTime.Now.TimeOfDay.ToString();
            frmHoaDon.Value_KhangHang.Text = data.Rows[0]["TongGioChoi"].ToString();
            frmHoaDon.Value_Ban.Text = data.Rows[0]["TenBan"].ToString();
            frmHoaDon.Value_KhangHang.Text = data.Rows[0]["TenKhachHang"].ToString();
            frmHoaDon.Value_NhanVien.Text = data.Rows[0]["TenNhanVien"].ToString();
            //Tính tiền giờ:

            DateTime tonggiochoi = DateTime.Parse(data.Rows[0]["TongGioChoi"].ToString());
            int gia = Int32.Parse(data.Rows[0]["GIA"].ToString());
            float tienGio = tonggiochoi.Hour * gia + (tonggiochoi.Minute * gia / 60);
            
            //Hiển thị trên datagridview
            DataTable dt = daHoaDon.showBill(id_hoadon);
            frmHoaDon.dataGridView2.Rows.Clear();
            frmHoaDon.dataGridView2.Rows.Add("Tiền giờ", data.Rows[0]["GIA"].ToString(), tonggiochoi.TimeOfDay, tienGio);
            float tongtien = tienGio;
            foreach (DataRow row in dt.Rows)
            {
                frmHoaDon.dataGridView2.Rows.Add(row.ItemArray);
                tongtien += float.Parse(row["ThanhTien"].ToString());
            }

            frmHoaDon.ValueTongTien.Text = tongtien.ToString();
        }

        public DataTable ThongKeHoaDon(string text1, string text2)
        {
            DateTime denngay = Convert.ToDateTime(text2);
            //denngay.AddDays(1);
            denngay = denngay.Date.AddDays(1);
            return daHoaDon.ThongKeHoaDon(text1, denngay.ToShortDateString());
        }

        /// <summary>
        /// Hiển thị 1 bảng có danh sách các món ăn có trong bill có id_hoadon = @idHoaDon 
        /// Dành cho in thử bill và kết thúc
        /// </summary>
        /// <param name="idHoaDon"></param>
        /// <returns></returns>
        public DataTable HienThiThucPhamCoTrongHoaDon(int idHoaDon)
        {
            return daHoaDon.HienThiThucPhamCoTrongHoaDon(idHoaDon);
        }

        public void ThemMatHang(int id_HoaDOn, int soluong, int iD_ThucPham)
        {
            daHoaDon.ThemMatHang(id_HoaDOn, soluong, iD_ThucPham);
        }

        public HoaDon LayHoaDon(Ban ban)
        {
            DataTable dt = daHoaDon.LayHoaDon(ban);
            DataRow row = dt.Rows[0];
            HoaDon hoadon = new HoaDon(row);
            return hoadon;

        }

        public DataTable TimKiemHoaDonShowLenThanhToan(int sohd)
        {
            
            return daHoaDon.TimKiemHoaDonShowLenThanhToan(sohd);
        }

        public DataTable LayHoaDon(int id)
        {
            return daHoaDon.LayHoaDon(id);
        }
        public void XoaMatHang(int idHoaDon, string text,string sl)
        {
            int soluong = Int32.Parse(sl);
            int idThucPham = Int32.Parse(text);
            int i = daHoaDon.XoaMatHang(idHoaDon, idThucPham,soluong);
        }

        public void DoiSoLuong(int idHoaDon, int idThucPham, int soluong)
        {
            int i = daHoaDon.SuaSoLuong(idHoaDon, idThucPham, soluong);
        }

        public int ThanhToanHoaDon(int sohd, bool trangthai)
        {
            if (trangthai) return daHoaDon.ThanhToanHoaDon(sohd, 1);
            return daHoaDon.ThanhToanHoaDon(sohd, 0);
        }

        public void GanGiaTriInThuBill(int id, string nv, string kh)

        {
            int idNhanVien = Convert.ToInt32(nv);
            int idKhachHang = Convert.ToInt32(kh);
            daHoaDon.GanGiaTriInThuBill(id,idNhanVien, idKhachHang);
        }
    }
}
