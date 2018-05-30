using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBilliard.DTO;
using QuanLyBilliard.BL;

namespace QuanLyBilliard.GUI
{
    public partial class FrmChuyenBan : Form
    {
        BL_Ban blBan;
        int idBanHienTai;
        const int TABLE_WIDTHHEIGHT = 100;
        public FrmChuyenBan(int id)
        {
            InitializeComponent();
            blBan = new BL_Ban(this);
            this.idBanHienTai = id;
        }

        private void FrmChuyenBan_Load(object sender, EventArgs e)
        {
            HienThiBanTat();
            cbBanHienTai.SelectedValue = idBanHienTai;
            
        }
        public void HienThiBanTat()
        {
            flpBanTat.Controls.Clear();
            List<Ban> lst = blBan.LayBan();
            List<Ban> chuabat = new List<Ban>();
            List<Ban> batroi = new List<Ban>();
            foreach (Ban table in lst)
            {
                // Tạo ra các button bàn, các thuộc tính của bàn như text và cách hiển thị màu của nó
                if (!table.TrangThai)
                {
                    chuabat.Add(table);
                    Button btn = new Button() { Width = TABLE_WIDTHHEIGHT, Height = TABLE_WIDTHHEIGHT };
                    btn.Text = table.TenBan;
                    btn.BackColor = Color.Brown;
                    btn.Click += new EventHandler(btnChonBanChuyen_Click);

                    btn.Tag = table;
                    flpBanTat.Controls.Add(btn);
                }
                else
                {
                    batroi.Add(table);
                }
            }
            cbBanChuyen.DataSource = chuabat;
            cbBanChuyen.DisplayMember = "TenBan";
            cbBanChuyen.ValueMember = "ID_Ban";

            cbBanHienTai.DataSource = batroi;

            cbBanHienTai.DisplayMember = "TenBan";
            cbBanHienTai.ValueMember = "ID_Ban";
            //frmChuyenBan.cbBanHienTai.SelectedValue = (frmSuDungDichVu.btnDaiDienBan.Tag as Ban).ID_Ban;

        }

        public void btnChonBanChuyen_Click(object sender, EventArgs e)
        {
            cbBanChuyen.Text = "";
            cbBanChuyen.SelectedValue = ((sender as Button).Tag as Ban).ID_Ban;
            
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (cbBanChuyen.SelectedValue == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn cần chuyển");
            }
            else
            {
                try
                {
                    int banHienTai = (int)cbBanHienTai.SelectedValue;
                    int banChuyen = (int)cbBanChuyen.SelectedValue;
                    blBan.ChuyenBan(banHienTai,banChuyen);
                    this.Close();
                }
                catch (Exception)
                {
                    int kq = BATLOI.SAI_DINH_DANG;
                    BATLOI.HienThiLoi(kq);
                }
                
            }
            
        }

        private void cbBanChuyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbBanHienTai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
