using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
    public class diemtichluyDAL
    {
        public static List<tbl_DiemTichLuyDTO> GetToanBoDTL()
        {
            PhimEntities data = new PhimEntities();
            var nv = from s in data.tbl_DiemTichLuy
                   
                     select s;
            List<tbl_DiemTichLuyDTO> dsnhanvien = new List<tbl_DiemTichLuyDTO>();
            foreach (tbl_DiemTichLuy p in nv)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_DiemTichLuy, tbl_DiemTichLuyDTO>());
                var mapper = new Mapper(config);
                tbl_DiemTichLuyDTO dto = mapper.Map<tbl_DiemTichLuyDTO>(p);
                dsnhanvien.Add(dto);
            }
            return dsnhanvien;
        }
        public static List<tbl_DiemTichLuyDTO> GetToanBoDTLByIDKH(string idkh)
        {
            PhimEntities data = new PhimEntities();
            var nv = from s in data.tbl_DiemTichLuy
                     where s.id_khachhang == idkh
                     select s;
            List<tbl_DiemTichLuyDTO> dsnhanvien = new List<tbl_DiemTichLuyDTO>();
            foreach (tbl_DiemTichLuy p in nv)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_DiemTichLuy, tbl_DiemTichLuyDTO>());
                var mapper = new Mapper(config);
                tbl_DiemTichLuyDTO dto = mapper.Map<tbl_DiemTichLuyDTO>(p);
                dsnhanvien.Add(dto);
            }
            return dsnhanvien;
        }
        public static bool AddNewDTL(tbl_DiemTichLuyDTO a)
        {
            PhimEntities data = new PhimEntities();
            tbl_DiemTichLuy nv = new tbl_DiemTichLuy();
            nv.id_hoadon = a.id_hoadon;
            nv.id_khachhang = a.id_khachhang;
            nv.diemtichluySD = a.diemtichluySD;
            nv.diemtichluynhan = a.diemtichluynhan;
            
            data.tbl_DiemTichLuy.Add(nv);
            return data.SaveChanges() != 0 ? true : false;
        }
        public static int GetCountDTL()
        {
            return GetToanBoDTL().Count;
        }
    }
}
