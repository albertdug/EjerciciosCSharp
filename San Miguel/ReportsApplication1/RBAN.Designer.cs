namespace ReportsApplication1
{
    partial class RBAN
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.smDataSet = new ReportsApplication1.smDataSet();
            this.bancoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoTableAdapter = new ReportsApplication1.smDataSetTableAdapters.bancoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.bancoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(628, 420);
            this.reportViewer1.TabIndex = 0;
            // 
            // smDataSet
            // 
            this.smDataSet.DataSetName = "smDataSet";
            this.smDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bancoBindingSource
            // 
            this.bancoBindingSource.DataMember = "banco";
            this.bancoBindingSource.DataSource = this.smDataSet;
            // 
            // bancoTableAdapter
            // 
            this.bancoTableAdapter.ClearBeforeFill = true;
            // 
            // RBAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(650, 444);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RBAN";
            this.Text = "Reporte de los Cheques Post-Fechados";
            this.Load += new System.EventHandler(this.RBAN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bancoBindingSource;
        private smDataSet smDataSet;
        private smDataSetTableAdapters.bancoTableAdapter bancoTableAdapter;
    }
}