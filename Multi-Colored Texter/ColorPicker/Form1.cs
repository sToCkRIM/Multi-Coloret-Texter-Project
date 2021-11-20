using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = (Bitmap)colorwheel.Image;
                Color clr = bmp.GetPixel(e.X, e.Y);
                lbHex.Text = clr.Name;
                lbR.Text = clr.R.ToString();
                lbG.Text = clr.G.ToString();
                lbB.Text = clr.B.ToString();
                selector.BackColor = clr;
            }
            catch
            {

            }
        }

        private void colorbox_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = (Bitmap)colorbox.Image;
                Color clr = bmp.GetPixel(e.X, e.Y);
                lbHex.Text = clr.Name;
                lbR.Text = clr.R.ToString();
                lbG.Text = clr.G.ToString();
                lbB.Text = clr.B.ToString();
                selector.BackColor = clr;
            }
            catch
            {

            }
      
        }
    }
}
