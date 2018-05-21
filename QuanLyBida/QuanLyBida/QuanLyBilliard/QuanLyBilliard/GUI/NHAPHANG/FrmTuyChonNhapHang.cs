using QuanLyBilliard.BL;
using QuanLyBilliard.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI.NHAPHANG
{
    public partial class FrmTuyChonNhapHang : Form
    {
        private BL_LoaiThucPham blLoaiThucPham;
        private BL_ThucPham blThucPham;
        //Chứa mặt hàng nhập, đơn giá, số lượng,tổng tiền same same với datagridview hiển thị
        DataTable matHangNhap;
        const int SOLUONGNHAP = 1;
        const int GIANHAP = 2;
        const int TONGTIEN = 3;
        const int ID_MATHANG = 4;
        BL_NhapHang blNhapHang;
        private int v;

        public FrmTuyChonNhapHang(int v)
        {
            InitializeComponent();
            this.v = v;

        }


        public void TaoMoibang()
        {
            matHangNhap = new DataTable();
            for (int i = 0; i < 5; i++)
            {
                DataColumn column;
                column = new DataColumn();
                //column.DataType = System.Type.GetType("System.Int32");
                column.ColumnName = i.ToString();
                column.ReadOnly = true;
                column.Unique = false;
                // Add the Column to the DataColumnCollection.
                matHangNhap.Columns.Add(column);
            }

        }
        private void FrmTuyChonNhapHang_Load(object sender, EventArgs e)
        {
            blLoaiThucPham = new BL_LoaiThucPham(this);
            blThucPham = new BL_ThucPham(this);
            blNhapHang = new BL_NhapHang(this);
            LoadLoaiThucPham();
            TaoMoibang();
            //Nếu số hóa đơn là 0 thì là thêm mới
            if (v == 0)
            {
                txtSoHoaDon.Text = v.ToString();
                txtSoHoaDon.Visible = false;
                lbSoHoaDonNhapHang.Visible = false;
                dtpNgayTaoHoaDon.Text = DateTime.Now.ToShortDateString();
            }
            else //Sửa hóa đơn cũ
            {

                txtSoHoaDon.Text = v.ToString();
                txtSoHoaDon.Enabled = false;
                DataTable result = blNhapHang.LayDuLieuHoaDonNhap(v);

                txtTenHoaDon.Text = result.Rows[0][1].ToString();
                dtpNgayTaoHoaDon.Text = result.Rows[0][2].ToString();
                //Show lên datagridview
                result = blNhapHang.LayDuLieuChiTietHoaDonNhap(v);
                RefeshMatHangNhap(result);
                matHangNhap = result;
            }

        }

        private void LoadLoaiThucPham()
        {
            List<LoaiThucPham> lst = blLoaiThucPham.LoadLoaiThucPham();
            RefeshLoaiThucPham(lst);
        }

        private void RefeshLoaiThucPham(List<LoaiThucPham> lst)
        {
            foreach (LoaiThucPham food in lst)
            {
                treeView1.Nodes.Add(food.id.ToString(), food.tenloai);
                treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
                treeView1.Tag = food;
            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            LoadThucPham(Int32.Parse(e.Node.Name));
        }

        private void LoadThucPham(int v)
        {
            DataTable result = blThucPham.getDuLieu(v);
            RefeshThucPham(result);
        }

        private void RefeshThucPham(DataTable result)
        {
            dataGridView1.Rows.Clear();
            foreach (DataRow row in result.Rows)
            {
                dataGridView1.Rows.Add(row["TENTHUCPHAM"], row["DVT"], row["GIABAN"], row["ID_THUCPHAM"]);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text;
            DataTable dt = blThucPham.TimThucPham(keyword);
            RefeshThucPham(dt);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Tag = dataGridView1.CurrentRow;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn thực phẩm để thêm");
            }
            else if (cbSoLuong.Text == "0")
            {
                MessageBox.Show("Không thể thêm mặt hàng với số lượng là 0");
            }
            else
            {

                //Trước hết cần phải kiểm tra hàng đó có trong danh sách bill chưa, nếu có rồi thì update số lượng, còn chưa thì mới insert => kiểm tra và làm 1 lần trong csdl
                int soluong=0;
                try
                {
                    soluong = Int32.Parse(cbSoLuong.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Số lượng sai định dạng");
                }
                int id_thucpham = (int)(btnThem.Tag as DataGridViewRow).Cells["ID_THUCPHAM"].Value;
                string tenThucPham = (btnThem.Tag as DataGridViewRow).Cells["TENTHUCPHAM"].Value.ToString();
                int gianhap = Convert.ToInt32(txtGiaNhap.Text);
                int tongtien = soluong * gianhap;
                int i = 0;
                foreach (DataRow row in matHangNhap.Rows)
                {
                    if (row[ID_MATHANG].ToString() == id_thucpham.ToString() && row[GIANHAP].ToString() == gianhap.ToString())
                    {
                        soluong += Convert.ToInt32((matHangNhap.Rows[i]).ItemArray[1]);
                        matHangNhap.Rows.RemoveAt(i);
                        break;

                    }
                    i++;
                }
                matHangNhap.Rows.Add(tenThucPham, soluong, gianhap, tongtien, id_thucpham);

                //Hiển thị lên dgv
                RefeshMatHangNhap(matHangNhap);
            }
        }
        private void RefeshMatHangNhap(DataTable matHangNhap)
        {
            dgvTuyChonNhapHang.Rows.Clear();
            foreach (DataRow row in matHangNhap.Rows)
            {
                dgvTuyChonNhapHang.Rows.Add(row.ItemArray);
            }
        }

        private void btnGhiDuLieu_Click(object sender, EventArgs e)
        {
            int soHoaDon = 0;
            string tenHoaDon = null;
            DateTime ngayTaoHoaDon = DateTime.Today;
            soHoaDon = Int32.Parse(txtSoHoaDon.Text);
            tenHoaDon = txtTenHoaDon.Text;
            ngayTaoHoaDon = DateTime.Parse(dtpNgayTaoHoaDon.Text);
            int kq =blNhapHang.TuyChonNhapHang(soHoaDon, tenHoaDon, ngayTaoHoaDon, matHangNhap);
            if (kq > 0)
            {
                MessageBox.Show("Thành công");
            }else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void txtSoHoaDon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sai định dạng ", "Thông Báo ");
            }
        }

        private void txtGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sai định dạng ", "Thông Báo ");
            }
        }

        private void dgvTuyChonNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDoiSoLuong.Tag = dgvTuyChonNhapHang.CurrentRow;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (btnDoiSoLuong.Tag == null)
            {
                MessageBox.Show("Bạn chưa chọn mặt hàng cần xóa");
            }else
            {
                int idMatHang = Int32.Parse((btnDoiSoLuong.Tag as DataGridViewRow).Cells[4].Value.ToString());
                foreach (DataRow row in matHangNhap.Rows)
                {
                    if (idMatHang.ToString() == row[ID_MATHANG].ToString())
                    {
                        matHangNhap.Rows.Remove(row);
                        break;
                    }
                }
                RefeshMatHangNhap(matHangNhap);
            }
        }

    }
}
