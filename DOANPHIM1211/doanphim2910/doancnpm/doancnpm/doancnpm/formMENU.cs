
using doancnpm.DTO;
using doancnpm.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doancnpm
{
    public partial class formMENU : Form
    {
        private Button currentButton;
        private UserControl activeForm;
        public static tbl_nhanvienDTO nvdangnhap;
        public formMENU(tbl_nhanvienDTO nv)
        {
            InitializeComponent();
            nvdangnhap = nv;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }
        
        public void sup()
        {
            FormLogin.phanquyench += FormLogin_phanquyench;
            DoiMK_UC.TatTrangChu += DoiMK_UC_TatTrangChu;
        }

        private void DoiMK_UC_TatTrangChu(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_phanquyench(object sender, EventArgs e)
        {
            btnQLP.Enabled = false;
            btnQLNV.Enabled = false;
            btnQLLC.Enabled = false;
            btnBC.Enabled = false;
            btnQLP.BackColor = Color.Red;
            btnQLNV.BackColor = Color.Red;
            btnQLLC.BackColor = Color.Red;
            btnBC.BackColor = Color.Red;

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = SystemColors.ActiveCaption;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                   // panelTitleBar.BackColor = Color.CadetBlue;
                }
            }
        }

        public static string mahoa(string chuoimahoa)
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(chuoimahoa);
                byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                return hash;
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMENU.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    if ((previousBtn as Button).BackColor == Color.Red)
                    {
                        continue;
                    }
                    else
                    {
                        previousBtn.BackColor = Color.White;
                        previousBtn.ForeColor = Color.Black;
                        previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                }
               // Microsoft Sans Serif, 8.25pt
            }
        }
        public static void autocomplete(TextBox a, List<string> b)
        {
            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            foreach (string s in b)
            {
                allowedTypes.Add(s);
            }
            a.AutoCompleteMode = AutoCompleteMode.Suggest;
            a.AutoCompleteSource = AutoCompleteSource.CustomSource;
            a.AutoCompleteCustomSource = allowedTypes;
        }
        public void OpenChildForm(UserControl a, object btnSender)
        {
            if (activeForm != null)
                activeForm.Hide();
            activeForm = a;
            ActivateButton(btnSender);
            this.paneCHINH.Controls.Add(a);
            this.paneCHINH.Tag = a;
            TITLEQL.Text = (btnSender as Button).Text;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new POS_UC(), sender);
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new QLNV_UC(), sender);
        }

        private void btnQLV_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new QLLL_UC(), sender);

        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;

        }

        private void btnQLLC_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new QLLC_UC(), sender);
        }

        private void btnQLP_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new QLP_UC(), sender);


        }

        private void btnBC_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new BC_UC(), sender);
        }

        private void formMENU_Load(object sender, EventArgs e)
        {
            TenNVLB.Text = nvdangnhap.tennhanvien;
            TenCN.Text = (chinhanhBLL.GetCNTheoIDCN(nvdangnhap.id_chinhanh).tenchinhanh);
            
            sup();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
           
            FormLogin lg = new FormLogin();
            lg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new DoiMK_UC(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TITLEQL.Text = (sender as Button).Text;
            OpenChildForm(new QLKH_UC(), sender);
        }
    }
}
