using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_release
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.Font = new Font("Arial", 12);
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            comboBox1.SelectedIndex = 0;
            pictureBox1.Image = Image.FromFile(path + "Init.jpg");
            InitButton(false);
        }

        Class1 a = new Class1();
        Class2 b = new Class2();
        int count_c = 0;
        int count_i = 0;
        string path = "Icons\\";

        void SetButton(bool enabled)
        {
            for (int i = 2; i < 35; i++)
            {
                Controls["button" + i].Enabled = enabled;
                Controls["button" + i].BackColor = DefaultBackColor;
            }
        }

        void InitButton(bool value)
        {
            pictureBox1.Enabled = value;
            button1.Enabled = !value;
            comboBox1.Enabled = !value;
            SetButton(value);
        }

        void CharLose(Control control)
        {
            control.BackColor = Color.Red;
            count_i++;
            pictureBox1.Image = Image.FromFile(path + count_i.ToString() + ".jpg");
            if (count_i == 10)
            {
                pictureBox1.Image = Image.FromFile(path + "Lose.jpg");
                InitButton(false);
                for (int i = 0; i < count_c; i++)
                    dataGridView1.Rows[0].Cells[i].Value = a.word1[i];
            }
        }

        void CharWin(Control control)
        {
            control.BackColor = Color.Green;
            char[] c = a.word2.ToCharArray();
            for (int i = 0; i < count_c; i++)
            {
                dataGridView1.Rows[0].Cells[i].Value = c[i].ToString();
            }

            if (a.word2.IndexOf(' ') == -1)
            {
                pictureBox1.Image = Image.FromFile(path + "Win.jpg");
                InitButton(false);
            }
        }

        void Check(Control control, char let)
        {
            a.getWord(let);
            if (a.rx())
            {
                CharWin(control);
            }
            else
            {
                CharLose(control);
            }
            control.Enabled = false;
            dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count_i = 4;
            dataGridView1.Columns.Clear();
            a.setWord(b.choosing_word(comboBox1.SelectedIndex + 1));
            pictureBox1.Image = Image.FromFile(path + "4.jpg");
            count_c = a.word1.Length;
            dataGridView1.RowCount = 1;
            char[] c = a.word2.ToCharArray();
            for (int i = 0; i < count_c - 1; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                dataGridView1.Rows[0].Cells[i].Value = c[i].ToString();
            }
            dataGridView1.ClearSelection();
            InitButton(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check(button2, '�');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check(button3, '�');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Check(button4, '�');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Check(button5, '�');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Check(button6, '�');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Check(button7, '�');
            button8.Enabled = false;
            button8.BackColor = button7.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Check(button8, '�');
            button7.Enabled = false;
            button7.BackColor = button8.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Check(button9, '�');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Check(button10, '�');
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Check(button11, '�');
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Check(button12, '�');
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Check(button13, '�');
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Check(button14, '�');
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Check(button15, '�');
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Check(button16, '�');
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Check(button17, '�');
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Check(button18, '�');
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Check(button19, '�');
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Check(button20, '�');
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Check(button21, '�');
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Check(button22, '�');
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Check(button23, '�');
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Check(button24, '�');
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Check(button25, '�');
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Check(button26, '�');
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Check(button26, '�');
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Check(button28, '�');
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Check(button29, '�');
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Check(button30, '�');
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Check(button31, '�');
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Check(button32, '�');
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Check(button33, '�');
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Check(button34, '�');
        }
    }
}
