using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
	public class nhanvienDAL
	{
        public static List<tbl_nhanvienDTO> GetToanBoNhanVien()
        {
            PhimEntities data = new PhimEntities();
            var nv = from s in data.tbl_nhanvien
                       where s.trangthai == true
                       select s;
            List<tbl_nhanvienDTO> dsnhanvien = new List<tbl_nhanvienDTO>();
            foreach (tbl_nhanvien p in nv)
            {              
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_nhanvien, tbl_nhanvienDTO>());
                var mapper = new Mapper(config);
                tbl_nhanvienDTO dto = mapper.Map<tbl_nhanvienDTO>(p);
                dsnhanvien.Add(dto);
            }
            return dsnhanvien;
        }
        public static tbl_nhanvienDTO GetNhanVienTheoID(string idnv)
        {
            PhimEntities data = new PhimEntities();
            tbl_nhanvien temp = (from nv in data.tbl_nhanvien
                              where nv.id_nhanvien == idnv.Trim()
                              where nv.trangthai == true
                              select nv).Single();
            tbl_nhanvienDTO dto = new tbl_nhanvienDTO(temp.id_nhanvien,temp.tennhanvien,temp.matkhau,temp.sdt, temp.email,temp.id_chinhanh,temp.trangthai,temp.chucvu);
            return dto;
        }
        public static tbl_nhanvienDTO GetNhanVienTheoTen(string ten)
        {
            PhimEntities data = new PhimEntities();
            tbl_nhanvien temp = (from nv in data.tbl_nhanvien
                                 where nv.tennhanvien == ten.Trim()
                                 where nv.trangthai == true
                                 select nv).Single();
            tbl_nhanvienDTO dto = new tbl_nhanvienDTO(temp.id_nhanvien, temp.tennhanvien, temp.matkhau, temp.sdt, temp.email, temp.id_chinhanh, temp.trangthai, temp.chucvu);
            return dto;
        }
        public static bool UpdateMatKhauNV(tbl_nhanvienDTO nhanvien)
        {
            PhimEntities data = new PhimEntities();
            tbl_nhanvien nv = (from p in data.tbl_nhanvien
                            where p.id_nhanvien == nhanvien.id_nhanvien.Trim()
                            select p).Single<tbl_nhanvien>();
            nv.matkhau = nhanvien.matkhau;
            return data.SaveChanges() != 0 ? true : false;
        }
        public static List<tbl_nhanvienDTO> GetNhanVienTheoCN(string idCn)
        {
            PhimEntities data = new PhimEntities();
            var temp = from nv in data.tbl_nhanvien
                                 where nv.id_chinhanh == idCn.Trim()
                                 where nv.trangthai == true
                                 select nv;
            List<tbl_nhanvienDTO> ds = new List<tbl_nhanvienDTO>();
            foreach(tbl_nhanvien s in temp)
            {            
                tbl_nhanvienDTO dto = new tbl_nhanvienDTO(s.id_nhanvien, s.tennhanvien, s.matkhau, s.sdt, s.email, s.id_chinhanh, s.trangthai, s.chucvu);
                ds.Add(dto);
            }
            return ds;
        }
    
            public static bool AddNew(tbl_nhanvienDTO phim)
            {
                //var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_movieDTO, tbl_movie>());
                //  var mapper = new Mapper(config);
                //  tbl_movie dto = mapper.Map<tbl_movie>(phim);
                //  PhimEntities1 data = new PhimEntities1();
                //  data.tbl_movie.Add(dto);
                // return data.SaveChanges() > 0 ? true : false;
                PhimEntities data = new PhimEntities();
                tbl_nhanvien nv = new tbl_nhanvien();
            nv.id_nhanvien = phim.id_nhanvien;
            nv.tennhanvien = phim.tennhanvien;
            nv.chucvu = phim.chucvu;
            nv.id_chinhanh = phim.id_chinhanh;
            nv.matkhau = phim.matkhau;
            nv.sdt = phim.sdt;
            nv.email = phim.email;
            nv.trangthai = phim.trangthai;
                data.tbl_nhanvien.Add(nv);
                return data.SaveChanges() != 0 ? true : false;

            }
        
        public static bool Modify(tbl_nhanvienDTO phim)
        {
            PhimEntities data = new PhimEntities();
            tbl_nhanvien nv = (from n in data.tbl_nhanvien
                     where n.id_nhanvien == phim.id_nhanvien.Trim()
                     where n.trangthai == true
                     select n).Single();
            nv.id_nhanvien = phim.id_nhanvien;
            nv.tennhanvien = phim.tennhanvien;
            nv.chucvu = phim.chucvu;
            nv.id_chinhanh = phim.id_chinhanh;
            nv.matkhau = phim.matkhau;
            nv.sdt = phim.sdt;
            nv.email = phim.email;
            nv.trangthai = phim.trangthai;
            return data.SaveChanges() != 0 ? true : false;
        }
        public static bool Delete(string id)
        {
            PhimEntities data = new PhimEntities();
            tbl_nhanvien nv = (from p in data.tbl_nhanvien
                            where p.id_nhanvien == id.Trim()
                            select p).Single<tbl_nhanvien>();
            nv.trangthai = false;
            return data.SaveChanges() != 0 ? true : false;
        }
        public static bool Recover(string id)
        {
            PhimEntities data = new PhimEntities();
            tbl_nhanvien nv = (from p in data.tbl_nhanvien
                               where p.id_nhanvien == id.Trim()
                               select p).Single<tbl_nhanvien>();
            nv.trangthai = true;
            return data.SaveChanges() != 0 ? true : false;
        }

        public static int GetCountNV()
        {
            return GetToanBoNhanVien().Count;
        }
    }
}
