namespace ProyectoCompra.Controles
{
    partial class CtrlEnvio
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbbtnTienda = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxRecoger = new System.Windows.Forms.GroupBox();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.flProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.tlProductos = new System.Windows.Forms.TableLayoutPanel();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lblResumenProductos = new System.Windows.Forms.Label();
            this.btnOcultarDetalles = new System.Windows.Forms.Button();
            this.tcAccesoPago = new System.Windows.Forms.TabControl();
            this.tpDetalle = new System.Windows.Forms.TabPage();
            this.tpDireccion = new System.Windows.Forms.TabPage();
            this.tpPago = new System.Windows.Forms.TabPage();
            this.rbtnCasa = new System.Windows.Forms.RadioButton();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxRecoger.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.flProductos.SuspendLayout();
            this.tcAccesoPago.SuspendLayout();
            this.tpDetalle.SuspendLayout();
            this.tpDireccion.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbbtnTienda
            // 
            this.rbbtnTienda.Enabled = false;
            this.rbbtnTienda.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbbtnTienda.Image = global::ProyectoCompra.Properties.Resources.icon_tienda2;
            this.rbbtnTienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbbtnTienda.Location = new System.Drawing.Point(6, 9);
            this.rbbtnTienda.Name = "rbbtnTienda";
            this.rbbtnTienda.Size = new System.Drawing.Size(421, 42);
            this.rbbtnTienda.TabIndex = 2;
            this.rbbtnTienda.Text = "Recoger en tienda\r\nLlegará a tu tienda en 24/48h hábiles\r\n";
            this.rbbtnTienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbbtnTienda.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Nova Cond", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pedido 1 de 1: vendido y enviado por EasyShop";
            // 
            // gbxRecoger
            // 
            this.gbxRecoger.Controls.Add(this.rbbtnTienda);
            this.gbxRecoger.Location = new System.Drawing.Point(28, 51);
            this.gbxRecoger.Name = "gbxRecoger";
            this.gbxRecoger.Size = new System.Drawing.Size(433, 57);
            this.gbxRecoger.TabIndex = 4;
            this.gbxRecoger.TabStop = false;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.flProductos);
            this.panelDetalles.Controls.Add(this.btnDetalles);
            this.panelDetalles.Controls.Add(this.lblResumenProductos);
            this.panelDetalles.Controls.Add(this.btnOcultarDetalles);
            this.panelDetalles.Location = new System.Drawing.Point(0, 0);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(477, 437);
            this.panelDetalles.TabIndex = 7;
            // 
            // flProductos
            // 
            this.flProductos.AutoScroll = true;
            this.flProductos.Controls.Add(this.tlProductos);
            this.flProductos.Location = new System.Drawing.Point(3, 42);
            this.flProductos.Name = "flProductos";
            this.flProductos.Size = new System.Drawing.Size(471, 392);
            this.flProductos.TabIndex = 6;
            this.flProductos.Visible = false;
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
            this.tlProductos.TabIndex = 0;
            // 
            // btnDetalles
            // 
            this.btnDetalles.Location = new System.Drawing.Point(358, 13);
            this.btnDetalles.Name = "btnDetalles";
            this.btnDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnDetalles.TabIndex = 1;
            this.btnDetalles.Text = "Ver detalles";
            this.btnDetalles.UseVisualStyleBackColor = true;
            this.btnDetalles.Click += new System.EventHandler(this.btnDetalles_Click);
            // 
            // lblResumenProductos
            // 
            this.lblResumenProductos.AutoSize = true;
            this.lblResumenProductos.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumenProductos.Location = new System.Drawing.Point(17, 17);
            this.lblResumenProductos.Name = "lblResumenProductos";
            this.lblResumenProductos.Size = new System.Drawing.Size(118, 14);
            this.lblResumenProductos.TabIndex = 0;
            this.lblResumenProductos.Text = "Resumen de productos";
            // 
            // btnOcultarDetalles
            // 
            this.btnOcultarDetalles.Location = new System.Drawing.Point(340, 13);
            this.btnOcultarDetalles.Name = "btnOcultarDetalles";
            this.btnOcultarDetalles.Size = new System.Drawing.Size(93, 23);
            this.btnOcultarDetalles.TabIndex = 3;
            this.btnOcultarDetalles.Text = "Ocultar detalles";
            this.btnOcultarDetalles.UseVisualStyleBackColor = true;
            this.btnOcultarDetalles.Visible = false;
            this.btnOcultarDetalles.Click += new System.EventHandler(this.btnOcultarDetalles_Click);
            // 
            // tcAccesoPago
            // 
            this.tcAccesoPago.Controls.Add(this.tpDetalle);
            this.tcAccesoPago.Controls.Add(this.tpDireccion);
            this.tcAccesoPago.Controls.Add(this.tpPago);
            this.tcAccesoPago.Location = new System.Drawing.Point(10, 7);
            this.tcAccesoPago.Name = "tcAccesoPago";
            this.tcAccesoPago.SelectedIndex = 0;
            this.tcAccesoPago.Size = new System.Drawing.Size(496, 466);
            this.tcAccesoPago.TabIndex = 8;
            // 
            // tpDetalle
            // 
            this.tpDetalle.Controls.Add(this.panelDetalles);
            this.tpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tpDetalle.Name = "tpDetalle";
            this.tpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tpDetalle.Size = new System.Drawing.Size(488, 440);
            this.tpDetalle.TabIndex = 0;
            this.tpDetalle.Text = "Detalle";
            this.tpDetalle.UseVisualStyleBackColor = true;
            // 
            // tpDireccion
            // 
            this.tpDireccion.Controls.Add(this.lblTitulo);
            this.tpDireccion.Controls.Add(this.gbxDomicilio);
            this.tpDireccion.Controls.Add(this.gbxRecoger);
            this.tpDireccion.Location = new System.Drawing.Point(4, 22);
            this.tpDireccion.Name = "tpDireccion";
            this.tpDireccion.Padding = new System.Windows.Forms.Padding(3);
            this.tpDireccion.Size = new System.Drawing.Size(488, 440);
            this.tpDireccion.TabIndex = 1;
            this.tpDireccion.Text = "Dirección";
            this.tpDireccion.UseVisualStyleBackColor = true;
            // 
            // tpPago
            // 
            this.tpPago.Location = new System.Drawing.Point(4, 22);
            this.tpPago.Name = "tpPago";
            this.tpPago.Padding = new System.Windows.Forms.Padding(3);
            this.tpPago.Size = new System.Drawing.Size(488, 440);
            this.tpPago.TabIndex = 2;
            this.tpPago.Text = "Pago";
            this.tpPago.UseVisualStyleBackColor = true;
            // 
            // rbtnCasa
            // 
            this.rbtnCasa.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCasa.Image = global::ProyectoCompra.Properties.Resources.icon_casa;
            this.rbtnCasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnCasa.Location = new System.Drawing.Point(6, 13);
            this.rbtnCasa.Name = "rbtnCasa";
            this.rbtnCasa.Size = new System.Drawing.Size(354, 38);
            this.rbtnCasa.TabIndex = 1;
            this.rbtnCasa.Text = "Envío a domicilio\r\nEntrega en 24/48h hábiles\r\n\r\n";
            this.rbtnCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCasa.UseVisualStyleBackColor = true;
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Font = new System.Drawing.Font("Arial Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvio.Location = new System.Drawing.Point(363, 21);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(64, 23);
            this.lblEnvio.TabIndex = 2;
            this.lblEnvio.Text = "3.99 €";
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.Controls.Add(this.label1);
            this.gbxDomicilio.Controls.Add(this.label3);
            this.gbxDomicilio.Controls.Add(this.label4);
            this.gbxDomicilio.Controls.Add(this.label5);
            this.gbxDomicilio.Controls.Add(this.lblTelefono);
            this.gbxDomicilio.Controls.Add(this.lblLocalidad);
            this.gbxDomicilio.Controls.Add(this.label2);
            this.gbxDomicilio.Controls.Add(this.lblNombre);
            this.gbxDomicilio.Controls.Add(this.lblEnvio);
            this.gbxDomicilio.Controls.Add(this.rbtnCasa);
            this.gbxDomicilio.Location = new System.Drawing.Point(28, 114);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(433, 303);
            this.gbxDomicilio.TabIndex = 3;
            this.gbxDomicilio.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Teléfono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Localidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Direccion completa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre completo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(16, 148);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(16, 126);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 10;
            this.lblLocalidad.Text = "Localidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Direccion completa";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre completo";
            // 
            // CtrlEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tcAccesoPago);
            this.Name = "CtrlEnvio";
            this.Size = new System.Drawing.Size(509, 476);
            this.Load += new System.EventHandler(this.CtrlEnvio_Load);
            this.gbxRecoger.ResumeLayout(false);
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.flProductos.ResumeLayout(false);
            this.flProductos.PerformLayout();
            this.tcAccesoPago.ResumeLayout(false);
            this.tpDetalle.ResumeLayout(false);
            this.tpDireccion.ResumeLayout(false);
            this.tpDireccion.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbbtnTienda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxRecoger;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.FlowLayoutPanel flProductos;
        private System.Windows.Forms.TableLayoutPanel tlProductos;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label lblResumenProductos;
        private System.Windows.Forms.Button btnOcultarDetalles;
        private System.Windows.Forms.TabControl tcAccesoPago;
        private System.Windows.Forms.TabPage tpDetalle;
        private System.Windows.Forms.TabPage tpDireccion;
        private System.Windows.Forms.TabPage tpPago;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.RadioButton rbtnCasa;
    }
}
