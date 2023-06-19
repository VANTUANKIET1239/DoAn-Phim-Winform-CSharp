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
    public partial class QLLL_UC : UserControl
    {
        public QLLL_UC()
        {
            InitializeComponent();
        }

        private void QLLL_UC_Load(object sender, EventArgs e)
        {
            cbNv.DisplayMember = "tennhanvien";
            cbNv.ValueMember = "id_nhanvien";
            cbNv.DataSource = nhanvienBLL.GetNhanVienTheoCN(formMENU.nvdangnhap.id_chinhanh);
            lblWat.Visible = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnSea.Enabled = false;
            btnEdi.Enabled = false;
            txtWatCn.Text = chinhanhBLL.GetCNTheoIDCN(formMENU.nvdangnhap.id_chinhanh).tenchinhanh;
            txtWatCn.Enabled = false;
            changecolorbtnLich();

        }


        private void txtWatCn_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbNv_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn2S.BackColor = Color.Transparent;
            btn3S.BackColor = Color.Transparent;
            btn4S.BackColor = Color.Transparent;
            btn5S.BackColor = Color.Transparent;
            btn6S.BackColor = Color.Transparent;
            btn7S.BackColor = Color.Transparent;
            btn8S.BackColor = Color.Transparent;
            btn2C.BackColor = Color.Transparent;
            btn3C.BackColor = Color.Transparent;
            btn4C.BackColor = Color.Transparent;
            btn5C.BackColor = Color.Transparent;
            btn6C.BackColor = Color.Transparent;
            btn7C.BackColor = Color.Transparent;
            btn8C.BackColor = Color.Transparent;
        }

        private void dtpDay_ValueChanged(object sender, EventArgs e)
        {
            btn2S.BackColor = Color.Transparent;
            btn3S.BackColor = Color.Transparent;
            btn4S.BackColor = Color.Transparent;
            btn5S.BackColor = Color.Transparent;
            btn6S.BackColor = Color.Transparent;
            btn7S.BackColor = Color.Transparent;
            btn8S.BackColor = Color.Transparent;
            btn2C.BackColor = Color.Transparent;
            btn3C.BackColor = Color.Transparent;
            btn4C.BackColor = Color.Transparent;
            btn5C.BackColor = Color.Transparent;
            btn6C.BackColor = Color.Transparent;
            btn7C.BackColor = Color.Transparent;
            btn8C.BackColor = Color.Transparent;
            if (dtpDay.Value.DayOfWeek.ToString() != "Monday")//??
            {
                txtIn4.Text = "Ngày bắt đầu phải là ngày thứ hai!";
                txtIn4.Visible = true;
            }
            else
            {
                btnSea.Enabled = true;
                txtIn4.Visible = false;
                if (dtpDay.Value > DateTime.Now)
                {
                    btnAdd.Enabled = true;
                    btnDel.Enabled = true;
                    btnEdi.Enabled = true;
                }
                else
                {
                    txtIn4.Text = "Không thể thay đổi lịch làm việc đã qua!";
                    txtIn4.Visible = true;
                    btnAdd.Enabled = false;
                    btnDel.Enabled = false;
                    btnEdi.Enabled = false;
                }
            }
        }

        private void btnSea_Click(object sender, EventArgs e)
        {
            tbl_lichlamviecDTO Li = lichlamviecBLL.GetOneByNv(dtpDay.Value, cbNv.SelectedValue.ToString());
            //tbl_lichlamviec Li = lichlamviecBLL.GetOneByNv(dtpDay.Text.Substring(0, 10), txtId.Text);
            if (Li.MonMOR) btn2S.BackColor = Color.Green;
            if (Li.TueMOR) btn3S.BackColor = Color.Green;
            if (Li.WedMOR) btn4S.BackColor = Color.Green;
            if (Li.ThuMOR) btn5S.BackColor = Color.Green;
            if (Li.FriMOR) btn6S.BackColor = Color.Green;
            if (Li.SatMOR) btn7S.BackColor = Color.Green;
            if (Li.SunMOR) btn8S.BackColor = Color.Green;
            if (Li.MonEVE) btn2C.BackColor = Color.Green;
            if (Li.TueEVE) btn3C.BackColor = Color.Green;
            if (Li.WedEVE) btn4C.BackColor = Color.Green;
            if (Li.ThuEVE) btn5C.BackColor = Color.Green;
            if (Li.FriEVE) btn6C.BackColor = Color.Green;
            if (Li.SatEVE) btn7C.BackColor = Color.Green;
            if (Li.SunEVE) btn8C.BackColor = Color.Green;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbl_lichlamviecDTO Li = new tbl_lichlamviecDTO();
            DialogResult r = MessageBox.Show("Đang thêm lịch làm việc tuần ngày "
                    + dtpDay.Text.Substring(0, 10) + " của " + cbNv.SelectedValue.ToString() + "...", "Thêm?", MessageBoxButtons.OKCancel);
            Li.id_nhanvien = cbNv.SelectedValue.ToString();
            Li.ngaybd = dtpDay.Value;
            if (r == DialogResult.OK)
            {
                if (btn2S.BackColor == Color.Green) Li.MonMOR = true;
                if (btn3S.BackColor == Color.Green) Li.TueMOR = true;
                if (btn4S.BackColor == Color.Green) Li.WedMOR = true;
                if (btn5S.BackColor == Color.Green) Li.ThuMOR = true;
                if (btn6S.BackColor == Color.Green) Li.FriMOR = true;
                if (btn7S.BackColor == Color.Green) Li.SatMOR = true;
                if (btn8S.BackColor == Color.Green) Li.SunMOR = true;
                if (btn2C.BackColor == Color.Green) Li.MonEVE = true;
                if (btn3C.BackColor == Color.Green) Li.TueEVE = true;
                if (btn4C.BackColor == Color.Green) Li.WedEVE = true;
                if (btn5C.BackColor == Color.Green) Li.ThuEVE = true;
                if (btn6C.BackColor == Color.Green) Li.FriEVE = true;
                if (btn7C.BackColor == Color.Green) Li.SatEVE = true;
                if (btn8C.BackColor == Color.Green) Li.SunEVE = true;
                if (lichlamviecBLL.AddNew(Li))
                {
                    MessageBox.Show("Đã thêm lịch làm việc tuần ngày "
                      + dtpDay.Text.Substring(0, 10) + " của " + cbNv.SelectedValue.ToString(), "Thành công");
                }
                else MessageBox.Show("Không thêm được", "Thất bại");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Đang xóa lịch làm việc tuần ngày "
                    + dtpDay.Text.Substring(0, 10) + " của " + cbNv.SelectedValue.ToString() + "...", "Xóa?", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                if (lichlamviecBLL.Delete(dtpDay.Value, cbNv.SelectedValue.ToString()))
                {
                    MessageBox.Show("Đã xóa lịch làm việc tuần ngày "
                      + dtpDay.Text.Substring(0, 10) + " của " + cbNv.SelectedValue.ToString(), "Thành công");
                }
                else MessageBox.Show("Không xóa được", "Thất bại");
            }
        }

        private void btnEdi_Click(object sender, EventArgs e)
        {
            tbl_lichlamviecDTO Li = lichlamviecBLL.GetOneByNv(dtpDay.Value, cbNv.SelectedValue.ToString());
            DialogResult r = MessageBox.Show("Đang sửa lịch làm việc tuần ngày "
                    + dtpDay.Text.Substring(0, 10) + " của " + cbNv.SelectedValue.ToString() + "...", "Sửa?", MessageBoxButtons.OKCancel);
            if (r == DialogResult.OK)
            {
                if (btn2S.BackColor == Color.Green) Li.MonMOR = true;
                if (btn3S.BackColor == Color.Green) Li.TueMOR = true;
                if (btn4S.BackColor == Color.Green) Li.WedMOR = true;
                if (btn5S.BackColor == Color.Green) Li.ThuMOR = true;
                if (btn6S.BackColor == Color.Green) Li.FriMOR = true;
                if (btn7S.BackColor == Color.Green) Li.SatMOR = true;
                if (btn8S.BackColor == Color.Green) Li.SunMOR = true;
                if (btn2C.BackColor == Color.Green) Li.MonEVE = true;
                if (btn3C.BackColor == Color.Green) Li.TueEVE = true;
                if (btn4C.BackColor == Color.Green) Li.WedEVE = true;
                if (btn5C.BackColor == Color.Green) Li.ThuEVE = true;
                if (btn6C.BackColor == Color.Green) Li.FriEVE = true;
                if (btn7C.BackColor == Color.Green) Li.SatEVE = true;
                if (btn8C.BackColor == Color.Green) Li.SunEVE = true;
                if (lichlamviecBLL.Modify(Li))
                {
                    MessageBox.Show("Đã sửa lịch làm việc tuần ngày "
                      + dtpDay.Text.Substring(0, 10) + " của " + cbNv.SelectedValue.ToString(), "Thành công");
                }
                else MessageBox.Show("Không sửa được", "Thất bại");
            }

        }
        private void ChangeColor(Button btn)
        {
            if (btn.BackColor == Color.Transparent)
                btn.BackColor = Color.Green;
            else btn.BackColor = Color.Transparent;
        }
        private void changecolorbtnLich()
        {
            foreach (Control s in flowlich.Controls)
            {
                (s as Button).Click += QLLL_UC_Click;
            }
        }

        private void QLLL_UC_Click(object sender, EventArgs e)
        {
            ChangeColor(sender as Button);
        }
        private void watch(Button btn, bool bo)
        {
            if (bo) btn.BackColor = Color.Green;
        }
        private void watchC(Button btn, bool bo)
        {
            if (bo) btn.BackColor = Color.OrangeRed;
        }
        void Taopanel(int k, List<tbl_lichlamviecDTO> lll)
        {
            for (int i = 0; i < k; i++)
            {
                TextBox tb_maNV = new TextBox();
                TextBox tb_tenNV = new TextBox();
                tb_maNV.Name = "tb_maNV" + i;
                tb_tenNV.Name = "tb_tenNV" + i;
                tb_maNV.Width = 75;
                tb_maNV.Height = 24;
                tb_tenNV.Width = 186;
                tb_tenNV.Height = 24;
                tb_maNV.Text = lll[0].id_nhanvien.ToString();
                tb_tenNV.Text = nhanvienBLL.GetNhanVienTheoID(lll[0].id_nhanvien.ToString()).tennhanvien;
                fLPlll.Controls.Add(tb_maNV);
                fLPlll.Controls.Add(tb_tenNV);
                for (int j = 0; j < 14; j++)
                {
                    Button btn = new Button();
                    btn.Name = "x" + i * 14 + j;
                    btn.BackColor = Color.Gray;
                    switch (j)
                    {
                        case 0:
                            if (lll[i].MonMOR == true)
                                btn.BackColor = Color.Green; break;
                        case 1:
                            if (lll[i].TueMOR == true)
                                btn.BackColor = Color.Green; break;
                        case 2:
                            if (lll[i].WedMOR == true)
                                btn.BackColor = Color.Green; break;
                        case 3:
                            if (lll[i].ThuMOR == true)
                                btn.BackColor = Color.Green; break;
                        case 4:
                            if (lll[i].FriMOR == true)
                                btn.BackColor = Color.Green; break;
                        case 5:
                            if (lll[i].SatMOR == true)
                                btn.BackColor = Color.Green; break;
                        case 6:
                            if (lll[i].SunMOR == true)
                                btn.BackColor = Color.Green; break;
                        case 7:
                            if (lll[i].MonEVE == true)
                                btn.BackColor = Color.Green; break;
                        case 8:
                            if (lll[i].TueEVE == true)
                                btn.BackColor = Color.Green; break;
                        case 9:
                            if (lll[i].ThuEVE == true)
                                btn.BackColor = Color.Green; break;
                        case 10:
                            if (lll[i].ThuEVE == true)
                                btn.BackColor = Color.Green; break;
                        case 11:
                            if (lll[i].FriEVE == true)
                                btn.BackColor = Color.Green; break;
                        case 12:
                            if (lll[i].SatEVE == true)
                                btn.BackColor = Color.Green; break;
                        case 13:
                            if (lll[i].SunEVE == true)
                                btn.BackColor = Color.Green; break;

                    }
                    btn.Width = 44;
                    btn.Height = 25;
                    fLPlll.Controls.Add(btn);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
