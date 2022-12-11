using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ПРОЕКТPROGECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void buttonumnozit_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void buttonrazdelit_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void buttonclean_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void buttonrowno_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("+"))
            {
                string[] s = textBox1.Text.Split('+');
                float x = Convert.ToSingle(s[0]);
                float y = Convert.ToSingle(s[1]);
                float z = x + y;
                textBox1.Text = z.ToString();
            }
            else if (textBox1.Text.Contains("-"))
            {
                string[] s = textBox1.Text.Split('-');
                float x = Convert.ToSingle(s[0]);
                float y = Convert.ToSingle(s[1]);
                float z = x - y;
                textBox1.Text = z.ToString();
            }
            else if (textBox1.Text.Contains("*"))
            {
                string[] s = textBox1.Text.Split('*');
                float x = Convert.ToSingle(s[0]);
                float y = Convert.ToSingle(s[1]);
                float z = x * y;
                textBox1.Text = z.ToString();
            }
            else if (textBox1.Text.Contains("/"))
            {
                string[] s = textBox1.Text.Split('/');
                float x = Convert.ToSingle(s[0]);
                float y = Convert.ToSingle(s[1]);
                float z = x / y;
                textBox1.Text = z.ToString();
            }
            else if (textBox1.Text.Contains("^"))
            {
                string[] s = textBox1.Text.Split('^');
                float x = Convert.ToSingle(s[0]);
                float y = Convert.ToSingle(s[1]);
                double z = Math.Pow(x, y);
                textBox1.Text = z.ToString();

            }
        }

        private void buttonprocent_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            float w = Convert.ToSingle(s);
            float h = w / 100;
            textBox1.Text = h.ToString();
        }

        private void buttonkoren_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            float w = Convert.ToSingle(s);
            double k = Math.Sqrt(w);
            textBox1.Text = k.ToString();
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            float w = Convert.ToSingle(s);
            float c = w - (2 * w);
            float k = -w;
            if (w > 0)
            {
                textBox1.Text = c.ToString();
            }
            else if (w == 0)
            {
                textBox1.Text = w.ToString();
            }
            else if (w < 0)
            {
                textBox1.Text = k.ToString();
            }
        }

        private void buttonkwadrat_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            float w = Convert.ToSingle(s);
            float z = w * w;
            textBox1.Text = z.ToString();
        }

        private void buttonkub_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            float w = Convert.ToSingle(s);
            float z = w * w * w;
            textBox1.Text = z.ToString();
        }

        private void buttonxwstepeniy_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "^";
        }

        private void buttonPI_Click(object sender, EventArgs e)
        {
            double s = Math.PI;
            textBox1.Text = s.ToString();
        }

        private void buttonlog2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            float w = Convert.ToSingle(s);
            double c = Math.Log(w, 2);
            textBox1.Text = c.ToString();
        }

        private void buttonlog3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            float w = Convert.ToSingle(s);
            double c = Math.Log(w, 3);
            textBox1.Text = c.ToString();
        }
    }
}
