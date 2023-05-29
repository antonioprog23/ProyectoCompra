namespace ProyectoCompra.Controles
{
    partial class CtrlResumenPedido
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
            this.lblNumProductos = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRepetirPedido = new System.Windows.Forms.Button();
            this.lblTotalMostrar = new System.Windows.Forms.Label();
            this.lblProductosMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumProductos
            // 
            this.lblNumProductos.AutoSize = true;
            this.lblNumProductos.Location = new System.Drawing.Point(12, 11);
            this.lblNumProductos.Name = "lblNumProductos";
            this.lblNumProductos.Size = new System.Drawing.Size(55, 13);
            this.lblNumProductos.TabIndex = 0;
            this.lblNumProductos.Text = "Productos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total";
            // 
            // btnRepetirPedido
            // 
            this.btnRepetirPedido.Location = new System.Drawing.Point(3, 69);
            this.btnRepetirPedido.Name = "btnRepetirPedido";
            this.btnRepetirPedido.Size = new System.Drawing.Size(472, 23);
            this.btnRepetirPedido.TabIndex = 2;
            this.btnRepetirPedido.Text = "Repetir pedido";
            this.btnRepetirPedido.UseVisualStyleBackColor = true;
            this.btnRepetirPedido.Click += new System.EventHandler(this.btnRepetirPedido_Click);
            // 
            // lblTotalMostrar
            // 
            this.lblTotalMostrar.AutoSize = true;
            this.lblTotalMostrar.Location = new System.Drawing.Point(402, 34);
            this.lblTotalMostrar.Name = "lblTotalMostrar";
            this.lblTotalMostrar.Size = new System.Drawing.Size(31, 13);
            this.lblTotalMostrar.TabIndex = 4;
            this.lblTotalMostrar.Text = "Total";
            // 
            // lblProductosMostrar
            // 
            this.lblProductosMostrar.AutoSize = true;
            this.lblProductosMostrar.Location = new System.Drawing.Point(402, 11);
            this.lblProductosMostrar.Name = "lblProductosMostrar";
            this.lblProductosMostrar.Size = new System.Drawing.Size(55, 13);
            this.lblProductosMostrar.TabIndex = 3;
            this.lblProductosMostrar.Text = "Productos";
            // 
            // CtrlResumenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalMostrar);
            this.Controls.Add(this.lblProductosMostrar);
            this.Controls.Add(this.btnRepetirPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNumProductos);
            this.Name = "CtrlResumenPedido";
            this.Size = new System.Drawing.Size(478, 95);
            this.Load += new System.EventHandler(this.CtrlResumenPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRepetirPedido;
        private System.Windows.Forms.Label lblTotalMostrar;
        private System.Windows.Forms.Label lblProductosMostrar;
    }
}
