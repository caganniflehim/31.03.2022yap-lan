using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31._03._2022yapılan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add("çağan demirkıran");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <=100; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==1)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int  i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%5==0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 100; i >= 1; i--)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                toplam += i;
            }
            textBox1.Text = toplam.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox2.Text);
            int toplam = 0;
            for (int i = 0; i <= sayi; i++)
            {
                toplam += i;
            }
            textBox3.Text = toplam.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            char i;
            for ( i = 'A'; i <= 'Z'; i++)
            {
                listBox1.Items.Add(i);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox4.Text);
            int fak = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            textBox5.Text = fak.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10 ; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    listBox1.Items.Add(i + "x" + j + "=" + i * j);
                }
                listBox1.Items.Add("------------------------");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.Items.Count-1; i >= 0; i--)
            {
                if (Convert.ToInt16(listBox2.Items[i])%2==0)
                {
                    listBox3.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                listBox2.Items.Add(rnd.Next(10, 100));
            }
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                listBox3.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = listBox2.Items.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt16(listBox2.Items[i]) % 2 == 1)
                {
                    listBox3.Items.Add(listBox2.Items[i]);
                    listBox2.Items.Remove(listBox2.Items[i]);
                }
            }
        }
    }
}
