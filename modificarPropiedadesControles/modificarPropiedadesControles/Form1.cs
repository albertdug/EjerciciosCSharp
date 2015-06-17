using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace modificarPropiedadesControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.ForeColor = System.Drawing.Color.FromName(comboBox1.Text);
            }
            catch { MessageBox.Show ("Debe seleccionar un color de la lista");}
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.BackColor = System.Drawing.Color.FromName(comboBox1.Text);
            }
            catch { MessageBox.Show("Debe seleccionar un color de la lista"); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/albertdug/EjerciciosCSharp");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }
    }
}