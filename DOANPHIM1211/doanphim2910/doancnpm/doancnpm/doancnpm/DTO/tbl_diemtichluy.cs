using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
    public class tbl_DiemTichLuyDTO
    {
        private string _id_khachhang;
        public string id_khachhang
        {
            get { return _id_khachhang; }
            set { _id_khachhang = value; }
        }

        private string _id_hoadon;
        public string id_hoadon
        {
            get { return _id_hoadon; }
            set { _id_hoadon = value; }
        }


        private int _diemtichluynhan;
        public int diemtichluynhan
        {
            get { return _diemtichluynhan; }
            set { _diemtichluynhan = value; }
        }

        private int _diemtichluySD;
        public int diemtichluySD
        {
            get { return _diemtichluySD; }
            set { _diemtichluySD = value; }
        }


        public tbl_DiemTichLuyDTO(string id_khachhang_, string id_hoadon_, int diemtichluynhan_, int diemtichluySD_)
        {
            this.id_khachhang = id_khachhang_;
            this.id_hoadon = id_hoadon_;
           
            this.diemtichluynhan = diemtichluynhan_;
            this.diemtichluySD = diemtichluySD_;
        }
        public tbl_DiemTichLuyDTO()
        {
            this.id_khachhang = "";
            this.id_hoadon = "";
           
            this.diemtichluynhan = 0;
            this.diemtichluySD = 0;
        }
    }
}
