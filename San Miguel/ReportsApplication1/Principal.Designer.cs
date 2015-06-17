namespace ReportsApplication1
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.maestrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRCHIVOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aLUMNOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mATERIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequesPostfechadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasPorCobrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.compraVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maestrosToolStripMenuItem,
            this.aRCHIVOSToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // maestrosToolStripMenuItem
            // 
            this.maestrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarBancoToolStripMenuItem,
            this.registrarProductoToolStripMenuItem});
            this.maestrosToolStripMenuItem.Name = "maestrosToolStripMenuItem";
            this.maestrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.maestrosToolStripMenuItem.Text = "Maestros";
            // 
            // registrarBancoToolStripMenuItem
            // 
            this.registrarBancoToolStripMenuItem.Name = "registrarBancoToolStripMenuItem";
            this.registrarBancoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.registrarBancoToolStripMenuItem.Text = "Registrar Banco";
            this.registrarBancoToolStripMenuItem.Click += new System.EventHandler(this.registrarBancoToolStripMenuItem_Click);
            // 
            // registrarProductoToolStripMenuItem
            // 
            this.registrarProductoToolStripMenuItem.Name = "registrarProductoToolStripMenuItem";
            this.registrarProductoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.registrarProductoToolStripMenuItem.Text = "Registrar Producto";
            this.registrarProductoToolStripMenuItem.Click += new System.EventHandler(this.registrarProductoToolStripMenuItem_Click);
            // 
            // aRCHIVOSToolStripMenuItem
            // 
            this.aRCHIVOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLUMNOSToolStripMenuItem,
            this.mATERIASToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem,
            this.bancosToolStripMenuItem});
            this.aRCHIVOSToolStripMenuItem.Name = "aRCHIVOSToolStripMenuItem";
            this.aRCHIVOSToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.aRCHIVOSToolStripMenuItem.Text = "Transacciones ";
            // 
            // aLUMNOSToolStripMenuItem
            // 
            this.aLUMNOSToolStripMenuItem.Name = "aLUMNOSToolStripMenuItem";
            this.aLUMNOSToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.aLUMNOSToolStripMenuItem.Text = "Inventario";
            this.aLUMNOSToolStripMenuItem.Click += new System.EventHandler(this.aLUMNOSToolStripMenuItem_Click);
            // 
            // mATERIASToolStripMenuItem
            // 
            this.mATERIASToolStripMenuItem.Name = "mATERIASToolStripMenuItem";
            this.mATERIASToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.mATERIASToolStripMenuItem.Text = "Compra-Venta";
            this.mATERIASToolStripMenuItem.Click += new System.EventHandler(this.mATERIASToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem
            // 
            this.cuentasPorCobrarToolStripMenuItem.Name = "cuentasPorCobrarToolStripMenuItem";
            this.cuentasPorCobrarToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar";
            this.cuentasPorCobrarToolStripMenuItem.Click += new System.EventHandler(this.cuentasPorCobrarToolStripMenuItem_Click);
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.bancosToolStripMenuItem.Text = "Cheques Post-Fechados";
            this.bancosToolStripMenuItem.Click += new System.EventHandler(this.bancosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chequesPostfechadosToolStripMenuItem,
            this.articulosToolStripMenuItem,
            this.cuentasPorCobrarToolStripMenuItem1,
            this.compraVentaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // chequesPostfechadosToolStripMenuItem
            // 
            this.chequesPostfechadosToolStripMenuItem.Name = "chequesPostfechadosToolStripMenuItem";
            this.chequesPostfechadosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.chequesPostfechadosToolStripMenuItem.Text = "Cheques Post-Fechados";
            this.chequesPostfechadosToolStripMenuItem.Click += new System.EventHandler(this.chequesPostfechadosToolStripMenuItem_Click);
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.articulosToolStripMenuItem.Text = "Inventario";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // cuentasPorCobrarToolStripMenuItem1
            // 
            this.cuentasPorCobrarToolStripMenuItem1.Name = "cuentasPorCobrarToolStripMenuItem1";
            this.cuentasPorCobrarToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.cuentasPorCobrarToolStripMenuItem1.Text = "Cuentas Por Cobrar";
            this.cuentasPorCobrarToolStripMenuItem1.Click += new System.EventHandler(this.cuentasPorCobrarToolStripMenuItem1_Click);
            // 
            // compraVentaToolStripMenuItem
            // 
            this.compraVentaToolStripMenuItem.Name = "compraVentaToolStripMenuItem";
            this.compraVentaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.compraVentaToolStripMenuItem.Text = "Compra Venta";
            this.compraVentaToolStripMenuItem.Click += new System.EventHandler(this.compraVentaToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarNuevoUsuarioToolStripMenuItem
            // 
            this.registrarNuevoUsuarioToolStripMenuItem.Name = "registrarNuevoUsuarioToolStripMenuItem";
            this.registrarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.registrarNuevoUsuarioToolStripMenuItem.Text = "Incluir o Moficiar Usuarios";
            this.registrarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 314);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem maestrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLUMNOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mATERIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequesPostfechadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasPorCobrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem compraVentaToolStripMenuItem;
    }
}