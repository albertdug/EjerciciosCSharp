using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace formasdeMostrarMensajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Mostrando un Mensaje por Medio de un Label";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un Ejemplo de Mensaje usando MessageBox");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Esta es Otra manera de Enviar texto a un control";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/albertdug/EjerciciosCSharp");
        }

    }
}