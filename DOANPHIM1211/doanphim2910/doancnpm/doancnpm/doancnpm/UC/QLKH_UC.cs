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

namespace doancnpm.UC
{
    public partial class QLKH_UC : UserControl
    {
        public QLKH_UC()
        {
            InitializeComponent();
        }

        private void QLKH_UC_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            anthongtin(false);
            datakh.DataSource = khachhangBLL.GetToanBoKhachHang();
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            FormThemKH kh = new FormThemKH();
            kh.Show();
        }
        private void anthongtin(bool a)
        {
            txtdiachi.Enabled = a;
            txtdiemtichluy.Enabled = a;
            txthoten.Enabled = a;
            txtsdt.Enabled = a;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            tbl_khachhangDTO nv = khachhangBLL.GetKhachHangTheoID(datakh.SelectedRows[0].Cells[0].Value.ToString());

            if (khachhangBLL.Delete(nv.id_khachhang))
            {
                MessageBox.Show("Xóa khách hàng thành công!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Xóa khách hàng thất bại!");
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            tbl_khachhangDTO h = khachhangBLL.GetKhachHangTheoID(datakh.SelectedRows[0].Cells[1].Value.ToString());
           // kh.id_khachhang = "KH" + (khachhangBLL.GetCountKH() + 1).ToString("000");
            h.hoten = txthoten.Text;
            h.diachi = txtdiachi.Text;
            h.diemtichluy = 0;
            h.dienthoai = txtsdt.Text;
            if (khachhangBLL.Modify(h))
            {
                MessageBox.Show("Sửa khách hàng thành công!");
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại!");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            anthongtin(true);
          
        }

        private void datakh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txthoten.Text = datakh.SelectedRows[0].Cells[1].Value.ToString();
            txtdiachi.Text = datakh.SelectedRows[0].Cells[2].Value.ToString();
            txtsdt.Text = datakh.SelectedRows[0].Cells[3].Value.ToString();
            txtdiemtichluy.Text = datakh.SelectedRows[0].Cells[4].Value.ToString();

            datadiem.DataSource = diemtichluyBLL.GetToanBoDTLByIDKH(datakh.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
