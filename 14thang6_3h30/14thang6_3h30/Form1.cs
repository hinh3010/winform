using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14thang6_3h30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String ketQua = "";

            if (ckbChuVi.Checked)
            {
                double CV = 0;

                if (radHinhTron.Checked)
                {
                    float R = float.Parse(txtR.Text);
                    CV = R * 2 * Math.PI;
                }
                if (radTamGiac.Checked)
                {
                    float A = float.Parse(txtA.Text);
                    float B = float.Parse(txtB.Text);
                    float C = float.Parse(txtC.Text);
                    float P = (A + B + C) / 2;
                    if (Math.Sqrt(P * (P - A) * (P - B) * (P - C)) <= 0) CV = -1;
                    else CV = A + B + C;
                }
                if (radHinhChuNhat.Checked)
                {
                    float A = float.Parse(txtA.Text);
                    float B = float.Parse(txtB.Text);
                    CV = (A + B) * 2;
                }

                if (CV <= 0) ketQua += $"\nDay khong phai hinh tam giac ";
                else ketQua += $"Chu vi = {CV}";
            }

            if (ckbDienTich.Checked)
            {
                double DT = 0;
                if (radHinhTron.Checked)
                {
                    float R = float.Parse(txtR.Text);
                    DT = Math.PI * R * R;
                }
                if (radTamGiac.Checked)
                {
                    float A = float.Parse(txtA.Text);
                    float B = float.Parse(txtB.Text);
                    float C = float.Parse(txtC.Text);
                    float P = (A + B + C) / 2;
                    if(Math.Sqrt(P * (P - A) * (P - B) * (P - C)) <= 0) DT = -1;
                    else DT = Math.Sqrt(P * (P-A) * (P - B) * (P - C));
                }
                if (radHinhChuNhat.Checked)
                {
                    float A = float.Parse(txtA.Text);
                    float B = float.Parse(txtB.Text);
                    DT = A * B;
                }

                if (DT <= 0) ketQua += $"\nDay khong phai hinh tam giac ";
                else ketQua += $"\nDien tich = {DT}";
            }

            MessageBox.Show(
                $"{ketQua}",
                "Ket qua",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ckbChuVi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbChuVi.Checked || ckbDienTich.Checked) btnCount.Visible = true;
            else  btnCount.Visible = false;

            //double CV;
            //if (radHinhTron.Checked)
            //{
            //    float R = float.Parse(txtR.Text) ; 
            //    CV = R * 2 * Math.PI ;
            //}
            //if (radTamGiac.Checked)
            //{
            //    float A = float.Parse(txtA.Text);
            //    float B = float.Parse(txtB.Text);
            //    float C = float.Parse(txtC.Text);
            //    CV = A + B + C ;
            //}
            //if (radHinhChuNhat.Checked)
            //{
            //    float A = float.Parse(txtA.Text);
            //    float B = float.Parse(txtB.Text);
            //    CV = ( A + B ) * 2;
            //}
        }

        private void ckbDienTich_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbChuVi.Checked || ckbDienTich.Checked) btnCount.Visible = true;
            else  btnCount.Visible = false;

            //double DT;
            //if (radHinhTron.Checked)
            //{
            //    float R = float.Parse(txtR.Text);
            //    DT = Math.PI * R * R;
            //}
            //if (radTamGiac.Checked)
            //{
            //    float A = float.Parse(txtA.Text);
            //    float B = float.Parse(txtB.Text);
            //    float C = float.Parse(txtC.Text);
            //    DT = A + B + C;
            //}
            //if (radHinhChuNhat.Checked)
            //{
            //    float A = float.Parse(txtA.Text);
            //    float B = float.Parse(txtB.Text);
            //    DT = A * B;
            //}
        }

        private void radTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            if (radTamGiac.Checked)
            {
                labelA.Visible = true;
                labelB.Visible = true;
                labelC.Visible = true;
                txtA.Visible = true;
                txtB.Visible = true;
                txtC.Visible = true;
            }
            else visibleFalse();
        }

        void visibleFalse()
        {
            labelA.Visible = false;
            labelB.Visible = false;
            labelC.Visible = false;
            labelR.Visible = false;
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
            txtR.Visible = false;
        }

        private void radHinhTron_CheckedChanged(object sender, EventArgs e)
        {
            if (radHinhTron.Checked)
            {
                labelR.Visible = true;
                txtR.Visible = true;
            }
            else visibleFalse();
        }

        private void radHinhChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            if (radHinhChuNhat.Checked)
            {
                labelA.Visible = true;
                labelB.Visible = true;
                txtA.Visible = true;
                txtB.Visible = true;
            }
            else visibleFalse();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtR.Text = "";
        }
    }
}
