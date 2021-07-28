using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public double cüzdan =0;
        public double kola = 2.5;
        public double fanta = 2.5;
        public double su = 1;
        public double gofret = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {

            textBox2.Text = textBox1.Text;
            cüzdan = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cüzdan >= kola)
            {
                cüzdan = cüzdan - kola;
                textBox2.Text = Convert.ToString(cüzdan);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (cüzdan >= fanta)
            {
                cüzdan = cüzdan - fanta;
                textBox2.Text = Convert.ToString(cüzdan);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cüzdan >= su)
            {
                cüzdan = cüzdan - su;
                textBox2.Text = Convert.ToString(cüzdan);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cüzdan >= gofret)
            {
                cüzdan = cüzdan - gofret;
                textBox2.Text = Convert.ToString(cüzdan);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            cüzdan = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
