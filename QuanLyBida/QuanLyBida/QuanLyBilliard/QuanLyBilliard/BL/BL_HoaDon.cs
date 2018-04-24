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
        DA_HoaDon daHoaDon;
        
        public BL_HoaDon(FrmSuDungDichVu f)
        {
            this.frmSuDungDichVu = f;
            daHoaDon = new DA_HoaDon();
        }
        public BL_HoaDon(FrmChuyenBan f)
        {
            frmChuyenBan = f;
            daHoaDon = new DA_HoaDon();
        }
        public BL_HoaDon(FrmHoaDon f)
        {
            frmHoaDon = f;
            daHoaDon = new DA_HoaDon();
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

        public int ThanhToan(string text)
        {
            int id = Int32.Parse(text);
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

        public void DoiSoLuong(int idHoaDon, string idThucPham, string soluong)
        {
            int sl = Int32.Parse(soluong);
            int tp = Int32.Parse(idThucPham);
            int i = daHoaDon.SuaSoLuong(idHoaDon, tp, sl);
        }

        public void GanGiaTriInThuBill(string nv, string kh)
        {
            int idNhanVien = Convert.ToInt32(nv);
            int idKhachHang = Convert.ToInt32(kh);
            daHoaDon.GanGiaTriInThuBill(idNhanVien, idKhachHang);
        }
    }
}
