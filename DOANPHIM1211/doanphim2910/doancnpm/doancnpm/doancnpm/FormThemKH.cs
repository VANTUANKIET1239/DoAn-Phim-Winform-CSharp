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
    public partial class FormThemKH : Form
    {
        public FormThemKH()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl_khachhangDTO kh = new tbl_khachhangDTO();
            kh.id_khachhang = "KH" + (khachhangBLL.GetCountKH() + 1).ToString("000");
            kh.hoten = txthoten.Text;
            kh.diachi = txtdiachi.Text;
            kh.diemtichluy = 0;
            kh.dienthoai = txtsdt.Text;
            if (khachhangBLL.AddNew(kh))
            {
                MessageBox.Show("Thêm khách hàng thành công!");
            }
            else
            {
                MessageBox.Show("Thêm khách hàng thất bại!");
            }
            this.Close();

        }
    }
}
