using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16thang6_1h40
{
    public partial class FormQuanLyDiem : Form
    {
        public FormQuanLyDiem()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        void message(string a , string b , string e = "loi")
        {
            if (e == "loi")
             MessageBox.Show(
                $"{a}",
                $"Thong bao {b}",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Error
            );
            else
            MessageBox.Show(
                $"{a}",
                $"Thong bao {b}",
                MessageBoxButtons.OK,
                 MessageBoxIcon.Information
            );
        }
        private void btnDiemTB_Click(object sender, EventArgs e)
        {
            if (validateTxtString())
            {
                message("Vui long nhap day du Diem" , "Loi");
            }
            else
            {
                float TB = diemTB();
                if(TB < 0)
                {
                    message("Ban da nhap sai . Vui long nhap lai", "Loi");
                }
                else
                {
                    message($"Diem Trung Binh la : {TB} \nXep loai : {xepLoai(TB)}", "Ket Qua" , "info");
                }
            }
        }

        bool validateTxtNumber(float value)
        {
            bool err = false;
            if (value > 10 || value < 0)
                err = true;
            return err;
        }

        bool validateTxtString()
        {
            bool err = false;
            if (txtC.Text == "" || txtCS.Text == ""|| txtCTDL.Text == "" || txtCSDL.Text == "")
                err = true;
            return err;
        }

        float diemTB()
        {
            float C = int.Parse(txtC.Text);

            float CTDL = int.Parse(txtCTDL.Text);

            float CS = int.Parse(txtCS.Text);

            float CSDL = int.Parse(txtCSDL.Text);

            if (validateTxtNumber(C) || validateTxtNumber(CTDL) || validateTxtNumber(CS) || validateTxtNumber(CSDL))
            {

                return -100;
            }
            else
            {
                return (C*3 + CTDL*3 + CS*4 + CSDL*3) / 13;
            }

        }

        private void btnDiemChu_Click(object sender, EventArgs e)
        {
            if (validateTxtString())
            {
                message($"Vui long nhap day du Diem", "Loi");
            }
            else
            {
                float TB = diemTB();
                string diem = "Khong ro";
                if (TB < 0)
                {
                    message($"Ban da nhap sai . Vui long nhap lai", "Loi");
                }
                else
                {
                    diem = diemChu(TB);
                    message($"Diem chu la : {diem} \nXep loai : {xepLoai(TB)}", "Ket Qua","info");
                }
            }
        }

        string diemChu(float TB)
        {
            string diem = "";
            if (TB >= 8) diem = "A";
            else if (TB >= 6.5) diem = "B";
            else if (TB >= 5) diem = "C";
            else if (TB >= 3.5) diem = "D";
            else diem = "E";
            return diem;
        }

        string xepLoai(float TB)
        {
            string diem = "";
            if (TB >= 8) diem = "Gioi";
            else if (TB >= 6.5) diem = "Kha";
            else if (TB >= 5) diem = "TB";
            else if (TB >= 3.5) diem = "Yeu";
            else diem = "Kem";
            return diem;
        }

        bool validateThongTinSv()
        {
            bool err = false;
            if(txtMaSv.Text != "")
            {
                if (txtHoTen.Text != "")
                {
                    if (txtNamSinh.Text != "")
                    {
                        if(txtLop.Text != "")
                        {
                            err = true;
                        }
                    }
                }
            }
            return err;
        }
        bool validateNamSinh()
        {
            bool err = false;
            if (int.Parse(txtNamSinh.Text) <= 2003 && int.Parse(txtNamSinh.Text) >= 2000)
            {
                err = true;
            }
            return err;
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (validateThongTinSv())
            {
                if (validateNamSinh())
                {
                    panelDiemThi.Visible = true;
                    panelButton.Visible = true;
                }
                else
                {
                    message($"Ban da nhap sai Nam Sinh . Vui long nhap lai", "Loi");
                }
            }
            else
            {
                message($"Vui long nhap day du Thong Tin SV", "Loi");
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình ? ",
                "Thong bao",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes) Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            message(
                $"Thong Tin SV : {txtHoTen.Text} \r\n\r\n\r\n" +
                $"Ma Sinh Vien : {txtMaSv.Text} \r\n" +
                $"Ho Ten : {txtHoTen.Text} \r\n" +
                $"Lop : {txtLop.Text} \r\n" +
                $"Nam Sinh : {txtNamSinh.Text} \r\n" +
                $"Diem Trung Binh : {diemTB()}\r\n" +
                $"Diem chu : {diemChu(diemTB())} \r\n" +
                $"Xep Loai : {xepLoai(diemTB())} \r\n" ,
                "SV" ,
                "info"
            );
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avatar_Click(object sender, EventArgs e)
        {
            string filepath = null;
            OpenFileDialog ofdImages = new OpenFileDialog();
            if (ofdImages.ShowDialog() == DialogResult.OK)
            {
                filepath = ofdImages.FileName;
            }

            pictureAvatar.Image = Image.FromFile(filepath.ToString());
            pictureAvatar.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureAvatar_Click(object sender, EventArgs e)
        {

        }
    }
}
