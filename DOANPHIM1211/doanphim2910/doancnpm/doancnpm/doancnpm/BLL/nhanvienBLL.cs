using AutoMapper;
using doancnpm.DAL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.BLL
{
	public class nhanvienBLL
	{
        public static List<tbl_nhanvienDTO> GetToanBoNhanVien()
        { 
            return nhanvienDAL.GetToanBoNhanVien();
        }
        public static tbl_nhanvienDTO GetNhanVienTheoID(string idnv)
        {
           
            return nhanvienDAL.GetNhanVienTheoID(idnv);
        }
        public static bool UpdateMatKhauNV(tbl_nhanvienDTO nhanvien)
        {

            return nhanvienDAL.UpdateMatKhauNV(nhanvien);
        }
        public static List<tbl_nhanvienDTO> GetNhanVienTheoCN(string idCn)
        {
            return nhanvienDAL.GetNhanVienTheoCN(idCn);
        }
    
        public static bool AddNew(tbl_nhanvienDTO nv)
        {
            return nhanvienDAL.AddNew(nv);
        }
        public static bool Modify(tbl_nhanvienDTO nv)
        {
            return nhanvienDAL.Modify(nv);
        }
        public static bool Delete(string id)
        {
            return nhanvienDAL.Delete(id);
        }
        public static bool Recover(string id)
        {
            return nhanvienDAL.Recover(id);
        }
        public static int GetCountNV()
        {
            return nhanvienDAL.GetCountNV();
        }
        public static tbl_nhanvienDTO GetNhanVienTheoTen(string ten)
        {
            return nhanvienDAL.GetNhanVienTheoTen(ten);
        }
    }
}
