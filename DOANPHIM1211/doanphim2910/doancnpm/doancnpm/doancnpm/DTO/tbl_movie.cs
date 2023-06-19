using doancnpm.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_movieDTO
	{
		private string _id_phim;
		public string id_phim
		{
			get { return _id_phim; }
			set { _id_phim = value; }
		}

		private string _tenphim;
		public string tenphim
		{
			get { return _tenphim; }
			set { _tenphim = value; }
		}

		private string _phanloai;
		public string phanloai
		{
			get { return _phanloai; }
			set { _phanloai = value; }
		}

		private string _daodien;
		public string daodien
		{
			get { return _daodien; }
			set { _daodien = value; }
		}

		private string _dienvien;
		public string dienvien
		{
			get { return _dienvien; }
			set { _dienvien = value; }
		}

		private string _theloai;
		public string theloai
		{
			get { return _theloai; }
			set { _theloai = value; }
		}

		private DateTime _khoichieu;
		public DateTime khoichieu
		{
			get { return _khoichieu; }
			set { _khoichieu = value; }
		}

		private int _thoiluong;
		public int thoiluong
		{
			get { return _thoiluong; }
			set { _thoiluong = value; }
		}

		private bool _tinhtrangphim;
		public bool tinhtrangphim
		{
			get { return _tinhtrangphim; }
			set { _tinhtrangphim = value; }
		}

		private bool _trangthai;
		public bool trangthai
		{
			get { return _trangthai; }
			set { _trangthai = value; }
		}

		private byte[] _hinhanh;
		public byte[] hinhanh
		{
			get { return _hinhanh; }
			set { _hinhanh = value; }
		}


		public tbl_movieDTO( string tenphim_, string phanloai_, string daodien_, string dienvien_, string theloai_, DateTime khoichieu_, int thoiluong_, bool tinhtrangphim_, bool trangthai_, byte[] hinhanh_)
		{
			int slphim = movieBLL.DemSoLuongPhim();
			this.id_phim = "PH" + (slphim + 1).ToString("000");
			this.tenphim = tenphim_;
			this.phanloai = phanloai_;
			this.daodien = daodien_;
			this.dienvien = dienvien_;
			this.theloai = theloai_;
			this.khoichieu = khoichieu_;
			this.thoiluong = thoiluong_;
			this.tinhtrangphim = tinhtrangphim_;
			this.trangthai = trangthai_;
			this.hinhanh = hinhanh_;
		}
		public tbl_movieDTO()
		{
			int slphim = movieBLL.DemSoLuongPhim();
			this.id_phim = "PH" + (slphim + 1).ToString("000");
			this.tenphim = "";
			this.phanloai = "";
			this.daodien = "";
			this.dienvien = "";
			this.theloai = "";
			this.khoichieu = DateTime.Now;
			this.thoiluong = 0;
			this.tinhtrangphim = true;
			this.trangthai = true;
			this.hinhanh = null;
		}
	}
}
