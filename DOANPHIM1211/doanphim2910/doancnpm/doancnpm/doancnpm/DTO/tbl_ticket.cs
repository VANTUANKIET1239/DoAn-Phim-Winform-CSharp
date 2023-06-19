using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_ticketDTO
	{
		public string id_ve { get; set; }
		public string id_lichchieu { get; set; }
		public string ghe { get; set; }
		public int giave { get; set; }
		public bool trangthai { get; set; }

		public tbl_ticketDTO(string id_ve_, string id_lichchieu_, string ghe_, int giave_, bool trangthai_)
		{
			this.id_ve = id_ve_;
			this.id_lichchieu = id_lichchieu_;
			this.ghe = ghe_;
			this.giave = giave_;
			this.trangthai = trangthai_;
		}
		public tbl_ticketDTO()
		{
			this.id_ve = "";
			this.id_lichchieu = "";
			this.ghe = "";
			this.giave = 0;
			this.trangthai = true;
		}
	}
}
