using QuanLyBilliard.DA;
using QuanLyBilliard.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
        }



        public int SuaCapBac(string idcapbac, string tencapbac, string hesoluong)
        {
            try
            {
                int id = Int32.Parse(idcapbac);
                float hsl = float.Parse(hesoluong);
                return daCapBac.SuaCapBac(id, tencapbac, hsl);
            }
            catch (Exception)
            {
                return BATLOI.SAI_DINH_DANG;
            }

        }

        public int XoaCapBac(string idcapbac)
        {
            try
            {
                int id = Int32.Parse(idcapbac);
                return daCapBac.XoaCapBac(id);
            }
            catch (Exception)
            {
                return BATLOI.SAI_DINH_DANG;
            }


        }

        public int ThemCapBac(string tencapbac, string hesoluong)
        {
            try
            {
                float hsl = float.Parse(hesoluong);
                return daCapBac.ThemCapBac(tencapbac, hsl);
            }
            catch (Exception)
            {
                return BATLOI.SAI_DINH_DANG;
            }
        }

        public DataTable LayDanhSachCapBac()
        {
            return daCapBac.LayDanhSachCapBac();
        }
    }
}
