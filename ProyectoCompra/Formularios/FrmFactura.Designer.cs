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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSFactura = new ProyectoCompra.Reportes.DSFactura();
            this.tAdapter = new ProyectoCompra.Reportes.DSFacturaTableAdapters.ConsultarFacturaTableAdapter();
            this.rvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // bSource
            // 
            this.bSource.DataMember = "ConsultarFactura";
            this.bSource.DataSource = this.dSFactura;
            // 
            // dSFactura
            // 
            this.dSFactura.DataSetName = "DSFactura";
            this.dSFactura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAdapter
            // 
            this.tAdapter.ClearBeforeFill = true;
            // 
            // rvReporte
            // 
            this.rvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSFactura";
            reportDataSource1.Value = this.bSource;
            this.rvReporte.LocalReport.DataSources.Add(reportDataSource1);
            this.rvReporte.LocalReport.ReportEmbeddedResource = "ProyectoCompra.Reportes.InformeFactura.rdlc";
            this.rvReporte.Location = new System.Drawing.Point(0, 0);
            this.rvReporte.Name = "rvReporte";
            this.rvReporte.ServerReport.BearerToken = null;
            this.rvReporte.Size = new System.Drawing.Size(680, 450);
            this.rvReporte.TabIndex = 0;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.rvReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Reportes.DSFactura dSFactura;
        private System.Windows.Forms.BindingSource bSource;
        private Reportes.DSFacturaTableAdapters.ConsultarFacturaTableAdapter tAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rvReporte;
    }
}