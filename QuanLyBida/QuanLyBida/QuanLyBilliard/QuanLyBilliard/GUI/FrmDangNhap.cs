﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBilliard.BL;

namespace QuanLyBilliard.GUI
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BL_DangNhap blDangNhap;
        public FrmDangNhap()
        {
            InitializeComponent();
            blDangNhap = new BL_DangNhap(this);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            string tendangnhap = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            if (tendangnhap == "" || matkhau == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống");
            }
            else
            {
                int i = blDangNhap.DangNhap(tendangnhap, matkhau);
                if (i > 0)
                {
                    blDangNhap.HienThiFormMain(tendangnhap);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
           
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau f = new FrmQuenMatKhau();
            f.ShowDialog();
        }
    }
}