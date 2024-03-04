using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace praktiki
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w, h, sum;
            double cena = 0;
            w = Convert.ToDouble(textBox1.Text); h = Convert.ToDouble(textBox2.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    cena = 100; break;
                case 1:
                    cena = 250; break;
                case 2:
                    cena = 170; break;
                case 3:
                    cena = 170; break;
                case 4:
                    cena = 120; break;
            }
            sum = (w * h) / 10000 * cena;
            label4.Text = "Размер: " + w + "x" + h + "см.\n" + "Цена (р./м.кв.):" + cena.ToString("c") + "\nСумма:" + sum.ToString("c");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        textBox2.Focus();
                    else;
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9')) return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (sender.Equals(textBox1))
                        textBox2.Focus();
                    else;
                }
                return;
            }
            e.Handled = true;
        }
    }
}
            
        
        
        
       

