using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ReportsApplication1
{
    public partial class Inventario : Form
    {
        System.Data.OleDb.OleDbConnection Enlace;

        public Inventario()
        {
            Enlace = new System.Data.OleDb.OleDbConnection();

            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Enlace.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bd\sm.accdb";
            CenterToScreen();
        }

        private void Buscar()
        {
            Enlace.Open();
            String latira = "select * from inventario where Numero='" + textBox6.Text + "'";
            OleDbCommand comando = new OleDbCommand(latira, Enlace);
            OleDbDataReader DATO = comando.ExecuteReader();
            if (DATO.Read())
                Mostrar(DATO);
            else
            {
                MessageBox.Show("Nuevo registro....");
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;

            }

            Enlace.Close();
        }

        private void Mostrar(OleDbDataReader DATO)
        {
            textBox6.Text = DATO.GetString(0);
            textBox7.Text = DATO.GetString(1);      
            comboBox1.Text = DATO.GetString(2);
            textBox1.Text = DATO.GetString(3);
            int cantidad = DATO.GetInt32(4);
            textBox2.Text = cantidad.ToString();
            textBox3.Text = DATO.GetString(5);
            double monto = DATO.GetDouble(6);
            textBox4.Text = monto.ToString();
            DateTime fecha = DATO.GetDateTime(7);
            textBox5.Text = fecha.ToShortDateString();
            comboBox2.Text = DATO.GetString(8);

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void Limpiar()
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            textBox6.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numerazo;
            Enlace.Open();
            String sql = "select max(Numero) from Inventario";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            OleDbDataReader DATO = comando.ExecuteReader();
            if (DATO.Read())
            {
                numerazo = DATO.GetInt32(0) + 1;
                textBox6.Text = numerazo.ToString();
            }
            else
            {
                numerazo = 0;
                label2.Text = numerazo.ToString();

            }
            Enlace.Close();
            textBox6.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                MessageBox.Show("El Numero de Inventario NO puede estar vacio");
            else if (textBox7.Text == "")
                MessageBox.Show("El Nombre de la Mercancia NO puede estar vacio");
            else if (comboBox1.Text=="")
                MessageBox.Show("El Tipo de Mercancia NO puede estar vacio");
            else if (textBox1.Text == "")
                MessageBox.Show("La Descripción NO puede estar vacia");
            else if (textBox2.Text == "")
                MessageBox.Show("La Cantidad NO puede estar vacia");
            else if (textBox3.Text == "")
                MessageBox.Show("La Marca NO puede estar vacia");
            else if (textBox4.Text == "")
                MessageBox.Show("El Precio NO puede estar vacio");
            else if (textBox5.Text == "")
                MessageBox.Show("La Fecha NO puede estar vacia");
            else if (comboBox2.Text == "")
                MessageBox.Show("El Estado NO puede estar vacio");
            else
            {
                Enlace.Open();
                String sql = "insert into inventario (Numero,nombrem,tipom,descripcion,cantidad,marca,precio,fecha,estado1,estado2) values('" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox2.Text + "','A')";

                OleDbCommand comando = new OleDbCommand(sql, Enlace);
                comando.ExecuteNonQuery();

                MessageBox.Show("inclusion exitosa");

                Enlace.Close();
                Limpiar();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                MessageBox.Show("El Numero de Inventario NO puede estar vacio");
            else if (comboBox1.Text=="")
                MessageBox.Show("El Tipo de Mercancia NO puede estar vacio");
            else if (textBox1.Text == "")
                MessageBox.Show("La Descripción NO puede estar vacia");
            else if (textBox2.Text == "")
                MessageBox.Show("La Cantidad NO puede estar vacia");
            else if (textBox3.Text == "")
                MessageBox.Show("La Marca NO puede estar vacia");
            else if (textBox4.Text == "")
                MessageBox.Show("El Precio NO puede estar vacio");
            else if (textBox5.Text == "")
                MessageBox.Show("La Fecha NO puede estar vacia");
            else if (comboBox2.Text == "")
                MessageBox.Show("El Estado NO puede estar vacio");
            else
            {
                Enlace.Open();
                String sql = "update inventario set nombrem ='" + textBox7.Text + "', tipom ='" + comboBox1.Text + "', descripcion='" + textBox2.Text + "', cantidad='" + textBox2.Text + "', marca='" + textBox3.Text + "',precio='" + textBox4.Text + "',fecha='" + textBox5.Text + "', estado1='" + comboBox2.Text + "' where Numero='" + textBox6.Text + "'";
                OleDbCommand comando = new OleDbCommand(sql, Enlace);
                comando.ExecuteNonQuery();

                MessageBox.Show("modificacion  exitosa");

                Enlace.Close();
                Limpiar();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
                MessageBox.Show("El Numero de Inventario NO puede estar vacio");
            else if (comboBox1.Text=="")
                MessageBox.Show("El Tipo de Mercancia NO puede estar vacio");
            else if (textBox1.Text == "")
                MessageBox.Show("La Descripción NO puede estar vacia");
            else if (textBox2.Text == "")
                MessageBox.Show("La Cantidad NO puede estar vacia");
            else if (textBox3.Text == "")
                MessageBox.Show("La Marca NO puede estar vacia");
            else if (textBox4.Text == "")
                MessageBox.Show("El Precio NO puede estar vacio");
            else if (textBox5.Text == "")
                MessageBox.Show("La Fecha NO puede estar vacia");
            else if (comboBox2.Text == "")
                MessageBox.Show("El Estado NO puede estar vacio");
            else
            {
                Enlace.Open();
                String sql = "delete * from inventario where Numero='" + textBox6.Text + "'";
                OleDbCommand comando = new OleDbCommand(sql, Enlace);
                comando.ExecuteNonQuery();

                MessageBox.Show("eliminacion  exitosa");

                Enlace.Close();
                Limpiar();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}
