using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
	public class lichchieuDAL
	{
        public static List<tbl_lichchieuDTO> GetAll()
        {
            PhimEntities data = new PhimEntities();
            var truyvan = from lichchieu in data.tbl_lichchieu
                          where lichchieu.trangthai == true
                          select lichchieu;
            List<tbl_lichchieuDTO> list_lichchieu = new List<tbl_lichchieuDTO>();
            foreach (tbl_lichchieu p in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichchieu, tbl_lichchieuDTO>());
                var mapper = new Mapper(config);
                tbl_lichchieuDTO dto = mapper.Map<tbl_lichchieuDTO>(p);
                list_lichchieu.Add(dto);
            }
            return list_lichchieu;
        }
        public static List<tbl_lichchieuDTO> backup()
        {
            PhimEntities data = new PhimEntities();
            var truyvan = from lichchieu in data.tbl_lichchieu
                          where lichchieu.trangthai == false
                          select lichchieu;
            List<tbl_lichchieuDTO> list_lichchieu = new List<tbl_lichchieuDTO>();
            foreach (tbl_lichchieu p in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichchieu, tbl_lichchieuDTO>());
                var mapper = new Mapper(config);
                tbl_lichchieuDTO dto = mapper.Map<tbl_lichchieuDTO>(p);
                list_lichchieu.Add(dto);
            }
            return list_lichchieu;
        }
        public static List<tbl_lichchieuDTO> taoidmoi()
        {
            PhimEntities data = new PhimEntities();
            var truyvan = from lichchieu in data.tbl_lichchieu
                          select lichchieu;
            List<tbl_lichchieuDTO> list_lichchieu = new List<tbl_lichchieuDTO>();
            foreach (tbl_lichchieu p in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichchieu, tbl_lichchieuDTO>());
                var mapper = new Mapper(config);
                tbl_lichchieuDTO dto = mapper.Map<tbl_lichchieuDTO>(p);
                list_lichchieu.Add(dto);
            }
            return list_lichchieu;
        }

        public static List<tbl_lichchieuDTO> GetFind(DateTime dayfrom, DateTime dayto, string timefr, string timeend, string idphim, int rap)
        {
            PhimEntities data = new PhimEntities();
            var truyvan = from lichchieu in data.tbl_lichchieu
                          where ((lichchieu.ngay >= dayfrom && lichchieu.ngay <= dayto) ||
                                 (string.Compare(lichchieu.giochieu.Substring(1, 4), timefr) < 0 &&
                                  string.Compare(lichchieu.giochieu.Substring(1, 4), timeend) > 0) ||
                                (lichchieu.id_phim.ToLower() == idphim.ToLower()) ||
                                ((lichchieu.rap == rap)))
                          select lichchieu;
            List<tbl_lichchieuDTO> list_lichchieu = new List<tbl_lichchieuDTO>();
            foreach (tbl_lichchieu p in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichchieu, tbl_lichchieuDTO>());
                var mapper = new Mapper(config);
                tbl_lichchieuDTO dto = mapper.Map<tbl_lichchieuDTO>(p);
                list_lichchieu.Add(dto);
            }
            return list_lichchieu;
        }
        public static bool Delete(tbl_lichchieuDTO dto)
        {
            PhimEntities data = new PhimEntities();
            tbl_lichchieu nv = (from p in data.tbl_lichchieu
                                where p.id_lichchieu == dto.id_lichchieu
                                select p).FirstOrDefault();
            nv.trangthai = false;

            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool restore(tbl_lichchieuDTO dto)
        {
            PhimEntities data = new PhimEntities();
            tbl_lichchieu nv = (from p in data.tbl_lichchieu
                                where p.id_lichchieu == dto.id_lichchieu
                                select p).FirstOrDefault();
            nv.trangthai = true;

            return data.SaveChanges() > 0 ? true : false;
        }
        public static bool Update(tbl_lichchieuDTO dto)
        {
            PhimEntities data = new PhimEntities();
            tbl_lichchieu nv = (from p in data.tbl_lichchieu
                                where p.id_lichchieu == dto.id_lichchieu
                                select p).FirstOrDefault();

            nv.ngay = dto.ngay;
            nv.giochieu = dto.giochieu;
            nv.id_phim = dto.id_phim;
            nv.rap = dto.rap;
            nv.id_chinhanh = dto.id_chinhanh;
            nv.trangthai = true;
            return data.SaveChanges() > 0 ? true : false;
        }
        public static string GetFind_chinhanh(string id_chinhanh)
        {
            PhimEntities data = new PhimEntities();
            tbl_chinhanh cn = (from p in data.tbl_chinhanh
                               where p.id_chinhanh == id_chinhanh
                               select p).FirstOrDefault();
            return cn.tenchinhanh;
        }
        public static string Truyvanid_chinhanh(string tenchinhanh)
        {
            PhimEntities data = new PhimEntities();
            tbl_chinhanh cn = (from p in data.tbl_chinhanh
                               where p.tenchinhanh.ToLower() == tenchinhanh.ToLower()
                               select p).FirstOrDefault();
            return cn.id_chinhanh;

        }
        public static List<tbl_movie> Get_tenphim()
        {
            PhimEntities data = new PhimEntities();
            var truyvan = from moviee in data.tbl_movie
                          select moviee;
            List<tbl_movie> list_lichchieu = new List<tbl_movie>();
            foreach (tbl_movie p in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_movie, tbl_movie>());
                var mapper = new Mapper(config);
                tbl_movie dto = mapper.Map<tbl_movie>(p);
                list_lichchieu.Add(dto);
            }
            return list_lichchieu;
        }
        public static bool AddNew(tbl_lichchieuDTO dto)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichchieuDTO, tbl_lichchieu>());
            var mapper = new Mapper(config);
            tbl_lichchieu nv = mapper.Map<tbl_lichchieu>(dto);
            /*var config = new MapperConfiguration(cfg => cfg.CreateMap<NhanVienDTO, NhanVien>());
                        var mapper = new Mapper(config);
                        NhanVien nv = mapper.Map<NhanVien>(dto);*/
            PhimEntities data = new PhimEntities();
            data.tbl_lichchieu.Add(nv);
            return data.SaveChanges() > 0 ? true : false;
        }
        public static List<tbl_chinhanh> Get_tenchinhanh()
        {
            PhimEntities data = new PhimEntities();
            var truyvan = from cn in data.tbl_chinhanh
                          select cn;
            List<tbl_chinhanh> list_lichchieu = new List<tbl_chinhanh>();
            foreach (tbl_chinhanh p in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_chinhanh, tbl_chinhanh>());
                var mapper = new Mapper(config);
                tbl_chinhanh dto = mapper.Map<tbl_chinhanh>(p);
                list_lichchieu.Add(dto);
            }
            return list_lichchieu;
        }
        public static string GetFind_tenphim(string id_phim)
        {
            PhimEntities data = new PhimEntities();
            tbl_movie Mv = (from p in data.tbl_movie
                            where p.id_phim == id_phim
                            select p).FirstOrDefault();
            return Mv.tenphim;
        }
        public static string Truyvanid_tenphim(string tenphim)
        {
            PhimEntities data = new PhimEntities();
            tbl_movie Mv = (from p in data.tbl_movie
                            where p.tenphim.ToLower() == tenphim.ToLower()
                            select p).FirstOrDefault();
            string temp = Mv.id_phim.ToString();
            return temp;
        }
        public static List<tbl_lichchieuDTO> GetLichChieuByNgay(DateTime ngaychieu)
        {
            List<tbl_lichchieuDTO> lc = new List<tbl_lichchieuDTO>();
           foreach(tbl_lichchieuDTO a in GetAll())
            {
                if(ngaychieu.ToString("dd/MM/yyyy") == a.ngay.ToString("dd/MM/yyyy"))
                {
                    lc.Add(a);
                }
            }
            return lc;
        }

    }
}
