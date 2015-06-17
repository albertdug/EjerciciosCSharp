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
    public partial class cheques : Form
    {

        System.Data.OleDb.OleDbConnection Enlace;

        public cheques()
        {
            Enlace = new System.Data.OleDb.OleDbConnection();
            InitializeComponent();
        }

        private void cheques_Load(object sender, EventArgs e)
        {

            Enlace.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bd\sm.accdb";
            String sql = "SELECT * FROM  tipob ";
            Enlace.Open();

            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            OleDbDataReader DATO = comando.ExecuteReader();
            while (DATO.Read())
            {

                comboBox1.Items.Add(DATO.GetString(0));

            }

            Enlace.Close();
            CenterToScreen();
        }

        private void Mostrar(OleDbDataReader DATO)
        {
            textBox6.Text = DATO.GetString(0);
            comboBox1.Text = DATO.GetString(1);
            double monto = DATO.GetDouble(2);
            textBox3.Text = monto.ToString();
            textBox4.Text = DATO.GetString(3);
            DateTime fecha = DATO.GetDateTime(4);
            textBox5.Text = fecha.ToShortDateString();


            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void Limpiar()
        {
            textBox6.Text = "";
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Buscar()
        {
            Enlace.Open();
            String latira = "select * from banco where numerob='" + textBox6.Text + "'";
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

        private void button5_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "insert into banco (numerob,banco,montob,nombre,fechab,estatus) values('" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','A')";

            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();


            MessageBox.Show("inclusion exitosa");

            Enlace.Close();
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "update banco set banco ='" + comboBox1.Text + "', montob='" + textBox3.Text + "', nombre='" + textBox4.Text + "',fechab='" + textBox5.Text + "' where numerob='" + textBox6.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("modificacion  exitosa");

            Enlace.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "delete * from banco where numerob='" + textBox6.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("eliminacion  exitosa");

            Enlace.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
