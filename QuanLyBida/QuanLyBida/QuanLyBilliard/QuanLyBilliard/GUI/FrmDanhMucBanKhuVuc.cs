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

namespace QuanLyBilliard.GUI
{
    public partial class FrmDanhMucBanKhuVuc : DevExpress.XtraEditors.XtraForm
    {
        public FrmDanhMucBanKhuVuc()
        {
            InitializeComponent();
        }

        private void cbxLoaiBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbxLoaiBan.Text == "")
            {
                errorProvider1.SetError(cbxLoaiBan, "Bạn chưa nhập Loại Bàn");
            }
            else if (txtTenBan.Text == "")
            {
                errorProvider1.SetError(txtTenBan, "Bạn chưa nhập Tên Bàn");
            }
            else if (txtTenBan.Text == "")
            {
                errorProvider1.SetError(txtTenBan, "Bạn chưa nhập Giá Bán");
            }
            else
            {

            }
        }

        private void cbxLoaiBan_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(cbxLoaiBan, "");
        }

        private void txtTenBan_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTenBan, "");
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtGia, "");
        }

        private void FrmDanhMucBanKhuVuc_Load(object sender, EventArgs e)
        {

        }
    }
}