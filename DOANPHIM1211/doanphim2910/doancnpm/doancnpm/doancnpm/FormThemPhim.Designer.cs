
namespace doancnpm
{
    partial class FormThemPhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TinhTrangPhimCB = new System.Windows.Forms.ComboBox();
            this.KhoiChieuDATE = new System.Windows.Forms.DateTimePicker();
            this.HinhAnhPic = new System.Windows.Forms.PictureBox();
            this.btnThemPhim = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PhanLoaitxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DaoDientxt = new System.Windows.Forms.TextBox();
            this.ThoiLuongtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DienVientxt = new System.Windows.Forms.TextBox();
            this.TenPhimtxt = new System.Windows.Forms.TextBox();
            this.TheLoaitxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnhPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TinhTrangPhimCB
            // 
            this.TinhTrangPhimCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTrangPhimCB.FormattingEnabled = true;
            this.TinhTrangPhimCB.Items.AddRange(new object[] {
            "Phim đang chiếu",
            "Phim sắp chiếu"});
            this.TinhTrangPhimCB.Location = new System.Drawing.Point(261, 333);
            this.TinhTrangPhimCB.Name = "TinhTrangPhimCB";
            this.TinhTrangPhimCB.Size = new System.Drawing.Size(208, 28);
            this.TinhTrangPhimCB.TabIndex = 27;
            // 
            // KhoiChieuDATE
            // 
            this.KhoiChieuDATE.Location = new System.Drawing.Point(261, 261);
            this.KhoiChieuDATE.Name = "KhoiChieuDATE";
            this.KhoiChieuDATE.Size = new System.Drawing.Size(208, 20);
            this.KhoiChieuDATE.TabIndex = 26;
            // 
            // HinhAnhPic
            // 
            this.HinhAnhPic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.HinhAnhPic.Location = new System.Drawing.Point(11, 81);
            this.HinhAnhPic.Name = "HinhAnhPic";
            this.HinhAnhPic.Size = new System.Drawing.Size(113, 171);
            this.HinhAnhPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HinhAnhPic.TabIndex = 25;
            this.HinhAnhPic.TabStop = false;
            // 
            // btnThemPhim
            // 
            this.btnThemPhim.Location = new System.Drawing.Point(368, 453);
            this.btnThemPhim.Name = "btnThemPhim";
            this.btnThemPhim.Size = new System.Drawing.Size(99, 36);
            this.btnThemPhim.TabIndex = 24;
            this.btnThemPhim.Text = "Thêm Phim";
            this.btnThemPhim.UseVisualStyleBackColor = true;
            this.btnThemPhim.Click += new System.EventHandler(this.btnThemPhim_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Thể Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Đạo Diễn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Phân Loại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tình Trạng Phim";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Thời Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Khởi chiếu";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PhanLoaitxt
            // 
            this.PhanLoaitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhanLoaitxt.Location = new System.Drawing.Point(261, 413);
            this.PhanLoaitxt.Name = "PhanLoaitxt";
            this.PhanLoaitxt.Size = new System.Drawing.Size(208, 26);
            this.PhanLoaitxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Diễn Viên";
            // 
            // DaoDientxt
            // 
            this.DaoDientxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaoDientxt.Location = new System.Drawing.Point(231, 191);
            this.DaoDientxt.Multiline = true;
            this.DaoDientxt.Name = "DaoDientxt";
            this.DaoDientxt.Size = new System.Drawing.Size(235, 53);
            this.DaoDientxt.TabIndex = 11;
            // 
            // ThoiLuongtxt
            // 
            this.ThoiLuongtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThoiLuongtxt.Location = new System.Drawing.Point(261, 299);
            this.ThoiLuongtxt.Name = "ThoiLuongtxt";
            this.ThoiLuongtxt.Size = new System.Drawing.Size(208, 26);
            this.ThoiLuongtxt.TabIndex = 10;
            this.ThoiLuongtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên Phim";
            // 
            // DienVientxt
            // 
            this.DienVientxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DienVientxt.Location = new System.Drawing.Point(231, 119);
            this.DienVientxt.Multiline = true;
            this.DienVientxt.Name = "DienVientxt";
            this.DienVientxt.Size = new System.Drawing.Size(235, 53);
            this.DienVientxt.TabIndex = 9;
            // 
            // TenPhimtxt
            // 
            this.TenPhimtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenPhimtxt.Location = new System.Drawing.Point(231, 85);
            this.TenPhimtxt.Name = "TenPhimtxt";
            this.TenPhimtxt.Size = new System.Drawing.Size(235, 26);
            this.TenPhimtxt.TabIndex = 13;
            // 
            // TheLoaitxt
            // 
            this.TheLoaitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TheLoaitxt.Location = new System.Drawing.Point(261, 372);
            this.TheLoaitxt.Name = "TheLoaitxt";
            this.TheLoaitxt.Size = new System.Drawing.Size(208, 26);
            this.TheLoaitxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Tải Lên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 29;
            this.button2.Text = "Hủy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 62);
            this.panel1.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(170, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Thêm Phim Mới";
            // 
            // FormThemPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TinhTrangPhimCB);
            this.Controls.Add(this.KhoiChieuDATE);
            this.Controls.Add(this.HinhAnhPic);
            this.Controls.Add(this.btnThemPhim);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhanLoaitxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DaoDientxt);
            this.Controls.Add(this.ThoiLuongtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DienVientxt);
            this.Controls.Add(this.TenPhimtxt);
            this.Controls.Add(this.TheLoaitxt);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormThemPhim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HinhAnhPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TinhTrangPhimCB;
        private System.Windows.Forms.DateTimePicker KhoiChieuDATE;
        private System.Windows.Forms.PictureBox HinhAnhPic;
        private System.Windows.Forms.Button btnThemPhim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PhanLoaitxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DaoDientxt;
        private System.Windows.Forms.TextBox ThoiLuongtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DienVientxt;
        private System.Windows.Forms.TextBox TenPhimtxt;
        private System.Windows.Forms.TextBox TheLoaitxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}