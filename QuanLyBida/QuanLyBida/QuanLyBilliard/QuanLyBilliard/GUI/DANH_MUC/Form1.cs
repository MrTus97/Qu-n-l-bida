using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI.DANH_MUC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Reset();
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
            System.Drawing.Font font = new System.Drawing.Font("Arial", 25);
            sb = new SolidBrush(Color.Black);
            g.DrawString(txt, font, sb, 0, 0);
            return bt;
        }
        private string captchaText;
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private void Reset()
        {
            captchaText = RandomString(5);
            textBox1.Text = "";

            panel1.BackgroundImage = DrawImage(captchaText, panel1.Width, panel1.Height);
        }
    }
}
