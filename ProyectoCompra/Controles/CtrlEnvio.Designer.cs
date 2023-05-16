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
            this.gbxOpcion = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.rbtnCasa = new System.Windows.Forms.RadioButton();
            this.rbbtnTienda = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.flProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.tlProductos = new System.Windows.Forms.TableLayoutPanel();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lblResumenProductos = new System.Windows.Forms.Label();
            this.btnOcultarDetalles = new System.Windows.Forms.Button();
            this.gbxOpcion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.flProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOpcion
            // 
            this.gbxOpcion.Controls.Add(this.groupBox3);
            this.gbxOpcion.Controls.Add(this.rbbtnTienda);
            this.gbxOpcion.Controls.Add(this.lblTitulo);
            this.gbxOpcion.Controls.Add(this.groupBox4);
            this.gbxOpcion.Controls.Add(this.panelDetalles);
            this.gbxOpcion.Location = new System.Drawing.Point(3, 3);
            this.gbxOpcion.Name = "gbxOpcion";
            this.gbxOpcion.Size = new System.Drawing.Size(503, 469);
            this.gbxOpcion.TabIndex = 2;
            this.gbxOpcion.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEnvio);
            this.groupBox3.Controls.Add(this.rbtnCasa);
            this.groupBox3.Location = new System.Drawing.Point(31, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(433, 57);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
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
            // rbbtnTienda
            // 
            this.rbbtnTienda.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbbtnTienda.Image = global::ProyectoCompra.Properties.Resources.icon_tienda2;
            this.rbbtnTienda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbbtnTienda.Location = new System.Drawing.Point(37, 86);
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
            this.lblTitulo.Location = new System.Drawing.Point(25, 48);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pedido 1 de 1: vendido y enviado por EasyShop";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(31, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 57);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.flProductos);
            this.panelDetalles.Controls.Add(this.btnDetalles);
            this.panelDetalles.Controls.Add(this.lblResumenProductos);
            this.panelDetalles.Controls.Add(this.btnOcultarDetalles);
            this.panelDetalles.Location = new System.Drawing.Point(20, 213);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(477, 229);
            this.panelDetalles.TabIndex = 7;
            // 
            // flProductos
            // 
            this.flProductos.AutoScroll = true;
            this.flProductos.Controls.Add(this.tlProductos);
            this.flProductos.Location = new System.Drawing.Point(3, 42);
            this.flProductos.Name = "flProductos";
            this.flProductos.Size = new System.Drawing.Size(471, 187);
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
            // CtrlEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxOpcion);
            this.Name = "CtrlEnvio";
            this.Size = new System.Drawing.Size(509, 476);
            this.Load += new System.EventHandler(this.CtrlEnvio_Load);
            this.gbxOpcion.ResumeLayout(false);
            this.gbxOpcion.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.flProductos.ResumeLayout(false);
            this.flProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOpcion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.RadioButton rbtnCasa;
        private System.Windows.Forms.RadioButton rbbtnTienda;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.FlowLayoutPanel flProductos;
        private System.Windows.Forms.TableLayoutPanel tlProductos;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label lblResumenProductos;
        private System.Windows.Forms.Button btnOcultarDetalles;
    }
}
