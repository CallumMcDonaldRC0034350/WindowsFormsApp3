using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int i1 = 3 * 4;
            int i2 = 3 * 4;
            int i3 = 3 * 4;
            int i4 = 3 * 4;
            int i5 = 3 * 4;
            int i6 = 3 * 4;
            double d1 = 3.1 * 2.3;
            double d2 = 1.0 / 3.0;
            double d3 = 1 / 3;

            richTextBox1.AppendText(i1 + "\n" + i2 + "\n" + i3 + "\n" +
                14 + "\n" + i5 + "\n" + i6 + "\n");
            richTextBox1.AppendText(d1 + "\n" + d2 + "\n" + d3 + "\n");

            richTextBox1.AppendText(Math.Pow(27, 1.0 / 3.0 ) + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double d = Convert.ToDouble(textBox1.Text);
                double cuberoot = Math.Pow(d, 1.0 / 3.0);
                label1.Text = cuberoot.ToString();
            }
            catch
            {
                label1.Text = " Not a number";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
