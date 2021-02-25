namespace coordinate_scale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oldSz = new System.Windows.Forms.Panel();
            this.sz = new System.Windows.Forms.Panel();
            this.picB = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.sz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
            this.SuspendLayout();
            // 
            // oldSz
            // 
            this.oldSz.Location = new System.Drawing.Point(0, 0);
            this.oldSz.Margin = new System.Windows.Forms.Padding(0);
            this.oldSz.Name = "oldSz";
            this.oldSz.Size = new System.Drawing.Size(500, 300);
            this.oldSz.TabIndex = 0;
            // 
            // sz
            // 
            this.sz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sz.BackColor = System.Drawing.Color.White;
            this.sz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sz.Controls.Add(this.picB);
            this.sz.Location = new System.Drawing.Point(0, 0);
            this.sz.Margin = new System.Windows.Forms.Padding(0);
            this.sz.Name = "sz";
            this.sz.Size = new System.Drawing.Size(500, 300);
            this.sz.TabIndex = 1;
            // 
            // picB
            // 
            this.picB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picB.Image = ((System.Drawing.Image)(resources.GetObject("picB.Image")));
            this.picB.Location = new System.Drawing.Point(0, 0);
            this.picB.Margin = new System.Windows.Forms.Padding(0);
            this.picB.Name = "picB";
            this.picB.Size = new System.Drawing.Size(500, 300);
            this.picB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picB.TabIndex = 0;
            this.picB.TabStop = false;
            this.picB.Paint += new System.Windows.Forms.PaintEventHandler(this.picB_Paint);
            this.picB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picB_MouseClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(567, 33);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.sz);
            this.Controls.Add(this.oldSz);
            this.Name = "Form1";
            this.Text = "s";
            this.sz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel oldSz;
        private System.Windows.Forms.Panel sz;
        private System.Windows.Forms.PictureBox picB;
        private System.Windows.Forms.Button btn1;
    }
}

