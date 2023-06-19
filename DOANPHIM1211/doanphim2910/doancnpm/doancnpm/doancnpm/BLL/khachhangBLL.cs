using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
    public class khachhangBLL
    {
        public static List<tbl_khachhangDTO> GetToanBoKhachHang()
        {
         
            return khachhangDAL.GetToanBoKhachHang();
        }
        public static List<string> GetToanBoKhachHangSDT()
        {
            return khachhangDAL.GetToanBoKhachHangSDT();
        }
        public static tbl_khachhangDTO GetKhachHangTheoSDT(string sdt)
        {
            return khachhangDAL.GetKhachHangTheoSDT(sdt);
        }
        public static int GetCountKH()
        {
            return khachhangDAL.GetCountKH() ;
        }
        public static bool AddNew(tbl_khachhangDTO phim)
        {

            return khachhangDAL.AddNew(phim);

        }
        public static bool Modify(tbl_khachhangDTO phim)
        {
            return khachhangDAL.Modify(phim);
        }
        public static bool Delete(string id)
        {
            return khachhangDAL.Delete(id);
        }
        public static tbl_khachhangDTO GetKhachHangTheoID(string id)
        {
            return khachhangDAL.GetKhachHangTheoID(id);
        }
    }
}
