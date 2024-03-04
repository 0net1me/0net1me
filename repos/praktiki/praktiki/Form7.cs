using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktiki
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum;
            int period;

            double percent;
            double profit;

            sum = System.Convert.ToDouble(textBox1.Text);
            period = System.Convert.ToInt32(textBox2.Text);

            if (sum < 10000)
                percent = 8.5;

            else
                percent = 12;

            profit = sum * (percent / 100 / 12) * period;

            label3.Text = "Процентная ставка:" + percent.ToString("n") + "%\n" + "Доход:" + profit.ToString("c");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 dld = new Form2();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }
    }
}
