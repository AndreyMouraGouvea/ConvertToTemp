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
            MessageBox.Show("Fahrenheit: "+ textBox2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void kel_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox1.Text);
            textBox2.Text = Convert.ToString((k + 273.15));
            MessageBox.Show("Kelvin: " + textBox2);
        }
    }
}
