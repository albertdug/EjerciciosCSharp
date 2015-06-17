using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace controlesCBRBLB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            if (radioButton1.Checked) label3.Text = "Hombre";
            if (radioButton2.Checked) label3.Text = "Mujer";
            if (checkBox1.Checked) label4.Text = checkBox1.Text;
            if (checkBox2.Checked) label4.Text = checkBox2.Text;
            if (checkBox3.Checked) label4.Text = checkBox3.Text;               
        }
    }
}