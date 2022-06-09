using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9thang6_3h
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float diem = float.Parse(txtInput.Text);
            if(diem < 0 || diem >10)
            {
                DialogResult result = MessageBox.Show(
                    "Vui long nhap < 0 va > 10 ! Nhap lai .",
                    "Thong bao",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                /*if( result == DialogResult.Yes)
                {
                    txtInput.Text = "";
                };*/
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
