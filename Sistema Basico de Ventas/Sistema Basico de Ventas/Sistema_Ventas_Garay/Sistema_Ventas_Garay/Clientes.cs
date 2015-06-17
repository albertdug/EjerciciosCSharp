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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        void insertaclientes()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("No Deje Campos Vacios", "Advertencia");
                textBox1.Focus();
            }
            else
            {
                SqlCommand comando = new SqlCommand("insert into clientes(codcliente, nombres,pedido)values(@codcliente,@nombres,@pedido)", Conexion.obtenerconexion());
                comando.Parameters.AddWithValue("codcliente", textBox1.Text);
                comando.Parameters.AddWithValue("nombres", textBox2.Text);
                comando.Parameters.AddWithValue("pedido", textBox3.Text);
                Conexion.obtenerconexion();

                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado Satisfactoriamente", "Sistema Garay Ventas PC");
            }
        }

        void mostrarclientes()
        {
            SqlCommand comando = new SqlCommand("select * from clientes", Conexion.obtenerconexion());
            Conexion.obtenerconexion();

            SqlDataReader leer = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            int renglon = 0;
            while (leer.Read())
            {
                renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["codcliente"].Value = leer.GetString(0);
                dataGridView1.Rows[renglon].Cells["nombres"].Value = leer.GetString(1);
                dataGridView1.Rows[renglon].Cells["pedido"].Value = leer.GetString(2);
            }
            Conexion.obtenerconexion().Close();
        }

        private void Clientes_Load(object sender, EventArgs e)
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
            insertaclientes();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mostrarclientes();
        }

        private void button4_Click(object sender, EventArgs e)
        {
              //ELIMINAR
            DialogResult resultado = MessageBox.Show("¿Estas Seguro de Eliminar el Registro Seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            SqlCommand comando = new SqlCommand("delete from clientes where codcliente=@codcliente", Conexion.obtenerconexion());
            comando.Parameters.AddWithValue("codcliente", dataGridView1.CurrentRow.Cells["codcliente"].Value);
            comando.ExecuteNonQuery();
            Conexion.obtenerconexion().Close();
            MessageBox.Show("Registro Eliminado Satisfactoriamente", "Sistema");

            mostrarclientes();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        }
    }

