using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
	public class hoadonBLL
	{
        public static List<tbl_hoadonDTO> GetToanBoHD()
        {
            return hoadonDAL.GetToanBoHD();
        }
        public static bool AddNewHD(tbl_hoadonDTO a)
        {

            return hoadonDAL.AddNewHD(a);
        }
        public static int GetCountHD()
        {
            return hoadonDAL.GetCountHD();
        }
    }
}
