namespace _14thang6_3h30
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxTinh = new System.Windows.Forms.GroupBox();
            this.ckbChuVi = new System.Windows.Forms.CheckBox();
            this.ckbDienTich = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.groupBoxHinh = new System.Windows.Forms.GroupBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.groupBoxNhap = new System.Windows.Forms.GroupBox();
            this.radTamGiac = new System.Windows.Forms.RadioButton();
            this.radHinhTron = new System.Windows.Forms.RadioButton();
            this.radHinhChuNhat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxTinh.SuspendLayout();
            this.groupBoxHinh.SuspendLayout();
            this.groupBoxNhap.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(963, 591);
            this.splitContainer1.SplitterDistance = 504;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxHinh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 305);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxNhap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 286);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxTinh);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 305);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCount);
            this.panel4.Controls.Add(this.btnRemove);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 305);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 286);
            this.panel4.TabIndex = 1;
            // 
            // groupBoxTinh
            // 
            this.groupBoxTinh.Controls.Add(this.ckbDienTich);
            this.groupBoxTinh.Controls.Add(this.ckbChuVi);
            this.groupBoxTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTinh.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTinh.Name = "groupBoxTinh";
            this.groupBoxTinh.Size = new System.Drawing.Size(455, 305);
            this.groupBoxTinh.TabIndex = 0;
            this.groupBoxTinh.TabStop = false;
            this.groupBoxTinh.Text = "Tính";
            // 
            // ckbChuVi
            // 
            this.ckbChuVi.AutoSize = true;
            this.ckbChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbChuVi.Location = new System.Drawing.Point(50, 78);
            this.ckbChuVi.Name = "ckbChuVi";
            this.ckbChuVi.Size = new System.Drawing.Size(158, 50);
            this.ckbChuVi.TabIndex = 0;
            this.ckbChuVi.Text = "Chu vi";
            this.ckbChuVi.UseVisualStyleBackColor = true;
            this.ckbChuVi.CheckedChanged += new System.EventHandler(this.ckbChuVi_CheckedChanged);
            // 
            // ckbDienTich
            // 
            this.ckbDienTich.AutoSize = true;
            this.ckbDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbDienTich.Location = new System.Drawing.Point(50, 198);
            this.ckbDienTich.Name = "ckbDienTich";
            this.ckbDienTich.Size = new System.Drawing.Size(202, 50);
            this.ckbDienTich.TabIndex = 1;
            this.ckbDienTich.Text = "Diện tích";
            this.ckbDienTich.UseVisualStyleBackColor = true;
            this.ckbDienTich.CheckedChanged += new System.EventHandler(this.ckbDienTich_CheckedChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(64, 113);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(142, 57);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCount
            // 
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCount.Location = new System.Drawing.Point(275, 113);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(142, 57);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Tính";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Visible = false;
            this.btnCount.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBoxHinh
            // 
            this.groupBoxHinh.Controls.Add(this.radHinhChuNhat);
            this.groupBoxHinh.Controls.Add(this.radHinhTron);
            this.groupBoxHinh.Controls.Add(this.radTamGiac);
            this.groupBoxHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxHinh.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHinh.Name = "groupBoxHinh";
            this.groupBoxHinh.Size = new System.Drawing.Size(504, 305);
            this.groupBoxHinh.TabIndex = 0;
            this.groupBoxHinh.TabStop = false;
            this.groupBoxHinh.Text = "Hình";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(40, 57);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(30, 29);
            this.labelR.TabIndex = 0;
            this.labelR.Text = "R";
            this.labelR.Visible = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(40, 112);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(28, 29);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "A";
            this.labelA.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(40, 174);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(29, 29);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "B";
            this.labelB.Visible = false;
            this.labelB.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(40, 234);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(30, 29);
            this.labelC.TabIndex = 3;
            this.labelC.Text = "C";
            this.labelC.Visible = false;
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(169, 54);
            this.txtR.Multiline = true;
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(239, 37);
            this.txtR.TabIndex = 4;
            this.txtR.Visible = false;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(169, 109);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(239, 37);
            this.txtA.TabIndex = 5;
            this.txtA.Visible = false;
            this.txtA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(169, 171);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(239, 37);
            this.txtB.TabIndex = 6;
            this.txtB.Visible = false;
            this.txtB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(169, 230);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(239, 37);
            this.txtC.TabIndex = 7;
            this.txtC.Visible = false;
            // 
            // groupBoxNhap
            // 
            this.groupBoxNhap.Controls.Add(this.txtR);
            this.groupBoxNhap.Controls.Add(this.labelC);
            this.groupBoxNhap.Controls.Add(this.txtA);
            this.groupBoxNhap.Controls.Add(this.labelB);
            this.groupBoxNhap.Controls.Add(this.txtC);
            this.groupBoxNhap.Controls.Add(this.txtB);
            this.groupBoxNhap.Controls.Add(this.labelA);
            this.groupBoxNhap.Controls.Add(this.labelR);
            this.groupBoxNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNhap.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNhap.Name = "groupBoxNhap";
            this.groupBoxNhap.Size = new System.Drawing.Size(504, 286);
            this.groupBoxNhap.TabIndex = 8;
            this.groupBoxNhap.TabStop = false;
            this.groupBoxNhap.Text = "Nhập Kích Thước";
            // 
            // radTamGiac
            // 
            this.radTamGiac.AutoSize = true;
            this.radTamGiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTamGiac.Location = new System.Drawing.Point(56, 61);
            this.radTamGiac.Name = "radTamGiac";
            this.radTamGiac.Size = new System.Drawing.Size(175, 41);
            this.radTamGiac.TabIndex = 0;
            this.radTamGiac.TabStop = true;
            this.radTamGiac.Text = "Tam giác";
            this.radTamGiac.UseVisualStyleBackColor = true;
            this.radTamGiac.CheckedChanged += new System.EventHandler(this.radTamGiac_CheckedChanged);
            // 
            // radHinhTron
            // 
            this.radHinhTron.AutoSize = true;
            this.radHinhTron.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHinhTron.Location = new System.Drawing.Point(56, 153);
            this.radHinhTron.Name = "radHinhTron";
            this.radHinhTron.Size = new System.Drawing.Size(173, 41);
            this.radHinhTron.TabIndex = 1;
            this.radHinhTron.TabStop = true;
            this.radHinhTron.Text = "Hình tròn";
            this.radHinhTron.UseVisualStyleBackColor = true;
            this.radHinhTron.CheckedChanged += new System.EventHandler(this.radHinhTron_CheckedChanged);
            // 
            // radHinhChuNhat
            // 
            this.radHinhChuNhat.AutoSize = true;
            this.radHinhChuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radHinhChuNhat.Location = new System.Drawing.Point(56, 239);
            this.radHinhChuNhat.Name = "radHinhChuNhat";
            this.radHinhChuNhat.Size = new System.Drawing.Size(241, 41);
            this.radHinhChuNhat.TabIndex = 2;
            this.radHinhChuNhat.TabStop = true;
            this.radHinhChuNhat.Text = "Hình chữ nhật";
            this.radHinhChuNhat.UseVisualStyleBackColor = true;
            this.radHinhChuNhat.CheckedChanged += new System.EventHandler(this.radHinhChuNhat_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 591);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.Text = "Tinh ChuVi DienTich";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBoxTinh.ResumeLayout(false);
            this.groupBoxTinh.PerformLayout();
            this.groupBoxHinh.ResumeLayout(false);
            this.groupBoxHinh.PerformLayout();
            this.groupBoxNhap.ResumeLayout(false);
            this.groupBoxNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.GroupBox groupBoxHinh;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBoxTinh;
        private System.Windows.Forms.CheckBox ckbDienTich;
        private System.Windows.Forms.CheckBox ckbChuVi;
        private System.Windows.Forms.GroupBox groupBoxNhap;
        private System.Windows.Forms.RadioButton radHinhChuNhat;
        private System.Windows.Forms.RadioButton radHinhTron;
        private System.Windows.Forms.RadioButton radTamGiac;
    }
}

