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

namespace doancnpm
{
    public partial class FormThemPhim : Form
    {
        string imgloc = "";
        public FormThemPhim()
        {
            InitializeComponent();
        }
        public static event EventHandler loaddata;
        public static event EventHandler mokhoa;
        private void Form1_Load(object sender, EventArgs e)
        {
            // dataGridView1.DataSource = nhanvienBLL.GetToanBoNhanVien();
            // textBox1.Text = formMENU.mahoa("123");
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
            dlg.Title = "Chọn tấm ảnh";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                imgloc = dlg.FileName.ToString();
                HinhAnhPic.ImageLocation = imgloc;
            }
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            byte[] img = null;
            FileStream fs = new FileStream(imgloc, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            img = br.ReadBytes((int)fs.Length);
            tbl_movieDTO phim = new tbl_movieDTO();
            phim.tenphim = TenPhimtxt.Text;
            phim.dienvien = DienVientxt.Text;
            phim.daodien = DaoDientxt.Text;
            phim.khoichieu = KhoiChieuDATE.Value;
            phim.thoiluong = Convert.ToInt32(ThoiLuongtxt.Text);
            if(TinhTrangPhimCB.SelectedItem.ToString() == "Phim đang chiếu")
            {
                phim.tinhtrangphim = true;
            }
            else
            {
                phim.tinhtrangphim = false;
            }
            phim.theloai = TheLoaitxt.Text;
            phim.phanloai = PhanLoaitxt.Text;
            phim.hinhanh = img;
            if (movieBLL.AddNewPhim(phim))  
            {
                this.Close();
                loaddata(sender, new EventArgs());
                mokhoa(sender, new EventArgs());
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                this.Close();
                loaddata(sender, new EventArgs());
                mokhoa(sender, new EventArgs());
                MessageBox.Show("Thêm thất bại!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mokhoa(sender, new EventArgs());
            this.Close();
        }
    }
}
