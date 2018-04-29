﻿using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBilliard.GUI
{
    public partial class temp : Form
    {
        public temp()
        {
            InitializeComponent();
        }

       
        private void temp_Load(object sender, EventArgs e)
        {
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Appearance.Image = Properties.Resources.on;
            
        }
        private Bitmap MyImage;
        public void ShowMyImage(string fileToDisplay, int xSize, int ySize)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = (Image)MyImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button1_Click");
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("simpleButton1_Click");
        }

        private void simpleButton1_DoubleClick(object sender, EventArgs e)
        {
            Console.WriteLine("simpleButton1_DoubleClick");
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
