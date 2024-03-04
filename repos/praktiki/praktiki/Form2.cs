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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 dld = new Form1();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 dld = new Form3();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 dld = new Form4();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 dld = new Form5();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 dld = new Form7();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 dld = new Form8();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form9 dld = new Form9();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }
    }
}
