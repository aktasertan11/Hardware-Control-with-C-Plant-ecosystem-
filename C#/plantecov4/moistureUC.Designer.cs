namespace plantecov4
{
    partial class moistureUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(moistureUC));
            this.addWaterbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.circularprogressbar1 = new plantecov4.circularprogressbar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // addWaterbtn
            // 
            this.addWaterbtn.BackColor = System.Drawing.Color.Lime;
            this.addWaterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addWaterbtn.Location = new System.Drawing.Point(514, 560);
            this.addWaterbtn.Name = "addWaterbtn";
            this.addWaterbtn.Size = new System.Drawing.Size(146, 70);
            this.addWaterbtn.TabIndex = 1;
            this.addWaterbtn.Text = "ADD WATER";
            this.addWaterbtn.UseVisualStyleBackColor = false;
            this.addWaterbtn.Click += new System.EventHandler(this.addWaterbtn_Click_1);
            // 
            // stopbtn
            // 
            this.stopbtn.BackColor = System.Drawing.Color.Crimson;
            this.stopbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopbtn.Location = new System.Drawing.Point(729, 560);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(143, 70);
            this.stopbtn.TabIndex = 2;
            this.stopbtn.Text = "STOP";
            this.stopbtn.UseVisualStyleBackColor = false;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 276);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(337, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "MOISTURE LEVEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 390);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(304, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // circularprogressbar1
            // 
            this.circularprogressbar1.BackColor = System.Drawing.SystemColors.Info;
            this.circularprogressbar1.Location = new System.Drawing.Point(514, 84);
            this.circularprogressbar1.Max = 70F;
            this.circularprogressbar1.Name = "circularprogressbar1";
            this.circularprogressbar1.Size = new System.Drawing.Size(358, 358);
            this.circularprogressbar1.TabIndex = 0;
            this.circularprogressbar1.Value = 70F;
            // 
            // moistureUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.addWaterbtn);
            this.Controls.Add(this.circularprogressbar1);
            this.Name = "moistureUC";
            this.Size = new System.Drawing.Size(1041, 706);
            this.Load += new System.EventHandler(this.moistureUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private circularprogressbar circularprogressbar1;
        private System.Windows.Forms.Button addWaterbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
