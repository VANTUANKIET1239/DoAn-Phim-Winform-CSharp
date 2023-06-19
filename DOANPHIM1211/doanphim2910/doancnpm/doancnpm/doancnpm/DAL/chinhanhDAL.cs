using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
    class chinhanhDAL {
        public static tbl_chinhanhDTO GetCNTheoIDCN(string idcn)
        {
            PhimEntities dt = new PhimEntities();
            tbl_chinhanh cn = (from c in dt.tbl_chinhanh
                     where c.id_chinhanh == idcn
                     select c).Single();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_chinhanh, tbl_chinhanhDTO>());
            var mapper = new Mapper(config);
            tbl_chinhanhDTO dto = mapper.Map<tbl_chinhanhDTO>(cn);
            return dto;

        }
    

    }
}
