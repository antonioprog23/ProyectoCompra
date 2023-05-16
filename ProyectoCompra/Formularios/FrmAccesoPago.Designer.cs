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
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.btnDetalles = new System.Windows.Forms.Button();
            this.lblResumenProductos = new System.Windows.Forms.Label();
            this.btnOcultarDetalles = new System.Windows.Forms.Button();
            this.flProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.rbtnCasa = new System.Windows.Forms.RadioButton();
            this.rbbtnTienda = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxResumen = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTPagar = new System.Windows.Forms.Label();
            this.lblGastosEnvio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlProductos = new System.Windows.Forms.TableLayoutPanel();
            this.gbxOpcion.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.flProductos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbxResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOpcion
            // 
            this.gbxOpcion.Controls.Add(this.groupBox3);
            this.gbxOpcion.Controls.Add(this.rbbtnTienda);
            this.gbxOpcion.Controls.Add(this.lblTitulo);
            this.gbxOpcion.Controls.Add(this.groupBox4);
            this.gbxOpcion.Controls.Add(this.panelDetalles);
            this.gbxOpcion.Location = new System.Drawing.Point(12, 10);
            this.gbxOpcion.Name = "gbxOpcion";
            this.gbxOpcion.Size = new System.Drawing.Size(503, 481);
            this.gbxOpcion.TabIndex = 1;
            this.gbxOpcion.TabStop = false;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.flProductos);
            this.panelDetalles.Controls.Add(this.btnDetalles);
            this.panelDetalles.Controls.Add(this.lblResumenProductos);
            this.panelDetalles.Controls.Add(this.btnOcultarDetalles);
            this.panelDetalles.Location = new System.Drawing.Point(20, 213);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(477, 245);
            this.panelDetalles.TabIndex = 7;
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
            // flProductos
            // 
            this.flProductos.AutoScroll = true;
            this.flProductos.Controls.Add(this.tlProductos);
            this.flProductos.Location = new System.Drawing.Point(3, 42);
            this.flProductos.Name = "flProductos";
            this.flProductos.Size = new System.Drawing.Size(471, 200);
            this.flProductos.TabIndex = 6;
            this.flProductos.Visible = false;
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
            // gbxResumen
            // 
            this.gbxResumen.Controls.Add(this.btnContinuar);
            this.gbxResumen.Controls.Add(this.lblTotal);
            this.gbxResumen.Controls.Add(this.lblTPagar);
            this.gbxResumen.Controls.Add(this.lblGastosEnvio);
            this.gbxResumen.Controls.Add(this.label4);
            this.gbxResumen.Controls.Add(this.lblPTotal);
            this.gbxResumen.Controls.Add(this.label1);
            this.gbxResumen.Controls.Add(this.lblTitle);
            this.gbxResumen.Location = new System.Drawing.Point(526, 12);
            this.gbxResumen.Name = "gbxResumen";
            this.gbxResumen.Size = new System.Drawing.Size(275, 479);
            this.gbxResumen.TabIndex = 2;
            this.gbxResumen.TabStop = false;
            this.gbxResumen.Text = "Resumen del pedido";
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
            this.lblGastosEnvio.Text = "3,99";
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
            // lblPTotal
            // 
            this.lblPTotal.AutoSize = true;
            this.lblPTotal.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotal.Location = new System.Drawing.Point(196, 84);
            this.lblPTotal.Name = "lblPTotal";
            this.lblPTotal.Size = new System.Drawing.Size(35, 14);
            this.lblPTotal.TabIndex = 2;
            this.lblPTotal.Text = "label2";
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
            // FrmAccesoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 507);
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
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.flProductos.ResumeLayout(false);
            this.flProductos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbxResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTPagar;
        private System.Windows.Forms.Label lblGastosEnvio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnOcultarDetalles;
        private System.Windows.Forms.TableLayoutPanel tlProductos;
    }
}