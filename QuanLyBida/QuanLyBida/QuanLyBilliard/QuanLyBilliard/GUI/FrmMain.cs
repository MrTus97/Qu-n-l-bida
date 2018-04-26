﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public bool FormXuatHienChua(string text)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(text))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        public void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmSuDungDichVu"))
            {
                FrmSuDungDichVu f = new FrmSuDungDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
        }



        public void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        public void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
        public void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmSuDungDichVu"))
            {
                FrmSuDungDichVu f = new FrmSuDungDichVu();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void barButtonItem31_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        public void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmNhanVien"))
            {
                FrmNhanVien f = new FrmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void btnCapBac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmCapBac"))
            {
                FrmCapBac f = new FrmCapBac();
                f.MdiParent = this;
                f.Show();
            }


        } 
        public void btnDanhMucMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!FormXuatHienChua("FrmDanhMucMatHang"))
            {
                FrmDanhMucMatHang f = new FrmDanhMucMatHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhMucKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(!FormXuatHienChua("FrmDanhMucKhachHang"))
            {
                FrmDanhMucKhachHang f = new FrmDanhMucKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
