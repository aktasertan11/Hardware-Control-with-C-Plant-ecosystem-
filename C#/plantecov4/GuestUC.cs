using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace plantecov4
{
    public partial class GuestUC : UserControl
    {
        public static int aut1= 0;
        public static int aut = 0;
        public bool con_aut = false;
        private static GuestUC _instance;
        public static GuestUC Instance

        {
            get
            {
                if (_instance == null)
                    _instance = new GuestUC();
                return _instance;
            }
        }
        public GuestUC()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti =new OleDbConnection ("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\aktas\\OneDrive\\Masaüstü\\plantecov4\\songuests2.mdb");
        OleDbCommand komut = new OleDbCommand();
        private void verilerigoruntule()
        {
                

                listView1.Items.Clear();
                // baglanti.Open();
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglanti;
                komut.CommandText = ("Select * From Guests");
                OleDbDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["ID"].ToString();
                    ekle.SubItems.Add(oku["Name"].ToString());
                    ekle.SubItems.Add(oku["Color"].ToString());
                    ekle.SubItems.Add(oku["Situation"].ToString());

                listView1.Items.Add(ekle);

                }
                baglanti.Close();
            
        }
        
        public void update_rfid(object sender, EventArgs e)
        {
            aut = aut1;
            if(aut ==1)
            {
                con_aut = true;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

            ConnectionUC.Instance.SendDataGreen(sender, e, "4#");
            if (con_aut)
            {
                //MessageBox.Show("The Connection to database is OK", "Authorization Process...", MessageBoxButtons.OK,
                // MessageBoxIcon.Asterisk);
                try
                  {
                      baglanti.Open();
                       MessageBox.Show("The Connection to database is OK", "Connection Process...", MessageBoxButtons.OK,
                       MessageBoxIcon.Asterisk);
                      verilerigoruntule();
                    }
                  catch (Exception ex)
                    {
                        MessageBox.Show("The Connection is FAILED", "Connection Process..", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        MessageBox.Show("The Error: " + ex.ToString(), "Connection Process", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                         DialogResult res = MessageBox.Show("Do You want to TRY again", "Connection Pocess",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (res.ToString() == "Yes") { button1.PerformClick(); }
                        else
                         {
                         MessageBox.Show("Enter please OK to QUIT the program...", "Connection Process...",
                         MessageBoxButtons.OK, MessageBoxIcon.Stop);
                         baglanti.Close();
                         
                         }
                    }
            }
            else
            {
                DialogResult res = MessageBox.Show("Your acces is not allowed.Do You want to TRY Authorization", "Authorization Pocess",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res.ToString() == "Yes") { button1.PerformClick(); }
                else
                {
                    MessageBox.Show("Enter please OK to QUIT the program...", "Authorization Process...",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    baglanti.Close();
                }
            }
           
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            if (con_aut)
            {
                if (textBox4.Text.All(char.IsDigit))
                {
                    baglanti.Open();

                    OleDbCommand komut = new OleDbCommand("insert into Guests (id,Name,Color,Situation) values ('" + textBox4.Text.ToString() + "','" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "')", baglanti);



                    try
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("New Record is successfully inserted into DATABASE");
                        //baglanti.Close();
                        verilerigoruntule();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The Error: " + ex.ToString(), "Inserting Process...",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();
                    }

                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                }
                else
                {
                    MessageBox.Show("Please Enter A numeric Value in ID part", "Try Again",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Your acces is not allowed. Do You want to TRY Authorization", "Authorization Pocess",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res.ToString() == "Yes") { button1.PerformClick(); }
                else
                {
                    MessageBox.Show("Enter please OK to QUIT the program...", "Authorization Process...",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    baglanti.Close();
                }

            }


        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GuestUC_Load(object sender, EventArgs e)
        {
            this.Invoke(new EventHandler(update_rfid));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(con_aut)
            {
                DialogResult res = MessageBox.Show("Do You Want to Delete The Selected Record", "DeletingProcess", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res.ToString() == "Yes")
                {
                    baglanti.Open();
                    komut.Connection = baglanti;
                    komut.CommandText = "delete from Guests where id =" +textBox4.Text+ "";
                    komut.ExecuteNonQuery();
                    verilerigoruntule();
                   
                }
                else
                {
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                   
                    button1.PerformClick();
                }
            }

            else
            {
                DialogResult res = MessageBox.Show("Your acces is not allowed. Do You want to TRY Authorization", "Authorization Pocess",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res.ToString() == "Yes") { button1.PerformClick(); }
                else
                {
                    MessageBox.Show("Enter please OK to QUIT the program...", "Authorization Process...",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    baglanti.Close();
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update Guests set Name='"+textBox1.Text+"',Color='"+textBox2.Text+"',Situation='" +textBox3.Text+"'where id ="+textBox4.Text+ "";
            komut.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            
            verilerigoruntule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(con_aut))
            {
               
                ConnectionUC.Instance.SendDataGreen(sender, e, "4#");
                DialogResult res = MessageBox.Show("Your acces is not allowed. Do You want to TRY Authorization", "Authorization Pocess",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res.ToString() == "Yes") { button1.PerformClick(); }
                else
                {
                    MessageBox.Show("Enter please OK to QUIT the program...", "Authorization Process...",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    baglanti.Close();
                }

            }
            else
            {
                MessageBox.Show("Authorization Completed", "Authorization OK",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con_aut = false;
            listView1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            ConnectionUC.Instance.SendDataGreen(sender, e, "1#");
        }
    }
}
