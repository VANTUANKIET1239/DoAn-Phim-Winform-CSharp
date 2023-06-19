using doancnpm.DTO;
using doancnpm.BLL;
using doancnpm.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace doancnpm.UC
{
    public partial class DoiMK_UC : UserControl
    {
        public DoiMK_UC()
        {
            InitializeComponent();
        }
        public static event EventHandler TatTrangChu;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXacNhanMK_Click(object sender, EventArgs e)
        {
            tbl_nhanvienDTO nv = formMENU.nvdangnhap;
            if(formMENU.mahoa(MKhientai.Text) == nv.matkhau)
            {
                if(MKmoi1.Text == MKmoi2.Text)
                {
                    string mkm = formMENU.mahoa(MKmoi2.Text);
                    nv.matkhau = mkm;
                    if (nhanvienBLL.UpdateMatKhauNV(nv))
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!");
                        FormLogin lg = new FormLogin();
                        lg.Show();
                        TatTrangChu(sender, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại!");
                        FormLogin lg = new FormLogin();
                        lg.Show();
                        TatTrangChu(sender, new EventArgs());
                    }
                }
            }
            else
            {

            }
        }
    }
}
