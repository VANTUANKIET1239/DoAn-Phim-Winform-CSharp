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
    public partial class QLNV_UC : UserControl
    {
        public QLNV_UC()
        {
            InitializeComponent();
            dgvdsNv.MultiSelect = false;
            dgvdsNv.ReadOnly = true;
            dgvdsNv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void sub()
        {
            FormThemNV.loaddt += FormThemNV_loaddt;
        }

        private void FormThemNV_loaddt(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormThemNV tnv = new FormThemNV();
            tnv.Show();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            tbl_nhanvienDTO nv = nhanvienBLL.GetNhanVienTheoID(dgvdsNv.SelectedRows[0].Cells[0].Value.ToString());
            
            if (nhanvienBLL.Delete(nv.id_nhanvien))
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại!");
            }
        }

        private void tbnEdi_Click(object sender, EventArgs e)
        {
            btnLUU.Enabled = true;
            anthongtin(true);


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            tbl_nhanvienDTO nv = nhanvienBLL.GetNhanVienTheoID(dgvdsNv.SelectedRows[0].Cells[0].Value.ToString());
            nv.tennhanvien = txtNa.Text;
            nv.sdt = txtSDT.Text;
            nv.email = txtEma.Text;
            if (nhanvienBLL.Modify(nv))
            {
                MessageBox.Show("Sửa nhân viên thành công!");
                loaddata();
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại!");
            }
        }
        private void anthongtin(bool a)
        {
            txtEma.Enabled = a;
            txtNa.Enabled = a;
          
            txtSDT.Enabled = a;
        }
        private void loaddata()
        {
            dgvdsNv.DataSource = nhanvienBLL.GetToanBoNhanVien();
        }
        private void QLNV_UC_Load(object sender, EventArgs e)
        {
            loaddata();
            anthongtin(false);
            btnLUU.Enabled = false;
            dgvdsNv.Columns["trangthai"].Visible = false;
            List<string> a = new List<string>();
            foreach (tbl_nhanvienDTO n in nhanvienBLL.GetToanBoNhanVien())
            {
                a.Add(n.tennhanvien);
            }
            formMENU.autocomplete(timkiemtxt, a);
            
        }

        private void dgvdsNv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNa.Text = dgvdsNv.SelectedRows[0].Cells[1].Value.ToString();
          
            txtEma.Text = dgvdsNv.SelectedRows[0].Cells[4].Value.ToString();
            txtSDT.Text = dgvdsNv.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void timkiemtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                tbl_nhanvienDTO nv = nhanvienBLL.GetNhanVienTheoTen(timkiemtxt.Text);
                List<tbl_nhanvienDTO> a = new List<tbl_nhanvienDTO>();
                a.Add(nv);
                dgvdsNv.DataSource = a;
            }
        }
    }
}
