﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.DTO;

namespace QuanLyBilliard.DA
{
    class DA_ThucPham
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable getDuLieu(int loaiThucPham)
        {
            string sql = "select * from thucpham where ID_LOAITHUCPHAM = " + loaiThucPham + "";
            //string sql = "select TENTHUCPHAM,DVT,GIABAN from thucpham where ID_LOAITHUCPHAM = " + loaiThucPham+"";
            DataTable dt = ldc.getDuLieu(sql);
            return dt;
        }

        public int ThemMatHang(string tenthucpham,string dvt,int idLoaiThucPham, float dongia,int idNhaCungCap)
        {
            string sql = "insert into thucpham values('"+tenthucpham+"','"+dvt+"',"+idLoaiThucPham+",0,"+dongia+","+idNhaCungCap+")";
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable getDuLieu()
        {
            string sql = "select * from loaithucpham";
            return ldc.getDuLieu(sql);
        }

        public DataTable HienThiDuLieu()
        {
            string sql = "select tp.ID_LOAITHUCPHAM,ID_THUCPHAM,TENLOAITHUCPHAM, tp.TENTHUCPHAM,tp.DVT,GIABAN,ncc.TENNHACUNGCAP,ncc.ID_NHACUNGCAP from thucpham tp,loaithucpham ltp, nhacungcap ncc where tp.ID_LoaiThucPham = ltp.id_loaithucpham and tp.id_nhacungcap = ncc.Id_nhacungcap";
            return ldc.getDuLieu(sql);
        }

        public int CapNhatMatHang(int id_thucpham, string ten, string dvt, int idLoaiThucPham, float dongia, int idNhaCungCap)
        {
            string sql = "update thucpham set tenthucpham = '"+ten+"',dvt='"+dvt+"',id_loaithucpham="+idLoaiThucPham+",giaban="+dongia+",id_nhacungcap = "+idNhaCungCap+" where id_thucpham = "+id_thucpham;
            return ldc.ExecuteNonQuery(sql);
        }

        public int XoaMatHang(int id)
        {
            string sql = "delete thucpham where id_thucpham = " + id;
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable layDuLieulenDataGridView()
        {
            string sql = "select TENLOAITHUCPHAM,TENTHUCPHAM,DVT,GIABAN,TENNHACUNGCAP,ID_THUCPHAM,ltp.ID_LOAITHUCPHAM,ncc.ID_NHACUNGCAP from THUCPHAM tp,LOAITHUCPHAM ltp,NHACUNGCAP ncc where tp.ID_LOAITHUCPHAM = ltp.ID_LOAITHUCPHAM and tp.ID_NHACUNGCAP=ncc.ID_NHACUNGCAP";
            return ldc.getDuLieu(sql);
        }
    }
}
