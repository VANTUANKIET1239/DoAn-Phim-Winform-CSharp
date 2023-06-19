using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
    public class diemtichluyBLL
    {
        public static List<tbl_DiemTichLuyDTO> GetToanBoDTL()
        {
            return diemtichluyDAL.GetToanBoDTL();
        }
        public static bool AddNewDTL(tbl_DiemTichLuyDTO a)
        {
            return diemtichluyDAL.AddNewDTL(a);
        }
        public static int GetCountDTL()
        {
            return diemtichluyDAL.GetCountDTL();
        }
        public static List<tbl_DiemTichLuyDTO> GetToanBoDTLByIDKH(string idkh)
        {
            return diemtichluyDAL.GetToanBoDTLByIDKH(idkh);
        }
    }
}
