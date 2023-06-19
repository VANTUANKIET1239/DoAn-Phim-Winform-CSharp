using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
    public class lichlamviecDAL
    {
        public static bool IsExist(DateTime ngaybd, string idNv)
        {
            /*SqlConnection conn = DataProvider.open();
            string strCauTruyVan =
                "Select COUNT(*) FROM tbl_lichlamviec WHERE idNv = @idNv AND ngaybd = @ngaybd";
            List<SqlParameter> pars = new List<SqlParameter>
            {
                (new SqlParameter("@idNv", idNv)),
                (new SqlParameter("@ngaybd", ngaybd))
            };
            SqlDataReader reader = DataProvider.ExecuteReader(strCauTruyVan, pars.ToArray(), conn);
            bool exist = byte.Parse(reader.GetString(0)) > 0;
            reader.Close();
            conn.Close();
            return exist;*/
            PhimEntities dt = new PhimEntities();
            var ll = (from l in dt.tbl_lichlamviec
                                  where l.id_nhanvien == idNv
                                  where l.ngaybd == ngaybd
                                  select l).Count();
            bool exist = ll > 0;
            return exist;

        }
        public static List<tbl_lichlamviecDTO> GetAll(DateTime dt)
        {
            PhimEntities data = new PhimEntities();
            var truyvan = from lll in data.tbl_lichlamviec
                          where lll.trangthai == true && lll.ngaybd == dt
                          select lll;
            List<tbl_lichlamviecDTO> list_lll = new List<tbl_lichlamviecDTO>();
            foreach (tbl_lichlamviec p in truyvan)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichlamviec, tbl_lichlamviecDTO>());
                var mapper = new Mapper(config);
                tbl_lichlamviecDTO dto = mapper.Map<tbl_lichlamviecDTO>(p);
                list_lll.Add(dto);
            }
            return list_lll;
        }


        public static tbl_lichlamviecDTO GetOneByNv(DateTime ngaybd, string idNv)
        {
            PhimEntities dt = new PhimEntities();
            var ll = from l in dt.tbl_lichlamviec
                     where l.id_nhanvien == idNv
                    // where l.ngaybd >= ngaybd
                     select l;
            tbl_lichlamviec kq = new tbl_lichlamviec();
            foreach(tbl_lichlamviec l in ll)
            {
                if(ngaybd.ToString("dd/MM/yyyy") == l.ngaybd.ToString("dd/MM/yyyy"))
                {
                    kq = l;
                    break;
                }
            }
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichlamviec, tbl_lichlamviecDTO>());
            var mapper = new Mapper(config);
            tbl_lichlamviecDTO  dto = mapper.Map<tbl_lichlamviecDTO>(kq);
            return dto;
        }

        public static List<tbl_lichlamviecDTO> GetByCn(string idCn, DateTime ngaybd)
        {
            PhimEntities dt = new PhimEntities();
            var ll = from l in dt.tbl_lichlamviec
                     where l.id_nhanvien == idCn
                     where l.ngaybd == ngaybd
                     select l;
            List<tbl_lichlamviecDTO> ds = new List<tbl_lichlamviecDTO>();
            foreach(tbl_lichlamviec s in ll)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_lichlamviec, tbl_lichlamviecDTO>());
                var mapper = new Mapper(config);
                tbl_lichlamviecDTO dto = mapper.Map<tbl_lichlamviecDTO>(ll);

                ds.Add(dto);
            }
            return ds;
        }


        public static bool AddNew(tbl_lichlamviecDTO Lich)
        {
            PhimEntities data = new PhimEntities();
            tbl_lichlamviec nv = new tbl_lichlamviec();
            nv.id_nhanvien = Lich.id_nhanvien;
            nv.ngaybd = Lich.ngaybd;
            nv.MonMOR = Lich.MonMOR;
            nv.TueMOR = Lich.TueMOR;
            nv.WedMOR = Lich.WedMOR;
            nv.ThuMOR = Lich.ThuMOR;
            nv.FriMOR = Lich.FriMOR;
            nv.SatMOR = Lich.SatMOR;
            nv.SunMOR = Lich.SunMOR;
            nv.MonEVE = Lich.MonEVE;
            nv.TueEVE = Lich.TueEVE;
            nv.WedEVE = Lich.WedEVE;
            nv.ThuEVE = Lich.ThuEVE;
            nv.FriEVE = Lich.FriEVE;
            nv.SatEVE = Lich.SatEVE;
            nv.SunEVE = Lich.SunEVE;
            data.tbl_lichlamviec.Add(nv);
            return data.SaveChanges() != 0 ? true : false;
        }


        public static bool Delete(DateTime ngaybd, string id)
        {
            PhimEntities data = new PhimEntities();
            var nv = from p in data.tbl_lichlamviec
                                  where p.id_nhanvien == id
                                  //where p.ngaybd.ToString("dd/MM/yyyy") == ngaybd
                                  select p;
            tbl_lichlamviec kq = new tbl_lichlamviec();
            foreach (tbl_lichlamviec l in nv)
            {
                if (ngaybd.ToString("dd/MM/yyyy") == l.ngaybd.ToString("dd/MM/yyyy"))
                {
                    data.tbl_lichlamviec.Remove(l);
                    break;
                }
            }
            return data.SaveChanges() != 0 ? true : false;
        }

        public static bool Modify(tbl_lichlamviecDTO Lich)
        {
            PhimEntities data = new PhimEntities();           
            tbl_lichlamviec nv = (from p in data.tbl_lichlamviec
                                  where p.id_nhanvien == Lich.id_nhanvien
                                  where p.ngaybd == Lich.ngaybd
                                  select p).Single<tbl_lichlamviec>();
            nv.id_nhanvien = Lich.id_nhanvien;
            nv.ngaybd = Lich.ngaybd;
            nv.MonMOR = Lich.MonMOR;
            nv.TueMOR = Lich.TueMOR;
            nv.WedMOR = Lich.WedMOR;
            nv.ThuMOR = Lich.ThuMOR;
            nv.FriMOR = Lich.FriMOR;
            nv.SatMOR = Lich.SatMOR;
            nv.SunMOR = Lich.SunMOR;
            nv.MonEVE = Lich.MonEVE;
            nv.TueEVE = Lich.TueEVE;
            nv.WedEVE = Lich.WedEVE;
            nv.ThuEVE = Lich.ThuEVE;
            nv.FriEVE = Lich.FriEVE;
            nv.SatEVE = Lich.SatEVE;
            nv.SunEVE = Lich.SunEVE;
            return data.SaveChanges() != 0 ? true : false;
        }
    }
}
