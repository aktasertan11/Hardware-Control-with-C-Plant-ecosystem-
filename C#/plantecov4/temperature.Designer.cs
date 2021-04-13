namespace plantecov4
{
    partial class temperature
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temperature));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.heaterbtn = new System.Windows.Forms.Button();
            this.heateroffbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(140, 124);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Temperature";
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(645, 358);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Temperature";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(372, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "TEMPERATURE";
            // 
            // heaterbtn
            // 
            this.heaterbtn.BackColor = System.Drawing.Color.Yellow;
            this.heaterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heaterbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.heaterbtn.Image = ((System.Drawing.Image)(resources.GetObject("heaterbtn.Image")));
            this.heaterbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.heaterbtn.Location = new System.Drawing.Point(140, 548);
            this.heaterbtn.Name = "heaterbtn";
            this.heaterbtn.Size = new System.Drawing.Size(645, 60);
            this.heaterbtn.TabIndex = 2;
            this.heaterbtn.Text = "TURN ON THE HEATER";
            this.heaterbtn.UseVisualStyleBackColor = false;
            this.heaterbtn.Click += new System.EventHandler(this.heaterbtn_Click);
            // 
            // heateroffbtn
            // 
            this.heateroffbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.heateroffbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heateroffbtn.Location = new System.Drawing.Point(140, 614);
            this.heateroffbtn.Name = "heateroffbtn";
            this.heateroffbtn.Size = new System.Drawing.Size(645, 44);
            this.heateroffbtn.TabIndex = 3;
            this.heateroffbtn.Text = "TURN OFF";
            this.heateroffbtn.UseVisualStyleBackColor = false;
            this.heateroffbtn.Click += new System.EventHandler(this.heateroffbtn_Click);
            // 
            // temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.heateroffbtn);
            this.Controls.Add(this.heaterbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "temperature";
            this.Size = new System.Drawing.Size(1041, 706);
            this.Load += new System.EventHandler(this.temperature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button heaterbtn;
        private System.Windows.Forms.Button heateroffbtn;
    }
}
