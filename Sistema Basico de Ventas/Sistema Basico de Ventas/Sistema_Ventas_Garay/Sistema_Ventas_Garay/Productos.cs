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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }


        void insertaproductos()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("No Deje Campos Vacios", "Advertencia");
                textBox1.Focus();
            }
            else
            {
                SqlCommand comando = new SqlCommand("insert into productos(codproducto, nombreproducto,precio)values(@codproducto,@nombreproducto,@precio)", Conexion.obtenerconexion());
                comando.Parameters.AddWithValue("codproducto", textBox1.Text);
                comando.Parameters.AddWithValue("nombreproducto", textBox2.Text);
                comando.Parameters.AddWithValue("precio", textBox3.Text);
                Conexion.obtenerconexion();

                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado Satisfactoriamente.", "Sistema Garay Ventas PC");
            }
        }

        void mostrarproductos()
        {
            SqlCommand comando = new SqlCommand("select * from Productos", Conexion.obtenerconexion());
            Conexion.obtenerconexion();

            SqlDataReader leer = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            int renglon = 0;
            while (leer.Read())
            {
                renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["codproducto"].Value = leer.GetString(0);
                dataGridView1.Rows[renglon].Cells["nombreproducto"].Value = leer.GetString(1);
                dataGridView1.Rows[renglon].Cells["precio"].Value = leer.GetString(2);
            }
            Conexion.obtenerconexion().Close();
        }





        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            insertaproductos();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarproductos();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            DialogResult resultado = MessageBox.Show("¿Estas Seguro de Eliminar el Registro Seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            SqlCommand comando = new SqlCommand("delete from productos where codproducto=@codproducto", Conexion.obtenerconexion());
            comando.Parameters.AddWithValue("codproducto", dataGridView1.CurrentRow.Cells["codproducto"].Value);
            comando.ExecuteNonQuery();
            Conexion.obtenerconexion().Close();
            MessageBox.Show("Registro Eliminado Satisfactoriamente", "Sistema");

            mostrarproductos();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;

           
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
