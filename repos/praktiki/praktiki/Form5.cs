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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
            button1.Hide();
            button2.Visible = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 40;
            button2.Hide();
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 60;
            button3.Hide();
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 80;
            button4.Hide();
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            button5.Hide();
            button5.Visible = false;
            Form6 dld = new Form6();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }
    }
}
