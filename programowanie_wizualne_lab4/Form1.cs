using System;
using System.Drawing;
using System.Windows.Forms;

namespace programowanie_wizualne_lab4
{
    public partial class Form1 : Form
    {
        private Bitmap currentImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*.bmp)|*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                currentImage = new Bitmap(ofd.FileName);
                pictureBox1.Image = currentImage;
            }
        }
    }
}
