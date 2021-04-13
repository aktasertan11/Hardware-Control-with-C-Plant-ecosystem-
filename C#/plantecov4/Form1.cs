using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace plantecov4
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
             int nLeftRect,
             int nTopRect,
             int nRightRect,
             int nBottomRect,
             int nWidthEllipse,
                int nHeightEllipse

         );
        public string prog_bar = "a";
        private static Form1 _instance;
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Form1();
                return _instance;
            }
        }

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnGuests.Height;
            pnlNav.Top = btnGuests.Top;
            pnlNav.Left = btnGuests.Left;
            btnGuests.BackColor = Color.FromArgb(46, 51, 73);
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (!panel3.Controls.Contains(ConnectionUC.Instance))
            {
                panel3.Controls.Add(ConnectionUC.Instance);
                ConnectionUC.Instance.Dock = DockStyle.Fill;
                ConnectionUC.Instance.BringToFront();

            }
            else
            {
                ConnectionUC.Instance.BringToFront();

            }
        }
        
        private void btnGuests_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnGuests.Height;
            pnlNav.Top = btnGuests.Top;
            pnlNav.Left = btnGuests.Left;
            btnGuests.BackColor = Color.FromArgb(46, 51, 73);

            if (!panel3.Controls.Contains(GuestUC.Instance))
            {
                panel3.Controls.Add(GuestUC.Instance);
                GuestUC.Instance.Dock = DockStyle.Fill;
                GuestUC.Instance.BringToFront();

            }
            else
            {
                GuestUC.Instance.BringToFront();

            }
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTemperature.Height;
            pnlNav.Top = btnTemperature.Top;
            pnlNav.Left = btnTemperature.Left;
            btnTemperature.BackColor = Color.FromArgb(46, 51, 73);

            if (!panel3.Controls.Contains(temperature.Instance))
            {
                panel3.Controls.Add(temperature.Instance);
                temperature.Instance.Dock = DockStyle.Fill;
                temperature.Instance.BringToFront();

            }
            else
            {
                temperature.Instance.BringToFront();

            }

        }

        private void btnCo2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCo2.Height;
            pnlNav.Top = btnCo2.Top;
            pnlNav.Left = btnCo2.Left;
            btnCo2.BackColor = Color.FromArgb(46, 51, 73);

            if (!panel3.Controls.Contains(gassensorUCcs.Instance))
            {
                panel3.Controls.Add(gassensorUCcs.Instance);
                gassensorUCcs.Instance.Dock = DockStyle.Fill;
                gassensorUCcs.Instance.BringToFront();

            }
            else
            {
                gassensorUCcs.Instance.BringToFront();

            }
        }

        private void btnHumidity_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHumidity.Height;
            pnlNav.Top = btnHumidity.Top;
            pnlNav.Left = btnHumidity.Left;
            btnHumidity.BackColor = Color.FromArgb(46, 51, 73);

            if (!panel3.Controls.Contains(moistureUC.Instance))
            {
                panel3.Controls.Add(moistureUC.Instance);
                moistureUC.Instance.Dock = DockStyle.Fill;
                moistureUC.Instance.BringToFront();

            }
            else
            {
                moistureUC.Instance.BringToFront();

            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnConnection.Height;
            pnlNav.Top = btnConnection.Top;
            pnlNav.Left = btnConnection.Left;
            btnConnection.BackColor = Color.FromArgb(46, 51, 73);

            if (!panel3.Controls.Contains(ConnectionUC.Instance))
            {
                panel3.Controls.Add(ConnectionUC.Instance);
                ConnectionUC.Instance.Dock = DockStyle.Fill;
                ConnectionUC.Instance.BringToFront();

            }
            else
            {
                ConnectionUC.Instance.BringToFront();

            }
        }

        private void btnGuests_Leave(object sender, EventArgs e)
        {
            btnGuests.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnTemperature_Leave(object sender, EventArgs e)
        {
            btnTemperature.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCo2_Leave(object sender, EventArgs e)
        {
            btnCo2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnHumidity_Leave(object sender, EventArgs e)
        {
            btnHumidity.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnConnection_Leave(object sender, EventArgs e)
        {
            btnConnection.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connectionUC1_Load(object sender, EventArgs e)
        {

        }

        private void connectionUC1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
