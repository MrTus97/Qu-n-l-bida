using System;
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
using System.Security.Cryptography;

namespace QuanLyBilliard.GUI
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        BL_DangNhap blDangNhap;
       
        
        public FrmDangNhap()
        {
            InitializeComponent();
            blDangNhap = new BL_DangNhap(this);
            Reset();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            string xacnhan = xacNhanCaptcha.Text;
            string tendangnhap = txtTenDangNhap.Text;
            string matkhau = txtMatKhau.Text;
            if (tendangnhap == "" || matkhau == "")
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống");
                Reset();
            }
            if (captchaText != xacnhan)
            {
                MessageBox.Show("Sai captcha!!");
                Reset();
                
            }
            else
            {
                MaHoaMatKhau blMaHoa = new MaHoaMatKhau();
                string hasPass = blMaHoa.MaHoa(matkhau);
                int i = blDangNhap.DangNhap(tendangnhap, hasPass);
                if (i > 0)
                {
                    blDangNhap.HienThiFormMain(tendangnhap);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                    Reset();
                }
            }
           
        }


        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuenMatKhau f = new FrmQuenMatKhau();
            f.ShowDialog();
        }
        /// <summary>
        /// Trả về một bức hình 
        /// </summary>
        /// <param name="txt">chuỗi captcha</param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private Bitmap DrawImage(string txt, int width, int height)
        {
            Bitmap bt = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bt);
            SolidBrush sb = new SolidBrush(Color.White);
            g.FillRectangle(sb, 0, 0, bt.Width, bt.Height);
            System.Drawing.Font font = new System.Drawing.Font("Arial", 10);
            sb = new SolidBrush(Color.Black);
            g.DrawString(txt, font, sb, 0, 0);
            return bt;
        }
        private string captchaText;
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void Reset()
        {
            captchaText = RandomString(5);
            xacNhanCaptcha.Text = "";
            panel1.BackgroundImage = DrawImage(captchaText, panel1.Width, panel1.Height);
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}