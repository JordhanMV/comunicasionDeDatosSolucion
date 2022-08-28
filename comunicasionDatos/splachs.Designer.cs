namespace comunicasionDatos
{
    partial class splachs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splachs));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BarraPogreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BarraPogreso
            // 
            this.BarraPogreso.animated = false;
            this.BarraPogreso.animationIterval = 5;
            this.BarraPogreso.animationSpeed = 300;
            this.BarraPogreso.BackColor = System.Drawing.Color.Black;
            this.BarraPogreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraPogreso.BackgroundImage")));
            this.BarraPogreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.BarraPogreso.ForeColor = System.Drawing.Color.Cyan;
            this.BarraPogreso.LabelVisible = true;
            this.BarraPogreso.LineProgressThickness = 8;
            this.BarraPogreso.LineThickness = 5;
            this.BarraPogreso.Location = new System.Drawing.Point(418, 134);
            this.BarraPogreso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.BarraPogreso.MaxValue = 100;
            this.BarraPogreso.Name = "BarraPogreso";
            this.BarraPogreso.ProgressBackColor = System.Drawing.Color.Transparent;
            this.BarraPogreso.ProgressColor = System.Drawing.Color.Transparent;
            this.BarraPogreso.Size = new System.Drawing.Size(81, 81);
            this.BarraPogreso.TabIndex = 0;
            this.BarraPogreso.Value = 0;
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BarraPogreso);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 396);
            this.panel1.TabIndex = 2;
            // 
            // splachs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 396);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splachs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splachs";
            this.Load += new System.EventHandler(this.splachs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar BarraPogreso;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}