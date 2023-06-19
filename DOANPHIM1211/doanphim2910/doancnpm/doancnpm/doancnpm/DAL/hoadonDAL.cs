using AutoMapper;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DAL
{
	public class hoadonDAL
	{
        public static List<tbl_hoadonDTO> GetToanBoHD()
        {
            PhimEntities data = new PhimEntities();
            var nv = from s in data.tbl_hoadon
                     where s.trangthai == true
                     select s;
            List<tbl_hoadonDTO> dsnhanvien = new List<tbl_hoadonDTO>();
            foreach (tbl_hoadon p in nv)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_hoadon, tbl_hoadonDTO>());
                var mapper = new Mapper(config);
                tbl_hoadonDTO dto = mapper.Map<tbl_hoadonDTO>(p);
                dsnhanvien.Add(dto);
            }
            return dsnhanvien;
        }
        public static bool AddNewHD(tbl_hoadonDTO a)
        {
           
            PhimEntities data = new PhimEntities();
            tbl_hoadon nv = new tbl_hoadon();
            nv.id_hoadonmuave = a.id_hoadonmuave;
            nv.id_phim = a.id_phim;
            nv.id_lichchieu = a.id_lichchieu;
            nv.ngay_hd = a.ngay_hd;
            nv.trangthai = a.trangthai;
            nv.soluong = a.soluong;
            nv.bap = a.bap;
            nv.nuoc = a.nuoc;
            nv.tongtien = a.tongtien;
            nv.id_khachhang = a.id_khachhang;
            nv.id_chinhanh = a.id_chinhanh;
            data.tbl_hoadon.Add(nv);
            return data.SaveChanges() != 0 ? true : false;
        }
        public static int GetCountHD()
        {
            return GetToanBoHD().Count;
        }
    }
}
