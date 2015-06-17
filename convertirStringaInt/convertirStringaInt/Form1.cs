using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertirStringaInt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int v1, v2;
                double resultado;
                v1 = Convert.ToInt32(textBox1.Text);
                v2 = Convert.ToInt32(textBox2.Text);
                resultado = v1 + v2;
                label2.Text = Convert.ToString(resultado);
            }
            catch { MessageBox.Show("Debe indicar ambos valores y asegurese que sean valores numericos"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int v1, v2;
                double resultado;
                v1 = Convert.ToInt32(textBox1.Text);
                v2 = Convert.ToInt32(textBox2.Text);
                resultado = v1 - v2;
                label2.Text = Convert.ToString(resultado);
            }
            catch { MessageBox.Show("Debe indicar ambos valores y asegurese que sean valores numericos"); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int v1, v2;
                double resultado;
                v1 = Convert.ToInt32(textBox1.Text);
                v2 = Convert.ToInt32(textBox2.Text);
                resultado = v1 * v2;
                label2.Text = Convert.ToString(resultado);
            }
            catch { MessageBox.Show("Debe indicar ambos valores y asegurese que sean valores numericos"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int v1, v2;
                double resultado;
                v1 = Convert.ToInt32(textBox1.Text);
                v2 = Convert.ToInt32(textBox2.Text);
                resultado = v1 / v2;
                label2.Text = Convert.ToString(resultado);
            }
            catch { MessageBox.Show("Debe indicar ambos valores y asegurese que sean valores numericos"); }
        }

    }
}
