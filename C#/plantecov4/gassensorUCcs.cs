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
    
    public partial class gassensorUCcs : UserControl
    {
        public static string veri;
       

        private static gassensorUCcs _instance;
        public static gassensorUCcs Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new gassensorUCcs();
                return _instance;
            }
        }
        public gassensorUCcs()
        {
            InitializeComponent();
        }

        private void gassensorUCcs_Load(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(update_text));
            
        }
        
        
        
        public  void update_text(object sender, EventArgs e)
        {
             verticalProgressBar1.Value = Convert.ToInt16(veri);

        }

        private void verticalProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            ConnectionUC.Instance.SendDataGreen(sender,e,"7#");

        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            ConnectionUC.Instance.SendDataGreen(sender, e,"13#");
        }

        private void greenoff_Click(object sender, EventArgs e)
        {
            ConnectionUC.Instance.SendDataGreen(sender, e, "8#");
        }

        private void redoff_Click(object sender, EventArgs e)
        {
            ConnectionUC.Instance.SendDataGreen(sender, e, "12#");
        }
    }
}
