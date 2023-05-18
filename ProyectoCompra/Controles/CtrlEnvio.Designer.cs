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
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.lblLocalidad2 = new System.Windows.Forms.Label();
            this.lblDireccion2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.tpPago = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnCasa = new System.Windows.Forms.RadioButton();
            this.rbbtnTienda = new System.Windows.Forms.RadioButton();
            this.rbnTarjeta = new System.Windows.Forms.RadioButton();
            this.rbnEfectivo = new System.Windows.Forms.RadioButton();
            this.gbxRecoger.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.flProductos.SuspendLayout();
            this.tcAccesoPago.SuspendLayout();
            this.tpDetalle.SuspendLayout();
            this.tpDireccion.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.tpPago.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.panelDetalles.Size = new System.Drawing.Size(488, 437);
            this.panelDetalles.TabIndex = 7;
            // 
            // flProductos
            // 
            this.flProductos.AutoScroll = true;
            this.flProductos.Controls.Add(this.tlProductos);
            this.flProductos.Location = new System.Drawing.Point(3, 42);
            this.flProductos.Name = "flProductos";
            this.flProductos.Size = new System.Drawing.Size(482, 392);
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
            // gbxDomicilio
            // 
            this.gbxDomicilio.Controls.Add(this.lblTelefono2);
            this.gbxDomicilio.Controls.Add(this.lblLocalidad2);
            this.gbxDomicilio.Controls.Add(this.lblDireccion2);
            this.gbxDomicilio.Controls.Add(this.lblNombre2);
            this.gbxDomicilio.Controls.Add(this.lblTelefono);
            this.gbxDomicilio.Controls.Add(this.lblLocalidad);
            this.gbxDomicilio.Controls.Add(this.lblDireccion);
            this.gbxDomicilio.Controls.Add(this.lblNombre);
            this.gbxDomicilio.Controls.Add(this.lblEnvio);
            this.gbxDomicilio.Controls.Add(this.rbtnCasa);
            this.gbxDomicilio.Location = new System.Drawing.Point(28, 114);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(433, 303);
            this.gbxDomicilio.TabIndex = 3;
            this.gbxDomicilio.TabStop = false;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(251, 148);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono2.TabIndex = 15;
            this.lblTelefono2.Text = "Teléfono";
            this.lblTelefono2.Visible = false;
            // 
            // lblLocalidad2
            // 
            this.lblLocalidad2.AutoSize = true;
            this.lblLocalidad2.Location = new System.Drawing.Point(251, 126);
            this.lblLocalidad2.Name = "lblLocalidad2";
            this.lblLocalidad2.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad2.TabIndex = 14;
            this.lblLocalidad2.Text = "Localidad";
            this.lblLocalidad2.Visible = false;
            // 
            // lblDireccion2
            // 
            this.lblDireccion2.AutoSize = true;
            this.lblDireccion2.Location = new System.Drawing.Point(251, 103);
            this.lblDireccion2.Name = "lblDireccion2";
            this.lblDireccion2.Size = new System.Drawing.Size(98, 13);
            this.lblDireccion2.TabIndex = 13;
            this.lblDireccion2.Text = "Direccion completa";
            this.lblDireccion2.Visible = false;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(251, 80);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(90, 13);
            this.lblNombre2.TabIndex = 12;
            this.lblNombre2.Text = "Nombre completo";
            this.lblNombre2.Visible = false;
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
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 103);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(98, 13);
            this.lblDireccion.TabIndex = 9;
            this.lblDireccion.Text = "Direccion completa";
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
            // tpPago
            // 
            this.tpPago.Controls.Add(this.groupBox2);
            this.tpPago.Controls.Add(this.groupBox1);
            this.tpPago.Location = new System.Drawing.Point(4, 22);
            this.tpPago.Name = "tpPago";
            this.tpPago.Padding = new System.Windows.Forms.Padding(3);
            this.tpPago.Size = new System.Drawing.Size(488, 440);
            this.tpPago.TabIndex = 2;
            this.tpPago.Text = "Pago";
            this.tpPago.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnEfectivo);
            this.groupBox1.Location = new System.Drawing.Point(28, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbnTarjeta);
            this.groupBox2.Location = new System.Drawing.Point(28, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 57);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rbtnCasa
            // 
            this.rbtnCasa.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCasa.Image = global::ProyectoCompra.Properties.Resources.icon_casa;
            this.rbtnCasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtnCasa.Location = new System.Drawing.Point(6, 9);
            this.rbtnCasa.Name = "rbtnCasa";
            this.rbtnCasa.Size = new System.Drawing.Size(351, 42);
            this.rbtnCasa.TabIndex = 1;
            this.rbtnCasa.Text = "Envío a domicilio\r\nEntrega en 24/48h hábiles\r\n\r\n";
            this.rbtnCasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbtnCasa.UseVisualStyleBackColor = true;
            this.rbtnCasa.Click += new System.EventHandler(this.rbtnCasa_Click);
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
            // rbnTarjeta
            // 
            this.rbnTarjeta.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnTarjeta.Image = global::ProyectoCompra.Properties.Resources.icon_tipo_tarjeta;
            this.rbnTarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnTarjeta.Location = new System.Drawing.Point(6, 8);
            this.rbnTarjeta.Name = "rbnTarjeta";
            this.rbnTarjeta.Size = new System.Drawing.Size(421, 42);
            this.rbnTarjeta.TabIndex = 1;
            this.rbnTarjeta.Text = "Tarjeta bancaria";
            this.rbnTarjeta.UseVisualStyleBackColor = true;
            this.rbnTarjeta.Click += new System.EventHandler(this.rbnTarjeta_Click);
            // 
            // rbnEfectivo
            // 
            this.rbnEfectivo.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEfectivo.Image = global::ProyectoCompra.Properties.Resources.icon_efectivo;
            this.rbnEfectivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbnEfectivo.Location = new System.Drawing.Point(6, 9);
            this.rbnEfectivo.Name = "rbnEfectivo";
            this.rbnEfectivo.Size = new System.Drawing.Size(421, 42);
            this.rbnEfectivo.TabIndex = 2;
            this.rbnEfectivo.Text = "Efectivo";
            this.rbnEfectivo.UseVisualStyleBackColor = true;
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
            this.tpPago.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.Label lblLocalidad2;
        private System.Windows.Forms.Label lblDireccion2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.RadioButton rbtnCasa;
        public System.Windows.Forms.GroupBox gbxDomicilio;
        public System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbnTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnEfectivo;
    }
}
