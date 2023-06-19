using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
    public class ticketBLL
    {
        public static List<tbl_ticketDTO> GetToanBoVe()
        {
            
            return ticketDAL.GetToanBoVe();
        }
        public static bool AddNewVe(tbl_ticketDTO a)
        {
            return ticketDAL.AddNewVe(a);
        }
        public static int GetCountVe()
        {
            return ticketDAL.GetCountVe();
        }
        public static List<string> GetGheTheoLichChieu(string idlc)
        {
            
            return ticketDAL.GetGheTheoLichChieu(idlc);
        }
    }

}
