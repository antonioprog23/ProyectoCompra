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
            // 
            // CtrlResumenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRepetirPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNumProductos);
            this.Name = "CtrlResumenPedido";
            this.Size = new System.Drawing.Size(478, 95);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumProductos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRepetirPedido;
    }
}
