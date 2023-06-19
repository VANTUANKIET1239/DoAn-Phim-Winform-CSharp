using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_lichchieuDTO
	{
		private string _id_lichchieu;
		public string id_lichchieu
		{
			get { return _id_lichchieu; }
			set { _id_lichchieu = value; }
		}

		private DateTime _ngay;
		public DateTime ngay
		{
			get { return _ngay; }
			set { _ngay = value; }
		}

		private string _giochieu;
		public string giochieu
		{
			get { return _giochieu; }
			set { _giochieu = value; }
		}

		private string _id_phim;
		public string id_phim
		{
			get { return _id_phim; }
			set { _id_phim = value; }
		}

		private int _rap;
		public int rap
		{
			get { return _rap; }
			set { _rap = value; }
		}

		private string _id_chinhanh;
		public string id_chinhanh
		{
			get { return _id_chinhanh; }
			set { _id_chinhanh = value; }
		}

		private bool _trangthai;
		public bool trangthai
		{
			get { return _trangthai; }
			set { _trangthai = value; }
		}


		public tbl_lichchieuDTO(string id_lichchieu_, DateTime ngay_, string giochieu_, string id_phim_, int rap_, string id_chinhanh_, bool trangthai_)
		{
			this.id_lichchieu = id_lichchieu_;
			this.ngay = ngay_;
			this.giochieu = giochieu_;
			this.id_phim = id_phim_;
			this.rap = rap_;
			this.id_chinhanh = id_chinhanh_;
			this.trangthai = trangthai_;
		}
		public tbl_lichchieuDTO()
		{
			this.id_lichchieu = "";
			this.ngay = DateTime.Now;
			this.giochieu = "";
			this.id_phim = "";
			this.rap = 0;
			this.id_chinhanh = "";
			this.trangthai = true;
		}
	}
}

