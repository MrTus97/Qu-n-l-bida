using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.DTO;

namespace QuanLyBilliard.DA
{
    class DA_HoaDon
    {
        LopDungChung ldc = new LopDungChung();
        public DataTable LayHoaDon(Ban ban)
        {
            //string sql = "SELECT TOP 1(ID_HOADON),ID_BAN,ID_NHANVIEN,ID_KHACHHANG,ID_GIAMGIA,GIAMGIAGIO,GIAMGIATHUCPHAM,TONGGIOCHOI,DATHANHTOAN FROM HOADON where ID_BAN ="+ban.ID_Ban+" order by ID_HOADON desc";
            string sql = "select * from hoadon where id_ban = " + ban.ID_Ban + " order by id_hoadon desc";
            return ldc.getDuLieu(sql);
        }
        //Overloading
        internal DataTable showBill(int idhd)
        {
            //if (hd == null) return default(DataTable);
            string sql = "SELECT tp.TENTHUCPHAM,tp.GIABAN,ct.SOLUONG, tp.GIABAN* ct.SOLUONG as thanhtien,tp.ID_THUCPHAM FROM CHITIETHD ct,HOADON hd, THUCPHAM tp WHERE ct.ID_HOADON = hd.ID_HOADON and tp.ID_THUCPHAM = ct.ID_THUCPHAM and ct.ID_HOADON = " + idhd;
            return ldc.getDuLieu(sql);
        }

        public DataTable LayHoaDon(int id_hoadon)
        {
            string sql = "select * from hoadon hd,ban b,khachhang kh,nhanvien nv where hd.ID_NHANVIEN = nv.ID_NHANVIEN and hd.ID_KHACHHANG = kh.ID_KHACHHANG and hd.ID_BAN = b.ID_BAN and hd.ID_HOADON = " + id_hoadon;
            return ldc.getDuLieu(sql);
        }

        public int ThanhToan(int id)
        {
            string sql = "update hoadon set thanhtoan =1 where id_hoadon =" + id;
            return ldc.ExecuteNonQuery(sql);

        }

        /// <summary>
        /// Hàm này sẽ thực hiện 1 procedure có 2 câu sql
        /// 1. Xóa 1 record trong chitiethd
        /// 2. Trả số lượng lại cho bảng thực phẩm
        /// </summary>
        /// <param name="idHoaDon"></param>
        /// <param name="idThucPham"></param>
        /// <param name="soluong"></param>
        /// <returns></returns>
        public int XoaMatHang(int idHoaDon, int idThucPham,int soluong)
        {
            /*
             * CREATE PROCEDURE XOAMATHANG
                @idHoaDon int,
                @idThucPham int,
                @soluong int
                as
                begin
	                delete CHITIETHD
	                where ID_HOADON = @idHoaDon and @idThucPham = @idThucPham

	                update THUCPHAM
	                SET SOLUONG = SOLUONG + @soluong
	                where ID_THUCPHAM= @idThucPham
                end*/
            string sql = "XoaMatHang " + idHoaDon + "," + idThucPham + "," + soluong;
            return ldc.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// Hàm này sẽ thực hiện câu sql sửa số lượng trong sql có idhoadon và idthucpham
        /// </summary>
        /// <param name="idHoaDon"></param>
        /// <param name="tp"></param>
        /// <param name="sl"></param>
        /// <returns></returns>
        public int SuaSoLuong(int idHoaDon, int tp, int sl)
        {
            string sql = "UPDATE CHITIETHD SET SOLUONG = SOLUONG + " + sl + " WHERE ID_HOADON = " + idHoaDon + " and ID_THUCPHAM=" + tp;
            return ldc.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// Đáng nhẽ phải viết 1 procedure xử lý thử mặt hàng đó đã có trong bill chưa rồi insert hay update trong đó luôn
        /// Nhưng vẫn chưa viết được, phải xài procedure insert và update + sửa số lượng trong mặt hàng
        /// </summary>
        /// <param name="id_HoaDOn"></param>
        /// <param name="soluong"></param>
        /// <param name="iD_ThucPham"></param>
        /// <returns></returns>
        public int ThemMatHang(int id_HoaDOn, int soluong, int iD_ThucPham)
        {
            string sql = "select count(*) from CHITIETHD where ID_HOADON = " + id_HoaDOn + " and ID_THUCPHAM = " + iD_ThucPham + "";
            int count = (int)ldc.ExecuteScalar(sql);
            if (count > 0)
            {
                /*
                 * CREATE PROCEDURE SuaSoLuongThucPhamKhiThemHang
                    @id_hoadon int,
                    @soluong int,
                    @id_thucpham int
                    as
                    begin
	                    update CHITIETHD
	                    set SOLUONG = SOLUONG + @soluong
	                    where ID_HOADON = @id_hoadon and ID_THUCPHAM= @id_thucpham

	                    update THUCPHAM
	                    set SOLUONG = SOLUONG - @soluong
	                    where ID_THUCPHAM = @id_thucpham
                    end
                    */
            sql = "SuaSoLuongThucPhamKhiThemHang " + id_HoaDOn + "," + soluong + "," + iD_ThucPham;
            }
            else
            {
                //CREATE PROCEDURE ThemMoiThucPhamVaoHoaDon
                //@id_hoadon int,
                //@soluong int,
                //@id_thucpham int
                //as
                //begin
                //    insert into CHITIETHD
                //    Values(@id_hoadon, @id_thucpham, @soluong)
                //    update THUCPHAM
                //    set SOLUONG = SOLUONG - @soluong
                //    where ID_THUCPHAM = @id_thucpham
                //end

                sql = "ThemMoiThucPhamVaoHoaDon " + id_HoaDOn + "," + soluong + "," + iD_ThucPham;
            }
            return ldc.ExecuteNonQuery(sql);
        }

        public int HienThiHoaDon(int id)
        {
            string sql = "select id hoadon from hoadon where ID_ban = '" + id + "' and dathanhtoan =0";
            return (int)ldc.ExecuteScalar(sql);
        }
    }
}
