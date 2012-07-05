using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class MainForm : Form
    {
        public ImageProcessor imageProcessor = new ImageProcessor();

        public MainForm()
        {
            InitializeComponent();
        }

        private void openFile()
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                imageProcessor.SetImage(openFileDialog1.FileName);
                image.Image = imageProcessor.GetImage();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void mnuSmoothEffect_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplySmooth(5);
            image.Image = imageProcessor.GetImage();
        }

        private void mnuGuassianBlur_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyGaussianBlur(4);
            image.Image = imageProcessor.GetImage();

        }

        private void mnuEmboss_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyEmboss(4);
            image.Image = imageProcessor.GetImage();

        }

        private void mnuSharpen_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplySharpen(11);
            image.Image = imageProcessor.GetImage();

        }

        private void mnuMeanRemoval_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyMeanRemoval(9);
            image.Image = imageProcessor.GetImage();

        }

        private void mnuInvert_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyInvert();
            image.Image = imageProcessor.GetImage();
        }

        private void mnuGreyscale_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyGreyscale();
            image.Image = imageProcessor.GetImage();

        }

        private void mnuBrightness_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyBrightness(50);
            image.Image = imageProcessor.GetImage();

        }

        private void mnuContrast_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyContrast(50);
            image.Image = imageProcessor.GetImage();
        }

        private void mnuColorFilter_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyColorFilter(1, 0, 0);
            image.Image = imageProcessor.GetImage();

        }

        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyGamma(0.6, 0.6, 0.6);
            image.Image = imageProcessor.GetImage();
        }

        private void mnuSepia_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplySepia(20);
            image.Image = imageProcessor.GetImage();

        }

        private void mnuDecreaseColorDepth_Click(object sender, EventArgs e)
        {
            imageProcessor.ApplyDecreaseColourDepth(16);
            image.Image = imageProcessor.GetImage();

        }
    }
}
