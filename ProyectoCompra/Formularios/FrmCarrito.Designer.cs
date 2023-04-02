namespace ProyectoCompra.Formularios
{
    partial class FrmCarrito
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
            this.btnVaciarCarrito = new System.Windows.Forms.Button();
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.btnSeguirComprando = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbProductos = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.Location = new System.Drawing.Point(368, 479);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(171, 25);
            this.btnVaciarCarrito.TabIndex = 3;
            this.btnVaciarCarrito.Text = "Vaciar carrito";
            this.btnVaciarCarrito.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(42, 479);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(128, 25);
            this.btnConfirmarCompra.TabIndex = 2;
            this.btnConfirmarCompra.Text = "Confirmar compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnSeguirComprando
            // 
            this.btnSeguirComprando.Location = new System.Drawing.Point(176, 479);
            this.btnSeguirComprando.Name = "btnSeguirComprando";
            this.btnSeguirComprando.Size = new System.Drawing.Size(186, 25);
            this.btnSeguirComprando.TabIndex = 4;
            this.btnSeguirComprando.Text = "Seguir comprando";
            this.btnSeguirComprando.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tbProductos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(537, 471);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tbProductos
            // 
            this.tbProductos.AutoSize = true;
            this.tbProductos.ColumnCount = 1;
            this.tbProductos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbProductos.Location = new System.Drawing.Point(3, 3);
            this.tbProductos.Name = "tbProductos";
            this.tbProductos.RowCount = 2;
            this.tbProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbProductos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbProductos.Size = new System.Drawing.Size(0, 0);
            this.tbProductos.TabIndex = 0;
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 511);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnVaciarCarrito);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Controls.Add(this.btnSeguirComprando);
            this.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cesta de productos";
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.Button btnSeguirComprando;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbProductos;
    }
}