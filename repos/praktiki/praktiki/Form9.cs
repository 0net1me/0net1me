﻿using System;
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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 dld = new Form2();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 dld = new Form10();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 dld = new Form12();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }
    }
}
