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

namespace QuanLyBilliard.GUI.DANH_MUC.KHACHHANG
{
    public partial class FrmKhachHang : Form
    {
        private BL_KhachHang blKhachHang;
        public FrmKhachHang()
        {
            InitializeComponent();
            blKhachHang = new BL_KhachHang(this);
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dt = blKhachHang.layDuLieuLenDataGridView();
            Refesh(dt);
            
        }
        private void Refesh(DataTable dt)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string gt;
                if (row[4].ToString() == "True")
                {
                    gt = "Nam";
                }
                else
                {
                    gt = "Nữ";
                }
                dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], gt, row[5], row[6]);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmTuyChonKhachHang f = new FrmTuyChonKhachHang(1);
            f.ShowDialog();
            DataTable dt = blKhachHang.layDuLieuLenDataGridView();
            Refesh(dt);
            btnSua.Tag = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Tag = dataGridView1.CurrentRow;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    int k = blKhachHang.xoaKhachHang((btnSua.Tag as DataGridViewRow).Cells["ID_KHACHHANG"].Value.ToString());
                    if (k < 0)
                    {
                        MessageBox.Show("Mặt hàng này đã xuất hiện trong hóa đơn. Không thể xóa !!");
                    }
                    DataTable dt = blKhachHang.layDuLieuLenDataGridView();
                    Refesh(dt);
                    btnSua.Tag = null;
                }


            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnSua.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn gì cả !!");
            }
            else
            {
                FrmTuyChonKhachHang f = new FrmTuyChonKhachHang(2, btnSua.Tag as DataGridViewRow);
                f.ShowDialog();
                DataTable dt = blKhachHang.layDuLieuLenDataGridView();
                Refesh(dt);
                btnSua.Tag = null;

            }
        }
    }
}
