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
    public partial class moistureUC : UserControl
    {
        public static string verinem;
        private static moistureUC _instance;
        public static moistureUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new moistureUC();
                return _instance;
            }
        }
        public moistureUC()
        {
            InitializeComponent();
        }

        private void moistureUC_Load(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(update1_text));
        }
        public void update1_text(object sender, EventArgs e)
        {
            circularprogressbar1.Value = Convert.ToInt16(verinem);

        }

        private void addWaterbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addWaterbtn_Click_1(object sender, EventArgs e)
        {
            addWaterbtn.Enabled = false;
            stopbtn.Enabled = true;
            ConnectionUC.Instance.SendDataGreen(sender, e, "3#");
        }

        private void stopbtn_Click_1(object sender, EventArgs e)
        {
            addWaterbtn.Enabled = true;
            stopbtn.Enabled = false;
            ConnectionUC.Instance.SendDataGreen(sender, e, "2#");
        }
    }
}

