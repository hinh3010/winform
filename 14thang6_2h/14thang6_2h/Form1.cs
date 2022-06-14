using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14thang6_2h
{
    public partial class FormFavorite : Form
    {
        public FormFavorite()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFavorites_Click(object sender, EventArgs e)
        {
            String soThich = "";
            if (ckbNgheNhac.Checked == true) soThich += "\n - Nghe nhac";
            if (ckbChoiTheThao.Checked == true) soThich += "\n - Choi the thao";
            if (ckbDiDuLich.Checked == true) soThich += "\n - Di du lich";
            if (ckbXemPhim.Checked == true) soThich += "\n - Xem Phim";
            if (ckbDiMuaSam.Checked == true) soThich += "\n - Di mua sam";

            if (soThich == "")
                MessageBox.Show(
                    $"Ban cha co so thich gi ca :)",
                    "Ket qua",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            else MessageBox.Show(
                    $"So thich cua ban la : {soThich}",
                    "Ket qua",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnFavoriteColor_Click(object sender, EventArgs e)
        {
            String mauYeuThich = "";
            if (radRed.Checked == true) mauYeuThich = "\n - Do";
            if (radWhite.Checked == true) mauYeuThich = "\n - Trang";
            if (radYellow.Checked == true) mauYeuThich = "\n - Vang";
            if (radPink.Checked == true) mauYeuThich = "\n - Hong";
            if (radViolet.Checked == true) mauYeuThich = "\n - Tim";

            if (mauYeuThich == "")
                MessageBox.Show(
                    $"Ban khong co mau yeu thich",
                    "Ket qua",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            else MessageBox.Show(
                    $"Mau yeu thich cua ban la : {mauYeuThich}",
                    "Ket qua",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
        }
    }
}
