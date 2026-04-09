namespace programowanie_wizualne_lab4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            btnLoad = new Button();
            btnRotate = new Button();
            btnInvert = new Button();
            btnUpsideDown = new Button();
            btnOnlyGreen = new Button();
            rb90 = new RadioButton();
            rb180 = new RadioButton();
            rb270 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(167, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(34, 283);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(112, 34);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Załaduj";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(178, 283);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(112, 34);
            btnRotate.TabIndex = 2;
            btnRotate.Text = "Obróć";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnInvert
            // 
            btnInvert.Location = new Point(330, 283);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(112, 34);
            btnInvert.TabIndex = 3;
            btnInvert.Text = "Negatyw";
            btnInvert.UseVisualStyleBackColor = true;
            // 
            // btnUpsideDown
            // 
            btnUpsideDown.Location = new Point(465, 283);
            btnUpsideDown.Name = "btnUpsideDown";
            btnUpsideDown.Size = new Size(157, 34);
            btnUpsideDown.TabIndex = 4;
            btnUpsideDown.Text = "Do góry nogami";
            btnUpsideDown.UseVisualStyleBackColor = true;
            // 
            // btnOnlyGreen
            // 
            btnOnlyGreen.Location = new Point(644, 283);
            btnOnlyGreen.Name = "btnOnlyGreen";
            btnOnlyGreen.Size = new Size(112, 34);
            btnOnlyGreen.TabIndex = 5;
            btnOnlyGreen.Text = "Zielony";
            btnOnlyGreen.UseVisualStyleBackColor = true;
            // 
            // rb90
            // 
            rb90.AutoSize = true;
            rb90.Checked = true;
            rb90.Location = new Point(96, 344);
            rb90.Name = "rb90";
            rb90.Size = new Size(57, 29);
            rb90.TabIndex = 6;
            rb90.TabStop = true;
            rb90.Text = "90";
            rb90.UseVisualStyleBackColor = true;
            // 
            // rb180
            // 
            rb180.AutoSize = true;
            rb180.Location = new Point(301, 344);
            rb180.Name = "rb180";
            rb180.Size = new Size(67, 29);
            rb180.TabIndex = 7;
            rb180.TabStop = true;
            rb180.Text = "180";
            rb180.UseVisualStyleBackColor = true;
            // 
            // rb270
            // 
            rb270.AutoSize = true;
            rb270.Location = new Point(499, 344);
            rb270.Name = "rb270";
            rb270.Size = new Size(67, 29);
            rb270.TabIndex = 8;
            rb270.Text = "270";
            rb270.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rb270);
            Controls.Add(rb180);
            Controls.Add(rb90);
            Controls.Add(btnOnlyGreen);
            Controls.Add(btnUpsideDown);
            Controls.Add(btnInvert);
            Controls.Add(btnRotate);
            Controls.Add(btnLoad);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnLoad;
        private Button btnRotate;
        private Button btnInvert;
        private Button btnUpsideDown;
        private Button btnOnlyGreen;
        private RadioButton rb90;
        private RadioButton rb180;
        private RadioButton rb270;
    }
}
