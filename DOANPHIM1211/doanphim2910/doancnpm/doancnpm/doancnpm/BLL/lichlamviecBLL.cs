using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
    public class lichlamviecBLL
    {
        public static bool IsExist(DateTime ngaybd, string idNv)
        {

            return lichlamviecDAL.IsExist(ngaybd, idNv);
        }


        public static tbl_lichlamviecDTO GetOneByNv(DateTime ngaybd, string idNv)
        {

            return lichlamviecDAL.GetOneByNv(ngaybd, idNv);
        }

        public static List<tbl_lichlamviecDTO> GetByCn(string idCn, DateTime ngaybd)
        {
            return lichlamviecDAL.GetByCn(idCn,ngaybd);
        }


        public static bool AddNew(tbl_lichlamviecDTO Lich)
        {
            return lichlamviecDAL.AddNew(Lich);
        }


        public static bool Delete(DateTime ngaybd, string id)
        {
            return lichlamviecDAL.Delete(ngaybd, id);
        }

        public static bool Modify(tbl_lichlamviecDTO Lich)
        {
            return lichlamviecDAL.Modify(Lich);
        }
        public static List<tbl_lichlamviecDTO> GetAll(DateTime dt)
        {
            return lichlamviecDAL.GetAll(dt);
        }
    }
}
