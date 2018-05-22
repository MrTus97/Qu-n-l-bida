using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.GUI;
using QuanLyBilliard.DA;
using QuanLyBilliard.GUI.KHUYEN_MAI;

namespace QuanLyBilliard.BL
{
    class BL_KhuyenMai
    {
        private FrmKhuyenMai frmKhuyenMai;
        private DA_KhuyenMai daKhuyenMai = new DA_KhuyenMai();
        private FrmTuyChonKhuyenMai frmTuyChonKhuyenMai;
        private FrmSuDungDichVu frmSuDungDichVu;

        public BL_KhuyenMai(FrmKhuyenMai frmKhuyenMai)
        {
            this.frmKhuyenMai = frmKhuyenMai;
        }

        public BL_KhuyenMai(FrmTuyChonKhuyenMai frmTuyChonKhuyenMai)
        {
            this.frmTuyChonKhuyenMai = frmTuyChonKhuyenMai;
        }

        public BL_KhuyenMai(FrmSuDungDichVu frmSuDungDichVu)
        {
            this.frmSuDungDichVu = frmSuDungDichVu;
        }

        public DataTable XemKhuyenMai()
        {
            return daKhuyenMai.XemKhuyenMai();
        }

        public int ThemKhuyenMai(string id, string ten, string giamGiaGio, string giamGiaThucPham, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                float gio_km = float.Parse(giamGiaGio);
                float nuoc_km = float.Parse(giamGiaThucPham);
                return daKhuyenMai.ThemKhuyenMai(ten, gio_km, nuoc_km, ngayBatDau, ngayKetThuc);
            }
            catch (Exception)
            {
                return -1;
            }
            
        }

        public int SuaKhuyenMai(string id, string ten, string giamGiaGio, string giamGiaThucPham, string ngayBatDau, string ngayKetThuc)
        {
            try
            {
                int id_km = Convert.ToInt32(id);
                float gio_km = float.Parse(giamGiaGio);
                float nuoc_km = float.Parse(giamGiaThucPham);
                return daKhuyenMai.SuaKhuyenMai(id_km, ten, gio_km, nuoc_km, ngayBatDau, ngayKetThuc);
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int XoaKhuyenMai(int id)
        {
            return daKhuyenMai.XoaKhuyenMai(id);
        }
    }
}
