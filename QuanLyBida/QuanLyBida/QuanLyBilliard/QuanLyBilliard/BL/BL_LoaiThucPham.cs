using QuanLyBilliard.DA;
using QuanLyBilliard.DTO;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;

namespace QuanLyBilliard.BL
{
    class BL_LoaiThucPham
    {
        DA_ThucPham daThucPham;
        BL_ThucPham blThucPham;
        DA_LoaiThucPham daLoaiThucPham;
        FrmSuDungDichVu frmSuDungDichVu;
        const int TABLE_WIDTHHEIGHT = 100;
        public BL_LoaiThucPham(FrmSuDungDichVu f)
        {
            daThucPham = new DA.DA_ThucPham();
            daLoaiThucPham = new DA.DA_LoaiThucPham();
            blThucPham = new BL_ThucPham(f);
            frmSuDungDichVu = f;
        }
        public void LoadLoaiThucPham()
        {
            List<LoaiThucPham> lst = daLoaiThucPham.getDuLieu();
            foreach (LoaiThucPham food in lst)
            {
                frmSuDungDichVu.treeView1.Nodes.Add(food.id.ToString(), food.tenloai);
                frmSuDungDichVu.treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
                frmSuDungDichVu.treeView1.Tag = food;
            }
        }
        #region Event
        private void TreeView1_NodeMouseClick(object sender, System.Windows.Forms.TreeNodeMouseClickEventArgs e)
        {
            blThucPham.getDuLieu(Int32.Parse(e.Node.Name));
        }
        #endregion
    }
}
