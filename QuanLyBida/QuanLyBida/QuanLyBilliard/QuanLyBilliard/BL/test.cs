using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    class test
    {
        //md5 = 21232f297a57a5a743894a0e4a801fc3
        public void aa()
        {
            String email = "mr.tus97@gmail.com";
            String token = "ebed6e6d1b579ec1";
            String hash = "21232f297a57a5a743894a0e4a801fc3";
            String hashType = "md5";

            String url = "http://md5decrypt.net/Api/api.php?hash=" + hash + "&hash_type=" + hashType + "&email=" + email + "&code=" + token;
            WebBrowser WebBrowser1 = new WebBrowser();
            WebBrowser1.Url = new Uri(url);
            WebBrowser1.Navigate(url);
            MessageBox.Show(WebBrowser1.StatusText);
        }
              
        
    }
}
