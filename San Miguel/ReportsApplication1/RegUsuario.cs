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
    public partial class RegUsuario : Form
    {
        System.Data.OleDb.OleDbConnection Enlace;

        public RegUsuario()
        {
            
            Enlace = new System.Data.OleDb.OleDbConnection();

            InitializeComponent();
        }

        private void RegUsuario_Load(object sender, EventArgs e)
        {
            Enlace.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bd\sm.accdb";
            
            CenterToScreen();
        }

        private void Mostrar(OleDbDataReader DATO)
        {
            textBox1.Text = DATO.GetString(0);
            textBox2.Text = DATO.GetString(1);
            comboBox1.Text = DATO.GetString(2);

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            button1.Enabled = true;
        }

        private void Buscar()
        {
            Enlace.Open();
            String sql = "select * from Usuarios where usuario='" + textBox1.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            OleDbDataReader DATO = comando.ExecuteReader();
            if (DATO.Read())
            {
                Mostrar(DATO);
                textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nuevo registro..");
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;

            }
            Enlace.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "insert into Usuarios (Usuario,Clave,nivel,estatusu) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','A')";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("inclusion exitosa");

            Enlace.Close();
            Limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "update Usuarios set Clave ='" + textBox2.Text + "', nivel='" + comboBox1.Text + "' where usuario='" + textBox1.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("modificacion  exitosa");

            Enlace.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "delete * from Usuarios where usuario='" + textBox1.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("eliminacion  exitosa");

            Enlace.Close();
        }
    }
}
