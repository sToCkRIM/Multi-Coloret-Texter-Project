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
            this.colorbox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorwheel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).BeginInit();
            this.SuspendLayout();
            // 
            // colorbox
            // 
            this.colorbox.ErrorImage = global::WindowsFormsApplication2.Properties.Resources.colorbox;
            this.colorbox.Image = global::WindowsFormsApplication2.Properties.Resources.colorbox;
            this.colorbox.Location = new System.Drawing.Point(12, 182);
            this.colorbox.Name = "colorbox";
            this.colorbox.Size = new System.Drawing.Size(206, 80);
            this.colorbox.TabIndex = 1;
            this.colorbox.TabStop = false;
            this.colorbox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.colorbox_MouseMove);
            // 
            // colorwheel
            // 
            this.colorwheel.Image = global::WindowsFormsApplication2.Properties.Resources.images;
            this.colorwheel.Location = new System.Drawing.Point(27, 12);
            this.colorwheel.Name = "colorwheel";
            this.colorwheel.Size = new System.Drawing.Size(160, 164);
            this.colorwheel.TabIndex = 0;
            this.colorwheel.TabStop = false;
            this.colorwheel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // selector
            // 
            this.selector.Location = new System.Drawing.Point(304, 12);
            this.selector.Name = "selector";
            this.selector.Size = new System.Drawing.Size(125, 164);
            this.selector.TabIndex = 2;
            this.selector.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hex:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(456, 92);
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
            this.lbR.Location = new System.Drawing.Point(491, 66);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(0, 13);
            this.lbR.TabIndex = 9;
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.Location = new System.Drawing.Point(491, 79);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(0, 13);
            this.lbG.TabIndex = 10;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(491, 92);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(0, 13);
            this.lbB.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 276);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Color Picker v1.00";
            ((System.ComponentModel.ISupportInitialize)(this.colorbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorwheel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox colorwheel;
        private System.Windows.Forms.PictureBox colorbox;
        private System.Windows.Forms.PictureBox selector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbHex;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Label lbG;
        private System.Windows.Forms.Label lbB;
    }
}

