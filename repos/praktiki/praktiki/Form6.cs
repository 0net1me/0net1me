using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktiki
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            timer1.Interval = 500;
            timer1.Enabled = false;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            
        }

        private void t_tick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();
            MessageBox.Show("ОТЧИСЛЕН");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            Timer t = new Timer();
            t.Interval = 5000;
            t.Tick += new EventHandler(t_tick);
            t.Start();
        }
    }
}

