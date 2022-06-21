namespace _16thang6_1h40
{
    partial class FormQuanLyDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLyDiem));
            this.label = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaSv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDiemThi = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCSDL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtCTDL = new System.Windows.Forms.TextBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnDiemChu = new System.Windows.Forms.Button();
            this.btnDiemTB = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnInThongTin = new System.Windows.Forms.Button();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.Avatar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelDiemThi.SuspendLayout();
            this.panelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label.Dock = System.Windows.Forms.DockStyle.Top;
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1082, 56);
            this.label.TabIndex = 0;
            this.label.Text = "Quan Ly Diem";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Avatar);
            this.splitContainer1.Panel1.Controls.Add(this.pictureAvatar);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.txtLop);
            this.splitContainer1.Panel1.Controls.Add(this.txtNamSinh);
            this.splitContainer1.Panel1.Controls.Add(this.txtHoTen);
            this.splitContainer1.Panel1.Controls.Add(this.txtMaSv);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelDiemThi);
            this.splitContainer1.Panel2.Controls.Add(this.panelButton);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Size = new System.Drawing.Size(1082, 547);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnNhapDiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 54);
            this.panel1.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Location = new System.Drawing.Point(194, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(203, 54);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Thoat";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhapDiem.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNhapDiem.Location = new System.Drawing.Point(0, 0);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(189, 54);
            this.btnNhapDiem.TabIndex = 9;
            this.btnNhapDiem.Text = "Nhap Diem";
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // txtLop
            // 
            this.txtLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLop.Location = new System.Drawing.Point(123, 267);
            this.txtLop.Multiline = true;
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(181, 26);
            this.txtLop.TabIndex = 8;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamSinh.Location = new System.Drawing.Point(123, 204);
            this.txtNamSinh.Multiline = true;
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(181, 26);
            this.txtNamSinh.TabIndex = 7;
            this.txtNamSinh.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(123, 132);
            this.txtHoTen.Multiline = true;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(181, 26);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMaSv
            // 
            this.txtMaSv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSv.Location = new System.Drawing.Point(123, 61);
            this.txtMaSv.Multiline = true;
            this.txtMaSv.Name = "txtMaSv";
            this.txtMaSv.Size = new System.Drawing.Size(181, 26);
            this.txtMaSv.TabIndex = 5;
            this.txtMaSv.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Lop";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nam Sinh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ho Ten";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ma SV";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thong Tin Sinh Vien";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDiemThi
            // 
            this.panelDiemThi.Controls.Add(this.label11);
            this.panelDiemThi.Controls.Add(this.txtCSDL);
            this.panelDiemThi.Controls.Add(this.label8);
            this.panelDiemThi.Controls.Add(this.label10);
            this.panelDiemThi.Controls.Add(this.txtCS);
            this.panelDiemThi.Controls.Add(this.label9);
            this.panelDiemThi.Controls.Add(this.txtC);
            this.panelDiemThi.Controls.Add(this.txtCTDL);
            this.panelDiemThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiemThi.Location = new System.Drawing.Point(0, 50);
            this.panelDiemThi.Name = "panelDiemThi";
            this.panelDiemThi.Size = new System.Drawing.Size(682, 443);
            this.panelDiemThi.TabIndex = 14;
            this.panelDiemThi.Visible = false;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(49, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 39);
            this.label11.TabIndex = 5;
            this.label11.Text = "Lap Trinh C";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCSDL
            // 
            this.txtCSDL.Location = new System.Drawing.Point(249, 251);
            this.txtCSDL.Multiline = true;
            this.txtCSDL.Name = "txtCSDL";
            this.txtCSDL.Size = new System.Drawing.Size(181, 40);
            this.txtCSDL.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(49, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "CSDL";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(49, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 39);
            this.label10.TabIndex = 6;
            this.label10.Text = "CTDL va GT";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCS
            // 
            this.txtCS.Location = new System.Drawing.Point(249, 188);
            this.txtCS.Multiline = true;
            this.txtCS.Name = "txtCS";
            this.txtCS.Size = new System.Drawing.Size(181, 40);
            this.txtCS.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(49, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 39);
            this.label9.TabIndex = 7;
            this.label9.Text = "Lap Trinh C#";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(249, 45);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(181, 40);
            this.txtC.TabIndex = 9;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtCTDL
            // 
            this.txtCTDL.Location = new System.Drawing.Point(249, 116);
            this.txtCTDL.Multiline = true;
            this.txtCTDL.Name = "txtCTDL";
            this.txtCTDL.Size = new System.Drawing.Size(181, 40);
            this.txtCTDL.TabIndex = 10;
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnDiemChu);
            this.panelButton.Controls.Add(this.btnInThongTin);
            this.panelButton.Controls.Add(this.btnDiemTB);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 493);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(682, 54);
            this.panelButton.TabIndex = 13;
            this.panelButton.Visible = false;
            // 
            // btnDiemChu
            // 
            this.btnDiemChu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDiemChu.Location = new System.Drawing.Point(179, 0);
            this.btnDiemChu.Name = "btnDiemChu";
            this.btnDiemChu.Size = new System.Drawing.Size(291, 54);
            this.btnDiemChu.TabIndex = 2;
            this.btnDiemChu.Text = "Diem Chu";
            this.btnDiemChu.UseVisualStyleBackColor = true;
            this.btnDiemChu.Click += new System.EventHandler(this.btnDiemChu_Click);
            // 
            // btnDiemTB
            // 
            this.btnDiemTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiemTB.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDiemTB.Location = new System.Drawing.Point(0, 0);
            this.btnDiemTB.Name = "btnDiemTB";
            this.btnDiemTB.Size = new System.Drawing.Size(179, 54);
            this.btnDiemTB.TabIndex = 0;
            this.btnDiemTB.Text = "Diem TB";
            this.btnDiemTB.UseVisualStyleBackColor = true;
            this.btnDiemTB.Click += new System.EventHandler(this.btnDiemTB_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(682, 50);
            this.label7.TabIndex = 0;
            this.label7.Text = "Diem Thi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInThongTin
            // 
            this.btnInThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInThongTin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInThongTin.Location = new System.Drawing.Point(470, 0);
            this.btnInThongTin.Name = "btnInThongTin";
            this.btnInThongTin.Size = new System.Drawing.Size(212, 54);
            this.btnInThongTin.TabIndex = 1;
            this.btnInThongTin.Text = "In Thong Tin";
            this.btnInThongTin.UseVisualStyleBackColor = true;
            this.btnInThongTin.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureAvatar.InitialImage")));
            this.pictureAvatar.Location = new System.Drawing.Point(119, 316);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(184, 68);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAvatar.TabIndex = 15;
            this.pictureAvatar.TabStop = false;
            this.pictureAvatar.Click += new System.EventHandler(this.pictureAvatar_Click);
            // 
            // Avatar
            // 
            this.Avatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avatar.Location = new System.Drawing.Point(3, 332);
            this.Avatar.Name = "Avatar";
            this.Avatar.Size = new System.Drawing.Size(116, 39);
            this.Avatar.TabIndex = 16;
            this.Avatar.Text = "Avatar";
            this.Avatar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Avatar.Click += new System.EventHandler(this.Avatar_Click);
            // 
            // FormQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormQuanLyDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan Ly Diem";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelDiemThi.ResumeLayout(false);
            this.panelDiemThi.PerformLayout();
            this.panelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaSv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCSDL;
        private System.Windows.Forms.TextBox txtCS;
        private System.Windows.Forms.TextBox txtCTDL;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnDiemChu;
        private System.Windows.Forms.Button btnDiemTB;
        private System.Windows.Forms.Panel panelDiemThi;
        private System.Windows.Forms.Button btnNhapDiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInThongTin;
        private System.Windows.Forms.Label Avatar;
        public System.Windows.Forms.PictureBox pictureAvatar;
    }
}

