namespace ReportsApplication1
{
    partial class RCV
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.smDataSet = new ReportsApplication1.smDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cuentasTableAdapter = new ReportsApplication1.smDataSetTableAdapters.cuentasTableAdapter();
            this.smDataSet2 = new ReportsApplication1.smDataSet2();
            this.comvenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comvenTableAdapter = new ReportsApplication1.smDataSet2TableAdapters.comvenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comvenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            this.cuentasBindingSource.DataSource = this.smDataSet;
            // 
            // smDataSet
            // 
            this.smDataSet.DataSetName = "smDataSet";
            this.smDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.comvenBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportsApplication1.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(744, 363);
            this.reportViewer1.TabIndex = 0;
            // 
            // cuentasTableAdapter
            // 
            this.cuentasTableAdapter.ClearBeforeFill = true;
            // 
            // smDataSet2
            // 
            this.smDataSet2.DataSetName = "smDataSet2";
            this.smDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comvenBindingSource
            // 
            this.comvenBindingSource.DataMember = "comven";
            this.comvenBindingSource.DataSource = this.smDataSet2;
            // 
            // comvenTableAdapter
            // 
            this.comvenTableAdapter.ClearBeforeFill = true;
            // 
            // RCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(768, 387);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RCV";
            this.Text = "Reporte de Compra Venta";
            this.Load += new System.EventHandler(this.RCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comvenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
        private smDataSet smDataSet;
        private smDataSetTableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.BindingSource comvenBindingSource;
        private smDataSet2 smDataSet2;
        private smDataSet2TableAdapters.comvenTableAdapter comvenTableAdapter;
    }
}