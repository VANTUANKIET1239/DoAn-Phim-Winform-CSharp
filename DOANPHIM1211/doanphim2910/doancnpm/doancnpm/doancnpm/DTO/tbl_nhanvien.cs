using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_nhanvienDTO
	{
		private string _id_nhanvien;
		public string id_nhanvien
		{
			get { return _id_nhanvien; }
			set { _id_nhanvien = value; }
		}

		private string _tennhanvien;
		public string tennhanvien
		{
			get { return _tennhanvien; }
			set { _tennhanvien = value; }
		}

		private string _matkhau;
		public string matkhau
		{
			get { return _matkhau; }
			set { _matkhau = value; }
		}

		private string _sdt;
		public string sdt
		{
			get { return _sdt; }
			set { _sdt = value; }
		}

		private string _email;
		public string email
		{
			get { return _email; }
			set { _email = value; }
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

		private string _chucvu;
		public string chucvu
		{
			get { return _chucvu; }
			set { _chucvu = value; }
		}


		public tbl_nhanvienDTO(string id_nhanvien_, string tennhanvien_, string matkhau_, string sdt_, string email_, string id_chinhanh_, bool trangthai_, string chucvu_)
		{
			this.id_nhanvien = id_nhanvien_;
			this.tennhanvien = tennhanvien_;
			this.matkhau = matkhau_;
			this.sdt = sdt_;
			this.email = email_;
			this.id_chinhanh = id_chinhanh_;
			this.trangthai = trangthai_;
			this.chucvu = chucvu_;
		}
		public tbl_nhanvienDTO()
		{
			this.id_nhanvien = "";
			this.tennhanvien = "";
			this.matkhau = "";
			this.sdt = "";
			this.email = "";
			this.id_chinhanh = "";
			this.trangthai = true;
			this.chucvu = "";
		}
	}
	
}


