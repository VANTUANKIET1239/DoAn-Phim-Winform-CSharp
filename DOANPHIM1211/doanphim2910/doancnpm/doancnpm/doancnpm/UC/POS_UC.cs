using doancnpm.BLL;
using doancnpm.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm.UC
{
    public partial class POS_UC : UserControl
    {
        private int slchonLC = 0;
        private Button prebtn;
       // public static int slve;
        public static List<string> GhePOS = new List<string>();
        // thomg tin thanh toan
        public static string TenPhimTT = "";
        public static tbl_lichchieuDTO VaoLucTT = new tbl_lichchieuDTO();
        private List<tbl_lichchieuDTO> LichChieuTam = new List<tbl_lichchieuDTO>();
        public static int slnuocTT = 0;
        public static int slve;
        public static int slbapTT = 0;
        public static int diemtichluyKHTT = 0;
        public static int diemsudungKHTT;
        public static DateTime ngayTT;
        public static string sdtKHTT;
        public static int tongtienTT;
        public POS_UC()
        {
            InitializeComponent();
            sub();
          
        }
        public static event EventHandler chuyenSLVE;
        public static event EventHandler ChuyenThongTinThanhToan;
        public static event EventHandler khongcoKH;
        public static event EventHandler layghetheolich;

        public void sub()
        {
            FormChonGhe.ChuyenThongTinGhe += FormChonGhe_ChuyenThongTinGhe;
            FormThanhToan.LoadPOS += POS_UC_Load;

        }

        private void FormChonGhe_ChuyenThongTinGhe(object sender, EventArgs e)
        {
            GhePOS.Clear();
            GhePOS.AddRange(FormChonGhe.GheFCG);
        }

        private void POS_UC_Load(object sender, EventArgs e)
        {
            PhanLoaitxt.Enabled = false;
            ThoiLuongtxt.Enabled = false;
            NgayChieutxt.Enabled = false;
            dateTimePicker1.Enabled = false;
            btnChonGhe.Enabled = false;
            btnThanhToan.Enabled = false;
           /* TenPhimCB.DataSource = movieBLL.GetToanBoPhim();
            TenPhimCB.ValueMember = "id_phim";
            TenPhimCB.DisplayMember = "tenphim";*/
            txtSDT.Enabled = false;
            txtKhachHang.Enabled = false;
            txtdiemtichluy.Enabled = false;
            formMENU.autocomplete(txtSDT, khachhangBLL.GetToanBoKhachHangSDT());
            formMENU.autocomplete(TenPhimtxt, movieBLL.GetTenPhimToanBo());
           // dataGridView4.DataSource = movieBLL.GetToanBoPhim();
        //    label7.Text = TenPhimCB.SelectedValue.ToString();
            
        }
        private void fillthongtinphim(tbl_movie temp)
        {
            PhanLoaitxt.Text = temp.phanloai.ToString();
            ThoiLuongtxt.Text = temp.thoiluong.ToString();
            NgayChieutxt.Text = temp.khoichieu.ToString("dd/MM/yyyy");
            byte[] imgdata = (byte[])temp.hinhanh;
            picHinhAnhPhim.Image = ByteArrayToImage((byte[])temp.hinhanh);
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }


        private void tinhtien()
        {
            txtTongTien.Text = (Convert.ToInt32(txtSLVE.Text) * 45000 + Convert.ToInt32(txtSLNUOC.Text) * 50000 + Convert.ToInt32(txtSLBAP.Text) * 65000).ToString();
        }
        private void btnCongBap_Click(object sender, EventArgs e)
        {
            txtSLBAP.Text = (Convert.ToInt32(txtSLBAP.Text) + 1).ToString();
            tinhtien();
        }

        private void btnCongNuoc_Click(object sender, EventArgs e)
        {
            txtSLNUOC.Text = (Convert.ToInt32(txtSLNUOC.Text) + 1).ToString();
            tinhtien();
        }

        private void btnTruBap_Click(object sender, EventArgs e)
        {
            if(txtSLBAP.Text != "0")
            {
                txtSLBAP.Text = (Convert.ToInt32(txtSLBAP.Text) - 1).ToString();
                tinhtien();
            }
        }

        private void btnTruNuoc_Click(object sender, EventArgs e)
        {
            if (txtSLNUOC.Text != "0")
            {
                txtSLNUOC.Text = (Convert.ToInt32(txtSLNUOC.Text) - 1).ToString();
                tinhtien();
            }
        }

        private void ckbkhachhang_CheckedChanged(object sender, EventArgs e)
        {
           if(ckbkhachhang.Checked == true)
            {
                txtSDT.Enabled = true;

            }
            else
            {
                txtSDT.Enabled = false;
            }
           
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                List<tbl_khachhangDTO> kh = khachhangBLL.GetToanBoKhachHang();
                txtKhachHang.Text = khachhangBLL.GetKhachHangTheoSDT(txtSDT.Text).hoten;
                txtdiemtichluy.Text = khachhangBLL.GetKhachHangTheoSDT(txtSDT.Text).diemtichluy.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSLVE.Text = (Convert.ToInt32(txtSLVE.Text) + 1).ToString();
            tinhtien();
           // slve = Convert.ToInt32(txtSLVE.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSLVE.Text != "0")
            {
                txtSLVE.Text = (Convert.ToInt32(txtSLVE.Text) - 1).ToString();
                tinhtien();
              //  slve = Convert.ToInt32(txtSLVE.Text);
            }
        }

        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            slve = Convert.ToInt32(txtSLVE.Text);
            if (slchonLC == 1 && slve > 0)
            {
                FormChonGhe cg = new FormChonGhe();
                chuyenSLVE(sender, new EventArgs());
                layghetheolich(sender, new EventArgs());
                cg.Show();
            }
            else
           
            {
                if (slve == 0)
                {
                    MessageBox.Show("Bạn chưa chọn số lượng vé");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn lịch chiếu");
                }
            }
            
        }

        private void TenPhimCB_SelectedIndexChanged(object sender, EventArgs e)
        {
           
          
            
            
        }

        private void TenPhimtxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                flowLayoutPanel1.Controls.Clear();
                dateTimePicker1.Enabled = true;
                btnChonGhe.Enabled = true;
                btnThanhToan.Enabled = true;
                tbl_movie temp = new tbl_movie();
                temp = movieBLL.GetPhimByTen(TenPhimtxt.Text);
                fillthongtinphim(temp);
                List<tbl_lichchieuDTO> lc = lichchieuBLL.GetLichChieuByNgay(dateTimePicker1.Value);
                FillLichChieu(lc);
                LichChieuTam.Clear();
                LichChieuTam.AddRange(lc);
                

            }
        }
        private void FillLichChieu(List<tbl_lichchieuDTO> a)
        {
                   
                Button btn;
                for (int i = 0; i < a.Count; i++)
                {
                    btn = new Button();
                    btn.BackColor = Color.Gray;
                    btn.Text = a[i].giochieu;
                    btn.Width = 120;
                    btn.Height = 40;
                    btn.Name = "lc" + (i+1);
                    btn.Click += new EventHandler(buttionclick);
                    flowLayoutPanel1.Controls.Add(btn);
                    
               }
                     
        }
        private void buttionclick(object sender, EventArgs e)
        {
          
            Button btn = (Button)sender;
            if (slchonLC == 1)
            {                             
                   if(prebtn == (Button)sender)
                    {
                      
                        btn.BackColor = Color.Gray;
                        slchonLC -= 1;
                    VaoLucTT = new tbl_lichchieuDTO();
                    }
                    else
                    {
                        MessageBox.Show("Chỉ có thể chọn 1 lịch chiếu!");
                    }             
               
            }
            else
            {                
                prebtn = btn;
                btn.BackColor = Color.Yellow;
                slchonLC += 1;
                foreach (tbl_lichchieuDTO s in LichChieuTam)
                {
                    if (s.giochieu == btn.Text)
                    {
                        VaoLucTT = s;
                        break;
                    }
                }
            }

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            List<tbl_lichchieuDTO> lc = lichchieuBLL.GetLichChieuByNgay(dateTimePicker1.Value);
            FillLichChieu(lc);
            LichChieuTam.Clear();
            LichChieuTam.AddRange(lc);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            FormThanhToan tt = new FormThanhToan();
            if(ckbkhachhang.Checked == false)
            {
                khongcoKH(sender, new EventArgs());
            }
            TenPhimTT = TenPhimtxt.Text;
            slnuocTT = Convert.ToInt32(txtSLNUOC.Text);
            slbapTT = Convert.ToInt32(txtSLBAP.Text);
            slve = Convert.ToInt32(txtSLVE.Text);
            diemtichluyKHTT = Convert.ToInt32(txtdiemtichluy.Text);
            ngayTT = dateTimePicker1.Value;
            sdtKHTT = txtSDT.Text;
            tongtienTT = Convert.ToInt32(txtTongTien.Text);

            /*public static string TenPhimTT = "";
              public static string VaoLucTT = "";
              public static int slnuocTT = 0;
              public static int slve;
              public static int slbapTT = 0;
              public static int diemtichluyKHTT = 0;
              public static int diemsudungKHTT;
              public static string ngayTT;
              public static string sdtKHTT;
              public static int tongtienTT;*/
            ChuyenThongTinThanhToan(sender, new EventArgs());
            tt.Show();
        }
    }
}
