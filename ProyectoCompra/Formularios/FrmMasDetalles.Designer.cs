namespace ProyectoCompra.Formularios
{
    partial class FrmMasDetalles
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
            this.flpProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.flProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.tlProductos = new System.Windows.Forms.TableLayoutPanel();
            this.tflDetalles = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctrlResumenPedido1 = new ProyectoCompra.Controles.CtrlResumenPedido();
            this.ctrlMasInformacion1 = new ProyectoCompra.Controles.CtrlMasInformacion();
            this.ctrlHistorialPedido1 = new ProyectoCompra.Controles.CtrlHistorialPedido();
            this.flpProductos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.flProductos.SuspendLayout();
            this.tflDetalles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpProductos
            // 
            this.flpProductos.Controls.Add(this.groupBox3);
            this.flpProductos.Location = new System.Drawing.Point(2, 3);
            this.flpProductos.Name = "flpProductos";
            this.flpProductos.Size = new System.Drawing.Size(487, 358);
            this.flpProductos.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.flProductos);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 351);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del pedido";
            // 
            // flProductos
            // 
            this.flProductos.AutoScroll = true;
            this.flProductos.Controls.Add(this.tlProductos);
            this.flProductos.Controls.Add(this.ctrlHistorialPedido1);
            this.flProductos.Location = new System.Drawing.Point(6, 19);
            this.flProductos.Name = "flProductos";
            this.flProductos.Size = new System.Drawing.Size(467, 326);
            this.flProductos.TabIndex = 0;
            // 
            // tlProductos
            // 
            this.tlProductos.AutoSize = true;
            this.tlProductos.ColumnCount = 1;
            this.tlProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlProductos.Location = new System.Drawing.Point(3, 3);
            this.tlProductos.Name = "tlProductos";
            this.tlProductos.RowCount = 1;
            this.tlProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlProductos.Size = new System.Drawing.Size(0, 0);
            this.tlProductos.TabIndex = 1;
            // 
            // tflDetalles
            // 
            this.tflDetalles.ColumnCount = 1;
            this.tflDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tflDetalles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tflDetalles.Controls.Add(this.groupBox1, 0, 0);
            this.tflDetalles.Controls.Add(this.groupBox2, 0, 1);
            this.tflDetalles.Location = new System.Drawing.Point(490, 3);
            this.tflDetalles.Name = "tflDetalles";
            this.tflDetalles.RowCount = 2;
            this.tflDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.51955F));
            this.tflDetalles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.48045F));
            this.tflDetalles.Size = new System.Drawing.Size(497, 358);
            this.tflDetalles.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrlResumenPedido1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen del pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctrlMasInformacion1);
            this.groupBox2.Location = new System.Drawing.Point(3, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Más información";
            // 
            // ctrlResumenPedido1
            // 
            this.ctrlResumenPedido1.factura = null;
            this.ctrlResumenPedido1.Location = new System.Drawing.Point(6, 13);
            this.ctrlResumenPedido1.Name = "ctrlResumenPedido1";
            this.ctrlResumenPedido1.Size = new System.Drawing.Size(478, 95);
            this.ctrlResumenPedido1.TabIndex = 0;
            // 
            // ctrlMasInformacion1
            // 
            this.ctrlMasInformacion1.AutoSize = true;
            this.ctrlMasInformacion1.factura = null;
            this.ctrlMasInformacion1.Location = new System.Drawing.Point(6, 19);
            this.ctrlMasInformacion1.Name = "ctrlMasInformacion1";
            this.ctrlMasInformacion1.Size = new System.Drawing.Size(476, 206);
            this.ctrlMasInformacion1.TabIndex = 0;
            // 
            // ctrlHistorialPedido1
            // 
            this.ctrlHistorialPedido1.AutoSize = true;
            this.ctrlHistorialPedido1.BackColor = System.Drawing.Color.White;
            this.ctrlHistorialPedido1.Location = new System.Drawing.Point(9, 3);
            this.ctrlHistorialPedido1.Name = "ctrlHistorialPedido1";
            this.ctrlHistorialPedido1.Size = new System.Drawing.Size(439, 176);
            this.ctrlHistorialPedido1.TabIndex = 2;
            // 
            // FrmMasDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 366);
            this.Controls.Add(this.tflDetalles);
            this.Controls.Add(this.flpProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMasDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial pedido detalle";
            this.Load += new System.EventHandler(this.FrmMasDetalles_Load);
            this.flpProductos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.flProductos.ResumeLayout(false);
            this.flProductos.PerformLayout();
            this.tflDetalles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpProductos;
        private System.Windows.Forms.TableLayoutPanel tflDetalles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.FlowLayoutPanel flProductos;
        private Controles.CtrlMasInformacion ctrlMasInformacion1;
        private Controles.CtrlResumenPedido ctrlResumenPedido1;
        private System.Windows.Forms.TableLayoutPanel tlProductos;
        private Controles.CtrlHistorialPedido ctrlHistorialPedido1;
    }
}