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
    public partial class QLLC_UC : UserControl
    {
        public QLLC_UC()
        {
            InitializeComponent();
        }
        void load_lichchieu()
        {
            List<tbl_lichchieuDTO> lichchieu = lichchieuBLL.GetAll();
            dGV_lichchieu.DataSource = lichchieu;
        }
        public static void Autocomplete(TextBox tb, List<string> _list)
        {
            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            foreach (string s in _list)
            {
                allowedTypes.Add(s);
            }
            tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb.AutoCompleteCustomSource = allowedTypes;
        }

        private void QLLC_UC_Load(object sender, EventArgs e)
        {
            load_lichchieu();
            List<tbl_movie> asd = lichchieuBLL.Get_tenphim();
            List<string> a = new List<string>();
            List<string> b = new List<string>();
            tB_chinhanh.Enabled = false;
            tB_phim.Enabled = false;
            tB_chinhanh.Text = chinhanhBLL.GetCNTheoIDCN(formMENU.nvdangnhap.id_chinhanh).tenchinhanh;
            foreach (tbl_movie temp in asd)
            {
                a.Add(temp.id_phim);
                b.Add(temp.tenphim);
            }
            Autocomplete(tB_tenphim, b);
            Autocomplete(tB_phim, b);
            //  Autocomplete(tB_id_phim, a);
            List<tbl_chinhanh> abcd = lichchieuBLL.Get_tenchinhanh();
            List<string> c = new List<string>();
            foreach (tbl_chinhanh ch in abcd)
            {
                c.Add(ch.tenchinhanh);
            }
            Autocomplete(tB_chinhanh, c);
        }

        private void dGV_lichchieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tB_id_lichchieu.Text = dGV_lichchieu.CurrentRow.Cells[0].Value.ToString();
            dTP_lc_ngaychieu.Value = (DateTime)dGV_lichchieu.CurrentRow.Cells[1].Value;
            tB_chinhanh.Text = lichchieuBLL.GetFind_chinhanh(dGV_lichchieu.CurrentRow.Cells[5].Value.ToString());
            string temp = dGV_lichchieu.CurrentRow.Cells[2].Value.ToString();
            cB_hourGC.Text = temp.Substring(1, 2);
            cB_minuteGC.Text = temp.Substring(3, 2);
            tB_rap.Text = dGV_lichchieu.CurrentRow.Cells[4].Value.ToString();
            //tB_id_phim.Text = dGV_lichchieu.CurrentRow.Cells[3].Value.ToString();
            tB_phim.Text = lichchieuBLL.GetFind_tenphim(dGV_lichchieu.CurrentRow.Cells[3].Value.ToString());
        }

        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            string tenphim = null;
            if (cB_tenphim.Checked)
            {
                tenphim = lichchieuBLL.Truyvanid_tenphim(tB_tenphim.Text);
            }
            int rapp = 0;
            if (cB_rap.Checked)
                rapp = int.Parse(cB_rap_tracuu.Text.ToString());
            string timefr = string.Concat(cB_hourfrom.Text.ToString(), cB_minutefrom.Text.ToString());
            string timeend = string.Concat(cB_hourto.Text.ToString(), cB_minuteto.Text.ToString());
            List<tbl_lichchieuDTO> nv = lichchieuBLL.GetFind(dtpTimeFrom.Value, dtpTimeTo.Value, timefr, timeend, tenphim, rapp);
            dGV_lichchieu.DataSource = nv;
        }
        private void cB_ngaychieu_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_ngaychieu.Checked)
            {
                gB_ngaychieuphim.Enabled = true;
            }
            else
            {
                gB_ngaychieuphim.Enabled = false;
            }
        }
        private void cB_tenphim_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_tenphim.Checked)
            {
                tB_tenphim.Enabled = true;
            }
            else
            {
                tB_tenphim.Enabled = false;
            }
        }
        private void cB_giochieu_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_giochieu.Checked)
            {
                gB_giochieuphim.Enabled = true;
            }
            else
            {
                gB_giochieuphim.Enabled = false;
            }
        }
        private void cB_rap_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_rap.Checked)
            {
                cB_rap_tracuu.Enabled = true;
            }
            else
            {
                cB_rap_tracuu.Enabled = false;
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            dTP_lc_ngaychieu.Enabled = true;
            tB_chinhanh.Enabled = true;
            tB_phim.Enabled = false;
            tB_rap.Enabled = true;
            btn_luu.Enabled = true;
            cB_hourGC.Enabled = true;
            cB_minuteGC.Enabled = true;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            tbl_lichchieuDTO nv = new tbl_lichchieuDTO();
            nv.id_lichchieu = tB_id_lichchieu.Text;
            if (lichchieuBLL.Delete(nv))
            {
                MessageBox.Show("Xóa thành công");
                load_lichchieu();
            }
            else MessageBox.Show("Fail!");
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            List<tbl_lichchieuDTO> temp = lichchieuBLL.taoidmoi();
            tB_id_lichchieu.Text = "LC" + (temp.Count + 1).ToString("000");
            dTP_lc_ngaychieu.Enabled = true;
            tB_chinhanh.Enabled = true;
            tB_phim.Enabled = true;
            // tB_id_phim.Enabled = true;
            tB_rap.Enabled = true;
            btn_luu.Enabled = true;
            cB_hourGC.Enabled = true;
            cB_minuteGC.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            tbl_lichchieuDTO a = new tbl_lichchieuDTO();
            a.id_lichchieu = tB_id_lichchieu.Text;
            a.giochieu = "G" + cB_hourGC.Text + cB_minuteGC.Text;
            //  a.id_phim = tB_id_phim.Text;
            a.ngay = (DateTime)dTP_lc_ngaychieu.Value;
            a.rap = int.Parse(tB_rap.Text);
            a.id_chinhanh = lichchieuBLL.Truyvanid_chinhanh(tB_chinhanh.Text);
            string ne = tB_id_lichchieu.Text.ToString().Substring(2, 3);
            int temp = Convert.ToInt32(ne);
            List<tbl_lichchieuDTO> tempp = lichchieuBLL.taoidmoi();
            if (temp > tempp.Count)
            {
                if (lichchieuBLL.AddNew(a))
                {
                    MessageBox.Show("Thê, thành công");
                    List<tbl_lichchieuDTO> tempppp = lichchieuBLL.GetAll();
                    dGV_lichchieu.DataSource = tempppp;
                }
                else MessageBox.Show("Fail!");
            }
            else
            {
                if (lichchieuBLL.Update(a))
                {
                    MessageBox.Show("Sửa thành công");
                    List<tbl_lichchieuDTO> tempppp = lichchieuBLL.GetAll();
                    dGV_lichchieu.DataSource = tempppp;
                }
                else MessageBox.Show("Fail!");
            }
        }

        private void bt_thungrac_Click(object sender, EventArgs e)
        {
            bt_khoiphuc.Enabled = true;
            List<tbl_lichchieuDTO> lichchieu = lichchieuBLL.backup();
            dGV_lichchieu.DataSource = lichchieu;
        }

        private void bt_khoiphuc_Click(object sender, EventArgs e)
        {
            tbl_lichchieuDTO nv = new tbl_lichchieuDTO();
            nv.id_lichchieu = tB_id_lichchieu.Text;
            if (lichchieuBLL.restore(nv))
            {
                MessageBox.Show("Khôi phục thành công");
                load_lichchieu();
            }
            else MessageBox.Show("Fail!");
        }

        private void tB_phim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
