using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
    public class khachhangDAL
    {
        public static List<tbl_khachhangDTO> GetToanBoKhachHang()
        {
            PhimEntities data = new PhimEntities();
            var nv = from s in data.tbl_khachhang
                     where s.trangthai == true
                     select s;
            List<tbl_khachhangDTO> dsnhanvien = new List<tbl_khachhangDTO>();
            foreach (tbl_khachhang p in nv)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_khachhang, tbl_khachhangDTO>());
                var mapper = new Mapper(config);
                tbl_khachhangDTO dto = mapper.Map<tbl_khachhangDTO>(p);
                dsnhanvien.Add(dto);
            }
            return dsnhanvien;
        }
        public static List<string> GetToanBoKhachHangSDT()
        {
            PhimEntities data = new PhimEntities();
            var nv = from s in data.tbl_khachhang
                     where s.trangthai == true
                     select s;
            List<string> dsnhanvien = new List<string>();
            foreach (tbl_khachhang p in nv)
            {
               
                dsnhanvien.Add(p.dienthoai);
            }
            return dsnhanvien;
        }
        public static tbl_khachhangDTO GetKhachHangTheoSDT(string sdt)
        {
            PhimEntities data = new PhimEntities();
            tbl_khachhang nv = (from s in data.tbl_khachhang
                     where s.trangthai == true
                     where s.dienthoai == sdt
                     select s).Single();
           
            
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_khachhang, tbl_khachhangDTO>());
                var mapper = new Mapper(config);
                tbl_khachhangDTO dto = mapper.Map<tbl_khachhangDTO>(nv);
              
            
            return dto;
        }
        public static int GetCountKH()
        {
            return GetToanBoKhachHang().Count;
        }
        public static bool AddNew(tbl_khachhangDTO phim)
        {
           
            PhimEntities data = new PhimEntities();
            tbl_khachhang nv = new tbl_khachhang();
            nv.id_khachhang = phim.id_khachhang;
            nv.hoten = phim.hoten;
            nv.dienthoai = phim.dienthoai;
            nv.diachi = phim.diachi;
            nv.diemtichluy = phim.diemtichluy;       
            nv.trangthai = phim.trangthai;
            data.tbl_khachhang.Add(nv);
            return data.SaveChanges() != 0 ? true : false;

        }
        public static bool Modify(tbl_khachhangDTO phim)
        {
            PhimEntities data = new PhimEntities();
            tbl_khachhang nv = (from n in data.tbl_khachhang
                               where n.id_khachhang == phim.id_khachhang.Trim()
                               where n.trangthai == true
                               select n).Single();
            nv.id_khachhang = phim.id_khachhang;
            nv.hoten = phim.hoten;
            nv.diachi = phim.diachi;
            nv.dienthoai = phim.dienthoai;
            nv.diemtichluy = phim.diemtichluy;
            nv.trangthai = phim.trangthai;
            return data.SaveChanges() != 0 ? true : false;
        }
        public static bool Delete(string id)
        {
            PhimEntities data = new PhimEntities();
            tbl_khachhang nv = (from p in data.tbl_khachhang
                               where p.id_khachhang == id.Trim()
                               select p).Single<tbl_khachhang>();
            nv.trangthai = false;
            return data.SaveChanges() != 0 ? true : false;
        }
        public static tbl_khachhangDTO GetKhachHangTheoID(string id)
        {
            PhimEntities data = new PhimEntities();
            tbl_khachhang nv = (from s in data.tbl_khachhang
                                where s.trangthai == true
                                where s.id_khachhang == id
                                select s).Single();


            var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_khachhang, tbl_khachhangDTO>());
            var mapper = new Mapper(config);
            tbl_khachhangDTO dto = mapper.Map<tbl_khachhangDTO>(nv);


            return dto;
        }
    }
}
