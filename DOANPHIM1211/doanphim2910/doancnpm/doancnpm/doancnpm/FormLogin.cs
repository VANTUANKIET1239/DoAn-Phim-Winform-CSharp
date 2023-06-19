using doancnpm.BLL;
using doancnpm.DTO;
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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            MKtxt.PasswordChar = '\u25CF';
        }
        public static event EventHandler phanquyench;

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_click(object sender, EventArgs e)
        {
            List<tbl_nhanvienDTO> dsnhanvien = nhanvienBLL.GetToanBoNhanVien();
            string manv = TKtxt.Text;
            string matkhaunv = MKtxt.Text;
            foreach(tbl_nhanvienDTO s in dsnhanvien)
            {
                if(s.id_nhanvien.Trim() == manv.Trim())
                {
                    if(s.matkhau == formMENU.mahoa(matkhaunv).Trim())
                    {
                        tbl_nhanvienDTO nv = nhanvienBLL.GetNhanVienTheoID(manv);
                        if(nv.chucvu.Trim() == "CHT")
                        {
                            formMENU form = new formMENU(nv);
                            form.Show();
                            this.Hide();                           
                            //phanquyench(sender, new EventArgs());
                            break;
                        }
                       else
                        {
                            formMENU form = new formMENU(nv);
                            form.Show();
                            this.Hide();
                            phanquyench(sender, new EventArgs());
                          //  brea
                        }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MKtxt.PasswordChar == '\0')
            {
                pictureBox2.BringToFront();
                MKtxt.PasswordChar = '\u25CF';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MKtxt.PasswordChar == '\u25CF')
            {
                pictureBox1.BringToFront();
                MKtxt.PasswordChar = '\0';
            }
        }
    }
}
