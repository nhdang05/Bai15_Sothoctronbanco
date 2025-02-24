using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15_Sothoctronbanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            int soO = Convert.ToInt32(txto.Text);

            double sothoc = 0;

            if (soO > 64)
            {
                MessageBox.Show("Bàn cờ chỉ có 64 ô vui lòng nhập số < 64", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            for (int i = 0; i < soO; i++)
            {
                sothoc += Math.Pow(2, i);
                listBox1.Items.Add($" Ô thứ " + (i + 1) + " có " + Math.Pow(2, i) + "thóc");
            }
            txtSothoc.Text = sothoc.ToString();

        }

        private void lstCacO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
       