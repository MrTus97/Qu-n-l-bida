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
        //public int ThemNhanVien(string ten,string ngaysinh,string cmnd,string sdt,int gioitinh,int capbac,string catruc,string tendangnhap)
        //{
        //    string sql = "INSERT INTO NHANVIEN VALUES(N'"+ten+"',convert(datetime,'"+ngaysinh+"',103),'"+cmnd+"','"+sdt+"',"+gioitinh+","+capbac+",'"+catruc+"',NULL)";
        //    return ldc.ExecuteNonQuery(sql);
        //}

        public DataTable LayNhanvien()
        {
            string sql = "select * from nhanvien";
            return ldc.getDuLieu(sql);
        }

        public DataTable getDuLieu()
        {
            string sql = "select * from CAPBAC";
            return ldc.getDuLieu(sql);
        }

        //public int SuaThongTinNhanVien(int idNhanVien, string ten, string ngaysinh, string cmnd, string sdt, int gioitinh, int capbac, string catruc, string tendangnhap)
        //{
        //    string sql = "update NHANVIEN set TENNHANVIEN='" + ten + "',ngaysinh = convert(datetime,'" + ngaysinh + "',103), cmnd = '" + cmnd + "', sodienthoai = '" + sdt + "' where ID_NhanVien = '" + idNhanVien + "'";
        //    return ldc.ExecuteNonQuery(sql);
        //}

        public DataTable layDuLieuLenDataGridView()
        {
            string sql = "select TENNHANVIEN,CMND,SODIENTHOAI,CATRUC,NGAYSINH,GIOITINH,TENCAPBAC,ID_NHANVIEN,nv.ID_CAPBAC from NHANVIEN nv,CAPBAC cb where nv.ID_CAPBAC = cb.ID_CAPBAC";
            return ldc.getDuLieu(sql);
        }

        public string QuenMatKhau(string text)
        {
            string sql = "select matkhau from dangnhap where tendangnhap = '"+ text +"'";
            object result = ldc.ExecuteScalar(sql);
            if (result == null)
            {
                return "";
            }
            return ldc.ExecuteScalar(sql).ToString();
        }

        public int XoaNhanVien(int idNhanVien)
        {
            string sql = "Delete NHANVIEN where ID_NhanVien = " + idNhanVien ;
            return ldc.ExecuteNonQuery(sql);
            
        }

   
        public int ThemNhanVien(string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, int idCapBac, string catruc)
        {
            string sql = "insert into NhanVien values('"+tennhanvien+"',convert(datetime,'"+ngaysinh+"',103),'"+cmnd+"','"+sdt+"',"+gioitinh+", "+idCapBac+",N'"+catruc+"',null) ";
            return ldc.ExecuteNonQuery(sql);
        }

        public int SuaThongTinNhanVien(int IdNhanVien,string tennhanvien, string ngaysinh, string cmnd, string sdt, int gioitinh, int idCapBac, string catruc)
        {
            string sql = "update NHANVIEN set TENNHANVIEN='" + tennhanvien + "',ngaysinh = convert(datetime,'" + ngaysinh + "',103), cmnd = '" + cmnd + "', sodienthoai = '" + sdt + "' where ID_NhanVien = '" + IdNhanVien + "'";
            return ldc.ExecuteNonQuery(sql);
        }
    }
}
