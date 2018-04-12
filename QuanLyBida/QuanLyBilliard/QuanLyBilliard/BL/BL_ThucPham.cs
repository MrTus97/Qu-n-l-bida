using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.BL
{
    class BL_ThucPham
    {
        DA_ThucPham daThucPham;
        FrmSuDungDichVu frmSuDungDichVu;
        public BL_ThucPham(FrmSuDungDichVu f)
        {
            daThucPham = new DA.DA_ThucPham();
            frmSuDungDichVu = f;
        }
        public void getDuLieu(int id)
        {
            DataTable dt = daThucPham.getDuLieu(id);
            frmSuDungDichVu.dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                frmSuDungDichVu.dataGridView1.Rows.Add(row["TENTHUCPHAM"], row["DVT"], row["GIABAN"], row["ID_THUCPHAM"]);

            }
            //frmMain.dataGridView1.DataSource = daThucPham.getDuLieu(id);
        }
    }
}
