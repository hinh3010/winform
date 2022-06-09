using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7thang6
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //float tbCong = diemTb();
            //if (Convert.ToBoolean(tbCong))
            //{
                btnThongTin.Visible = true;
                btnDiemTb.Visible = true;
            //}
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnDiemTb_Click(object sender, EventArgs e)
        {
            // showText.Text = diemTb().ToString();

            float tbCong = diemTb();
            if (tbCong != -1)
            {
                showText.Text = diemTb().ToString();
            }
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            string HoTen = hoTen.Text;
            string MaSv = maSv.Text;
            float tbCong = diemTb();

            string xh = string.Empty;

            if (tbCong < 5) xh = "Kém";
            else if (tbCong < 7) xh = "Trung bình";
            else if (tbCong < 8) xh = "Khá";
            else if (tbCong <= 10) xh = "Giỏi";

            showText.Text = $"Sinh vien : {HoTen} có mã sv : {MaSv} xếp loại : {xh}";
        }
        float diemTb()
        {
            
            float diemA = float.Parse(diem1.Text);
            float diemB = float.Parse(diem2.Text);
            float diemC = float.Parse(diem3.Text);

            //return _diemTb;
            float _diemTb = -1 ;
            
            if (diemA < 0 || diemA > 10)
            {
                diem1.Text = "";
                return _diemTb;
            }
            if (diemB < 0 || diemB > 10)
            {
                diem2.Text = "";
                return _diemTb;
            }
            if (diemC < 0 || diemC > 10)
            {
                diem3.Text = "";
                return _diemTb;
            }
            if (diemA < 0 || diemA > 10 && diemB < 0 || diemB > 10 && diemC < 0 || diemC > 10)
            {
                _diemTb = (diemA + diemB + diemC) / 3;
            }
            return _diemTb;
        }

    }
}
