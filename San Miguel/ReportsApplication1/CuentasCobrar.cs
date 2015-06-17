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
    public partial class CuentasCobrar : Form
    {
        System.Data.OleDb.OleDbConnection Enlace;

        public CuentasCobrar()
        {
            Enlace = new System.Data.OleDb.OleDbConnection();
            InitializeComponent();
        }

        private void CuentasCobrar_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Enlace.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bd\sm.accdb";
            String sql = "SELECT * FROM  inventario ";
            Enlace.Open();

            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            OleDbDataReader DATO = comando.ExecuteReader();
            while (DATO.Read())
            {

                comboBox1.Items.Add(DATO.GetString(1));

            }

            Enlace.Close();

        }

        private void Mostrar(OleDbDataReader DATO)
        {
            textBox1.Text = DATO.GetString(0);
            textBox2.Text = DATO.GetString(1);
            DateTime fecha = DATO.GetDateTime(2);
            textBox3.Text = fecha.ToShortDateString();
            textBox4.Text = DATO.GetString(3);
            comboBox1.Text = DATO.GetString(4);
            double monto = DATO.GetDouble(5);
            textBox5.Text = monto.ToString();

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
            comboBox1.Text = "";
            textBox5.Text = "";
        }

        private void Buscar()
        {
            Enlace.Open();
            String latira = "select * from cuentas where codigo='" + textBox1.Text + "'";
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
            //String sql = "insert into cuentas (codigo,nombre,fecha,telefono,producto,monto,estatusc) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','A')";
            String sql = "insert into cuentas (codigo,nombre,fecha,telefono,producto,monto,estatusc) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "','A')";
            //String sql = "insert into cuentas (codigo,nombre,fecha,telefono,estatusc) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','A')";

            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("inclusion exitosa");

            Enlace.Close();
            Limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "update cuentas set nombre ='" + textBox2.Text + "', fecha='" + textBox3.Text + "', telefono='" + textBox4.Text + "', producto='" + comboBox1.Text + "', monto='" + textBox5.Text + "' where codigo='" + textBox1.Text + "'";
            OleDbCommand comando = new OleDbCommand(sql, Enlace);
            comando.ExecuteNonQuery();

            MessageBox.Show("modificacion  exitosa");

            Enlace.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "delete * from cuentas where codigo='" + textBox1.Text + "'";
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
