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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public Principal(String nivel)
        {
           // MessageBox.Show("Entrando al Sistema como: " + nivel);
            InitializeComponent();
            if (nivel.Contains("ADMINISTRADOR"))
                //aLUMNOSToolStripMenuItem.Enabled=false;

                if (nivel.Contains("OPERADOR"))
                    usuariosToolStripMenuItem.Visible = false;

            if (nivel.Contains("SECRETARIA"))
                usuariosToolStripMenuItem.Visible = false;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void registrarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegBanco regbanco = new RegBanco();
            regbanco.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegProducto rp = new RegProducto();
            rp.Show();
        }

        private void aLUMNOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
        }

        private void mATERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompraVenta cv = new CompraVenta();
            cv.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CuentasCobrar cc = new CuentasCobrar();
            cc.Show();
        }

        private void bancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cheques ch = new cheques();
            ch.Show();
        }

        private void chequesPostfechadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RBAN rch = new RBAN();
            rch.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RIN repi = new RIN();
            repi.Show();
        }

        private void compraVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCV rcv = new RCV();
            rcv.Show();
        }

        private void cuentasPorCobrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RCC rcc = new RCC();
            rcc.Show();
        }

        private void registrarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegUsuario ru = new RegUsuario();
            ru.Show();
        }
    }
}
