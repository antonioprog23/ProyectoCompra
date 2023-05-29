namespace ProyectoCompra.Controles
{
    partial class CtrlProductoHistorial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlProductoHistorial));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDMostrar = new System.Windows.Forms.Label();
            this.lblCantidadMostrar = new System.Windows.Forms.Label();
            this.lblNombreMostrar = new System.Windows.Forms.Label();
            this.lblPrecioMostrar = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDMostrar);
            this.groupBox1.Controls.Add(this.lblCantidadMostrar);
            this.groupBox1.Controls.Add(this.lblNombreMostrar);
            this.groupBox1.Controls.Add(this.lblPrecioMostrar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.lblIdProducto);
            this.groupBox1.Controls.Add(this.lblCantidad);
            this.groupBox1.Controls.Add(this.lblPrecio);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblImage);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblIDMostrar
            // 
            this.lblIDMostrar.AutoSize = true;
            this.lblIDMostrar.Location = new System.Drawing.Point(258, 45);
            this.lblIDMostrar.Name = "lblIDMostrar";
            this.lblIDMostrar.Size = new System.Drawing.Size(13, 13);
            this.lblIDMostrar.TabIndex = 18;
            this.lblIDMostrar.Text = "0";
            // 
            // lblCantidadMostrar
            // 
            this.lblCantidadMostrar.AutoSize = true;
            this.lblCantidadMostrar.Location = new System.Drawing.Point(258, 67);
            this.lblCantidadMostrar.Name = "lblCantidadMostrar";
            this.lblCantidadMostrar.Size = new System.Drawing.Size(13, 13);
            this.lblCantidadMostrar.TabIndex = 17;
            this.lblCantidadMostrar.Text = "0";
            // 
            // lblNombreMostrar
            // 
            this.lblNombreMostrar.AutoSize = true;
            this.lblNombreMostrar.Location = new System.Drawing.Point(257, 90);
            this.lblNombreMostrar.Name = "lblNombreMostrar";
            this.lblNombreMostrar.Size = new System.Drawing.Size(49, 13);
            this.lblNombreMostrar.TabIndex = 16;
            this.lblNombreMostrar.Text = "XXXXXX";
            // 
            // lblPrecioMostrar
            // 
            this.lblPrecioMostrar.AutoSize = true;
            this.lblPrecioMostrar.Location = new System.Drawing.Point(258, 112);
            this.lblPrecioMostrar.Name = "lblPrecioMostrar";
            this.lblPrecioMostrar.Size = new System.Drawing.Size(13, 13);
            this.lblPrecioMostrar.TabIndex = 14;
            this.lblPrecioMostrar.Text = "0";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(386, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregar.Size = new System.Drawing.Size(35, 32);
            this.btnAgregar.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar al carrito.");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(199, 45);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(21, 13);
            this.lblIdProducto.TabIndex = 9;
            this.lblIdProducto.Text = "ID:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(200, 67);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(199, 112);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(199, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblImage
            // 
            this.lblImage.Location = new System.Drawing.Point(6, 14);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(187, 151);
            this.lblImage.TabIndex = 0;
            // 
            // CtrlProductoHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CtrlProductoHistorial";
            this.Size = new System.Drawing.Size(433, 171);
            this.Load += new System.EventHandler(this.CtrlProductoHistorial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioMostrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblIDMostrar;
        private System.Windows.Forms.Label lblCantidadMostrar;
        private System.Windows.Forms.Label lblNombreMostrar;
    }
}
