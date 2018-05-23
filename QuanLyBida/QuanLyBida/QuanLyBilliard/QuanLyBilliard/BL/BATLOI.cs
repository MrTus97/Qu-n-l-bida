using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    public static class BATLOI
    {
        public const int THIEU_DU_LIEU = -1;
        public const int TRUNG_DU_LIEU = -2;
        public const int SAI_DINH_DANG = -3;
        public const int SQL = -4;


        public static void HienThiLoi(int kq)
        {
            if (kq == THIEU_DU_LIEU)
            {
                MessageBox.Show("Thiếu dữ liệu");
            } else if (kq == TRUNG_DU_LIEU)
            {
                MessageBox.Show("Trùng dữ liệu");
            } else if (kq == SAI_DINH_DANG)
            {
                MessageBox.Show("Sai định dạng");
            }else if (kq == SQL)
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
