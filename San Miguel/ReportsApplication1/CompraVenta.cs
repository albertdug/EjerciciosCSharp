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
    public partial class CompraVenta : Form
    {
        System.Data.OleDb.OleDbConnection Enlace;

        public CompraVenta()
        {
            Enlace = new System.Data.OleDb.OleDbConnection();
            InitializeComponent();
        }

        private void CompraVenta_Load(object sender, EventArgs e)
        {
            Enlace.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bd\sm.accdb";
            CenterToScreen();
            String sql = "SELECT * FROM  inventario ";
            Enlace.Open();

            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            OleDbDataReader DATO = comando.ExecuteReader();
            while (DATO.Read())
            {
                comboBox2.Items.Add(DATO.GetString(1));
            }

            Enlace.Close();
        }

        private void Mostrar(OleDbDataReader DATO)
        {
            textBox1.Text = DATO.GetString(0);
            textBox2.Text = DATO.GetString(1);
            textBox3.Text = DATO.GetString(2);
            DateTime fecha = DATO.GetDateTime(3);
            textBox4.Text = fecha.ToShortDateString();
            comboBox2.Text = DATO.GetString(4);
            comboBox1.Text = DATO.GetString(5);
            double pre = DATO.GetDouble(6);
            textBox5.Text = pre.ToString();

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;

        }

        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            textBox5.Text = "";

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void Buscar()
        {
            Enlace.Open();
            String latira = "select * from comven where cedcv='" + textBox1.Text + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "insert into comven (cedcv,nombrecv,telefonocv,fechacv,producto,condicioncv,preciocv,estatuscv) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','A')";

            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();


            MessageBox.Show("inclusion exitosa");

            Enlace.Close();
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "update comven set nombrecv ='" + textBox2.Text + "', telefonocv='" + textBox3.Text + "', fechacv ='" + textBox4.Text + "', producto='" + comboBox2.Text + "', condicioncv='" + comboBox1.Text + "',preciocv='" + textBox5.Text + "' where cedcv='" + textBox1.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("modificacion  exitosa");

            Enlace.Close();
            Limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "delete * from comven where cedcv='" + textBox1.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("eliminacion  exitosa");

            Enlace.Close();
            Limpiar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
