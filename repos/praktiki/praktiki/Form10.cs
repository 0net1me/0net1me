using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace praktiki
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(ofd.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            ofd.Dispose();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 dld = new Form9();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();

            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox3.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n', '\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox1.Checked = true;
            radioButton1.Checked = true;
            listBox1.Items.Clear();
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Clear();
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;
            if (checkBox1.Checked)
            {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form11 AddRec = new Form11();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Алфавиту (по возрастанию)")
            {
                List<String> list = new List<String>();
                foreach (var item in listBox1.Items)
                    list.Add(item.ToString());
                list.Sort();
                listBox1.Items.Clear();
                foreach (var item in list)
                    listBox1.Items.Add(item);
            }

            if (comboBox1.Text == "Алфавиту (по убыванию)")
            {
                List<String> list = new List<String>();
                foreach (var item in listBox1.Items)
                    list.Add(item.ToString());
                list.Sort();
                list.Reverse();
                listBox1.Items.Clear();
                foreach (var item in list)
                    listBox1.Items.Add(item);
            }

            if (comboBox1.Text == "Длине слова (по возрастанию)")
            {
                List<String> list = new List<string>();
                foreach (var item in listBox1.Items)
                    list.Add(item.ToString());
                listBox1.Items.Clear();
                var sortResult = list.OrderBy(x => x.Length);
                foreach (var item in sortResult)
                    listBox1.Items.Add(item);
            }

            if (comboBox1.Text == "Длине слова (по убыванию)")
            {
                List<String> list = new List<string>();
                foreach (var item in listBox1.Items)
                    list.Add(item.ToString());
                listBox1.Items.Clear();
                var sortResult = list.OrderByDescending(x => x.Length);
                foreach (var item in sortResult)
                    listBox1.Items.Add(item);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Алфавиту (по возрастанию)")
            {
                List<String> list = new List<String>();
                foreach (var item in listBox2.Items)
                    list.Add(item.ToString());
                list.Sort();
                listBox2.Items.Clear();
                foreach (var item in list)
                    listBox2.Items.Add(item);
            }

            if (comboBox2.Text == "Алфавиту (по убыванию)")
            {
                List<String> list = new List<String>();
                foreach (var item in listBox2.Items)
                    list.Add(item.ToString());
                list.Sort();
                list.Reverse();
                listBox2.Items.Clear();
                foreach (var item in list)
                    listBox2.Items.Add(item);
            }

            if (comboBox2.Text == "Длине слова (по возрастанию)")
            {
                List<String> list = new List<string>();
                foreach (var item in listBox2.Items)
                    list.Add(item.ToString());
                listBox2.Items.Clear();
                var sortResult = list.OrderBy(x => x.Length);
                foreach (var item in sortResult)
                    listBox2.Items.Add(item);
            }

            if (comboBox2.Text == "Длине слова (по убыванию)")
            {
                List<String> list = new List<string>();
                foreach (var item in listBox2.Items)
                    list.Add(item.ToString());
                listBox2.Items.Clear();
                var sortResult = list.OrderByDescending(x => x.Length);
                foreach (var item in sortResult)
                    listBox2.Items.Add(item);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form9 dld = new Form9();
            dld.StartPosition = FormStartPosition.Manual;
            dld.Location = new Point(100, 100);
            dld.Show(this);
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создатель: Абрамов Кирилл Алексеевич. Версмя: 001", "Информация о приложении");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.BeginUpdate();
            foreach (object Item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(Item);
            }
            listBox2.EndUpdate();
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.BeginUpdate();
            foreach (object Item in listBox2.SelectedItems)
            {
                listBox1.Items.Add(Item);
            }
            listBox1.EndUpdate();

            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }
    }
}

                    
    


   
