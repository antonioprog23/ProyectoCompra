namespace ProyectoCompra.Controles
{
    partial class CtrlProductoCarrito
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioMostrar = new System.Windows.Forms.Label();
            this.lblNombreMostrar = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cantidad);
            this.groupBox1.Controls.Add(this.lblPrecioMostrar);
            this.groupBox1.Controls.Add(this.lblNombreMostrar);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(185, 73);
            this.cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(51, 20);
            this.cantidad.TabIndex = 8;
            this.cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrecioMostrar
            // 
            this.lblPrecioMostrar.AutoSize = true;
            this.lblPrecioMostrar.Location = new System.Drawing.Point(180, 51);
            this.lblPrecioMostrar.Name = "lblPrecioMostrar";
            this.lblPrecioMostrar.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioMostrar.TabIndex = 6;
            // 
            // lblNombreMostrar
            // 
            this.lblNombreMostrar.AutoSize = true;
            this.lblNombreMostrar.Location = new System.Drawing.Point(180, 29);
            this.lblNombreMostrar.Name = "lblNombreMostrar";
            this.lblNombreMostrar.Size = new System.Drawing.Size(0, 13);
            this.lblNombreMostrar.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(127, 75);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(127, 51);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(127, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(305, 81);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(6, 16);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(100, 88);
            this.lblImage.TabIndex = 0;
            // 
            // CtrlProductoCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.groupBox1);
            this.Name = "CtrlProductoCarrito";
            this.Size = new System.Drawing.Size(391, 113);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrecioMostrar;
        private System.Windows.Forms.Label lblNombreMostrar;
        private System.Windows.Forms.NumericUpDown cantidad;
    }
}
