using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_chinhanhDTO
	{
		private string _id_chinhanh;
		public string id_chinhanh
		{
			get { return _id_chinhanh; }
			set { _id_chinhanh = value; }
		}

		private string _tenchinhanh;
		public string tenchinhanh
		{
			get { return _tenchinhanh; }
			set { _tenchinhanh = value; }
		}

		private string _diachi;
		public string diachi
		{
			get { return _diachi; }
			set { _diachi = value; }
		}

		private bool _trangthai;
		public bool trangthai
		{
			get { return _trangthai; }
			set { _trangthai = value; }
		}


		public tbl_chinhanhDTO(string id_chinhanh_, string tenchinhanh_, string diachi_, bool trangthai_)
		{
			this.id_chinhanh = id_chinhanh_;
			this.tenchinhanh = tenchinhanh_;
			this.diachi = diachi_;
			this.trangthai = trangthai_;
		}
		public tbl_chinhanhDTO()
		{
			this.id_chinhanh = "";
			this.tenchinhanh = "";
			this.diachi = "";
			this.trangthai = true;
		}
	}
}
