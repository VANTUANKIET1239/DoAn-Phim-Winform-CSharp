using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
    public class movieBLL
    {
        public static List<tbl_movie> GetToanBoPhim()
        {
            return movieDAL.GetToanBoPhim();
        }
        public static bool AddNewPhim(tbl_movieDTO phim)
        {
            return movieDAL.AddNewPhim(phim);

        }
        public static bool UpdatePhim(tbl_movieDTO phim)
        {
            return movieDAL.UpdatePhim(phim);
        }
        public static bool DeletePhim(string phim)
        {
            return movieDAL.DeletePhim(phim);
        }
        public static int DemSoLuongPhim()
        {
            return movieDAL.DemSoLuongPhim();
        }
        public static List<tbl_movie> GetPhimTheoTheLoai(string tinhtrangphim)
        {

            return movieDAL.GetPhimTheoTheLoai(tinhtrangphim);
        }
        public static tbl_movie GetPhimByTen(string idphim)
        {
            return movieDAL.GetPhimByTen(idphim);
        }
        public static List<string> GetTenPhimToanBo()
        {
            

            return movieDAL.GetTenPhimToanBo();
        }
    }
}
