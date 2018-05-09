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
        /// <param name="id">ID bàn</param>
        /// <returns>
        /// Trả về số dòng thay đổi, nếu lớn hơn 0 thì thành công
        /// </returns>
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
                    values (@id,NULL,NULL,NULL,NULL,NULL,NULL,NULL,0,0,getdate(),null);

                    update BAN 
                    set trangthai = 1, GIOVAO = GETDATE(), GIORA = NULL 
                    where ID_BAN = @id;
                    end
                 */
            string sql = "batgio " + id;
            return ldc.ExecuteNonQuery(sql);
        }

<<<<<<< HEAD
        
        /// <summary>
        /// Chuyển bàn curr sang taget
        /// </summary>
        /// <param name="curr"></param>
        /// <param name="taget"></param>
        /// <returns></returns>
=======
        public int themBan(int idLoaiBan, string tenBan)
        {
            string sql = "insert into BAN values ('" + tenBan + "',0,null,null,"+idLoaiBan+")";
            return ldc.ExecuteNonQuery(sql);
        }


>>>>>>> origin/Khoa
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

<<<<<<< HEAD
        public int TATBAN(HoaDon hd,int idNhanVien,int idkhachhang,float tiengio,float tienthucpham)
=======
        public int capNhatBan(int idBan, int idLoaidBan, string text2)
        {
            string sql = "update ban set TENBAN = '"+text2+"', ID_LOAIBAN = "+idLoaidBan+" where ID_BAN = "+idBan;
            return ldc.ExecuteNonQuery(sql);
        }


        public int TATBAN(HoaDon hd,int idNhanVien)
>>>>>>> origin/Khoa
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
                    SET TONGGIOCHOI = (SELECT GIORA-GIOVAO FROM BAN WHERE ID_BAN =@id_ban),ID_NHANVIEN = @idNhanVien,ID_KHACHHANG=@id_khachhang,tiengio = @tiengio,tienthucpham=@tienthucpham,NGAYKETTHUCHOADON=GETDATE()
                    where ID_HOADON = @id_hoadon
                    end
                 */
            string sql = "TATBAN " + hd.ID_Ban + "," + hd.ID_HoaDon + "," + idNhanVien + "," + idkhachhang + "," + tiengio + "," + tienthucpham;
            return ldc.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// Tắt bàn có số hóa đơn là text
        /// Tìm bàn đang chứa hóa đơn rồi tắt bàn theo idbàn và kết thúc hóa đơn
        /// </summary>
        /// <param name="idhoadon"></param>
        /// <returns></returns>
        public int TATBAN(int idhoadon)
        {
            int idban = (int)ldc.ExecuteScalar("select ID_BAN from hoadon where id_hoadon =" + idhoadon);
            string sql = "TATBAN " + idban + "," + idhoadon;
            return ldc.ExecuteNonQuery(sql);
        }

        public int xoaBan(int id)
        {
            string sql = "delete BAN where ID_BAN ="+id;
            return ldc.ExecuteNonQuery(sql);
        }

        public DataTable layDuLieuLenDataGridView()
        {
            string sql = "select TENLOAI,TENBAN,ban.ID_BAN,ban.ID_LOAIBAN from LOAIBAN,BAN where LOAIBAN.ID_LOAIBAN=BAN.ID_LOAIBAN";
            return ldc.getDuLieu(sql);
        }

        public DataTable HienThiDuLieu()
        {
            string sql = "select ban.ID_LoaiBan,TenBan,Gia from Ban, LoaiBan where Ban.ID_LoaiBan = LoaiBan.Id_LoaiBan";
                return ldc.getDuLieu(sql);
        }

        public DataTable getDuLieu()
        {
            string sql = "select * from loaiban";
            return ldc.getDuLieu(sql);
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
