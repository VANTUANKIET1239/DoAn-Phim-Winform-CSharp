using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doancnpm.DTO
{
	public class tbl_lichlamviecDTO
	{
		private string _id_nhanvien;
		public string id_nhanvien
		{
			get { return _id_nhanvien; }
			set { _id_nhanvien = value; }
		}

		private DateTime _ngaybd;
		public DateTime ngaybd
		{
			get { return _ngaybd; }
			set { _ngaybd = value; }
		}

		private bool _MonMOR;
		public bool MonMOR
		{
			get { return _MonMOR; }
			set { _MonMOR = value; }
		}

		private bool _TueMOR;
		public bool TueMOR
		{
			get { return _TueMOR; }
			set { _TueMOR = value; }
		}

		private bool _WedMOR;
		public bool WedMOR
		{
			get { return _WedMOR; }
			set { _WedMOR = value; }
		}

		private bool _ThuMOR;
		public bool ThuMOR
		{
			get { return _ThuMOR; }
			set { _ThuMOR = value; }
		}

		private bool _FriMOR;
		public bool FriMOR
		{
			get { return _FriMOR; }
			set { _FriMOR = value; }
		}

		private bool _SatMOR;
		public bool SatMOR
		{
			get { return _SatMOR; }
			set { _SatMOR = value; }
		}

		private bool _SunMOR;
		public bool SunMOR
		{
			get { return _SunMOR; }
			set { _SunMOR = value; }
		}

		private bool _MonEVE;
		public bool MonEVE
		{
			get { return _MonEVE; }
			set { _MonEVE = value; }
		}

		private bool _TueEVE;
		public bool TueEVE
		{
			get { return _TueEVE; }
			set { _TueEVE = value; }
		}

		private bool _WedEVE;
		public bool WedEVE
		{
			get { return _WedEVE; }
			set { _WedEVE = value; }
		}

		private bool _ThuEVE;
		public bool ThuEVE
		{
			get { return _ThuEVE; }
			set { _ThuEVE = value; }
		}

		private bool _FriEVE;
		public bool FriEVE
		{
			get { return _FriEVE; }
			set { _FriEVE = value; }
		}

		private bool _SatEVE;
		public bool SatEVE
		{
			get { return _SatEVE; }
			set { _SatEVE = value; }
		}

		private bool _SunEVE;
		public bool SunEVE
		{
			get { return _SunEVE; }
			set { _SunEVE = value; }
		}
		private bool _trangthai;
		public bool trangthai
		{
			get { return _trangthai; }
			set { _trangthai = value; }
		}


		public tbl_lichlamviecDTO(string id_nhanvien_, DateTime ngaybd_, bool MonMOR_, bool TueMOR_, bool WedMOR_, bool ThuMOR_, bool FriMOR_, bool SatMOR_, bool SunMOR_, bool MonEVE_, bool TueEVE_, bool WedEVE_, bool ThuEVE_, bool FriEVE_, bool SatEVE_, bool SunEVE_,bool trangthai_)
		{
			this.id_nhanvien = id_nhanvien_;
			this.ngaybd = ngaybd_;
			this.MonMOR = MonMOR_;
			this.TueMOR = TueMOR_;
			this.WedMOR = WedMOR_;
			this.ThuMOR = ThuMOR_;
			this.FriMOR = FriMOR_;
			this.SatMOR = SatMOR_;
			this.SunMOR = SunMOR_;
			this.MonEVE = MonEVE_;
			this.TueEVE = TueEVE_;
			this.WedEVE = WedEVE_;
			this.ThuEVE = ThuEVE_;
			this.FriEVE = FriEVE_;
			this.SatEVE = SatEVE_;
			this.SunEVE = SunEVE_;
			this.trangthai = trangthai_;
		}
		public tbl_lichlamviecDTO()
		{
			this.id_nhanvien = "";
			this.ngaybd = DateTime.Now;
			this.MonMOR = false;
			this.TueMOR = false;
			this.WedMOR = false;
			this.ThuMOR = false;
			this.FriMOR = false;
			this.SatMOR = false;
			this.SunMOR = false;
			this.MonEVE = false;
			this.TueEVE = false;
			this.WedEVE = false;
			this.ThuEVE = false;
			this.FriEVE = false;
			this.SatEVE = false;
			this.SunEVE = false;
			this.trangthai = true;
		}
	}
}
