using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse);
            
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        bool formTasiniyor = false;
        bool denet = false;
        bool coder = false;
        bool c1 = false;
        bool c2 = false;
        int ranger = 0;
        bool r1 = false;
        bool r2 = false;
        Point baslangicNoktasi = new Point(0, 0);
        string ur1, ug1, ub1, ur2, ug2, ub2, text, tbh1, tbh2, fdelete, red1 = null, red2 = null, green1 = null, green2 = null, blue1 = null, blue2 = null;
        char[] kelime;
        Color myColor;
        string hex;
        int r, g, b, dr1, dr2, dg1, dg2, db1, db2, x = 0, d, opac = 1;

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (formTasiniyor)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.baslangicNoktasi.X, p.Y - this.baslangicNoktasi.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            formTasiniyor = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formTasiniyor = true;
                baslangicNoktasi = new Point(e.X, e.Y);
            }
        }

        private void colorwheel_Click(object sender, EventArgs e)
        {
            if (r1 && r2)
            {
                cder.Text = "";
                r1 = false;
                r2 = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cder.Text.Length == 0)
            { }
            else
            {
                string cumle;
                string[] s;
                cumle = cder.Text;
                s = cumle.Split(' ', ',', '.', '-', '<', '>', ';');

                fdelete = s[1];

                XDocument xDoc = XDocument.Load(@"SavedColorCodes.xml");
                XElement rootElement = xDoc.Root;

                foreach (XElement rehberimiz in rootElement.Elements())
                {
                    if (rehberimiz.Attribute("ID").Value == fdelete)
                    {
                        rehberimiz.Remove();
                    }
                }
                xDoc.Save(@"SavedColorCodes.xml");
                cder.Text = "";
                load();
            }
        }

        private void opaCalc()
        {
            if (opaci.Value > 0 || opaci.Value <= 11)
            {
                opac = opaci.Value;
                switch (opac)
                {
                    case 1:
                        {
                            this.Opacity = 0.02;
                            break;
                        }
                    case 2:
                        {
                            this.Opacity = 0.04;
                            break;
                        }
                    case 3:
                        {
                            this.Opacity = 0.06;
                            break;
                        }
                    case 4:
                        {
                            this.Opacity = 0.08;
                            break;
                        }
                    case 5:
                        {
                            this.Opacity = 0.1;
                             
                            break;
                        }
                    case 6:
                        {
                            this.Opacity = 0.12;
                             
                            break;
                        }
                    case 7:
                        {
                            this.Opacity = 0.14;
                             
                            break;
                        }
                    case 8:
                        {
                            this.Opacity = 0.16;
                             
                            break;
                        }
                    case 9:
                        {
                            this.Opacity = 0.18;
                             
                            break;
                        }
                    case 10:
                        {
                            this.Opacity = 0.2;
                             
                            break;
                        }
                    case 11:
                        {
                            this.Opacity = 0.22;
                             
                            break;
                        }
                    case 12:
                        {
                            this.Opacity = 0.24;
                             
                            break;
                        }
                    case 13:
                        {
                            this.Opacity = 0.26;
                             
                            break;
                        }
                    case 14:
                        {
                            this.Opacity = 0.28;
                             
                            break;
                        }
                    case 15:
                        {
                            this.Opacity = 0.3;
                             
                            break;
                        }
                    case 16:
                        {
                            this.Opacity = 0.32;
                             
                            break;
                        }
                    case 17:
                        {
                            this.Opacity = 0.34;
                             
                            break;
                        }
                    case 18:
                        {
                            this.Opacity = 0.36;
                             
                            break;
                        }
                    case 19:
                        {
                            this.Opacity = 0.38;
                             
                            break;
                        }
                    case 20:
                        {
                            this.Opacity = 0.4;
                             
                            break;
                        }
                    case 21:
                        {
                            this.Opacity = 0.42;
                             
                            break;
                        }
                    case 22:
                        {
                            this.Opacity = 0.44;
                             
                            break;
                        }
                    case 23:
                        {
                            this.Opacity = 0.46;
                             
                            break;
                        }
                    case 24:
                        {
                            this.Opacity = 0.48;
                             
                            break;
                        }
                    case 25:
                        {
                            this.Opacity = 0.5;
                             
                            break;
                        }
                    case 26:
                        {
                            this.Opacity = 0.52;
                             
                            break;
                        }
                    case 27:
                        {
                            this.Opacity = 0.54;
                             
                            break;
                        }
                    case 28:
                        {
                            this.Opacity = 0.56;
                             
                            break;
                        }
                    case 29:
                        {
                            this.Opacity = 0.58;
                             
                            break;
                        }
                    case 30:
                        {
                            this.Opacity = 0.6;
                             
                            break;
                        }
                    case 31:
                        {
                            this.Opacity = 0.62;
                             
                            break;
                        }
                    case 32:
                        {
                            this.Opacity = 0.64;
                             
                            break;
                        }
                    case 33:
                        {
                            this.Opacity = 0.66;
                             
                            break;
                        }
                    case 34:
                        {
                            this.Opacity = 0.68;
                             
                            break;
                        }
                    case 35:
                        {
                            this.Opacity = 0.7;
                             
                            break;
                        }
                    case 36:
                        {
                            this.Opacity = 0.72;
                             
                            break;
                        }
                    case 37:
                        {
                            this.Opacity = 0.74;
                             
                            break;
                        }
                    case 38:
                        {
                            this.Opacity = 0.76;
                             
                            break;
                        }
                    case 39:
                        {
                            this.Opacity = 0.78;
                             
                            break;
                        }
                    case 40:
                        {
                            this.Opacity = 0.8;
                             
                            break;
                        }
                    case 41:
                        {
                            this.Opacity = 0.82;
                             
                            break;
                        }
                    case 42:
                        {
                            this.Opacity = 0.84;
                             
                            break;
                        }
                    case 43:
                        {
                            this.Opacity = 0.86;
                             
                            break;
                        }
                    case 44:
                        {
                            this.Opacity = 0.88;
                             
                            break;
                        }
                    case 45:
                        {
                            this.Opacity = 0.9;
                             
                            break;
                        }
                    case 46:
                        {
                            this.Opacity = 0.92;
                             
                            break;
                        }
                    case 47:
                        {
                            this.Opacity = 0.94;
                             
                            break;
                        }
                    case 48:
                        {
                            this.Opacity = 0.96;
                             
                            break;
                        }
                    case 49:
                        {
                            this.Opacity = 0.98;
                             
                            break;
                        }
                    case 50:
                        {
                            this.Opacity = 1;
                             
                            break;
                        }
                    default:
                        {
                            this.Opacity = 1;
                             
                            break;
                        }
                }
            }
            else { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void opaci_Scroll(object sender, EventArgs e)
        {
            opaCalc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            opac = 10;
            tbHex.MaxLength = 6;
            xmlctrl();
            load();
        }
        private void xmlctrl()
        {
            string dosya_dizini = AppDomain.CurrentDomain.BaseDirectory.ToString() + "SavedColorCodes.xml";
            if (File.Exists(dosya_dizini) == true)
            {
            }
            else
            {
                
                FileStream fs = new FileStream(dosya_dizini, FileMode.OpenOrCreate);

                string YazilacakIcerik = "<?xml version=\"1.0\" encoding=\"utf-8\" ?> "
                    + Environment.NewLine + "<clrs> "
                    + Environment.NewLine + "</clrs>";
                fs.Flush();
                fs.Close();

                File.AppendAllText(dosya_dizini, YazilacakIcerik);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            colorwheel.Enabled = false;
            button1.Enabled = false;
            r1 = true;
            if (cder.Text.Length == 0)
            {

            }
            else
            {
                if (!c1)
                {
                    string cumle;
                    string[] s;
                    cumle = cder.Text;
                    s = cumle.Split(' ', ',', '.', '-');

                    tbR.Text = s[4];
                    tbG.Text = s[5];
                    tbB.Text = s[6];
                    button1.PerformClick();
                    button3.PerformClick();
                }
                else
                {

                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            r2 = true;
            if (cder.Text.Length == 0)
            {

            }
            else
            {
                    string cumle;
                    string[] s;
                    cumle = cder.Text;
                    s = cumle.Split(' ', ',', '.', '-');
    
                    tbR.Text = s[7];
                    tbG.Text = s[8];
                    tbB.Text = s[9];
                    button1.PerformClick();
                    button3.PerformClick();

            }
        }

        private void load()
        {
            cder.Items.Clear();
            XDocument xDoc = XDocument.Load(@"DataBase.xml");
            XElement rootElement = xDoc.Root;
            int cint = cder.Items.Count;
            foreach (XElement rehberimiz in rootElement.Elements())
            {
                cder.Items.Add(rehberimiz.Value);
            }
        }
            private void saver_Click(object sender, EventArgs e)
            {
                if (cder.Text.Length == 0)
            {

            }
            else
            {
                if (cder.Text == null)
                {

                }
                else
                {
                    XDocument xDoc = XDocument.Load(@"SavedColorCodes.xml");
                    XElement rootElement = xDoc.Root;
                    XElement newElement = new XElement("COLORS");
                    int cint = cder.Items.Count + 1;
                    XAttribute idAttribute = new XAttribute("ID", cint);
                    XElement adiElement = new XElement("RGB", "ID: " + cint + "   " + cder.Text + " <----> ");
                    XElement telefonElement = new XElement("Hex", tbh1 + " - " + tbh2);
                    newElement.Add(idAttribute, adiElement, telefonElement);
                    rootElement.Add(newElement);
                    xDoc.Save(@"SavedColorCodes.xml");
                    load();
                }
            }
            }

        private void loadder_Click(object sender, EventArgs e)
        {
            if (cder.Text == "" && cder.Text == " ")
            {
                MessageBox.Show("Please Select Any Saved Color Code");
            }
            else
            {
                load();
            }
        }

        private void coppy_Click(object sender, EventArgs e)
        {
                System.Windows.Forms.Clipboard.SetText(outp.Text);
        }

        private void refre_Click(object sender, EventArgs e)
        {
            colorwheel.Enabled = true;
            button1.Enabled = true;
            coder = false;
            ranger = 0;
            button5.Enabled = true;
            button6.Enabled = true;
            dr1 = 0;
            dr2 = 0;
            dg1 = 0;
            dg2 = 0;
            db1 = 0;
            db2 = 0;
            x = 1;
            i = 0;
            tbHex.Text = "";
            tbR.Text = "";
            tbG.Text = "";
            tbB.Text = "";
            cder.Text = "";
            inp.Text = "Your Text Is Here";
            outp.Text = "Output Text Is Here";
            selector.BackColor = Color.Transparent;
        }

        int i = 0;
        string clr2;
        float calcLuminance(int rgb)
        {
            int r = (rgb & 0xff0000) >> 16;
            int g = (rgb & 0xff00) >> 8;
            int b = (rgb & 0xff);
            tbR.Text = r.ToString();
            tbG.Text = g.ToString();
            tbB.Text = b.ToString();
            return (r * 0.299f + g * 0.587f + b * 0.114f) / 256;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (tbHex.Text != "" && tbHex.Text != " ")
            {
                Bitmap bmp = (Bitmap)colorwheel.Image;
                string hex = "0x" + tbHex.Text;
                int r = Convert.ToInt32(hex.Substring(2, 2), 16);
                int g = Convert.ToInt32(hex.Substring(4, 2), 16);
                int b = Convert.ToInt32(hex.Substring(6, 2), 16);
                var myColor = Color.FromArgb(r, g, b);
                Color clrs = myColor;
                selector.BackColor = clrs;
                int rgb = Convert.ToInt32(tbHex.Text, 16);
                var a = calcLuminance(rgb);
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbR.Text != "" && tbG.Text != "" && tbB.Text != "" && tbR.Text != " " && tbG.Text != " " && tbB.Text != " ")
            {
                Bitmap bmp = (Bitmap)colorwheel.Image;
                int r = Convert.ToInt32(tbR.Text);
                int g = Convert.ToInt32(tbG.Text);
                int b = Convert.ToInt32(tbB.Text);
                var myColor = Color.FromArgb(r, g, b);
                Color clrs = myColor;
                selector.BackColor = clrs;
                tbR.Text = r.ToString();
                tbG.Text = g.ToString();
                tbB.Text = b.ToString();
                tbHex.Text = string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
            }
            else
            {
                tbHex.Text = "";
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Bitmap bmp = (Bitmap)colorwheel.Image;
                    Color clr = bmp.GetPixel(e.X, e.Y);

                    button3.PerformClick();

                    tbR.Text = clr.R.ToString();
                    tbG.Text = clr.G.ToString();
                    tbB.Text = clr.B.ToString();
                    selector.BackColor = clr;
                }
                catch
                {

                }
            }
        }

        private void colorbox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                try
                {
                    Bitmap bmp = (Bitmap)colorbox.Image;
                    Color clr = bmp.GetPixel(e.X, e.Y);
                    tbHex.Text = clr.Name;
                    tbR.Text = clr.R.ToString();
                    tbG.Text = clr.G.ToString();
                    tbB.Text = clr.B.ToString();
                    selector.BackColor = clr;
                }
                catch
                {

                }
            }
        }
        private void den()
        {
            if (r1 && r2)
            {
                switch (x)
                {
                    case 0:
                        red1 = tbR.Text;
                        green1 = tbG.Text;
                        blue1 = tbB.Text;
                        clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text + "-";
                        tbh1 = tbHex.Text;
                        x++;
                        break;
                    case 1:
                        red2 = tbR.Text;
                        green2 = tbG.Text;
                        blue2 = tbB.Text;
                        clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text;
                        tbh2 = tbHex.Text;
                        x++;
                        break;
                    case 3:
                        cder.Text = "";
                        x = 1;
                        goto case 0;
                }
            }
               else if (cder.Text.Length != 0)
                {
                    denet = true;
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c1 = true;
            if (cder.Text.Length == 0)
            {
                    button5.Enabled = false;
                    button6.Enabled = false;
            }
            den();
            if (!r1 && r2)
            {
                if (!coder && ranger == 0 && cder.Text.Length == 0)
                {
                    range();
                    coder = true;
                }
                else if (!coder && ranger == 0 && cder.Text.Length != 0)
                {
                    range();
                    ranger++;
                }
                else if (!coder && ranger != 0)
                {
                    rang();
                    ranger++;
                }
                else if (coder)
                {
                    x++;
                    rang();
                }
            }
            else if (!r1 && !r2)
            {
                if (!coder && ranger == 0 && cder.Text.Length == 0)
                {
                    range();
                    coder = true;
                }
                else if (!coder && ranger == 0 && cder.Text.Length != 0)
                {
                    range();
                    ranger++;
                }
                else if (!coder && ranger != 0)
                {
                    rang();
                    ranger++;
                }
                else if (coder)
                {
                    x++;
                    rang();
                }
            }
        }
        private void range()
        {
            if ((tbR.Text.Length != 0 && tbG.Text.Length != 0 && tbB.Text.Length != 0) || tbHex.Text.Length != 0)
            {
                if (!denet)
                {
                    switch (x)
                    {
                        case 0:
                            red1 = tbR.Text;
                            green1 = tbG.Text;
                            blue1 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text + "-";
                            cder.Text = cder.Text + clr2;
                            tbh1 = tbHex.Text;
                            x++;
                            break;
                        case 1:
                            red2 = tbR.Text;
                            green2 = tbG.Text;
                            blue2 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text;
                            cder.Text = cder.Text + clr2;
                            tbh2 = tbHex.Text;
                            x++;
                            break;
                        case 2:
                            cder.Text = "";
                            x = 1;
                            goto case 0;
                    }
                }
                else if (denet)
                {
                    switch (x)
                    {
                        case 1:
                            red1 = tbR.Text;
                            green1 = tbG.Text;
                            blue1 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text + "-";
                            tbh1 = tbHex.Text;
                            x++;
                            break;
                        case 2:
                            red2 = tbR.Text;
                            green2 = tbG.Text;
                            blue2 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text;
                            tbh2 = tbHex.Text;
                            cder.Text = cder.Text + clr2;
                            x++;
                            break;
                        case 3:
                            cder.Text = "";
                            x = 1;
                            goto case 1;
                    }
                }
            }
            else
            {

            }
        }
        private void rang()
        {
            if ((tbR.Text.Length != 0 && tbG.Text.Length != 0 && tbB.Text.Length != 0) || tbHex.Text.Length != 0)
            {
                if (!denet)
                {
                    switch (x)
                    {
                        case 1:
                            red1 = tbR.Text;
                            green1 = tbG.Text;
                            blue1 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text + "-";
                            cder.Text = cder.Text + clr2;
                            tbh1 = tbHex.Text;
                            break;
                        case 2:
                            red2 = tbR.Text;
                            green2 = tbG.Text;
                            blue2 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text;
                            cder.Text = cder.Text + clr2;
                            tbh2 = tbHex.Text;
                            break;
                        case 3:
                            cder.Text = "";
                            x = 1;
                            goto case 1;
                    }
                }
                else if (denet)
                {
                    switch (x)
                    {
                        case 0:
                            red1 = tbR.Text;
                            green1 = tbG.Text;
                            blue1 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text + "-";
                            cder.Text = cder.Text + clr2;
                            tbh1 = tbHex.Text;
                            break;
                        case 2:
                            red2 = tbR.Text;
                            green2 = tbG.Text;
                            blue2 = tbB.Text;
                            clr2 = tbR.Text + "," + tbG.Text + "," + tbB.Text;
                            cder.Text = cder.Text + clr2;
                            tbh2 = tbHex.Text;
                            break;
                        case 3:
                            cder.Text = "";
                            x = 1;
                            goto case 0;
                    }
                }
            }
            else
            {

            }
        }
        private void hesap()
        {
            string[] texts = inp.Text.Split();
            kelime = inp.Text.ToCharArray();

            string[] words = cder.Text.Split(' ', ',', '-');
            ur1 = red1;
            ug1 = green1;
            ub1 = blue1;
            ur2 = red2;
            ug2 = green2;
            ub2 = blue2;

            dr1 = Convert.ToInt32(ur1);
            dg1 = Convert.ToInt32(ug1);
            db1 = Convert.ToInt32(ub1);
            dr2 = Convert.ToInt32(ur2);
            dg2 = Convert.ToInt32(ug2);
            db2 = Convert.ToInt32(ub2);
            d = Convert.ToInt32(inp.Text.Length);

            if (dr1 <= 255 && dr2 <= 255 && dg1 <= 255 && dg2 <= 255 && db1 <= 255 && db2 <= 255)
            {
                if (dr1 < dr2 && dg1 < dg2 && db1 < db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 < dr2 && dg1 < dg2 && db1 > db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db1 - db2;
                }
                else if (dr1 < dr2 && dg1 == dg2 && db1 > db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db1 - db2;
                }
                else if (dr1 < dr2 && dg1 > dg2 && db1 < db2)
                {
                    r = dr2 - dr1;
                    g = dg1 - dg2;
                    b = db2 - db1;
                }
                else if (dr1 > dr2 && dg1 < dg2 && db1 < db2)
                {
                    r = dr1 - dr2;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 < dr2 && dg1 > dg2 && db1 > db2)
                {
                    r = dr2 - dr1;
                    g = dg1 - dg2;
                    b = db1 - db2;
                }
                else if (dr1 > dr2 && dg1 > dg2 && db1 < db2)
                {
                    r = dr1 - dr2;
                    g = dg1 - dg2;
                    b = db2 - db1;
                }
                else if (dr1 > dr2 && dg1 < dg2 && db1 > db2)
                {
                    r = dr1 - dr2;
                    g = dg2 - dg1;
                    b = db1 - db2;
                }
                else if (dr1 == dr2 && dg1 == dg2 && db1 == db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 < dr2 && dg1 < dg2 && db1 == db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 < dr2 && dg1 == dg2 && db1 < db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 == dr2 && dg1 < dg2 && db1 < db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 < dr2 && dg1 == dg2 && db1 == db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 == dr2 && dg1 == dg2 && db1 < db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 == dr2 && dg1 < dg2 && db1 == db2)
                {
                    r = dr2 - dr1;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 > dr2 && dg1 > dg2 && db1 > db2)
                {
                    r = dr1 - dr2;
                    g = dg1 - dg2;
                    b = db1 - db2;
                }
                else if (dr1 < dr2 && dg1 > dg2 && db1 == db2)
                {
                    r = dr2 - dr1;
                    g = dg1 - dg2;
                    b = db2 - db1;
                }
                else if (dr1 > dr2 && dg1 < dg2 && db1 == db2)
                {
                    r = dr1 - dr2;
                    g = dg2 - dg1;
                    b = db2 - db1;
                }
                else if (dr1 > dr2 && dg1 == dg2 && db1 < db2)
                {
                    r = dr1 - dr2;
                    g = dg1 - dg2;
                    b = db2 - db1;
                }
                else if (dr1 > dr2 && dg1 == dg2 && db1 == db2)
                {
                    r = dr1 - dr2;
                    g = dg1 - dg2;
                    b = db1 - db2;
                }
                else if (dr1 == dr2 && dg1 > dg2 && db1 == db2)
                {
                    r = dr1 - dr2;
                    g = dg1 - dg2;
                    b = db1 - db2;
                }
                else if (dr1 == dr2 && dg1 == dg2 && db1 > db2)
                {
                    r = dr1 - dr2;
                    g = dg1 - dg2;
                    b = db1 - db2;
                }
            }
            else
            {
                MessageBox.Show("Error Code: 2");
            }

            var hr = r;
            var hg = g;
            var hb = b;
            var dr = Convert.ToInt32(hr / d);
            var dg = Convert.ToInt32(hg / d);
            var db = Convert.ToInt32(hb / d);
        if (dr1 == 0 && dg1 == 0 && db1 == 0 && dr2 == 0 && dg2 == 0 && db2 == 0)
            {

            }
            else
            {
                if (cder.Text == null || cder.Text == "" || cder.Text == " ")
                {
                    outp.Text = "Output Text Is Here";
                }
                else
                {
                tag:
                if (i < inp.Text.Length)
                {
                    if (dr1 <= 255 && dr2 <= 255 && dg1 <= 255 && dg2 <= 255 && db1 <= 255 && db2 <= 255)
                    {
                        text = kelime[i].ToString();
                        if (text == " ")
                        {
                            outp.Text = outp.Text + kelime[i];
                            i++;
                            goto tag;
                        }
                        else
                        {
                            if (dr1 < dr2 && dg1 < dg2 && db1 < db2)
                            {
                                dr1 += dr;
                                dg1 += dg;
                                db1 += db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 < dr2 && dg1 < dg2 && db1 > db2)
                            {
                                dr1 += dr;
                                dg1 += dg;
                                db1 -= db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 < dr2 && dg1 == dg2 && db1 > db2)
                            {
                                if (dg1 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 -= db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dg1 == 255)
                                {
                                    dr1 += dr;
                                    dg1 -= dg;
                                    db1 -= db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 > dr2 && dg1 == dg2 && db1 == db2)
                            {
                                dr1 -= dr;
                                dg1 = dg;
                                db1 = db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 > dr2 && dg1 == dg2 && db1 < db2)
                            {
                                if (dg1 < 255)
                                {
                                    dr1 -= dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dg1 == 255)
                                {
                                    dr1 -= dr;
                                    dg1 -= dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 < dr2 && dg1 > dg2 && db1 < db2)
                            {
                                dr1 += dr;
                                dg1 -= dg;
                                db1 += db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 == dr2 && dg1 > dg2 && db1 == db2)
                            {
                                dr1 = dr;
                                dg1 -= dg;
                                db1 = db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 == dr2 && dg1 == dg2 && db1 > db2)
                            {
                                dr1 = dr;
                                dg1 = dg;
                                db1 -= db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 > dr2 && dg1 < dg2 && db1 < db2)
                            {
                                dr1 -= dr;
                                dg1 += dg;
                                db1 += db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 < dr2 && dg1 > dg2 && db1 > db2)
                            {
                                dr1 += dr;
                                dg1 -= dg;
                                db1 -= db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 > dr2 && dg1 > dg2 && db1 < db2)
                            {
                                dr1 -= dr;
                                dg1 -= dg;
                                db1 += db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 > dr2 && dg1 < dg2 && db1 > db2)
                            {
                                dr1 -= dr;
                                dg1 += dg;
                                db1 -= db;
                                myColor = Color.FromArgb(dr1, dg1, db1);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 == dr2 && dg1 == dg2 && db1 == db2)
                            {
                                if (dr1 < 255 && dr2 < 255 && dg1 < 255 && dg2 < 255 && db1 < 255 && db2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dr1 == 255 && dg1 == 255 && db1 == 255)
                                {
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 < dr2 && dg1 < dg2 && db1 == db2)
                            {
                                if (db1 < 255 && db2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 = db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (db1 == 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 -= db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 < dr2 && dg1 == dg2 && db1 < db2)
                            {
                                if (dg1 < 255 && dg2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dg1 == 255)
                                {
                                    dr1 += dr;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 == dr2 && dg1 < dg2 && db1 < db2)
                            {
                                if (dr1 < 255 && dr2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dr1 == 255)
                                {
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 < dr2 && dg1 == dg2 && db1 == db2)
                            {
                                if (dg1 < 255 && dg2 < 255 && db1 < 255 && db2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dg1 == 255 && db1 == 255)
                                {
                                    dr1 += dr;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 == dr2 && dg1 == dg2 && db1 < db2)
                            {
                                if (dr1 < 255 && dr2 < 255 && dg1 < 255 && dg2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dr1 == 255 && dg1 == 255)
                                {
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 == dr2 && dg1 < dg2 && db1 == db2)
                            {
                                if (dr1 < 255 && dr2 < 255 && db1 < 255 && db2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (dr1 == 255 && db1 == 255)
                                {
                                    dg1 += dg;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 > dr2 && dg1 > dg2 && db1 > db2)
                            {
                                dr2 += dr;
                                dg2 += dg;
                                db2 += db;
                                myColor = Color.FromArgb(dr2, dg2, db2);
                                hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                i++;
                            }
                            else if (dr1 < dr2 && dg1 > dg2 && db1 == db2)
                            {
                                if (db1 < 255 && db2 < 255)
                                {
                                    dr1 += dr;
                                    dg1 -= dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (db1 == 255)
                                {
                                    dr1 += dr;
                                    dg1 -= dg;
                                    myColor = Color.FromArgb(dr1, dg2, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                            else if (dr1 > dr2 && dg1 < dg2 && db1 == db2)
                            {
                                if (db1 < 255 && db2 < 255)
                                {
                                    dr1 -= dr;
                                    dg1 += dg;
                                    db1 += db;
                                    myColor = Color.FromArgb(dr1, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                                if (db1 == 255)
                                {
                                    dr1 -= dr;
                                    dg1 += dg;
                                    myColor = Color.FromArgb(dr2, dg1, db1);
                                    hex = myColor.R.ToString("X2") + myColor.G.ToString("X2") + myColor.B.ToString("X2");
                                    outp.Text = ($"{outp.Text}[COLOR=#{hex}]{kelime[i]+"[/COLOR]"}");
                                    i++;
                                }
                            }
                        }
                        goto tag;
                    }
                } 
                }
            }
        }

        private void per1()
        {
            button5.PerformClick();
        }
        private void per2()
        {
            button6.PerformClick();
        }
        private void coded_Click(object sender, EventArgs e)
        {
            if (cder.Text == null || cder.Text == "" || cder.Text == " ")
            {

            }
            else
            {
                if (red1 == null || green1 == null || blue1 == null || red2 == null || green2 == null || blue2 == null)
                {
                    if (cder.Text.Length != 0)
                    {
                        per1();
                        System.Threading.Thread.Sleep(1000);
                        per2();
                        outp.Text = "";
                        hesap();
                    }
                    else
                    {
                        per1();
                        System.Threading.Thread.Sleep(1000);
                        per2();
                        outp.Text = "";
                        hesap();
                    }
                }
                else
                {
                    if (cder.Text.Length != 0)
                    {
                        
                        outp.Text = "";
                        hesap();
                    }
                    else
                    {
                        outp.Text = "";
                        hesap();
                    }
                }
            }
        }
    }
}
