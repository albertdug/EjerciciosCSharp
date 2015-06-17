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
    public partial class RCC : Form
    {
        public RCC()
        {
            InitializeComponent();
        }

        private void RCC_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            // TODO: esta línea de código carga datos en la tabla 'smDataSet.cuentas' Puede moverla o quitarla según sea necesario.
            this.cuentasTableAdapter.Fill(this.smDataSet.cuentas);

            this.reportViewer1.RefreshReport();
        }
    }
}
