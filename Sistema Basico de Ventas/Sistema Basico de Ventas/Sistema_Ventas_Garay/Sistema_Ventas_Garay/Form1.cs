using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Ventas_Garay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion.obtenerconexion();
            SqlCommand consulta = new SqlCommand("select * from Usuarios where Usuario='" + txtusu.Text + "'and contraseña='" + txtpass.Text + "'", Conexion.obtenerconexion());
            SqlDataReader ejecuta = consulta.ExecuteReader();


            if (ejecuta.Read() == true)
            {
                MessageBox.Show("Bienvenido: " + txtusu.Text, "Sistema");
                this.Hide();
                Sistema abrir = new Sistema();
                abrir.Show();
            }
            else if (txtusu.Text == "")
            {
                MessageBox.Show("No deje Campos Vacios", "Acceso Denegado");
                txtpass.Clear();
                txtusu.Clear();
                txtusu.Focus();
                Conexion.obtenerconexion().Close();
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("No deje Campos Vacios", "Acceso Denegado");
                txtusu.Clear();
                txtpass.Clear();
                txtusu.Focus();
                Conexion.obtenerconexion().Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta - Ingrese Datos Otra vez", "Acceso Denegado");
                txtusu.Clear();
                txtpass.Clear();
                txtusu.Focus();
                Conexion.obtenerconexion().Close();
            }
            
        }
    }
}
