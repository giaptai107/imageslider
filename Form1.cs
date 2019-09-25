using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgSliderOfficial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int img = 0;
        private void LoadNextImage()
        {
            if (img >= 10) img = 1;
            if (img < 0) img = 10;
            img++;
             
            mainPic.ImageLocation = string.Format(@"Image\{0}.jpg", img);
            pic1.ImageLocation = string.Format(@"Image\{0}.jpg", img - 1);
            pic2.ImageLocation = string.Format(@"Image\{0}.jpg", img);
            pic3.ImageLocation = string.Format(@"Image\{0}.jpg", img + 1);
        }

        private void MainPic_Click(object sender, EventArgs e)
        {

        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            img = img - 2;
            LoadNextImage();
            timer1.Stop();
            timer1.Start();
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void Pic3_Click(object sender, EventArgs e)
        {
            LoadNextImage();
            timer1.Stop();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void Pre_Click(object sender, EventArgs e)
        {
            if (img == 1) img = 13;
            img = img - 2;
            LoadNextImage();
            timer1.Stop();
            timer1.Start();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            LoadNextImage();
            timer1.Stop();
            timer1.Start();
        }
    }
}
