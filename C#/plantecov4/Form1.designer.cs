namespace plantecov4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnHumidity = new System.Windows.Forms.Button();
            this.btnCo2 = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnGuests = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.temperature1 = new plantecov4.temperature();
            this.guestUC1 = new plantecov4.GuestUC();
            this.gassensorUCcs1 = new plantecov4.gassensorUCcs();
            this.connectionUC1 = new plantecov4.ConnectionUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnConnection);
            this.panel1.Controls.Add(this.btnHumidity);
            this.panel1.Controls.Add(this.btnCo2);
            this.panel1.Controls.Add(this.btnTemperature);
            this.panel1.Controls.Add(this.btnGuests);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 706);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 238);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(4, 123);
            this.pnlNav.TabIndex = 1;
            // 
            // btnConnection
            // 
            this.btnConnection.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.Location = new System.Drawing.Point(0, 602);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(227, 101);
            this.btnConnection.TabIndex = 3;
            this.btnConnection.Text = "Connection\r\n";
            this.btnConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            this.btnConnection.Leave += new System.EventHandler(this.btnConnection_Leave);
            // 
            // btnHumidity
            // 
            this.btnHumidity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHumidity.FlatAppearance.BorderSize = 0;
            this.btnHumidity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHumidity.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHumidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnHumidity.Image = ((System.Drawing.Image)(resources.GetObject("btnHumidity.Image")));
            this.btnHumidity.Location = new System.Drawing.Point(0, 501);
            this.btnHumidity.Margin = new System.Windows.Forms.Padding(4);
            this.btnHumidity.Name = "btnHumidity";
            this.btnHumidity.Size = new System.Drawing.Size(227, 101);
            this.btnHumidity.TabIndex = 3;
            this.btnHumidity.Text = "Humidity\r\n";
            this.btnHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHumidity.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHumidity.UseVisualStyleBackColor = true;
            this.btnHumidity.Click += new System.EventHandler(this.btnHumidity_Click);
            this.btnHumidity.Leave += new System.EventHandler(this.btnHumidity_Leave);
            // 
            // btnCo2
            // 
            this.btnCo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCo2.FlatAppearance.BorderSize = 0;
            this.btnCo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCo2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnCo2.Image = ((System.Drawing.Image)(resources.GetObject("btnCo2.Image")));
            this.btnCo2.Location = new System.Drawing.Point(0, 400);
            this.btnCo2.Margin = new System.Windows.Forms.Padding(4);
            this.btnCo2.Name = "btnCo2";
            this.btnCo2.Size = new System.Drawing.Size(227, 101);
            this.btnCo2.TabIndex = 3;
            this.btnCo2.Text = "Co2 Level";
            this.btnCo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCo2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCo2.UseVisualStyleBackColor = true;
            this.btnCo2.Click += new System.EventHandler(this.btnCo2_Click);
            this.btnCo2.Leave += new System.EventHandler(this.btnCo2_Leave);
            // 
            // btnTemperature
            // 
            this.btnTemperature.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTemperature.FlatAppearance.BorderSize = 0;
            this.btnTemperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemperature.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnTemperature.Image = ((System.Drawing.Image)(resources.GetObject("btnTemperature.Image")));
            this.btnTemperature.Location = new System.Drawing.Point(0, 299);
            this.btnTemperature.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(227, 101);
            this.btnTemperature.TabIndex = 3;
            this.btnTemperature.Text = "Temperature";
            this.btnTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTemperature.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            this.btnTemperature.Leave += new System.EventHandler(this.btnTemperature_Leave);
            // 
            // btnGuests
            // 
            this.btnGuests.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuests.FlatAppearance.BorderSize = 0;
            this.btnGuests.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuests.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnGuests.Image = ((System.Drawing.Image)(resources.GetObject("btnGuests.Image")));
            this.btnGuests.Location = new System.Drawing.Point(0, 198);
            this.btnGuests.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuests.Name = "btnGuests";
            this.btnGuests.Size = new System.Drawing.Size(227, 101);
            this.btnGuests.TabIndex = 3;
            this.btnGuests.Text = "Guests";
            this.btnGuests.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuests.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGuests.UseVisualStyleBackColor = true;
            this.btnGuests.Click += new System.EventHandler(this.btnGuests_Click);
            this.btnGuests.Leave += new System.EventHandler(this.btnGuests_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 198);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(47, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plant Ecosystem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.temperature1);
            this.panel3.Controls.Add(this.guestUC1);
            this.panel3.Controls.Add(this.gassensorUCcs1);
            this.panel3.Controls.Add(this.connectionUC1);
            this.panel3.Location = new System.Drawing.Point(225, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1041, 706);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // temperature1
            // 
            this.temperature1.Location = new System.Drawing.Point(0, -3);
            this.temperature1.Name = "temperature1";
            this.temperature1.Size = new System.Drawing.Size(1041, 706);
            this.temperature1.TabIndex = 3;
            // 
            // guestUC1
            // 
            this.guestUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.guestUC1.Location = new System.Drawing.Point(0, 3);
            this.guestUC1.Name = "guestUC1";
            this.guestUC1.Size = new System.Drawing.Size(952, 634);
            this.guestUC1.TabIndex = 2;
            // 
            // gassensorUCcs1
            // 
            this.gassensorUCcs1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gassensorUCcs1.Location = new System.Drawing.Point(150, 84);
            this.gassensorUCcs1.Name = "gassensorUCcs1";
            this.gassensorUCcs1.Size = new System.Drawing.Size(736, 486);
            this.gassensorUCcs1.TabIndex = 1;
            // 
            // connectionUC1
            // 
            this.connectionUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.connectionUC1.Location = new System.Drawing.Point(0, -3);
            this.connectionUC1.Name = "connectionUC1";
            this.connectionUC1.Size = new System.Drawing.Size(1041, 706);
            this.connectionUC1.TabIndex = 0;
            this.connectionUC1.Load += new System.EventHandler(this.connectionUC1_Load_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1268, 706);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnHumidity;
        private System.Windows.Forms.Button btnCo2;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel panel3;
        private ConnectionUC connectionUC1;
        private gassensorUCcs gassensorUCcs1;
        private GuestUC guestUC1;
        public System.Windows.Forms.Button btnGuests;
        private temperature temperature1;
    }
}

