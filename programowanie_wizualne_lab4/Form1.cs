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

        private Bitmap RotateImage(Bitmap source, float angle)
        {
            if (source == null)
                return null;

            Bitmap rotated = new Bitmap(source.Width, source.Height);

            using (Graphics g = Graphics.FromImage(rotated))
            {
                g.Clear(Color.White);
                g.TranslateTransform(source.Width / 2f, source.Height / 2f);
                g.RotateTransform(angle);
                g.TranslateTransform(-source.Width / 2f, -source.Height / 2f);
                g.DrawImage(source, new Point(0, 0));
            }

            return rotated;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
                return;
            }

            float angle = 90;

            if (rb90.Checked) angle = 90;
            else if (rb180.Checked) angle = 180;
            else if (rb270.Checked) angle = 270;

            currentImage = RotateImage(currentImage, angle);
            pictureBox1.Image = currentImage;
        }
    }
}
