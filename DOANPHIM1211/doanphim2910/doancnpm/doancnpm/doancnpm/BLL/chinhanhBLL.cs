using doancnpm.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class chinhanhBLL
	{
        public static tbl_chinhanhDTO GetCNTheoIDCN(string idcn)
        {
            return chinhanhDAL.GetCNTheoIDCN(idcn);

        }
    }
}
