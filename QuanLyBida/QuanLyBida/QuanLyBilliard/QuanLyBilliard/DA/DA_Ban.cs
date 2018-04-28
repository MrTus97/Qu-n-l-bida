using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.DTO;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBilliard.DA
{
    class DA_Ban
    {
        LopDungChung ldc = new LopDungChung();
        /// <summary>
        /// Lấy tất cả các bàn có tỏng cơ sở dữ liệu
        /// </summary>
        /// <returns></returns>
        public List<Ban> LayBan()
        {
            DataTable dt = null;
            try
            {
                string sql = "SELECT * FROM BAN";
                dt = ldc.getDuLieu(sql);
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<Ban> lst = new List<Ban>();
            foreach (DataRow row in dt.Rows)
            {
                Ban table = new Ban(row);
                lst.Add(table);
            }
            return lst;
        }
        /// <summary>
        /// Thực hiện procedure đổi trạng thái bàn và tạo hóa đơn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int BATBAN(int id)
        {
            /*
                    Thực thi 1 procedure như sau, nhiệm vụ là thêm 1 hóa đơn với giờ chơi và trạng thái thanh toán bằng 0
                    sau đó update trạng thái bàn chuyển sang bật và lấy giờ vào cho bàn
                    CREATE PROCEDURE BATGIO
                    @id int
                    as
                    begin
                    insert into HOADON
                    values (@id,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0);

                    update BAN 
                    set trangthai = 1, GIOVAO = GETDATE(), GIORA = NULL 
                    where ID_BAN = @id;
                    end
                 */
            string sql = "batgio " + id;
            return ldc.ExecuteNonQuery(sql);
        }

        

        public int chuyenBan(int curr, int taget)
        {
            /*CREATE PROCEDURE chuyenban
                @curr int,
                @taget int
                as
                begin
                update ban set TRANGTHAI =1,GIOVAO=(select GIOVAO from BAN where ID_BAN=@curr),GIORA = null where ID_BAN=@taget
                Update ban set TRANGTHAI = 0,GIOVAO=null,GIORA=null where ID_BAN=@curr
                update HOADON set ID_BAN = @taget where ID_HOADON = (select top 1 (ID_HOADON) from HOADON where ID_BAN = @curr order by ID_HOADON desc)
                end*/
            string sql = "chuyenban "+ curr+ "," + taget;
            return ldc.ExecuteNonQuery(sql);
        }

        public int TATBAN(HoaDon hd,int idNhanVien,int idkhachhang,float tiengio,float tienthucpham)
        {

            /*
                 CREATE PROCEDURE TATBAN
                    @id_ban int,
                    @id_hoadon int,
                    @id_NhanVien int,
                    @id_khachhang int,
                    @tiengio float,
                    @tienthucpham int
                    as
                    begin
                    -- Cập nhật trạng thái cho bàn
                    UPDATE BAN
                    SET TRANGTHAI = 0,GIORA = getdate()
                    where ID_BAN = @id_ban
                    -- Tính tổng số giờ chơi của bàn có id_hoadon
                    UPDATE HOADON 
                    SET TONGGIOCHOI = (SELECT GIORA-GIOVAO FROM BAN WHERE ID_BAN =@id_ban),ID_NHANVIEN = @idNhanVien,ID_KHACHHANG=@id_khachhang,tiengio = @tiengio,tienthucpham=@tienthucpham
                    where ID_HOADON = @id_hoadon
                    end
                 */
            string sql = "TATBAN " + hd.ID_Ban + "," + hd.ID_HoaDon + "," + idNhanVien + "," + idkhachhang + "," + tiengio + "," + tienthucpham;
            return ldc.ExecuteNonQuery(sql);
        }

        public int TATBAN(int idhoadon)
        {
            int idban = (int)ldc.ExecuteScalar("select ID_BAN from hoadon where id_hoadon =" + idhoadon);
            string sql = "TATBAN " + idban + "," + idhoadon;
            return ldc.ExecuteNonQuery(sql);
        }
        public DateTime LayGioVao(int iD_Ban)
        {
            string sql = "select giovao from ban where id_ban = " + iD_Ban;
            return (DateTime)ldc.ExecuteScalar(sql);
           
            
        }

        internal float LayGiaBan(int iD_LoaiBan)
        {
            string sql = "select GIA from LOAIBAN where ID_LOAIBAN =" + iD_LoaiBan;
            return float.Parse(ldc.ExecuteScalar(sql).ToString());
        }
    }
}
