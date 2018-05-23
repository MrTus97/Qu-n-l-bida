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
        /// <summary>
        /// Lấy tất cả các hóa đơn của bàn sắp xếp giảm dần
        /// </summary>
        /// <param name="ban"></param>
        /// <returns></returns>
        public DataTable LayHoaDon(Ban ban)
        {
            string sql = "select * from hoadon where id_ban = " + ban.ID_Ban + " order by id_hoadon desc";
            return ldc.getDuLieu(sql);
        }
        

        public DataTable showBill(int idhd)
        {
            //if (hd == null) return default(DataTable);
            string sql = "SELECT tp.TENTHUCPHAM,tp.GIABAN,ct.SOLUONG, tp.GIABAN* ct.SOLUONG as thanhtien,tp.ID_THUCPHAM FROM CHITIETHD ct,HOADON hd, THUCPHAM tp WHERE ct.ID_HOADON = hd.ID_HOADON and tp.ID_THUCPHAM = ct.ID_THUCPHAM and ct.ID_HOADON = " + idhd;
            return ldc.getDuLieu(sql);
        }
        /// <summary>
        /// Chọn tất cả hóa đơn
        /// </summary>
        /// <returns></returns>
        public DataTable HienThiTatCaCacHoaDon()
        {
            string sql = "SELECT hd.ID_HOADON,b.TENBAN,nv.TENNHANVIEN,kh.TENKHACHHANG,hd.TIENGIO,hd.GIAMGIAGIO,hd.TIENTHUCPHAM,hd.GIAMGIATHUCPHAM,hd.tiengio + hd.tienthucpham as tongtien,hd.DATHANHTOAN FROM (((KHACHHANG kh inner join HOADON hd on hd.ID_KHACHHANG = kh.ID_KHACHHANG) inner join NHANVIEN nv on hd.ID_NHANVIEN = nv.ID_NHANVIEN) inner join ban b on hd.ID_BAN = b.ID_BAN) order by hd.ID_HOADON desc";
            return ldc.getDuLieu(sql);
        }

        public DataTable LayHoaDon(int id_hoadon)
        {
            string sql = "select * from (((hoadon hd left join ban b on hd.ID_BAN = b.ID_BAN) left join khachhang kh on hd.ID_KHACHHANG = kh.ID_KHACHHANG) left join nhanvien nv on hd.ID_NHANVIEN = nv.ID_NHANVIEN) left join loaiban lb on lb.ID_LOAIBAN = b.ID_LOAIBAN where hd.ID_HOADON = " + id_hoadon;
            return ldc.getDuLieu(sql);
        }

        public int ThanhToan(int id)
        {
            string sql = "update hoadon set dathanhtoan =1 where id_hoadon =" + id;
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
        /// Thống kê hóa đơn từ ngày này đến ngày kia
        /// </summary>
        /// <param name="tungay"></param>
        /// <param name="denngay"></param>
        /// <returns></returns>
        public DataTable ThongKeHoaDon(string tungay,string denngay)
        {
            string sql = "SELECT hd.ID_HOADON,b.TENBAN,nv.TENNHANVIEN,kh.TENKHACHHANG,hd.TIENGIO,hd.GIAMGIAGIO,hd.TIENTHUCPHAM,hd.GIAMGIATHUCPHAM,hd.tiengio + hd.tienthucpham as tongtien,hd.DATHANHTOAN FROM (((KHACHHANG kh inner join HOADON hd on hd.ID_KHACHHANG = kh.ID_KHACHHANG) inner join NHANVIEN nv on hd.ID_NHANVIEN = nv.ID_NHANVIEN) inner join ban b on hd.ID_BAN = b.ID_BAN) where hd.NGAYKETTHUCHOADON >= CONVERT(datetime,'"+tungay+"',103) and hd.NGAYKETTHUCHOADON<CONVERT(datetime,'" + denngay + "',103)";
            return ldc.getDuLieu(sql);

        }

        /// <summary>
        /// Thực hiện đổi số lượng thực phẩm ở trong bill có id_hoadon = @idhoadon
        /// Dành cho "đổi số lượng", "thêm 1", "Giảm 1"
        /// </summary>
        /// <param name="idHoaDon"></param>
        /// <param name="tp"></param>
        /// <param name="sl"></param>
        /// <returns></returns>
        public int SuaSoLuong(int idHoaDon, int tp, int sl)
        {
            string sql = "UPDATE CHITIETHD SET SOLUONG = " + sl + " WHERE ID_HOADON = " + idHoaDon + " and ID_THUCPHAM=" + tp;
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable TimKiemHoaDonShowLenThanhToan(int sohd)
        {
            string sql = "SELECT hd.ID_HOADON,b.TENBAN,nv.TENNHANVIEN,kh.TENKHACHHANG,hd.TIENGIO,hd.GIAMGIAGIO,hd.TIENTHUCPHAM,hd.GIAMGIATHUCPHAM,hd.tiengio + hd.tienthucpham as tongtien,hd.DATHANHTOAN FROM (((KHACHHANG kh inner join HOADON hd on hd.ID_KHACHHANG = kh.ID_KHACHHANG) inner join NHANVIEN nv on hd.ID_NHANVIEN = nv.ID_NHANVIEN) inner join ban b on hd.ID_BAN = b.ID_BAN) where hd.ID_HOADON ="+sohd;
            return ldc.getDuLieu(sql);
        }

        public int ThanhToanHoaDon(int sohd, int trangthai)
        {
            string sql = "update hoadon set DATHANHTOAN = " + trangthai + " where ID_HOADON = " + sohd;
            return ldc.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// Hiển thị tên,số lượng, đơn giá, thành tiền cho hóa đơn có id_hoadon = @id
        /// Dành cho in thử bill và Kết thúc
        /// </summary>
        /// <param name="idHoaDon"></param>
        /// <returns></returns>
        public DataTable HienThiThucPhamCoTrongHoaDon(int idHoaDon)
        {
            string sql = "SELECT TENTHUCPHAM,ct.SOLUONG,GIABAN, ct.SOLUONG*GIABAN as THANHTIEN FROM CHITIETHD ct inner join thucpham tp on ct.ID_THUCPHAM = tp.ID_THUCPHAM where ct.ID_HOADON = " + idHoaDon;
            return ldc.getDuLieu(sql);
        }

        public int SetGiamGiaThucPham(int idHoaDon, double giamGiaThucPham)
        {
            string sql = "update HOADON set GIAMGIATHUCPHAM = " + giamGiaThucPham + " where ID_HOADON=" + idHoaDon;
            return ldc.ExecuteNonQuery(sql);
        }

        public int SetGiamGiaGio(int idHoaDon, double giamGiaGio)
        {
            string sql = "update HOADON set GIAMGIAGIO = " + giamGiaGio + " where ID_HOADON=" + idHoaDon;
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

        public int TinhTongTienThucPham(int iD_HoaDon)
        {
            string sql = "select sum(GiABAN*ct.SOLUONG) from CHITIETHD ct inner join THUCPHAM tp on ct.ID_THUCPHAM = tp.ID_THUCPHAM where ID_HOADON =" + iD_HoaDon;
            object tienThucPham = ldc.ExecuteScalar(sql);
            if (tienThucPham.ToString() != "")
            {
                int result = Convert.ToInt32(ldc.ExecuteScalar(sql));
                return result;
            }
            return 0;
        }

        /// <summary>
        /// Gán giá trị nhân viên,khách hàng vào csdl
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idNhanVien"></param>
        /// <param name="idKhachHang"></param>
        /// <returns></returns>
        public int GanGiaTriInThuBill(int id,int idNhanVien, int idKhachHang)
        {
            string sql = "update HOADON set ID_NHANVIEN = " + idNhanVien + ", ID_KHACHHANG= " + idKhachHang + " where ID_HOADON = " + id;
            return ldc.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// Hiển thị những hóa đơn chưa thanh toán
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int HienThiHoaDon(int id)
        {
            string sql = "select id hoadon from hoadon where ID_ban = '" + id + "' and dathanhtoan =0";
            return (int)ldc.ExecuteScalar(sql);
        }
    }
}
