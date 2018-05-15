using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.BL
{
    class BL_CapBac
    {
        DA_CapBac daCapBac;
        FrmCapBac frmCapBac;

        public BL_CapBac(FrmCapBac f)
        {
            frmCapBac = f;
            daCapBac = new DA_CapBac();
            HienThiCapBac();
        }

        public void SuaCapBac(string tencapbac, string hesoluong)
        {
            
        }

        public void HienThiCapBac()
        {
            frmCapBac.dtgCapBac.DataSource =  daCapBac.HienThiCapBac();            
        }

        internal void SuaCapBac(string idcapbac, string tencapbac, string hesoluong)
        {
            int id = Int32.Parse(idcapbac);
            float hsl = float.Parse(hesoluong);
            int result = daCapBac.SuaCapBac(id,tencapbac, hsl);
            if (result > 0) MessageBox.Show("thành công");
            else MessageBox.Show("Thất bại");
        }

        internal void XoaCapBac(string idcapbac)
        {
            int id = Int32.Parse(idcapbac);
            int result = daCapBac.XoaCapBac(id);
            if (result > 0)
            {
                MessageBox.Show("Thanh cong");
            }
            else { MessageBox.Show("That bai"); }

        }

        internal void ThemCapBac(string tencapbac, string hesoluong)
        {
            float hsl = float.Parse(hesoluong);
            daCapBac.ThemCapBac(tencapbac, hsl);
        }
    }
}
