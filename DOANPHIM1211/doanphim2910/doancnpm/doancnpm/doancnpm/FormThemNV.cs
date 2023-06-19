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
    public partial class FormThemNV : Form
    {
        public FormThemNV()
        {
            InitializeComponent();
        }
        public static event EventHandler loaddt;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            tbl_nhanvienDTO nv = new tbl_nhanvienDTO();
            nv.id_nhanvien = "NV" + (nhanvienBLL.GetCountNV() + 1).ToString("000");
            nv.id_chinhanh = formMENU.nvdangnhap.id_chinhanh;
            nv.tennhanvien = textBox1.Text;
            nv.matkhau = formMENU.mahoa(textBox2.Text);
            nv.email = textBox4.Text;
            nv.sdt = textBox3.Text;
            nv.chucvu = "NV";
           if (nhanvienBLL.AddNew(nv))
            {
                MessageBox.Show("Thêm nhân viên thành công!");
                loaddt(sender, new EventArgs());
                this.Close();   
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!");
            }
           

        }
    }
}
