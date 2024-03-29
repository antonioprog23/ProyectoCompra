﻿namespace ProyectoCompra.Formularios
{
    partial class FrmDetalleProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleProducto));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.flPanelImage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblImage = new System.Windows.Forms.Label();
            this.dwCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFabricanteMostrar = new System.Windows.Forms.Label();
            this.lblPrecioMostrar = new System.Windows.Forms.Label();
            this.lblDescripcionMostrar = new System.Windows.Forms.Label();
            this.lblNombreMostrar = new System.Windows.Forms.Label();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.flPanelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwCantidad)).BeginInit();
            this.SuspendLayout();
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
            this.btnAgregar.Location = new System.Drawing.Point(413, 147);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregar.Size = new System.Drawing.Size(35, 32);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // flPanelImage
            // 
            this.flPanelImage.AutoSize = true;
            this.flPanelImage.Controls.Add(this.lblImage);
            this.flPanelImage.Location = new System.Drawing.Point(3, 4);
            this.flPanelImage.Name = "flPanelImage";
            this.flPanelImage.Size = new System.Drawing.Size(194, 183);
            this.flPanelImage.TabIndex = 13;
            // 
            // lblImage
            // 
            this.lblImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblImage.Location = new System.Drawing.Point(3, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(188, 178);
            this.lblImage.TabIndex = 1;
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dwCantidad
            // 
            this.dwCantidad.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dwCantidad.Location = new System.Drawing.Point(295, 137);
            this.dwCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dwCantidad.Name = "dwCantidad";
            this.dwCantidad.Size = new System.Drawing.Size(63, 21);
            this.dwCantidad.TabIndex = 23;
            this.dwCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dwCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(219, 139);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(51, 14);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblFabricanteMostrar
            // 
            this.lblFabricanteMostrar.AutoSize = true;
            this.lblFabricanteMostrar.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFabricanteMostrar.Location = new System.Drawing.Point(292, 110);
            this.lblFabricanteMostrar.Name = "lblFabricanteMostrar";
            this.lblFabricanteMostrar.Size = new System.Drawing.Size(61, 14);
            this.lblFabricanteMostrar.TabIndex = 21;
            this.lblFabricanteMostrar.Text = "Fabricante:";
            // 
            // lblPrecioMostrar
            // 
            this.lblPrecioMostrar.AutoSize = true;
            this.lblPrecioMostrar.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioMostrar.Location = new System.Drawing.Point(292, 85);
            this.lblPrecioMostrar.Name = "lblPrecioMostrar";
            this.lblPrecioMostrar.Size = new System.Drawing.Size(41, 14);
            this.lblPrecioMostrar.TabIndex = 20;
            this.lblPrecioMostrar.Text = "Precio:";
            // 
            // lblDescripcionMostrar
            // 
            this.lblDescripcionMostrar.AutoSize = true;
            this.lblDescripcionMostrar.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionMostrar.Location = new System.Drawing.Point(292, 62);
            this.lblDescripcionMostrar.Name = "lblDescripcionMostrar";
            this.lblDescripcionMostrar.Size = new System.Drawing.Size(67, 14);
            this.lblDescripcionMostrar.TabIndex = 19;
            this.lblDescripcionMostrar.Text = "Descripción:";
            // 
            // lblNombreMostrar
            // 
            this.lblNombreMostrar.AutoSize = true;
            this.lblNombreMostrar.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMostrar.Location = new System.Drawing.Point(292, 37);
            this.lblNombreMostrar.Name = "lblNombreMostrar";
            this.lblNombreMostrar.Size = new System.Drawing.Size(49, 14);
            this.lblNombreMostrar.TabIndex = 18;
            this.lblNombreMostrar.Text = "Nombre:";
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(219, 110);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(60, 14);
            this.lblFabricante.TabIndex = 17;
            this.lblFabricante.Text = "Fabricante:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(219, 85);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(41, 14);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(219, 62);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(67, 14);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(219, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 14);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre:";
            // 
            // FrmDetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 188);
            this.Controls.Add(this.dwCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblFabricanteMostrar);
            this.Controls.Add(this.lblPrecioMostrar);
            this.Controls.Add(this.lblDescripcionMostrar);
            this.Controls.Add(this.lblNombreMostrar);
            this.Controls.Add(this.lblFabricante);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.flPanelImage);
            this.Controls.Add(this.btnAgregar);
            this.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del producto";
            this.Load += new System.EventHandler(this.FrmDetalleProducto_Load);
            this.flPanelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dwCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.FlowLayoutPanel flPanelImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.NumericUpDown dwCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFabricanteMostrar;
        private System.Windows.Forms.Label lblPrecioMostrar;
        private System.Windows.Forms.Label lblDescripcionMostrar;
        private System.Windows.Forms.Label lblNombreMostrar;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
    }
}