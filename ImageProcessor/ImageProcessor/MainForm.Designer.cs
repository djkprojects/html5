namespace ImageProcessor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGamma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSmoothEffect = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuassianBlur = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmboss = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSharpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeanRemoval = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuInvert = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGreyscale = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColorFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.image = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.mnuSepia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDecreaseColorDepth = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuGamma});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuGamma
            // 
            this.mnuGamma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSmoothEffect,
            this.mnuGuassianBlur,
            this.mnuEmboss,
            this.mnuSharpen,
            this.mnuMeanRemoval,
            this.toolStripMenuItem2,
            this.mnuInvert,
            this.mnuGreyscale,
            this.mnuBrightness,
            this.mnuContrast,
            this.mnuColorFilter,
            this.gammaToolStripMenuItem,
            this.mnuSepia,
            this.mnuDecreaseColorDepth});
            this.mnuGamma.Name = "mnuGamma";
            this.mnuGamma.Size = new System.Drawing.Size(49, 20);
            this.mnuGamma.Text = "&Effect";
            // 
            // mnuSmoothEffect
            // 
            this.mnuSmoothEffect.Name = "mnuSmoothEffect";
            this.mnuSmoothEffect.Size = new System.Drawing.Size(195, 22);
            this.mnuSmoothEffect.Text = "&Smooth";
            this.mnuSmoothEffect.Click += new System.EventHandler(this.mnuSmoothEffect_Click);
            // 
            // mnuGuassianBlur
            // 
            this.mnuGuassianBlur.Name = "mnuGuassianBlur";
            this.mnuGuassianBlur.Size = new System.Drawing.Size(195, 22);
            this.mnuGuassianBlur.Text = "&Guassian Blur";
            this.mnuGuassianBlur.Click += new System.EventHandler(this.mnuGuassianBlur_Click);
            // 
            // mnuEmboss
            // 
            this.mnuEmboss.Name = "mnuEmboss";
            this.mnuEmboss.Size = new System.Drawing.Size(195, 22);
            this.mnuEmboss.Text = "&Emboss";
            this.mnuEmboss.Click += new System.EventHandler(this.mnuEmboss_Click);
            // 
            // mnuSharpen
            // 
            this.mnuSharpen.Name = "mnuSharpen";
            this.mnuSharpen.Size = new System.Drawing.Size(195, 22);
            this.mnuSharpen.Text = "&Sharpen";
            this.mnuSharpen.Click += new System.EventHandler(this.mnuSharpen_Click);
            // 
            // mnuMeanRemoval
            // 
            this.mnuMeanRemoval.Name = "mnuMeanRemoval";
            this.mnuMeanRemoval.Size = new System.Drawing.Size(195, 22);
            this.mnuMeanRemoval.Text = "&Mean Removal";
            this.mnuMeanRemoval.Click += new System.EventHandler(this.mnuMeanRemoval_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
            // 
            // mnuInvert
            // 
            this.mnuInvert.Name = "mnuInvert";
            this.mnuInvert.Size = new System.Drawing.Size(195, 22);
            this.mnuInvert.Text = "&Invert";
            this.mnuInvert.Click += new System.EventHandler(this.mnuInvert_Click);
            // 
            // mnuGreyscale
            // 
            this.mnuGreyscale.Name = "mnuGreyscale";
            this.mnuGreyscale.Size = new System.Drawing.Size(195, 22);
            this.mnuGreyscale.Text = "&Greyscale";
            this.mnuGreyscale.Click += new System.EventHandler(this.mnuGreyscale_Click);
            // 
            // mnuBrightness
            // 
            this.mnuBrightness.Name = "mnuBrightness";
            this.mnuBrightness.Size = new System.Drawing.Size(195, 22);
            this.mnuBrightness.Text = "&Brightness";
            this.mnuBrightness.Click += new System.EventHandler(this.mnuBrightness_Click);
            // 
            // mnuContrast
            // 
            this.mnuContrast.Name = "mnuContrast";
            this.mnuContrast.Size = new System.Drawing.Size(195, 22);
            this.mnuContrast.Text = "&Contrast";
            this.mnuContrast.Click += new System.EventHandler(this.mnuContrast_Click);
            // 
            // mnuColorFilter
            // 
            this.mnuColorFilter.Name = "mnuColorFilter";
            this.mnuColorFilter.Size = new System.Drawing.Size(195, 22);
            this.mnuColorFilter.Text = "Color &Filter";
            this.mnuColorFilter.Click += new System.EventHandler(this.mnuColorFilter_Click);
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gammaToolStripMenuItem.Text = "&Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.Black;
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 24);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(531, 355);
            this.image.TabIndex = 1;
            this.image.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All files|*.*";
            // 
            // mnuSepia
            // 
            this.mnuSepia.Name = "mnuSepia";
            this.mnuSepia.Size = new System.Drawing.Size(195, 22);
            this.mnuSepia.Text = "&Sepia";
            this.mnuSepia.Click += new System.EventHandler(this.mnuSepia_Click);
            // 
            // mnuDecreaseColorDepth
            // 
            this.mnuDecreaseColorDepth.Name = "mnuDecreaseColorDepth";
            this.mnuDecreaseColorDepth.Size = new System.Drawing.Size(195, 22);
            this.mnuDecreaseColorDepth.Text = "&Decrease Colour Depth";
            this.mnuDecreaseColorDepth.Click += new System.EventHandler(this.mnuDecreaseColorDepth_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 379);
            this.Controls.Add(this.image);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Image Processor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGamma;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuSmoothEffect;
        private System.Windows.Forms.ToolStripMenuItem mnuGuassianBlur;
        private System.Windows.Forms.ToolStripMenuItem mnuEmboss;
        private System.Windows.Forms.ToolStripMenuItem mnuSharpen;
        private System.Windows.Forms.ToolStripMenuItem mnuMeanRemoval;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuInvert;
        private System.Windows.Forms.ToolStripMenuItem mnuGreyscale;
        private System.Windows.Forms.ToolStripMenuItem mnuBrightness;
        private System.Windows.Forms.ToolStripMenuItem mnuContrast;
        private System.Windows.Forms.ToolStripMenuItem mnuColorFilter;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSepia;
        private System.Windows.Forms.ToolStripMenuItem mnuDecreaseColorDepth;
    }
}

