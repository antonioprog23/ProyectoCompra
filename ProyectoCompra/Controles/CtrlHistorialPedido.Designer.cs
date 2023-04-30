namespace ProyectoCompra.Controles
{
    partial class CtrlHistorialPedido
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.btnMasDetalles = new System.Windows.Forms.Button();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::ProyectoCompra.Properties.Resources.icon_compra;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(104, 134);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(113, 35);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(113, 57);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(102, 13);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Cantidad productos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(113, 101);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(113, 79);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(73, 13);
            this.lblMetodoPago.TabIndex = 4;
            this.lblMetodoPago.Text = "Método pago:";
            // 
            // btnMasDetalles
            // 
            this.btnMasDetalles.Location = new System.Drawing.Point(285, 114);
            this.btnMasDetalles.Name = "btnMasDetalles";
            this.btnMasDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnMasDetalles.TabIndex = 5;
            this.btnMasDetalles.Text = "Más detalles";
            this.btnMasDetalles.UseVisualStyleBackColor = true;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(325, 3);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroPedido.TabIndex = 6;
            this.lblNumeroPedido.Text = "label1";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(113, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID:";
            // 
            // CtrlHistorialPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNumeroPedido);
            this.Controls.Add(this.btnMasDetalles);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CtrlHistorialPedido";
            this.Size = new System.Drawing.Size(363, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Button btnMasDetalles;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.Label lblId;
    }
}
