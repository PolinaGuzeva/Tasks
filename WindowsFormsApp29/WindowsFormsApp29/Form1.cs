using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[] b = new int[100];

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                b[i] = rand.Next(0, 100);
                textBox1.Text += " " + b[i];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int result = 0;
            for (int i = 1; i < 100; i++)
            {
                if (b[i - 1] == b[i])

                    result++;
            }

            textBox2.Text += " " + Convert.ToString(result);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        { 
           

        }
    }
}
