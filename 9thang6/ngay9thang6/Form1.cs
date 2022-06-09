using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ngay9thang6
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            pnMain.Controls.Clear();
            for(int i = 0; i < Int32.Parse(txtInput.Text); i++)
            {
                Button btnRuntime = new Button();
                btnRuntime.BackColor = Color.Green;
                btnRuntime.Location = new System.Drawing.Point(
                    pnMain.Width / 2 - btnRuntime.Width / 2 ,
                    i * btnRuntime.Height
                );
                btnRuntime.AutoSize = false;
                btnRuntime.Text = $"button {i}";
                btnRuntime.Tag = i;
                btnRuntime.Click += btnRuntime_click;
                pnMain.Controls.Add(btnRuntime);
            }
        }

        private void lblShow_Click(object sender, EventArgs e)
        {

        }

        private void btnRuntime_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblShow.Text = $"Button : {btn.Text} was clicked";
        }
    }
}
