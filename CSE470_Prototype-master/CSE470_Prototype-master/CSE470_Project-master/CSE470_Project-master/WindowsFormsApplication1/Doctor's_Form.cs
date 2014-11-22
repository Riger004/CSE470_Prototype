using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Doctor_s_Form : Form
    {
        DateTime Snooze;
        private Timer tm;
        public Doctor_s_Form(string val)
        {
            InitializeComponent();
            label1.Text = "Welcome Doc " + val + " have a nice time";
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

            tm.Stop();
            MessageBox.Show("asdjad");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tm = new Timer();
            tm.Interval = 1 * 1000; // 10 seconds
            tm.Tick += new EventHandler(timer1_Tick);
            tm.Start();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}