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
    public partial class Usuario : Form
    {
        System.Data.OleDb.OleDbConnection Enlace;

        public Usuario()
        {
            Enlace = new System.Data.OleDb.OleDbConnection();
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            Enlace.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\bd\sm.accdb";
        }

        private void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enlace.Open();
            String latira = "select * from Usuarios  where Usuario='" + textBox1.Text + "' and Clave='" + textBox2.Text + "'";

            OleDbCommand comando = new OleDbCommand(latira, Enlace);
            OleDbDataReader DATO = comando.ExecuteReader();
            if (DATO.Read())
            {
                String nivel;
                nivel = DATO.GetString(2);
                if (nivel.Contains("ADMINISTRADOR"))
                    nivel = "ADMINISTRADOR";

                if (nivel.Contains("SECRETARIA"))
                    nivel = "SECRETARIA";

                if (nivel.Contains("OPERADOR"))
                    nivel = "OPERADOR";

                //MessageBox.Show("Usuario registrado....");
                Limpiar();

                Principal principal = new Principal(nivel);
                principal.Show();
            }

            else
            {
                MessageBox.Show("Usuario NO Registrado....");
                Limpiar();
                button1.Enabled = true;
                button2.Enabled = true;

            }

            Enlace.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
