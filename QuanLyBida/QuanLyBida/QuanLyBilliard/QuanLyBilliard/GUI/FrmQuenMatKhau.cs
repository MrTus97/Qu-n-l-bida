using QuanLyBilliard.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI
{
    public partial class FrmQuenMatKhau : Form
    {
        private BL_NhanVien blNhanVien;
        public FrmQuenMatKhau()
        {
            InitializeComponent();
            blNhanVien = new BL_NhanVien(this);
        }
        
        private void btnGui_Click(object sender, EventArgs e)
        {
            string password = blNhanVien.QuenMatKhau(txtEmail.Text);
            if (password != "")
            {
                SendMail(txtEmail.Text, password);
                MessageBox.Show("Đã gửi mật khẩu vào email");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại trong hệ thống");
            }
        }
        public void SendMail(string email,string password)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("stringstu2@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Quên mật khẩu billiard application";
                mail.Body = "Password :" + password;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("stringstu2@gmail.com", "98760012t");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                Console.WriteLine("Send mail!");

                // phải làm cái này ở mail dùng để gửi phải bật lên
                // https://www.google.com/settings/u/1/security/lesssecureapps
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void FrmQuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
