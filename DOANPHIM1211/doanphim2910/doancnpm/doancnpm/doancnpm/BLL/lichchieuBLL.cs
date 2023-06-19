using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
	public class lichchieuBLL
	{
        public static List<tbl_lichchieuDTO> GetAll()
        {
            return lichchieuDAL.GetAll();
        }
        public static List<tbl_lichchieuDTO> GetFind(DateTime dayfrom, DateTime dayto, string timefr, string timeend, string idphim, int rap)
        {
            return lichchieuDAL.GetFind(dayfrom, dayto, timefr, timeend, idphim, rap);
        }
        public static List<tbl_lichchieuDTO> taoidmoi()
        {
            return lichchieuDAL.taoidmoi();
        }
        public static List<tbl_chinhanh> Get_tenchinhanh()
        {
            return lichchieuDAL.Get_tenchinhanh();
        }
        public static bool restore(tbl_lichchieuDTO dto)
        {
            return lichchieuDAL.restore(dto);
        }
        public static List<tbl_lichchieuDTO> backup()
        {
            return lichchieuDAL.backup();
        }
        public static bool Delete(tbl_lichchieuDTO dto)
        {
            return lichchieuDAL.Delete(dto);
        }
        public static bool Update(tbl_lichchieuDTO dto)
        {
            return lichchieuDAL.Update(dto);
        }
        public static bool AddNew(tbl_lichchieuDTO dto)
        {
            return lichchieuDAL.AddNew(dto);
        }
        public static string GetFind_chinhanh(string id_chinhanh)
        {
            return lichchieuDAL.GetFind_chinhanh(id_chinhanh);
        }
        public static string Truyvanid_chinhanh(string tenchinhanh)
        {
            return lichchieuDAL.Truyvanid_chinhanh(tenchinhanh);
        }
        public static List<tbl_movie> Get_tenphim()
        {
            return lichchieuDAL.Get_tenphim();
        }
        public static string GetFind_tenphim(string id_phim)
        {
            return lichchieuDAL.GetFind_tenphim(id_phim);
        }
        public static string Truyvanid_tenphim(string tenphim)
        {
            return lichchieuDAL.Truyvanid_tenphim(tenphim);
        }
        public static List<tbl_lichchieuDTO> GetLichChieuByNgay(DateTime ngaychieu)
        {
            return lichchieuDAL.GetLichChieuByNgay(ngaychieu);
        }
    }
}
