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
        string[,] morse;
        public MaHoaMatKhau()
        {
            morse = new string[,]
            {
                //Chữ hoa
                {"A","u._" },
                {"B","u_..." },
                {"C","u_._." },
                {"D","u_.."},
                {"E","u." },
                {"F","u.._." },
                {"G","u__." },
                {"H","u...."},
                {"I","u.."},
                {"J", "u.___"},
                {"K","u_._"},
                {"L","u._.."},
                {"M","u__"},
                {"N","u_." },
                {"O","u___" },
                {"P","u.__." },
                {"Q","u__._"},
                {"R","u._."},
                {"S","u..."},
                {"T","u_"},
                {"U","u.._"},
                {"V","u..._"},
                {"W","u.__"},
                {"X","u_.._" },
                {"Y","u_.__"},
                {"Z","u__.."},
                //Chữ thường
                {"a","._" },
                {"b","_..." },
                {"c","_._." },
                {"d","_.."},
                {"e","." },
                {"f",".._." },
                {"g","__." },
                {"h","...."},
                {"i",".."},
                {"j",".___"},
                {"k","_._"},
                {"l","._.."},
                {"m","__"},
                {"n","_." },
                {"o","___" },
                {"p",".__." },
                {"q","__._"},
                {"r","._."},
                {"s","..."},
                {"t","_"},
                {"u",".._"},
                {"v","..._"},
                {"w",".__"},
                {"x","_.._" },
                {"y","_.__"},
                {"z","__.."},
                //Số
                {"0","_____" },
                {"1",".____" },
                {"2","..___" },
                {"3","...__" },
                {"4","...._" },
                {"5","....." },
                {"6","_...." },
                {"7","__..." },
                {"8","___.." },
                {"9","____." }

                /*Chưa hoàn thành
                @
                %
                +
                \
                /
                ‘
                !
                #
                $
                ^
                ?
                :
                .
                (
                )
                {
                }
                [
                ]
                ~
                 `
                –
                _

                 */
            };
        }
        public string MaHoa(string matkhau)
        {
            string encrypt = "";
            foreach (char item in matkhau)
            {
                for (int i = 0; i < morse.Length-1; i++)
                {
                    if (item.ToString() == morse[i, 0])
                    {
                        encrypt += morse[i, 1] + ";";
                        break;
                    }
                }
            }
            return encrypt;
        }
        public string GiaiMa(string ma)
        {
            string matkhau = "";
            string kytu = "";
            for (int i = 0;i < ma.Length; i++)
            {
                if (ma[i] != ';')
                {
                    kytu += ma[i];
                }else
                {
                    kytu.Reverse();
                    for (int j = 0; j < morse.Length - 1; j++)
                    {
                        if (kytu == morse[j,1])
                        {
                            matkhau += morse[j, 0];
                            break;
                        }
                    }
                    kytu = "";
                }
            }
            return matkhau;
        }
    }
}
