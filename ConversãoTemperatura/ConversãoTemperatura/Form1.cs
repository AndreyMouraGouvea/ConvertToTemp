using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversãoTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fah_Click(object sender, EventArgs e)
        {
            double f = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((f * 1.8 + 32));
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kel_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((k + 273.15));
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(((c - 32) * 5/9));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ke = Convert.ToDouble(textBox3.Text);
            textBox4.Text = Convert.ToString(((ke - 32) * 5/9 + 273.15));
            //variavel.ToString("0.00")
        }
    }
}
