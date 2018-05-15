using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBilliard.GUI;
using QuanLyBilliard.DA;

namespace QuanLyBilliard.BL
{
    class BL_PhieuThu
    {
        private FrmPhieuThu frmPhieuThu;
        private DA_PhieuThu daPhieuThu = new DA_PhieuThu();
        public BL_PhieuThu(FrmPhieuThu frmPhieuThu)
        {
            this.frmPhieuThu = frmPhieuThu;
        }

        public DataTable LayDuLieuPhieuThu()
        {
            return daPhieuThu.LayDuLieuPhieuThu();
        }
    }
}
