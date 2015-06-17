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
    public partial class RegProducto : Form
    {
        System.Data.OleDb.OleDbConnection Enlace;

        public RegProducto()
        {
            Enlace = new System.Data.OleDb.OleDbConnection();

            InitializeComponent();
        }

        private void RegProducto_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Enlace.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bd\sm.accdb";
        }

        private void Limpiar()
        {
            textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String sql = "insert into producto (nombrep,estatusp) values('" + textBox1.Text + "','A')";

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
    }
}
