using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBilliard.DTO;
using QuanLyBilliard.BL;

namespace QuanLyBilliard.GUI
{
    public partial class FrmChuyenBan : Form
    {
        BL_Ban blBan;


        public FrmChuyenBan()
        {
            InitializeComponent();
            blBan = new BL_Ban(this);
        }

        private void FrmChuyenBan_Load(object sender, EventArgs e)
        {
            blBan.HienThiBanTat();
            
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (cbBanChuyen.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn cần chuyển");
            }
            else
            {
                blBan.ChuyenBan(cbBanHienTai.SelectedValue.ToString(), cbBanChuyen.SelectedValue.ToString());
                this.Close();
            }
            
        }
    }
}
