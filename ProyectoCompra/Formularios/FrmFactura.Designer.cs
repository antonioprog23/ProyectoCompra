namespace ProyectoCompra.Formularios
{
    partial class FrmFactura
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
            this.ConsultarFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFactura = new ProyectoCompra.Reportes.DSFactura();
            this.dSFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultarFacturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.consultarFacturaTableAdapter = new ProyectoCompra.Reportes.DSFacturaTableAdapters.ConsultarFacturaTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarFacturaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultarFacturaBindingSource
            // 
            this.ConsultarFacturaBindingSource.DataMember = "ConsultarFactura";
            this.ConsultarFacturaBindingSource.DataSource = this.dSFactura;
            // 
            // dSFactura
            // 
            this.dSFactura.DataSetName = "DSFactura";
            this.dSFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSFacturaBindingSource
            // 
            this.dSFacturaBindingSource.DataSource = this.dSFactura;
            this.dSFacturaBindingSource.Position = 0;
            // 
            // consultarFacturaBindingSource1
            // 
            this.consultarFacturaBindingSource1.DataMember = "ConsultarFactura";
            this.consultarFacturaBindingSource1.DataSource = this.dSFactura;
            // 
            // consultarFacturaTableAdapter
            // 
            this.consultarFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSFactura";
            reportDataSource2.Value = this.ConsultarFacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCompra.Reportes.InformeFactura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultarFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultarFacturaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Reportes.DSFactura dSFactura;
        private System.Windows.Forms.BindingSource dSFacturaBindingSource;
        private System.Windows.Forms.BindingSource ConsultarFacturaBindingSource;
        private System.Windows.Forms.BindingSource consultarFacturaBindingSource1;
        private Reportes.DSFacturaTableAdapters.ConsultarFacturaTableAdapter consultarFacturaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}