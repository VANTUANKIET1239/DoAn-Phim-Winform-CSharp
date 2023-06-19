using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_khachhangDTO
	{
		private string _id_khachhang;
		public string id_khachhang
		{
			get { return _id_khachhang; }
			set { _id_khachhang = value; }
		}

		private string _hoten;
		public string hoten
		{
			get { return _hoten; }
			set { _hoten = value; }
		}

		private string _diachi;
		public string diachi
		{
			get { return _diachi; }
			set { _diachi = value; }
		}

		private string _dienthoai;
		public string dienthoai
		{
			get { return _dienthoai; }
			set { _dienthoai = value; }
		}

		private int _diemtichluy;
		public int diemtichluy
		{
			get { return _diemtichluy; }
			set { _diemtichluy = value; }
		}

		private bool _trangthai;
		public bool trangthai
		{
			get { return _trangthai; }
			set { _trangthai = value; }
		}


		public tbl_khachhangDTO(string id_khachhang_, string hoten_, string diachi_, string dienthoai_, int diemtichluy_, bool trangthai_)
		{
			this.id_khachhang = id_khachhang_;
			this.hoten = hoten_;
			this.diachi = diachi_;
			this.dienthoai = dienthoai_;
			this.diemtichluy = diemtichluy_;
			this.trangthai = trangthai_;
		}
		public tbl_khachhangDTO()
		{
			this.id_khachhang = "";
			this.hoten = "";
			this.diachi = "";
			this.dienthoai = "";
			this.diemtichluy = 0;
			this.trangthai = true;
		}
	}
}
