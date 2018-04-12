using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI;
using System.Data;
using QuanLyBilliard.DA;

namespace QuanLyBilliard.BL
{
    class BL_HoaDon
    {
        FrmSuDungDichVu frmSuDungDichVu;
        DA_HoaDon daHoaDon;
        public BL_HoaDon(FrmSuDungDichVu f)
        {
            this.frmSuDungDichVu = f;
            daHoaDon = new DA_HoaDon();
        }

        public void ShowBill(HoaDon hd, out float tongtien)
        {
            DataTable dt = daHoaDon.showBill(hd);
            frmSuDungDichVu.dataGridView2.Rows.Clear();
            tongtien = 0f;
            foreach (DataRow row in dt.Rows)
            {
                frmSuDungDichVu.dataGridView2.Rows.Add(row.ItemArray);
                tongtien += float.Parse(row["ThanhTien"].ToString());
            }
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
    }
}
