using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DA
{
    class DA_NhanVien
    {
        LopDungChung ldc = new LopDungChung();
        public int ThemNhanVien(string ten,string ngaysinh,string cmnd,string sdt,int gioitinh,int capbac,string catruc,string tendangnhap)
        {
            string sql = "INSERT INTO NHANVIEN VALUES(N'"+ten+"',convert(datetime,'"+ngaysinh+"',103),'"+cmnd+"','"+sdt+"',"+gioitinh+","+capbac+",'"+catruc+"',NULL)";
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable LayNhanvien()
        {
            string sql = "select * from nhanvien";
            return ldc.getDuLieu(sql);
        }
        public int SuaThongTinNhanVien(int idNhanVien, string ten, string ngaysinh, string cmnd, string sdt, int gioitinh, int capbac, string catruc, string tendangnhap)
        {
            string sql = "update NHANVIEN set TENNHANVIEN='" + ten + "',ngaysinh = convert(datetime,'" + ngaysinh + "',103), cmnd = '" + cmnd + "', sodienthoai = '" + sdt + "' where ID_NhanVien = '" + idNhanVien + "'";
            return ldc.ExecuteNonQuery(sql);
        }

        public int XoaNhanVien(int idNhanVien)
        {
            string sql = "Delete NHANVIEN where ID_NhanVien = " + idNhanVien ;
            return ldc.ExecuteNonQuery(sql);
            
        }
    }
}
