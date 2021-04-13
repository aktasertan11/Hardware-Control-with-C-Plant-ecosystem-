using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plantecov4
{
    public partial class temperature : UserControl
    {
        public static int val;
        public static double x;
        private static temperature _instance;
        public static temperature Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new temperature();
                return _instance;
            }
        }
        public temperature()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void temperature_Load(object sender, EventArgs e)
        {
            
            timer1.Tick += timer1_Tick;
            timer1.Interval = 50;
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            
            this.Invoke(new EventHandler(update_chart));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(x, val);
            if (chart1.Series[0].Points.Count > 100)
                chart1.Series[0].Points.RemoveAt(0);

            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = x;

            x += 1;
        }
        public void update_chart(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(x, val);

        }
        
        private void heaterbtn_Click(object sender, EventArgs e)
        {
            
            ConnectionUC.Instance.SendDataGreen(sender, e, "6#");
        }

        private void heateroffbtn_Click(object sender, EventArgs e)
        {
            ConnectionUC.Instance.SendDataGreen(sender, e, "5#");
        }
    }
}
