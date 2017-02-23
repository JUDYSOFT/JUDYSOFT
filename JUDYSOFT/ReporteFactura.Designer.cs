namespace JUDYSOFT
{
    partial class ReporteFactura
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DatosFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new JUDYSOFT.DataSet2();
            this.pruebaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetfac = new JUDYSOFT.DataSetfac();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pruebaTableAdapter = new JUDYSOFT.DataSetfacTableAdapters.pruebaTableAdapter();
            //this.DatosFacturaTableAdapter = new JUDYSOFT.DataSet2TableAdapters.DatosFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetfac)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosFacturaBindingSource
            // 
            this.DatosFacturaBindingSource.DataMember = "DatosFactura";
            this.DatosFacturaBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pruebaBindingSource
            // 
            this.pruebaBindingSource.DataMember = "prueba";
            this.pruebaBindingSource.DataSource = this.dataSetfac;
            // 
            // dataSetfac
            // 
            this.dataSetfac.DataSetName = "DataSetfac";
            this.dataSetfac.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetValores";
            reportDataSource1.Value = this.DatosFacturaBindingSource;
            reportDataSource2.Name = "DataSetfac";
            reportDataSource2.Value = this.pruebaBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.pruebaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JUDYSOFT.InformeFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(284, 261);
            this.reportViewer1.TabIndex = 0;
            // 
            // pruebaTableAdapter
            // 
            this.pruebaTableAdapter.ClearBeforeFill = true;
            // 
            // DatosFacturaTableAdapter
            // 
            //this.DatosFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFactura
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFactura";
            this.Load += new System.EventHandler(this.ReporteFactura_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DatosFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetfac)).EndInit();
            this.ResumeLayout(false);

        }

        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DatosFacturaBindingSource;
        private DataSet2 DataSet2;
        private System.Windows.Forms.BindingSource pruebaBindingSource;
        private DataSetfac dataSetfac;
        private DataSetfacTableAdapters.pruebaTableAdapter pruebaTableAdapter;
        //private DataSet2TableAdapters.DatosFacturaTableAdapter DatosFacturaTableAdapter;

        #endregion
        /*private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;*/
    }
}