namespace plantecov4
{
    partial class ConnectionUC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionUC));
            this.comportlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comPortcmb = new System.Windows.Forms.ComboBox();
            this.baudcmb = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.disconnectbtn = new System.Windows.Forms.Button();
            this.connectOpenbtn = new System.Windows.Forms.Button();
            this.statuslbl = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comportlbl
            // 
            this.comportlbl.AutoSize = true;
            this.comportlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comportlbl.ForeColor = System.Drawing.Color.Black;
            this.comportlbl.Location = new System.Drawing.Point(84, 93);
            this.comportlbl.Name = "comportlbl";
            this.comportlbl.Size = new System.Drawing.Size(136, 32);
            this.comportlbl.TabIndex = 0;
            this.comportlbl.Text = "COM PORT";
            this.comportlbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(84, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(87, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "STATUS";
            // 
            // comPortcmb
            // 
            this.comPortcmb.FormattingEnabled = true;
            this.comPortcmb.Location = new System.Drawing.Point(265, 93);
            this.comPortcmb.Name = "comPortcmb";
            this.comPortcmb.Size = new System.Drawing.Size(137, 24);
            this.comPortcmb.TabIndex = 3;
            // 
            // baudcmb
            // 
            this.baudcmb.FormattingEnabled = true;
            this.baudcmb.Location = new System.Drawing.Point(265, 141);
            this.baudcmb.Name = "baudcmb";
            this.baudcmb.Size = new System.Drawing.Size(137, 24);
            this.baudcmb.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(265, 193);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(137, 23);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // disconnectbtn
            // 
            this.disconnectbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectbtn.Image = ((System.Drawing.Image)(resources.GetObject("disconnectbtn.Image")));
            this.disconnectbtn.Location = new System.Drawing.Point(290, 279);
            this.disconnectbtn.Name = "disconnectbtn";
            this.disconnectbtn.Size = new System.Drawing.Size(198, 57);
            this.disconnectbtn.TabIndex = 7;
            this.disconnectbtn.Text = "DISCONNECT";
            this.disconnectbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.disconnectbtn.UseVisualStyleBackColor = true;
            this.disconnectbtn.Click += new System.EventHandler(this.disconnectbtn_Click);
            // 
            // connectOpenbtn
            // 
            this.connectOpenbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectOpenbtn.Image = ((System.Drawing.Image)(resources.GetObject("connectOpenbtn.Image")));
            this.connectOpenbtn.Location = new System.Drawing.Point(71, 279);
            this.connectOpenbtn.Name = "connectOpenbtn";
            this.connectOpenbtn.Size = new System.Drawing.Size(175, 57);
            this.connectOpenbtn.TabIndex = 8;
            this.connectOpenbtn.Text = "CONNECT";
            this.connectOpenbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.connectOpenbtn.UseVisualStyleBackColor = true;
            this.connectOpenbtn.Click += new System.EventHandler(this.connectOpenbtn_Click);
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(217, 248);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            this.statuslbl.TabIndex = 9;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.baudcmb);
            this.panel1.Controls.Add(this.statuslbl);
            this.panel1.Controls.Add(this.comportlbl);
            this.panel1.Controls.Add(this.connectOpenbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.disconnectbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.comPortcmb);
            this.panel1.Location = new System.Drawing.Point(210, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 424);
            this.panel1.TabIndex = 10;
            // 
            // ConnectionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.panel1);
            this.Name = "ConnectionUC";
            this.Size = new System.Drawing.Size(1041, 706);
            this.Load += new System.EventHandler(this.ConnectionUC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label comportlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comPortcmb;
        private System.Windows.Forms.ComboBox baudcmb;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button disconnectbtn;
        private System.Windows.Forms.Button connectOpenbtn;
        private System.Windows.Forms.Label statuslbl;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
    }
}
