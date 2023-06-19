using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_hoadonDTO
	{
		private string _id_hoadonmuave;
		public string id_hoadonmuave
		{
			get { return _id_hoadonmuave; }
			set { _id_hoadonmuave = value; }
		}

		private string _id_phim;
		public string id_phim
		{
			get { return _id_phim; }
			set { _id_phim = value; }
		}

		private string _id_lichchieu;
		public string id_lichchieu
		{
			get { return _id_lichchieu; }
			set { _id_lichchieu = value; }
		}

		private DateTime _ngay_hd;
		public DateTime ngay_hd
		{
			get { return _ngay_hd; }
			set { _ngay_hd = value; }
		}

		private int _soluong;
		public int soluong
		{
			get { return _soluong; }
			set { _soluong = value; }
		}

		private int _bap;
		public int bap
		{
			get { return _bap; }
			set { _bap = value; }
		}

		private int _nuoc;
		public int nuoc
		{
			get { return _nuoc; }
			set { _nuoc = value; }
		}

		private int _tongtien;
		public int tongtien
		{
			get { return _tongtien; }
			set { _tongtien = value; }
		}

		private bool _trangthai;
		public bool trangthai
		{
			get { return _trangthai; }
			set { _trangthai = value; }
		}

		private string _id_khachhang;
		public string id_khachhang
		{
			get { return _id_khachhang; }
			set { _id_khachhang = value; }
		}
		private string _id_chinhanh;
		public string id_chinhanh
		{
			get { return _id_chinhanh; }
			set { _id_chinhanh = value; }
		}


		public tbl_hoadonDTO(string id_hoadonmuave_, string id_phim_, string id_lichchieu_, DateTime ngay_hd_, int soluong_, int bap_, int nuoc_, int tongtien_, bool trangthai_, string id_khachhang_,string id_chinhanh_)
		{
			this.id_hoadonmuave = id_hoadonmuave_;
			this.id_phim = id_phim_;
			this.id_lichchieu = id_lichchieu_;
			this.ngay_hd = ngay_hd_;
			this.soluong = soluong_;
			this.bap = bap_;
			this.nuoc = nuoc_;
			this.tongtien = tongtien_;
			this.trangthai = trangthai_;
			this.id_khachhang = id_khachhang_;
			this.id_khachhang = id_chinhanh_;
		}
		public tbl_hoadonDTO()
		{
			this.id_hoadonmuave = "";
			this.id_phim = "";
			this.id_lichchieu = "";
			this.ngay_hd = DateTime.Now;
			this.soluong = 0;
			this.bap = 0;
			this.nuoc = 0;
			this.tongtien = 0;
			this.trangthai = true;
			this.id_khachhang = "";
			this.id_khachhang = "";
		}
	}
}
