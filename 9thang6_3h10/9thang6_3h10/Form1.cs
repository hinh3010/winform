using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9thang6_3h10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if
            (
                txtName.Text == "" || txtName.Text == "" ||
                txtFirtsNum.Text == "" || txtLastNum.Text == "" ||
                 txtMonth.Text == ""
            )
            {
                DialogResult result = MessageBox.Show(
                    "Vui Lòng nhập đầy đủ thông tin khách hàng ! ",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                string name = txtName.Text;
                string address = txtName.Text;
                string month = txtMonth.Text;

                int firtsNum = int.Parse(txtFirtsNum.Text);
                int lastNum = int.Parse(txtLastNum.Text);

                if (firtsNum < 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Số công tơ điện phải lớn hơn 0 ! Nhập lại : ",
                        "Thong bao",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
                else
                {

                    if (lastNum < firtsNum)
                    {
                        DialogResult result = MessageBox.Show(
                            "Số công tơ điện tháng này phải lớn hơn tháng trước ! Nhập lại ",
                            "Thong bao",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    else
                    {
                        int soDien = lastNum - firtsNum;
                        int donGia = 1200;
                        if (soDien >= 100) donGia = 2000;

                        txtOutput.Text = $"Ho ten : {name} \r\n \r\n" +
                            $"Dia chi : {address} \r\n \r\n" +
                            $"Thang : {month} \r\n \r\n" +
                            $"Tien dien : {soDien * donGia} đ";

                        //MessageBox.Show(
                        //    $"Ho ten : {name} \r\n \r\n" +
                        //    $"Dia chi : {address} \r\n \r\n" +
                        //    $"Thang : {month} \r\n \r\n" +
                        //    $"Tien dien : {soDien * donGia} đ",
                        //    "Thong bao",
                        //    MessageBoxButtons.OK,
                        //    MessageBoxIcon.Information
                        //);
                    }
                }
            }
        }

    }
}
