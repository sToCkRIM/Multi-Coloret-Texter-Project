namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.colorwheel = new System.Windows.Forms.PictureBox();
            this.selector = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbHex = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbR = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.inp = new System.Windows.Forms.TextBox();
            this.coded = new System.Windows.Forms.Button();
            this.coppy = new System.Windows.Forms.Button();
            this.refre = new System.Windows.Forms.Button();
            this.outp = new System.Windows.Forms.TextBox();
            this.colorbox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cder = new System.Windows.Forms.ComboBox();
            this.saver = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.opaci = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.colorwheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opaci)).BeginInit();
            this.SuspendLayout();
            // 
            // colorwheel
            // 
            this.colorwheel.Image = global::WindowsFormsApplication2.Properties.Resources.images;
            this.colorwheel.Location = new System.Drawing.Point(12, 12);
            this.colorwheel.Name = "colorwheel";
            this.colorwheel.Size = new System.Drawing.Size(160, 164);
            this.colorwheel.TabIndex = 0;
            this.colorwheel.TabStop = false;
            this.colorwheel.Click += new System.EventHandler(this.colorwheel_Click);
            this.colorwheel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // selector
            // 
            this.selector.Location = new System.Drawing.Point(220, 12);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(125, 164);
            this.selector.TabIndex = 2;
            this.selector.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "B:";
            // 
            // lbHex
            // 
            this.lbHex.AutoSize = true;
            this.lbHex.Location = new System.Drawing.Point(491, 12);
            this.lbHex.Name = "lbHex";
            this.lbHex.Size = new System.Drawing.Size(0, 13);
            this.lbHex.TabIndex = 8;
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Location = new System.Drawing.Point(487, -16);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(0, 13);
            this.lbR.TabIndex = 9;
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.Location = new System.Drawing.Point(487, -3);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(0, 13);
            this.lbG.TabIndex = 10;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(487, 10);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(0, 13);
            this.lbB.TabIndex = 11;
            // 
            // tbHex
            // 
            this.tbHex.Location = new System.Drawing.Point(391, 12);
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(100, 20);
            this.tbHex.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Copy To Coder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(348, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 52);
            this.button4.TabIndex = 17;
            this.button4.Text = "Convert From Hex Code";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbR
            // 
            this.tbR.Location = new System.Drawing.Point(391, 42);
            this.tbR.Name = "tbR";
            this.tbR.Size = new System.Drawing.Size(36, 20);
            this.tbR.TabIndex = 18;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(391, 96);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(36, 20);
            this.tbB.TabIndex = 19;
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(391, 70);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(36, 20);
            this.tbG.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 52);
            this.button3.TabIndex = 21;
            this.button3.Text = "Convert From RGB Code";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inp
            // 
            this.inp.Location = new System.Drawing.Point(529, 76);
            this.inp.Multiline = true;
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(259, 83);
            this.inp.TabIndex = 22;
            this.inp.Text = "Your Text Is Here";
            // 
            // coded
            // 
            this.coded.Location = new System.Drawing.Point(529, 165);
            this.coded.Name = "coded";
            this.coded.Size = new System.Drawing.Size(85, 23);
            this.coded.TabIndex = 23;
            this.coded.Text = "Make Codded";
            this.coded.UseVisualStyleBackColor = true;
            this.coded.Click += new System.EventHandler(this.coded_Click);
            // 
            // coppy
            // 
            this.coppy.Location = new System.Drawing.Point(701, 165);
            this.coppy.Name = "coppy";
            this.coppy.Size = new System.Drawing.Size(87, 23);
            this.coppy.TabIndex = 24;
            this.coppy.Text = "Copy Clipboard";
            this.coppy.UseVisualStyleBackColor = true;
            this.coppy.Click += new System.EventHandler(this.coppy_Click);
            // 
            // refre
            // 
            this.refre.Location = new System.Drawing.Point(620, 165);
            this.refre.Name = "refre";
            this.refre.Size = new System.Drawing.Size(75, 23);
            this.refre.TabIndex = 25;
            this.refre.Text = "Refresh";
            this.refre.UseVisualStyleBackColor = true;
            this.refre.Click += new System.EventHandler(this.refre_Click);
            // 
            // outp
            // 
            this.outp.Location = new System.Drawing.Point(529, 194);
            this.outp.Multiline = true;
            this.outp.Name = "outp";
            this.outp.ReadOnly = true;
            this.outp.Size = new System.Drawing.Size(259, 99);
            this.outp.TabIndex = 26;
            this.outp.Text = "Output Text Is Here";
            // 
            // colorbox
            // 
            this.colorbox.ErrorImage = global::WindowsFormsApplication2.Properties.Resources.colorbox;
            this.colorbox.Image = global::WindowsFormsApplication2.Properties.Resources.colorbox;
            this.colorbox.Location = new System.Drawing.Point(1, 194);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(206, 80);
            this.colorbox.TabIndex = 1;
            this.colorbox.TabStop = false;
            this.colorbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorbox_MouseMove);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(809, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 24);
            this.button2.TabIndex = 27;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cder
            // 
            this.cder.FormattingEnabled = true;
            this.cder.Location = new System.Drawing.Point(515, 11);
            this.cder.Name = "cder";
            this.cder.Size = new System.Drawing.Size(288, 21);
            this.cder.TabIndex = 28;
            // 
            // saver
            // 
            this.saver.Location = new System.Drawing.Point(734, 41);
            this.saver.Name = "saver";
            this.saver.Size = new System.Drawing.Size(54, 25);
            this.saver.TabIndex = 30;
            this.saver.Text = "Save";
            this.saver.UseVisualStyleBackColor = true;
            this.saver.Click += new System.EventHandler(this.saver_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(529, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 34);
            this.button5.TabIndex = 31;
            this.button5.Text = "Show Range 1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(591, 36);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 34);
            this.button6.TabIndex = 32;
            this.button6.Text = "Show Range 2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(674, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(54, 25);
            this.button7.TabIndex = 33;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Set Transparency Here";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 298);
            this.splitter1.TabIndex = 37;
            this.splitter1.TabStop = false;
            // 
            // opaci
            // 
            this.opaci.Location = new System.Drawing.Point(241, 242);
            this.opaci.Maximum = 50;
            this.opaci.Minimum = 1;
            this.opaci.Name = "opaci";
            this.opaci.Size = new System.Drawing.Size(263, 45);
            this.opaci.TabIndex = 40;
            this.opaci.Value = 50;
            this.opaci.Scroll += new System.EventHandler(this.opaci_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(837, 298);
            this.Controls.Add(this.opaci);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.saver);
            this.Controls.Add(this.cder);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outp);
            this.Controls.Add(this.refre);
            this.Controls.Add(this.coppy);
            this.Controls.Add(this.coded);
            this.Controls.Add(this.inp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbR);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbHex);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbG);
            this.Controls.Add(this.lbR);
            this.Controls.Add(this.lbHex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selector);
            this.Controls.Add(this.colorbox);
            this.Controls.Add(this.colorwheel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Colored Texter Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.colorwheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox colorwheel;
        private System.Windows.Forms.PictureBox selector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHex;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbR;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox inp;
        private System.Windows.Forms.Button coded;
        private System.Windows.Forms.Button coppy;
        private System.Windows.Forms.Button refre;
        private System.Windows.Forms.TextBox outp;
        private System.Windows.Forms.PictureBox colorbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cder;
        private System.Windows.Forms.Button saver;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TrackBar opaci;
    }
}

