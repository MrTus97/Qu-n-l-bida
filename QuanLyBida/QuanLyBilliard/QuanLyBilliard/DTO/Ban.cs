using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBilliard.DTO
{
    class Ban
    {
        public int ID_Ban { get; set; }
        public string TenBan { get; set; }
        public bool TrangThai { get; set; }
        public DateTime GioVao { get; set; }
        public DateTime GioRa { get; set; }
        public int ID_LoaiBan { get; set; }
        public Ban(DataRow row)
        {
            this.ID_Ban = (int)row["ID_BAN"];
            this.TenBan = row["tenban"].ToString();
            this.TrangThai = (bool)row["trangthai"];
            if (row["GIOVAO"].ToString() == "")
            {
                this.GioVao = default(DateTime);
            }
            else this.GioVao = (DateTime)row["gioVao"];
            if (row["GIORA"].ToString() == "")
            {
                this.GioVao = DateTime.Now;
            }
            else this.GioRa = (DateTime)row["GIORA"];
            this.ID_LoaiBan = (int)row["ID_loaiban"];
        }
        
    }

}
