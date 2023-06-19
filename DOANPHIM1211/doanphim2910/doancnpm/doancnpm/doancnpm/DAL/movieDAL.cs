using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
	public class movieDAL
	{
		public static List<tbl_movie> GetToanBoPhim()
        {
            PhimEntities data = new PhimEntities();
            var phimt = from s in data.tbl_movie
                        where s.trangthai == true
                       select s;                  
            return phimt.ToList<tbl_movie>();
        }
      
        public static bool AddNewPhim(tbl_movieDTO phim)
        {
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_movieDTO, tbl_movie>());
            //  var mapper = new Mapper(config);
            //  tbl_movie dto = mapper.Map<tbl_movie>(phim);
            //  PhimEntities1 data = new PhimEntities1();
            //  data.tbl_movie.Add(dto);
            // return data.SaveChanges() > 0 ? true : false;
            PhimEntities data = new PhimEntities();
            tbl_movie nv = new tbl_movie();
            nv.id_phim = phim.id_phim;
            nv.tenphim = phim.tenphim;
            nv.phanloai = phim.phanloai;
            nv.daodien = phim.daodien;
            nv.dienvien = phim.dienvien;
            nv.theloai = phim.theloai;
            nv.khoichieu = phim.khoichieu;
            nv.thoiluong = phim.thoiluong;
            nv.tinhtrangphim = phim.tinhtrangphim;
            nv.trangthai = phim.trangthai;
            nv.hinhanh = phim.hinhanh;
            data.tbl_movie.Add(nv);
            return data.SaveChanges() != 0 ? true : false;

        }
        public static bool UpdatePhim(tbl_movieDTO phim)
        {
            PhimEntities data = new PhimEntities();
            tbl_movie nv = (from p in data.tbl_movie
                            where p.id_phim == phim.id_phim.Trim() 
                            select p).Single<tbl_movie>();
            nv.id_phim = phim.id_phim;
            nv.tenphim = phim.tenphim;
            nv.phanloai = phim.phanloai;
            nv.daodien = phim.daodien;
            nv.dienvien = phim.dienvien;
            nv.theloai = phim.theloai;
            nv.khoichieu = phim.khoichieu;
            nv.thoiluong = phim.thoiluong;
            nv.tinhtrangphim = phim.tinhtrangphim;
            nv.trangthai = phim.trangthai;
            nv.hinhanh = phim.hinhanh;
            return data.SaveChanges() != 0 ? true : false;
        }
        public static bool DeletePhim(string phim)
        {
            PhimEntities data = new PhimEntities();
            tbl_movie nv = (from p in data.tbl_movie
                            where p.id_phim == phim.Trim()
                            select p).Single<tbl_movie>();
            nv.trangthai = false;
            return data.SaveChanges() != 0 ? true : false;
        }
        public static int DemSoLuongPhim()
        {
            PhimEntities data = new PhimEntities();
            var phimt = from s in data.tbl_movie                        
                        select s;
            return phimt.ToList<tbl_movie>().Count;
        }
        public static List<tbl_movie> GetPhimTheoTheLoai(string tinhtrangphim)
        {
            bool a = true;
            if (tinhtrangphim.Length > 9)  a = true;          
            else a = false;
            PhimEntities data = new PhimEntities();
            var phim = from p in data.tbl_movie
                       where p.tinhtrangphim == a
                       where p.trangthai == true                 
                       select p;
            return phim.ToList<tbl_movie>();
        }
        public static tbl_movie GetPhimByTen(string idphim)
        {
            //PhimEntities data = new PhimEntities();
            tbl_movie phimt = (from s in GetToanBoPhim()
                               where s.trangthai == true
                               where s.tenphim == idphim
                               select s).Single<tbl_movie>();

            return phimt;
        }
        public static List<string> GetTenPhimToanBo()
        {
            List<string> a = new List<string>();

           foreach(tbl_movie s in GetToanBoPhim())
            {
                a.Add(s.tenphim);
            }

            return a;
        }
    }
}
