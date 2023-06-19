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
    public partial class QLP_UC : UserControl
    {
        public QLP_UC()
        {
            InitializeComponent();
            sub();
        }
        public void sub()
        {
            FormThemPhim.loaddata += FormThemPhim_loaddata;
            FormThemPhim.mokhoa += FormThemPhim_mokhoa;
        }

        private void FormThemPhim_mokhoa(object sender, EventArgs e)
        {
            this.Enabled = true;
        }

        private void FormThemPhim_loaddata(object sender, EventArgs e)
        {
            List<tbl_movie> dsphim = movieBLL.GetToanBoPhim();
             datagridphim.DataSource = dsphim;
             formMENU.autocomplete(textBox1, GetTenPhim(dsphim));
            
        }

        private void QLP_UC_Load(object sender, EventArgs e)
        {
          
            FormThemPhim_loaddata(sender, new EventArgs());
            //datagridphim.Columns.Remove("hinhanh");
            List<string> h = new List<string>() { "Phim Đang Chiếu", "Phim sắp Chiếu" };
            TinhTrangPhimCB.Items.AddRange(h.ToArray());
            datagridphim.Columns["tbl_lichchieu"].Visible = false;
            datagridphim.Columns["tbl_hoadon"].Visible = false;
            datagridphim.Columns["trangthai"].Visible = false;
            datagridphim.MultiSelect = false;
            datagridphim.ReadOnly = true;
            datagridphim.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //DataGridViewImageColumn img = new DataGridViewImageColumn();
            formMENU.autocomplete(textBox1, GetTenPhim(movieBLL.GetToanBoPhim()));
           //label9.Text = TinhTrangPhimCB.Text;

        }
        public void data()
        {
            List<tbl_movie> dsphim = movieBLL.GetToanBoPhim();
            datagridphim.DataSource = dsphim;

        }
        public List<string> GetTenPhim(List<tbl_movie> a)
        {
            List<string> lsphim = new List<string>();
            foreach(tbl_movie p in a)
            {
                lsphim.Add(p.tenphim);
            }
            return lsphim;
        }
       

        private void TinhTrangPhimCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {

            FormThemPhim themphim = new FormThemPhim();
            themphim.Show();
            this.Enabled = false;
        }

       

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void QLP_UC_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "Tìm kiếm...";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var listhh = from hh in movieBLL.GetToanBoPhim()
                             where hh.tenphim == textBox1.Text
                             where hh.trangthai == true
                             select hh;
                datagridphim.DataSource = listhh.ToList();
            }
       
            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            var list = movieBLL.GetPhimTheoTheLoai(comboBox1.Text);
            datagridphim.DataSource = list.ToList();         
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
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
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                Image a = new Bitmap(imageIn);
                a.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        public void unread(bool a)
        {
            btntaianhQLP.Enabled = !a;
            TenPhimtxt.ReadOnly = a;
            DienVientxt.ReadOnly = a;
            DaoDientxt.ReadOnly = a;
            TheLoaitxt.ReadOnly = a;
            PhanLoaitxt.ReadOnly = a;
            TinhTrangPhimCB.Enabled = !a;
            KhoiChieuDATE.Enabled = !a;
            ThoiLuongtxt.ReadOnly = a;
            btnXacNhan.Enabled = !a;
        }
        private void datagridphim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            unread(true);
            byte[] imgdata = (byte[])datagridphim.SelectedRows[0].Cells[10].Value;
            HinhAnhPic.Image = ByteToImage(imgdata);
            TenPhimtxt.Text = datagridphim.SelectedRows[0].Cells[1].Value.ToString();            
            DienVientxt.Text = datagridphim.SelectedRows[0].Cells[4].Value.ToString(); 
            DaoDientxt.Text = datagridphim.SelectedRows[0].Cells[3].Value.ToString(); 
            TheLoaitxt.Text = datagridphim.SelectedRows[0].Cells[5].Value.ToString(); 
            PhanLoaitxt.Text = datagridphim.SelectedRows[0].Cells[2].Value.ToString().Substring(0,3);
            if ((bool)datagridphim.SelectedRows[0].Cells[8].Value == true)
            {
                TinhTrangPhimCB.Text = "Phim Đang Chiếu";
            }
            else
            {
                TinhTrangPhimCB.Text = "Phim Sắp Chiếu";
            }
            KhoiChieuDATE.Value = (DateTime)datagridphim.SelectedRows[0].Cells[6].Value;
            ThoiLuongtxt.Text = datagridphim.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btnSuaPhim_Click(object sender, EventArgs e)
        {
            unread(false);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            tbl_movieDTO phim = new tbl_movieDTO();
            phim.id_phim = datagridphim.SelectedRows[0].Cells[0].Value.ToString();
            phim.tenphim = TenPhimtxt.Text;
            phim.hinhanh = ImageToByteArray(HinhAnhPic.Image);
            phim.dienvien = DienVientxt.Text;
            phim.daodien = DaoDientxt.Text;
            phim.theloai = TheLoaitxt.Text;
            phim.phanloai = PhanLoaitxt.Text;
            if (TinhTrangPhimCB.Text == "Phim Đang Chiếu") phim.tinhtrangphim = true;
            else phim.tinhtrangphim = false;
            phim.khoichieu = KhoiChieuDATE.Value;
            phim.thoiluong = Convert.ToInt32(ThoiLuongtxt.Text);
            if (movieBLL.UpdatePhim(phim))
            {               
                MessageBox.Show("Update thành công!");
                this.QLP_UC_Load(sender, new EventArgs());
            }
            else
            {            
                MessageBox.Show("Update thất bại!");
                this.QLP_UC_Load(sender, new EventArgs());
            }

        }

        private void btntaianhQLP_Click(object sender, EventArgs e)
        {
            string imgloc = "";
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            dlg.Title = "Chọn tấm ảnh";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgloc = dlg.FileName.ToString();
                HinhAnhPic.ImageLocation = imgloc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnXoaPhim_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon xóa phim này không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (movieBLL.DeletePhim(datagridphim.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("Xóa thành công!");
                    this.QLP_UC_Load(sender, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                    this.QLP_UC_Load(sender, new EventArgs());
                }
            }
        }
    }
}
