using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            String email = "mr.tus97@gmail.com";
            String token = "ebed6e6d1b579ec1";
            String hash = txtInput.Text;
            String hashType = "md5";

            String url = "http://md5decrypt.net/Api/api.php?hash=" + hash + "&hash_type=" + hashType + "&email=" + email + "&code=" + token;
            WebBrowser1.Navigate(url);
            MessageBox.Show(WebBrowser1.Document.Body.InnerText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
