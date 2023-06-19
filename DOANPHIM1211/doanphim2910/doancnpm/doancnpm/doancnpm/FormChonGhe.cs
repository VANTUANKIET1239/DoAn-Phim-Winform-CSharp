using doancnpm.BLL;
using doancnpm.DTO;
using doancnpm.UC;
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
    public partial class FormChonGhe : Form
    {
        //dữ liệu có được giữ lại hay không khi close form này đi, nếu không giữ lại được thì dung event
        public static List<string> GheFCG = new List<string>();
        private static int soluongve_FCG = 0;
        private static int slchonLC_FCG = 0;
        private static List<string> prebtn_FCG = new List<string>();
        private tbl_lichchieuDTO lctam = new tbl_lichchieuDTO();
        public FormChonGhe()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            sub();
        }
        public static event EventHandler ChuyenThongTinGhe;
        public void sub()
        {
            POS_UC.chuyenSLVE += POS_UC_chuyenSLVE;
            POS_UC.layghetheolich += POS_UC_layghetheolich;
        }

        private void POS_UC_layghetheolich(object sender, EventArgs e)
        {
            lctam = POS_UC.VaoLucTT;
            
        }

        private void POS_UC_chuyenSLVE(object sender, EventArgs e)
        {
            soluongve_FCG = POS_UC.slve;
        }

        void TaoButton(int k)
        {
            
            Button btn;
           
                
            
            for (int i = 0; i < k; i++)
            {
                
                btn = new Button();
                btn.BackColor = Color.Gray;
                btn.Text = (i+1).ToString();
                btn.Width = 50;
                btn.Height = 40;
                btn.Name = "G" + (i+1);
                btn.Click += new EventHandler(buttionclick);
                    flowLayoutPanel1.Controls.Add(btn);
                
            }
        
           for(int i = 0; i < GheFCG.Count; i++)
            {
                foreach (Control s in flowLayoutPanel1.Controls)
                {
                    if((s as Button).Name == GheFCG[i])
                    {

                        (s as Button).BackColor = Color.Yellow;
                    }
                }
            }
        }
       
        private void buttionclick(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;

            if (prebtn_FCG.Count == soluongve_FCG)
            {
                int count = 0;
                foreach (string n in prebtn_FCG)
                {

                    if (n == ((Button)sender).Name)
                    {

                        btn.BackColor = Color.Gray;
                        slchonLC_FCG -= 1;
                        
                        prebtn_FCG.Remove(n);
                             count += 1;
                        break;
                    }
                }
                if (count == 0)
                {
                    MessageBox.Show("Bạn chọn quá số lượng ghế");
                }
                    
            }
            else
            {
                int count2 = 0;
                foreach (string n in prebtn_FCG)
                {

                    if (n == ((Button)sender).Name)
                    {

                        btn.BackColor = Color.Gray;
                        slchonLC_FCG -= 1;

                        prebtn_FCG.Remove(n);
                  
                             count2 += 1;
                        break;
                    }
                  
                }
                  if(count2 == 0)
                {
                    prebtn_FCG.Add(btn.Name);
                   
                    btn.BackColor = Color.Yellow;
                    slchonLC_FCG += 1;
               
                    
                }

            }
            //int count = 0;


        }
        private void FormChonGhe_Load(object sender, EventArgs e)
        {
           foreach(string t in ticketBLL.GetGheTheoLichChieu(lctam.id_lichchieu))
            {
                textBox1.Text += t + "-";
            }
            TaoButton(40);
            foreach (string s in ticketBLL.GetGheTheoLichChieu(lctam.id_lichchieu))
            {
                foreach (Control n in flowLayoutPanel1.Controls)
                {
                    if (s.Trim() == (n as Button).Name)
                    {
                        (n as Button).BackColor = Color.Red;
                        (n as Button).Enabled = false;
                    }
                }

            }


        }

        private void btnHuyCG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void XacNhanCG_Click(object sender, EventArgs e)
        {
            GheFCG.Clear();
            foreach (Control s in flowLayoutPanel1.Controls)
            {
                Button btn = s as Button;
                if(btn.BackColor == Color.Yellow)
                {
                  
                    GheFCG.Add(btn.Name);
                   // prebtn_FCG.Add()
                }
            }
            ChuyenThongTinGhe(sender, new EventArgs());
            this.Close();
        }
    }
}
