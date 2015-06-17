using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace proveedorErrores
{
    public partial class Form1 : Form
    {
        private double datoTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            linkLabel1.Links.Add(0, linkLabel1.Text.Length, "https://github.com/albertdug/EjerciciosCSharp");
        }

        private void CajaTexto_Validating(object sender, CancelEventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            try
            {
                datoTextBox = Convert.ToDouble(objTextBox.Text);
            }
            catch (Exception)
            {
                e.Cancel = true;
                textBox1.SelectAll();
                proveedorError.SetError(objTextBox, "Tiene que ser numérico");
            }
        }
        private void CajaTexto_Validated(object sender, EventArgs e)
        {
            Debug.WriteLine("Caja de texto validada");
            proveedorError.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(e.Link.LinkData.ToString());
            Process.Start(sInfo);
        }
    }
}