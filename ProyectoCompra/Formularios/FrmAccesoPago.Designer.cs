namespace ProyectoCompra.Formularios
{
    partial class FrmAccesoPago
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
            this.gbxOpcion = new System.Windows.Forms.GroupBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbbtnTienda = new System.Windows.Forms.RadioButton();
            this.rbtnCasa = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.lblResumenProductos = new System.Windows.Forms.Label();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.ctrlProductoCarrito1 = new ProyectoCompra.Controles.CtrlProductoCarrito();
            this.gbxResumen = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTPagar = new System.Windows.Forms.Label();
            this.lblGastosEnvio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.btnOcultarDetalles = new System.Windows.Forms.Button();
            this.gbxOpcion.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.gbxResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOpcion
            // 
            this.gbxOpcion.Controls.Add(this.panelDetalles);
            this.gbxOpcion.Controls.Add(this.flProductos);
            this.gbxOpcion.Controls.Add(this.groupBox3);
            this.gbxOpcion.Controls.Add(this.rbbtnTienda);
            this.gbxOpcion.Controls.Add(this.lblTitulo);
            this.gbxOpcion.Controls.Add(this.groupBox4);
            this.gbxOpcion.Location = new System.Drawing.Point(12, 10);
            this.gbxOpcion.Name = "gbxOpcion";
            this.gbxOpcion.Size = new System.Drawing.Size(503, 479);
            this.gbxOpcion.TabIndex = 1;
            this.gbxOpcion.TabStop = false;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(31, 77);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(433, 57);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(271, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "3.99 €";
            // 
            // flProductos
            // 
            this.flProductos.Location = new System.Drawing.Point(17, 255);
            this.flProductos.Name = "flProductos";
            this.flProductos.Size = new System.Drawing.Size(467, 192);
            this.flProductos.TabIndex = 6;
            this.flProductos.Visible = false;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.ctrlProductoCarrito1);
            this.panelDetalles.Controls.Add(this.btnDetalles);
            this.panelDetalles.Controls.Add(this.lblResumenProductos);
            this.panelDetalles.Controls.Add(this.btnOcultarDetalles);
            this.panelDetalles.Location = new System.Drawing.Point(14, 213);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(473, 234);
            this.panelDetalles.TabIndex = 7;
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
            // ctrlProductoCarrito1
            // 
            this.ctrlProductoCarrito1.AutoSize = true;
            this.ctrlProductoCarrito1.Location = new System.Drawing.Point(14, 42);
            this.ctrlProductoCarrito1.Name = "ctrlProductoCarrito1";
            this.ctrlProductoCarrito1.Size = new System.Drawing.Size(433, 184);
            this.ctrlProductoCarrito1.TabIndex = 2;
            // 
            // gbxResumen
            // 
            this.gbxResumen.Controls.Add(this.btnContinuar);
            this.gbxResumen.Controls.Add(this.lblTotal);
            this.gbxResumen.Controls.Add(this.lblTPagar);
            this.gbxResumen.Controls.Add(this.lblGastosEnvio);
            this.gbxResumen.Controls.Add(this.label4);
            this.gbxResumen.Controls.Add(this.label2);
            this.gbxResumen.Controls.Add(this.label1);
            this.gbxResumen.Controls.Add(this.lblTitle);
            this.gbxResumen.Location = new System.Drawing.Point(526, 12);
            this.gbxResumen.Name = "gbxResumen";
            this.gbxResumen.Size = new System.Drawing.Size(275, 479);
            this.gbxResumen.TabIndex = 2;
            this.gbxResumen.TabStop = false;
            this.gbxResumen.Text = "Resumen del pedido";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(196, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "label7";
            // 
            // lblTPagar
            // 
            this.lblTPagar.AutoSize = true;
            this.lblTPagar.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPagar.Location = new System.Drawing.Point(29, 158);
            this.lblTPagar.Name = "lblTPagar";
            this.lblTPagar.Size = new System.Drawing.Size(69, 14);
            this.lblTPagar.TabIndex = 7;
            this.lblTPagar.Text = "Total a pagar";
            // 
            // lblGastosEnvio
            // 
            this.lblGastosEnvio.AutoSize = true;
            this.lblGastosEnvio.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosEnvio.Location = new System.Drawing.Point(196, 118);
            this.lblGastosEnvio.Name = "lblGastosEnvio";
            this.lblGastosEnvio.Size = new System.Drawing.Size(28, 14);
            this.lblGastosEnvio.TabIndex = 4;
            this.lblGastosEnvio.Text = "3.99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gastos de envío";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(29, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 14);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pedido 1 de 1: EasyShop";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(10, 450);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(259, 23);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
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
            // FrmAccesoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 501);
            this.Controls.Add(this.gbxResumen);
            this.Controls.Add(this.gbxOpcion);
            this.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAccesoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acceso pago";
            this.Load += new System.EventHandler(this.FrmAccesoPago_Load);
            this.gbxOpcion.ResumeLayout(false);
            this.gbxOpcion.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.gbxResumen.ResumeLayout(false);
            this.gbxResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxOpcion;
        private System.Windows.Forms.RadioButton rbtnCasa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbbtnTienda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Button btnDetalles;
        private System.Windows.Forms.Label lblResumenProductos;
        private System.Windows.Forms.FlowLayoutPanel flProductos;
        private Controles.CtrlProductoCarrito ctrlProductoCarrito1;
        private System.Windows.Forms.GroupBox gbxResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTPagar;
        private System.Windows.Forms.Label lblGastosEnvio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnOcultarDetalles;
    }
}