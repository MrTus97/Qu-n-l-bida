using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.BL
{
    public class MaHoaMatKhau
    {
        public string MaHoa(string matkhau)
        {
            //Mã hóa mật khẩu
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(matkhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            string hasPass = "";
            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
    }
}
