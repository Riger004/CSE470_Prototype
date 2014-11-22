using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Doctor_s_Form : Form
    {
        DateTime Snooze;

        public Doctor_s_Form(string val)
        {
            InitializeComponent();
            label1.Text = "Welcome Doc "+val+" have a nice time";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_s_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Show();
            comboBox2.Show();
            comboBox3.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                      
            if (DateTime.Now == Snooze)
            {
               
                MessageBox.Show("");
                timer1.Stop(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Snooze = DateTime.Now.AddSeconds(10); ;
           // MessageBox.Show(DateTime.Now + "/n" + Snooze);
            if (DateTime.Now.Equals(Snooze)) 
            {
                MessageBox.Show("ADjalsalj");
            }
            
        }
        }
    }


