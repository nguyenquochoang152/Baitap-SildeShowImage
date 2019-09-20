using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SlideShowImage1
{
    public partial class Form1 : Form
    {
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        bool playing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            counter++;
            string[] images = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
            if (counter > images.Length - 1)
            {
                counter = 0;
            }

            pictureBox1.Image = Image.FromFile(images[counter]);
            pictureBox2.Image = Image.FromFile(images[counter]);
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = fbd.ShowDialog();
        }
    }
}
