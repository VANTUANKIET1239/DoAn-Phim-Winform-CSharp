using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
    public class ticketDAL
    {
        public static List<tbl_ticketDTO> GetToanBoVe()
        {
            PhimEntities data = new PhimEntities();
            var nv = from s in data.tbl_ticket
                     where s.trangthai == true
                     select s;
            List<tbl_ticketDTO> dsnhanvien = new List<tbl_ticketDTO>();
            foreach (tbl_ticket p in nv)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_ticket, tbl_ticketDTO>());
                var mapper = new Mapper(config);
                tbl_ticketDTO dto = mapper.Map<tbl_ticketDTO>(p);
                dsnhanvien.Add(dto);
            }
            return dsnhanvien;
        }
        public static bool AddNewVe(tbl_ticketDTO a)
        {
            
                PhimEntities data = new PhimEntities();
                tbl_ticket nv = new tbl_ticket();
                nv.id_ve = a.id_ve;
                nv.id_lichchieu = a.id_lichchieu;
                nv.ghe = a.ghe;
                nv.giave = a.giave;
                nv.trangthai = a.trangthai;
                data.tbl_ticket.Add(nv);
                return data.SaveChanges() != 0 ? true : false;
            
           
        }
        public static int GetCountVe()
        {
            return GetToanBoVe().Count;
        }
        public static List<string> GetGheTheoLichChieu(string idlc)
        {
            PhimEntities data = new PhimEntities();
            List<string> cacghe = new List<string>();
            var nv = from s in data.tbl_ticket
                     where s.trangthai == true
                     where s.id_lichchieu == idlc
                     select s;
            foreach (tbl_ticket v in nv)
            {
                cacghe.Add(v.ghe);
            }
            return cacghe;
        }
    }
}
