using doancnpm.BLL;
using doancnpm.DTO;
using doancnpm.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm
{
    public partial class FormThanhToan : Form
    {
        private string TenPhimTT = "";
        private tbl_lichchieuDTO VaoLucTT = new tbl_lichchieuDTO();
        private int slnuocTT = 0;
        private int slveTT = 0;
        private int slbapTT = 0;
        private int diemtichluyKHTT = 0;
        private int diemsudungKHTT;
        private DateTime ngayTT;
        private string sdtKHTT;
        private int tongtienTT;
        private List<string> gheTT = new List<string>();

        public FormThanhToan()
        {
            InitializeComponent();
            sub();
        }
        public void sub()
        {
            POS_UC.ChuyenThongTinThanhToan += POS_UC_ChuyenThongTinThanhToan;
            POS_UC.khongcoKH += POS_UC_khongcoKH;

        }
        public static event EventHandler LoadPOS;
        private void POS_UC_khongcoKH(object sender, EventArgs e)
        {
            diemsudungKHtxt.Enabled = false;
        }

        private void POS_UC_ChuyenThongTinThanhToan(object sender, EventArgs e)
        {
            /* public static string TenPhimTT = "";
              public static string VaoLucTT = "";
              public static int slnuocTT = 0;
              public static int slve;
              public static int slbapTT = 0;
              public static int diemtichluyKHTT = 0;
              public static int diemsudungKHTT;
              public static string ngayTT;
              public static string sdtKHTT;
              public static int tongtienTT;*/
            TenPhimTT = POS_UC.TenPhimTT;
            VaoLucTT = POS_UC.VaoLucTT;
            slnuocTT = POS_UC.slnuocTT;
            slveTT = POS_UC.slve;
            slbapTT = POS_UC.slbapTT;
            diemtichluyKHTT = POS_UC.diemtichluyKHTT;
            ngayTT = POS_UC.ngayTT;
            sdtKHTT = POS_UC.sdtKHTT;
            tongtienTT = POS_UC.tongtienTT;
            gheTT.Clear();
            gheTT.AddRange(POS_UC.GhePOS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kq = 0;
           string idhd = "HD" + (hoadonBLL.GetCountHD() + 1).ToString("000");
            if(catnhatve(slveTT, gheTT, VaoLucTT))
            {
                kq++;
            }
            if(catnhathoadon(idhd, tenphimTTtxt.Text, VaoLucTT, ngayTT, slveTT, slbapTT, slnuocTT, tongtienTT, sdtKHTT, formMENU.nvdangnhap.id_chinhanh))
            {
                kq++;
            }
            if(catnhatdiemtichluy(sdtKHTT, idhd, Convert.ToInt32(diemsudungKHtxt.Text), tongtienTT))
            {
                kq++;
            }
            if(kq == 3)
            {
                MessageBox.Show("Thanh toán thành công !");
            }
            else
            {
                MessageBox.Show("Thanh toán thất bại !");
            }
            LoadPOS(sender,new EventArgs());
            this.Close();
        }
        private bool catnhatve(int slve, List<string> ghe, tbl_lichchieuDTO lc)
        {
            int count = 0;
            for(int i = 0; i < slve; i++)
            {
                tbl_ticketDTO a = new tbl_ticketDTO();
                a.id_ve = "VE" + (ticketBLL.GetCountVe() + 1).ToString("000");
                a.id_lichchieu = lc.id_lichchieu;
                a.ghe = ghe[i];
                a.giave = 45000;
                if (ticketBLL.AddNewVe(a))
                {
                    count++;
                }
                
            }
            if(count == slve)
            {
                return true;
            }
            return false;
        }
        private bool catnhathoadon(string idhd,string tenphim, tbl_lichchieuDTO lc,DateTime ngayhd,int slve,int bap, int nuoc,int tongtien, string sdt, string idcn)
        {
            tbl_hoadonDTO hd = new tbl_hoadonDTO();
            hd.id_hoadonmuave = idhd;
            hd.id_phim = movieBLL.GetPhimByTen(tenphim).id_phim;
            hd.id_lichchieu = lc.id_lichchieu;
            hd.ngay_hd = ngayhd;
            hd.soluong = slve;
            hd.bap = bap;
            hd.nuoc = nuoc;
            hd.tongtien = tongtien;
            hd.id_khachhang = khachhangBLL.GetKhachHangTheoSDT(sdt).id_khachhang;
            hd.id_chinhanh = idcn;
            if (hoadonBLL.AddNewHD(hd))
            {
                return true;
            }
            return false;

        }
        private bool catnhatdiemtichluy(string sdt,string idhd, int diemtichluySD, int tongtien )
        {
            tbl_DiemTichLuyDTO dtl = new tbl_DiemTichLuyDTO();
            dtl.id_hoadon = idhd;
            dtl.id_khachhang = khachhangBLL.GetKhachHangTheoSDT(sdt).id_khachhang;
            dtl.diemtichluySD = diemtichluySD;
            dtl.diemtichluynhan = tongtien;
            if (diemtichluyBLL.AddNewDTL(dtl))
            {
                return true;
            }
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            
            tenphimTTtxt.Text = TenPhimTT;
            GioChieuTTtxt.Text = VaoLucTT.giochieu;
            NgayTTtxt.Text = ngayTT.ToString("dd/MM/yyyy");
            sdtTTKHtxt.Text = sdtKHTT;
            diemtichluyKHtxt.Text = diemtichluyKHTT.ToString();
            SoLuongVeLB.Text = slveTT.ToString();
            SoLuongNuocLB.Text = slnuocTT.ToString();
            SoLuongBapLB.Text = slbapTT.ToString();
            TienTongtxt.Text = tongtienTT.ToString();
            khoathongtin();

        }
        private void khoathongtin()
        {
            tenphimTTtxt.Enabled = false;
            NgayTTtxt.Enabled = false;
            diemtichluyKHtxt.Enabled = false;
            sdtTTKHtxt.Enabled = false;
            GioChieuTTtxt.Enabled = false;
            TienTongtxt.Enabled = false;
            TienThoitxt.Enabled = false;
        }

        private void TienNhantxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(TienNhantxt.Text) < Convert.ToInt32(TienTongtxt.Text))
                {
                    MessageBox.Show("Tiền nhận không đủ");
                }
                else
                {
                    TienThoitxt.Text = (Convert.ToInt32(TienNhantxt.Text) - Convert.ToInt32(TienTongtxt.Text)).ToString();
                }
            }
        }
                

        private void diemsudungKHtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(Convert.ToInt32(diemsudungKHtxt.Text) < Convert.ToInt32(diemsudungKHtxt.Text))
                {
                    MessageBox.Show("không đủ điểm tích lũy");
                }
                else
                {
                    TienTongtxt.Text = (Convert.ToInt32(TienTongtxt.Text) - Convert.ToInt32(diemsudungKHtxt.Text)).ToString();
                    diemsudungKHtxt.Enabled = false;
                }
            }
        }
    }
}
