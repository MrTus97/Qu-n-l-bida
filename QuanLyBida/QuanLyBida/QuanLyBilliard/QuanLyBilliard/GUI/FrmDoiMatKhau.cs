using QuanLyBilliard.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI
{
    public partial class FrmDoiMatKhau : Form
    {
        string tendangnhap;
        BL_DangNhap blDangNhap;
        public FrmDoiMatKhau(string tendangnhap)
        {
            InitializeComponent();
            blDangNhap = new BL_DangNhap(this);
            this.tendangnhap = tendangnhap;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MaHoaMatKhau blMahoa = new MaHoaMatKhau();


            string matkhauhientai = blMahoa.MaHoa(txtMatkhauHienTai.Text);
            string result = blDangNhap.LayMatKhau(tendangnhap);
            if (result != matkhauhientai)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!!");
            }else
            {
                string matkhaumoi = blMahoa.MaHoa(txtMatKhauMoi.Text);

                string xacnhanmatkhau = blMahoa.MaHoa(txtXacNhanMatKhau.Text);
                if (matkhaumoi != xacnhanmatkhau)
                {
                    MessageBox.Show("Mật khẩu điền vào không giống nhau");
                }
                else if (matkhaumoi == matkhauhientai)
                {
                    MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ");
                }
                else
                {
                    blDangNhap.DoiMatKhau(tendangnhap, matkhaumoi);
                    MessageBox.Show("Đổi mật khẩu thành công !!");
                    this.Close();
                }
            }
        }
    }
}
