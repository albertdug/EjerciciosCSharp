using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportsApplication1
{
    public partial class RBAN : Form
    {
        public RBAN()
        {
            InitializeComponent();
        }

        private void RBAN_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smDataSet.banco' Puede moverla o quitarla según sea necesario.
            this.bancoTableAdapter.Fill(this.smDataSet.banco);
            CenterToScreen();
            this.reportViewer1.RefreshReport();
        }
    }
}
