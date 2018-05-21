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

namespace QuanLyBilliard.GUI
{
    public partial class FrmBaoCaoKho : Form
    {
        private BL_LoaiThucPham blLoaiThucPham;
        private BL_ThucPham blThucPham;
        public FrmBaoCaoKho()
        {
            InitializeComponent();
            blLoaiThucPham = new BL_LoaiThucPham(this);
            blThucPham = new BL_ThucPham(this);
        }

        private void FrmBaoCaoKho_Load(object sender, EventArgs e)
        {
            LoadLoaiThucPham();
        }

        public void LoadLoaiThucPham()
        {
            List<LoaiThucPham> lst = blLoaiThucPham.LoadLoaiThucPham();
            foreach (LoaiThucPham food in lst)
            {
                treeView1.Nodes.Add(food.id.ToString(), food.tenloai);
                treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
                treeView1.Tag = food;
            }
        }
    
        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //LoadThucPham(Int32.Parse(e.Node.Name));
            //blThucPham.getDuLieu(Int32.Parse(e.Node.Name));
            Console.WriteLine(e.Node.Name);
            DataTable reuslt = blThucPham.LayDuLieuThucPham(Int32.Parse(e.Node.Name));
            RefeshDgvBaoCao(reuslt);
            //btnDaiDienThucPham.Tag = null;
            
        }

        private void RefeshDgvBaoCao(DataTable result)
        {
            dgvBaoCao.Rows.Clear();
            foreach (DataRow row in result.Rows)
            {
                dgvBaoCao.Rows.Add(row.ItemArray);
            }
        }
    }
}
