using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Ventas_Garay
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios Usuarios = new Usuarios();
            Usuarios.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Productos Productos = new Productos();
            Productos.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clientes Clientes = new Clientes();
            Clientes.Show();
        }
    }
}
