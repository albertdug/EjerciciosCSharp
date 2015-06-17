using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace convertidorGrados
{
    public partial class Form1 : Form
    {
        private TextBox objTextBox = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double grados;
                // Estp valida en que caja de texto se escribio para mandar el resultado a la otra
                if (objTextBox == textBox2)
                {
                    grados = Convert.ToDouble(textBox2.Text) * 9.0 / 5.0 + 32.0;
                    // Como la variable es de tipo double puede arrojar decimales le decimos aqui
                    // que redondee el resultado a unicamente 2 decimales.
                    textBox1.Text = string.Format("{0:F2}", grados);
                }
                if (objTextBox == textBox1)
                {
                    grados = (Convert.ToDouble(textBox1.Text) - 32.0) * 5.0 / 9.0;
                    // Mostrar el resultado redondeado a dos decimales
                    textBox2.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (FormatException)
            {
                textBox2.Text = "0,00";
                textBox1.Text = "32,00";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            objTextBox = (TextBox)sender;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/albertdug/EjerciciosCSharp");
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
                  TextBox ObjTextBox = (TextBox)sender;
                  ObjTextBox.SelectAll();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox ObjTextBox = (TextBox)sender;
            ObjTextBox.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }
    }
}