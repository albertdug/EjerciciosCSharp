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
    public partial class RIN : Form
    {
        public RIN()
        {
            InitializeComponent();
        }

        private void RIN_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'smDataSet.inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.smDataSet.inventario);
            CenterToScreen();
            this.reportViewer1.RefreshReport();
        }
    }
}
