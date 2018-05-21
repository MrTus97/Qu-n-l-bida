﻿using QuanLyBilliard.DA;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyBilliard.BL
{
    class BL_Ban
    {
        #region Khai báo
        DA_Ban daTable;
        DA_HoaDon daHoaDon;
        FrmSuDungDichVu frmSuDungDichVu;
        FrmDanhMucBanKhuVuc frmDanhMucBanKhuVuc;
        FrmChuyenBan frmChuyenBan;
        BL_HoaDon blHoaDon;
        BL_NhanVien blNhanVien;
        BL_KhachHang blKhachHang;
        const int TABLE_WIDTH = 70;
        const int TABLE_HEIGHT = 120;
        FrmHoaDon frmHoaDon;

        #endregion
        /// <summary>
        /// Constructor cho Form Sử dụng dịch vụ
        /// </summary>
        /// <param name="f"></param>

        public BL_Ban(FrmDanhMucBanKhuVuc f)
        {
            frmDanhMucBanKhuVuc = f;
            daTable = new DA_Ban();
            daHoaDon = new DA_HoaDon();
        }


        public BL_Ban(FrmSuDungDichVu f)
        {
            daTable = new DA_Ban();
            daHoaDon = new DA_HoaDon();
            blHoaDon = new BL_HoaDon(f);
            blNhanVien = new BL_NhanVien(f);
            blKhachHang = new BL_KhachHang(f);
            frmSuDungDichVu = f;
        }

        /// <summary>
        /// Lấy tất cả các bàn có trong csdl
        /// </summary>
        /// <returns></returns>
        public List<Ban> LayBan()
        {
            return daTable.LayBan();
        }

        public DataTable LayDanhSachLoaiBan()
        {
            return daTable.layDanhSachLoaiBan();
        }

        /// <summary>
        /// constructor cho Form Chuyển bàn
        /// </summary>
        /// <param name="f"></param>


        public BL_Ban(FrmChuyenBan f)
        {
            frmChuyenBan = f;
            daTable = new DA_Ban();
            blHoaDon = new BL_HoaDon(f);
            
        }
        
        /// <summary>
        /// Constructor cho Form Hóa đơn
        /// </summary>
        /// <param name="f"></param>
        public BL_Ban(FrmHoaDon f)
        {
            frmHoaDon = f;
            daTable = new DA_Ban();
        }

       
        /// <summary>
        /// Chuyển bàn có id là v1 sang bàn có id là v2
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        public void themBan(string loaiBan, string TenBan)
        {
            int idLoaidBan = Int32.Parse(loaiBan);
            daTable.themBan(idLoaidBan, TenBan);
        }
        /// <summary>
        /// Chuyển bàn có mã từ v1 sang v2
        /// </summary>
        /// <param name="v1">Mã bàn hiện tại</param>
        /// <param name="v2">Mã bàn chuyển tới</param>
        public void ChuyenBan(string v1, string v2)
        {
            int curr = Int32.Parse(v1);
            int taget = Int32.Parse(v2);
            daTable.chuyenBan(curr, taget);
        }

        /// <summary>
        /// Kết thúc bàn đang chứa mã hóa đơn là text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int KetThuc(string text)
        {

            int idhoadon = Int32.Parse(text);
            return daTable.TATBAN(idhoadon);
        }
        /// <summary>
        /// Kết thúc theo id hóa đơn
        /// </summary>
        /// <param name="idhoadon"></param>
        /// <returns></returns>
        public int KetThuc(int idhoadon)
        {
            return daTable.TATBAN(idhoadon);
        }


        public int ThemLoaiBan(string tenloai,string gia)
        {
            int giaBan = Convert.ToInt32(gia);
            return daTable.ThemLoaiBan(tenloai, giaBan);
        }

        public int CapNhatLoaiBan(string txtTenLoai,string txtGia, int tag)
        {
            int gia = Convert.ToInt32(txtGia);
            return daTable.CapNhatLoaiBan(txtTenLoai,gia, tag);
        }

        public void capNhatBan(string text1, string loaiBan, string text2)
        {
            int idBan = Int32.Parse(text1);
            int idLoaidBan = Int32.Parse(loaiBan);
            daTable.capNhatBan(idBan,idLoaidBan, text2);
        }

        public int XoaLoaiBan(int idban)
        {
            return daTable.XoaLoaiBan(idban);
        }

        

        public int xoaBan(string text)
        {
            int id = Int32.Parse(text);
            return daTable.xoaBan(id);
        }

        public DataTable layDuLieuLenDataGridView()
        {
            return daTable.layDuLieuLenDataGridView();
        }

        public DataTable HienThiDuLieu()
        {
            return daTable.HienThiDuLieu();
        }

        public void LoadLoaiBan()
        {
            frmDanhMucBanKhuVuc.cbxLoaiBan.DataSource = daTable.getDuLieu();
            frmDanhMucBanKhuVuc.cbxLoaiBan.DisplayMember = "TenLoai";
            frmDanhMucBanKhuVuc.cbxLoaiBan.ValueMember = "ID_LoaiBan";
        }


        public DataTable LayHoaDon(Ban ban)
        {
            return daHoaDon.LayHoaDon(ban);
        }

        public DateTime LayGioVao(int iD_Ban)
        {
            return daTable.LayGioVao(iD_Ban);
        }

        /// <summary>
        /// Xử lý khi bấm nút tính tiền
        /// </summary>
        /// <param name="hd"></param>
        /// <param name="idnv"></param>
        /// <param name="kh"></param>
        /// <returns></returns>
        public int KetThuc(HoaDon hd,string idnv,string kh,string tg,string tpp)
        {
            //Chuyển đổi dữ liệu cho phù hợp
            int khachhang = Convert.ToInt32(kh);
            int idNhanVien = Int32.Parse(idnv);
            float tiengio = 0;
            if (tg != "")
            {
                tiengio = float.Parse(tg);
            }
            
            int tienthucpham = Convert.ToInt32(tpp);
            //Gọi hàm để tính cột tiền giờ
            /*1. Chọn bàn
             *2. Lấy giờ vào
             *3. Lấy giờ hiện tại
             *4. Tính giờ chơi
             *5. Tính tiền
             */
            //DateTime giovao = Convert.ToDateTime(daTable.LayGioVao(hd.ID_Ban));
            //DateTime gioRa = DateTime.Now;
            //int hour = gioRa.Hour - giovao.Hour;
            //int minute = gioRa.Minute - giovao.Minute;
            //int day = gioRa.Day - giovao.Day;
            //Gọi hàm để tính cột tiền thực phẩm
            //int tienthucpham = daHoaDon.TinhTongTienThucPham(hd.ID_HoaDon);
            return daTable.TATBAN(hd,idNhanVien,khachhang,tiengio,tienthucpham);
        }
        /// <summary>
        /// Bật giờ theo id bàn
        /// </summary>
        /// <param name="id"></param>
        public void BatGio(int id)
        {
            daTable.BATBAN(id);
        }
        /// <summary>
        /// Tính tiền giờ
        /// </summary>
        /// <param name="hour"></param>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public float TinhTienGio(int day,int hour, int minutes,float giamGiaGio)
        {
            float dongia = daTable.LayGiaBan((frmSuDungDichVu.btnDaiDienBan.Tag as Ban).ID_LoaiBan);
            float tiengio = (day*dongia*24) + (hour * dongia) + (int)(minutes * dongia/60);
            //Tính giảm giá
            tiengio -= (tiengio * giamGiaGio / 100);
            return tiengio;
        }

    }
}
