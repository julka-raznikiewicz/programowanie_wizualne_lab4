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

        private Bitmap OnlyGreen(Bitmap source)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color c = source.GetPixel(x, y);

                    bool isGreen = c.G > 100 && c.G > c.R + 20 && c.G > c.B + 20;

                    if (isGreen)
                        result.SetPixel(x, y, c);
                    else
                        result.SetPixel(x, y, Color.Black);
                }
            }

            return result;
        }

        private void btnOnlyGreen_Click(object sender, EventArgs e)
        {
            if (currentImage == null)
            {
                MessageBox.Show("Najpierw wczytaj obraz.");
                return;
            }

            currentImage = OnlyGreen(currentImage);
            pictureBox1.Image = currentImage;
        }
    }
}
