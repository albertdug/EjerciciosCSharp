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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

       
        void insertausuarios()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("No Deje Campos Vacios", "Advertencia");
                textBox1.Focus();
            }
            else
            {
                SqlCommand comando = new SqlCommand("insert into Usuarios(Usuario, contraseña)values(@Usuario,@contraseña)", Conexion.obtenerconexion());
                comando.Parameters.AddWithValue("Usuario", textBox1.Text);
                comando.Parameters.AddWithValue("contraseña", textBox2.Text);
                Conexion.obtenerconexion();

                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado Satisfactoriamente", "Sistema");
            }
        }

        
        void mostrarusuarios()
        {
            SqlCommand comando = new SqlCommand("select * from Usuarios", Conexion.obtenerconexion());
            Conexion.obtenerconexion();

            SqlDataReader leer = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            int renglon = 0;
            while (leer.Read())
            {
                renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["Usuario"].Value = leer.GetString(0);
                dataGridView1.Rows[renglon].Cells["contraseña"].Value = leer.GetString(1);
            }
            Conexion.obtenerconexion().Close();
        }
 

      

        private void button1_Click(object sender, EventArgs e)
        {
            insertausuarios();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrarusuarios();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
