namespace plantecov4
{
    partial class gassensorUCcs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gassensorUCcs));
            this.greenBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.greenoff = new System.Windows.Forms.Button();
            this.redoff = new System.Windows.Forms.Button();
            this.verticalProgressBar1 = new plantecov4.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // greenBtn
            // 
            this.greenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.greenBtn.Location = new System.Drawing.Point(545, 402);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(113, 106);
            this.greenBtn.TabIndex = 2;
            this.greenBtn.Text = "GREEN";
            this.greenBtn.UseVisualStyleBackColor = false;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.BackColor = System.Drawing.Color.Red;
            this.redBtn.Location = new System.Drawing.Point(784, 402);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(113, 106);
            this.redBtn.TabIndex = 3;
            this.redBtn.Text = "RED";
            this.redBtn.UseVisualStyleBackColor = false;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(399, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "CO2 LEVEL";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(45, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(305, 166);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // greenoff
            // 
            this.greenoff.BackColor = System.Drawing.Color.Green;
            this.greenoff.Location = new System.Drawing.Point(545, 514);
            this.greenoff.Name = "greenoff";
            this.greenoff.Size = new System.Drawing.Size(113, 45);
            this.greenoff.TabIndex = 7;
            this.greenoff.Text = "TURN OFF";
            this.greenoff.UseVisualStyleBackColor = false;
            this.greenoff.Click += new System.EventHandler(this.greenoff_Click);
            // 
            // redoff
            // 
            this.redoff.BackColor = System.Drawing.Color.Maroon;
            this.redoff.Location = new System.Drawing.Point(784, 514);
            this.redoff.Name = "redoff";
            this.redoff.Size = new System.Drawing.Size(113, 45);
            this.redoff.TabIndex = 8;
            this.redoff.Text = "TURN OFF";
            this.redoff.UseVisualStyleBackColor = false;
            this.redoff.Click += new System.EventHandler(this.redoff_Click);
            // 
            // verticalProgressBar1
            // 
            this.verticalProgressBar1.Location = new System.Drawing.Point(656, 100);
            this.verticalProgressBar1.Name = "verticalProgressBar1";
            this.verticalProgressBar1.Size = new System.Drawing.Size(123, 276);
            this.verticalProgressBar1.TabIndex = 1;
            this.verticalProgressBar1.Click += new System.EventHandler(this.verticalProgressBar1_Click);
            // 
            // gassensorUCcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.redoff);
            this.Controls.Add(this.greenoff);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.greenBtn);
            this.Controls.Add(this.verticalProgressBar1);
            this.Name = "gassensorUCcs";
            this.Size = new System.Drawing.Size(1041, 706);
            this.Load += new System.EventHandler(this.gassensorUCcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VerticalProgressBar verticalProgressBar1;
        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button redBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button greenoff;
        private System.Windows.Forms.Button redoff;
    }
}
