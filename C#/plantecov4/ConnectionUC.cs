using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace plantecov4
{
    public partial class ConnectionUC : UserControl
    {
        string serialDataIn;

        public sbyte indexOfA;
        public sbyte indexOfB;
        public sbyte indexOfC;
        public sbyte indexOfD;
        public string gassensor;
        public int gasvalue;
        public string rfidsensor;
        public int rfidvalue;
        public string nemsensor;
        public int nemvalue;
        public string sıcaksensor;
        public int sıcakvalue;

        public bool dongu = true;
        private static ConnectionUC _instance;
        public static ConnectionUC Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ConnectionUC();
                return _instance;
            }
        }
        public ConnectionUC()
        {
            InitializeComponent();
        }
        
        private void ConnectionUC_Load(object sender, EventArgs e)
        {
            connectOpenbtn.Enabled = true;
            disconnectbtn.Enabled = false;

            progressBar1.Value = 0;
            statuslbl.Text = "DISCONNECTED";
            
            statuslbl.ForeColor = Color.Red;
           
            baudcmb.Text = "9600";
            string[] portLists = SerialPort.GetPortNames();
            comPortcmb.Items.AddRange(portLists);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void connectOpenbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comPortcmb.Text;
                serialPort1.BaudRate = Convert.ToInt32(baudcmb.Text);
                serialPort1.Open();

                connectOpenbtn.Enabled = false;
                disconnectbtn.Enabled = true;

                progressBar1.Value = 100;
                
                statuslbl.Text = "CONNECTED";
               
                
                statuslbl.ForeColor = Color.Green;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void disconnectbtn_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    connectOpenbtn.Enabled = true;
                    disconnectbtn.Enabled = false;

                    progressBar1.Value = 0;
                    statuslbl.Text = "DISCONNECTED";
                    
                    
                    statuslbl.ForeColor = Color.Red;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }

        }

        public void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ProcessData));


        }
        public void ProcessData(object sender, EventArgs e)
        {
            try
            {
                indexOfA = Convert.ToSByte(serialDataIn.IndexOf("A"));
                indexOfB = Convert.ToSByte(serialDataIn.IndexOf("B"));
                indexOfC = Convert.ToSByte(serialDataIn.IndexOf("C"));
                indexOfD = Convert.ToSByte(serialDataIn.IndexOf("D"));

                gassensor = serialDataIn.Substring(0, indexOfA);
                nemsensor = serialDataIn.Substring(indexOfA + 1, (indexOfB- indexOfA) - 1);
                sıcaksensor = serialDataIn.Substring(indexOfB + 1, (indexOfC - indexOfB) - 1);
                rfidsensor = serialDataIn.Substring(indexOfC +1, (indexOfD - indexOfC)-1);
                rfidvalue = Convert.ToInt16(rfidsensor);
                gasvalue = Convert.ToInt16(gassensor);
                nemvalue = Convert.ToInt16(nemsensor);
                sıcakvalue = Convert.ToInt16(sıcaksensor);
                nemvalue = nemvalue * 100 / 1024;
                nemvalue = 100 - nemvalue;
                gasvalue = gasvalue * 100 / 1024;
                sıcakvalue = sıcakvalue / 2;
                gassensorUCcs.veri = Convert.ToString(gasvalue);
                gassensorUCcs.Instance.update_text(sender, e);
                GuestUC.aut1 = rfidvalue;
                GuestUC.Instance.update_rfid(sender,e);
                moistureUC.verinem = Convert.ToString(nemvalue);
                moistureUC.Instance.update1_text(sender,e);
                temperature.val = sıcakvalue;
                temperature.Instance.update_chart(sender,e); 



                






            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }
        public void SendDataGreen(object sender, EventArgs e,string deger)
        {
            if (serialPort1.IsOpen)
            {


                try
                {

                    serialPort1.Write(deger);




                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}