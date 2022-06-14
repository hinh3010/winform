namespace _14thang6_2h
{
    partial class FormFavorite
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbFavorite = new System.Windows.Forms.GroupBox();
            this.gbFavoriteColor = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.btnFavoriteColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.radWhite = new System.Windows.Forms.RadioButton();
            this.radYellow = new System.Windows.Forms.RadioButton();
            this.radPink = new System.Windows.Forms.RadioButton();
            this.radViolet = new System.Windows.Forms.RadioButton();
            this.ckbNgheNhac = new System.Windows.Forms.CheckBox();
            this.ckbXemPhim = new System.Windows.Forms.CheckBox();
            this.ckbChoiTheThao = new System.Windows.Forms.CheckBox();
            this.ckbDiMuaSam = new System.Windows.Forms.CheckBox();
            this.ckbDiDuLich = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbFavorite.SuspendLayout();
            this.gbFavoriteColor.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.gbFavoriteColor);
            this.splitContainer1.Size = new System.Drawing.Size(930, 666);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbFavorite
            // 
            this.gbFavorite.Controls.Add(this.ckbDiDuLich);
            this.gbFavorite.Controls.Add(this.ckbDiMuaSam);
            this.gbFavorite.Controls.Add(this.ckbChoiTheThao);
            this.gbFavorite.Controls.Add(this.ckbXemPhim);
            this.gbFavorite.Controls.Add(this.ckbNgheNhac);
            this.gbFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFavorite.Location = new System.Drawing.Point(0, 0);
            this.gbFavorite.Name = "gbFavorite";
            this.gbFavorite.Size = new System.Drawing.Size(372, 566);
            this.gbFavorite.TabIndex = 0;
            this.gbFavorite.TabStop = false;
            this.gbFavorite.Text = "Sở thích của bạn";
            this.gbFavorite.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbFavoriteColor
            // 
            this.gbFavoriteColor.Controls.Add(this.radViolet);
            this.gbFavoriteColor.Controls.Add(this.radPink);
            this.gbFavoriteColor.Controls.Add(this.radYellow);
            this.gbFavoriteColor.Controls.Add(this.radWhite);
            this.gbFavoriteColor.Controls.Add(this.radRed);
            this.gbFavoriteColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFavoriteColor.Location = new System.Drawing.Point(0, 0);
            this.gbFavoriteColor.Name = "gbFavoriteColor";
            this.gbFavoriteColor.Size = new System.Drawing.Size(554, 566);
            this.gbFavoriteColor.TabIndex = 0;
            this.gbFavoriteColor.TabStop = false;
            this.gbFavoriteColor.Text = "Màu bạn thích";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnFavorites);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 566);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnFavoriteColor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(554, 100);
            this.panel3.TabIndex = 2;
            // 
            // btnFavorites
            // 
            this.btnFavorites.AutoSize = true;
            this.btnFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFavorites.Location = new System.Drawing.Point(0, 0);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnFavorites.Size = new System.Drawing.Size(372, 100);
            this.btnFavorites.TabIndex = 0;
            this.btnFavorites.Text = "Sở thích của bạn";
            this.btnFavorites.UseVisualStyleBackColor = true;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // btnFavoriteColor
            // 
            this.btnFavoriteColor.AutoSize = true;
            this.btnFavoriteColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFavoriteColor.Location = new System.Drawing.Point(0, 0);
            this.btnFavoriteColor.Name = "btnFavoriteColor";
            this.btnFavoriteColor.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.btnFavoriteColor.Size = new System.Drawing.Size(554, 100);
            this.btnFavoriteColor.TabIndex = 1;
            this.btnFavoriteColor.Text = "Màu bạn thích";
            this.btnFavoriteColor.UseVisualStyleBackColor = true;
            this.btnFavoriteColor.Click += new System.EventHandler(this.btnFavoriteColor_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFavorite);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 666);
            this.panel1.TabIndex = 0;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(29, 100);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(75, 36);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Đỏ";
            this.radRed.UseVisualStyleBackColor = true;
            // 
            // radWhite
            // 
            this.radWhite.AutoSize = true;
            this.radWhite.Location = new System.Drawing.Point(29, 174);
            this.radWhite.Name = "radWhite";
            this.radWhite.Size = new System.Drawing.Size(113, 36);
            this.radWhite.TabIndex = 1;
            this.radWhite.TabStop = true;
            this.radWhite.Text = "Trắng";
            this.radWhite.UseVisualStyleBackColor = true;
            // 
            // radYellow
            // 
            this.radYellow.AutoSize = true;
            this.radYellow.Location = new System.Drawing.Point(29, 258);
            this.radYellow.Name = "radYellow";
            this.radYellow.Size = new System.Drawing.Size(106, 36);
            this.radYellow.TabIndex = 2;
            this.radYellow.TabStop = true;
            this.radYellow.Text = "Vàng";
            this.radYellow.UseVisualStyleBackColor = true;
            // 
            // radPink
            // 
            this.radPink.AutoSize = true;
            this.radPink.Location = new System.Drawing.Point(28, 328);
            this.radPink.Name = "radPink";
            this.radPink.Size = new System.Drawing.Size(107, 36);
            this.radPink.TabIndex = 3;
            this.radPink.TabStop = true;
            this.radPink.Text = "Hồng";
            this.radPink.UseVisualStyleBackColor = true;
            // 
            // radViolet
            // 
            this.radViolet.AutoSize = true;
            this.radViolet.Location = new System.Drawing.Point(28, 408);
            this.radViolet.Name = "radViolet";
            this.radViolet.Size = new System.Drawing.Size(86, 36);
            this.radViolet.TabIndex = 4;
            this.radViolet.TabStop = true;
            this.radViolet.Text = "Tím";
            this.radViolet.UseVisualStyleBackColor = true;
            // 
            // ckbNgheNhac
            // 
            this.ckbNgheNhac.AutoSize = true;
            this.ckbNgheNhac.Location = new System.Drawing.Point(43, 100);
            this.ckbNgheNhac.Name = "ckbNgheNhac";
            this.ckbNgheNhac.Size = new System.Drawing.Size(177, 36);
            this.ckbNgheNhac.TabIndex = 0;
            this.ckbNgheNhac.Text = "Nghe nhạc";
            this.ckbNgheNhac.UseVisualStyleBackColor = true;
            this.ckbNgheNhac.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbXemPhim
            // 
            this.ckbXemPhim.AutoSize = true;
            this.ckbXemPhim.Location = new System.Drawing.Point(43, 174);
            this.ckbXemPhim.Name = "ckbXemPhim";
            this.ckbXemPhim.Size = new System.Drawing.Size(167, 36);
            this.ckbXemPhim.TabIndex = 1;
            this.ckbXemPhim.Text = "Xem phim";
            this.ckbXemPhim.UseVisualStyleBackColor = true;
            this.ckbXemPhim.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // ckbChoiTheThao
            // 
            this.ckbChoiTheThao.AutoSize = true;
            this.ckbChoiTheThao.Location = new System.Drawing.Point(43, 258);
            this.ckbChoiTheThao.Name = "ckbChoiTheThao";
            this.ckbChoiTheThao.Size = new System.Drawing.Size(209, 36);
            this.ckbChoiTheThao.TabIndex = 2;
            this.ckbChoiTheThao.Text = "Chơi thể thao";
            this.ckbChoiTheThao.UseVisualStyleBackColor = true;
            this.ckbChoiTheThao.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ckbDiMuaSam
            // 
            this.ckbDiMuaSam.AutoSize = true;
            this.ckbDiMuaSam.Location = new System.Drawing.Point(43, 328);
            this.ckbDiMuaSam.Name = "ckbDiMuaSam";
            this.ckbDiMuaSam.Size = new System.Drawing.Size(189, 36);
            this.ckbDiMuaSam.TabIndex = 3;
            this.ckbDiMuaSam.Text = "Đi mua sắm";
            this.ckbDiMuaSam.UseVisualStyleBackColor = true;
            this.ckbDiMuaSam.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ckbDiDuLich
            // 
            this.ckbDiDuLich.AutoSize = true;
            this.ckbDiDuLich.Location = new System.Drawing.Point(43, 408);
            this.ckbDiDuLich.Name = "ckbDiDuLich";
            this.ckbDiDuLich.Size = new System.Drawing.Size(157, 36);
            this.ckbDiDuLich.TabIndex = 4;
            this.ckbDiDuLich.Text = "Đi du lịch";
            this.ckbDiDuLich.UseVisualStyleBackColor = true;
            this.ckbDiDuLich.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 100);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 100);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(321, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 100);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(419, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 100);
            this.label4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(51, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 18);
            this.label5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(135, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 18);
            this.label6.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(51, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 18);
            this.label7.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(135, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 18);
            this.label8.TabIndex = 5;
            // 
            // FormFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 666);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormFavorite";
            this.Text = "Favorites";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbFavorite.ResumeLayout(false);
            this.gbFavorite.PerformLayout();
            this.gbFavoriteColor.ResumeLayout(false);
            this.gbFavoriteColor.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbFavorite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbFavoriteColor;
        private System.Windows.Forms.Button btnFavoriteColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radViolet;
        private System.Windows.Forms.RadioButton radPink;
        private System.Windows.Forms.RadioButton radYellow;
        private System.Windows.Forms.RadioButton radWhite;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox ckbDiDuLich;
        private System.Windows.Forms.CheckBox ckbDiMuaSam;
        private System.Windows.Forms.CheckBox ckbChoiTheThao;
        private System.Windows.Forms.CheckBox ckbXemPhim;
        private System.Windows.Forms.CheckBox ckbNgheNhac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

