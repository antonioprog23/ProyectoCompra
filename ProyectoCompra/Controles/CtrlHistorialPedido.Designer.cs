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
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRealizado = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::ProyectoCompra.Properties.Resources.icon_compra;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 67);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(104, 92);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(116, 87);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(116, 109);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(102, 13);
            this.lblContador.TabIndex = 2;
            this.lblContador.Text = "Cantidad productos:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(116, 153);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(116, 131);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(73, 13);
            this.lblMetodoPago.TabIndex = 4;
            this.lblMetodoPago.Text = "Método pago:";
            // 
            // btnMasDetalles
            // 
            this.btnMasDetalles.Location = new System.Drawing.Point(343, 9);
            this.btnMasDetalles.Name = "btnMasDetalles";
            this.btnMasDetalles.Size = new System.Drawing.Size(75, 23);
            this.btnMasDetalles.TabIndex = 5;
            this.btnMasDetalles.Text = "Más detalles";
            this.btnMasDetalles.UseVisualStyleBackColor = true;
            this.btnMasDetalles.Click += new System.EventHandler(this.btnMasDetalles_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(116, 65);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID:";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panel1);
            this.groupBox.Controls.Add(this.lblId);
            this.groupBox.Controls.Add(this.flowLayoutPanel1);
            this.groupBox.Controls.Add(this.lblMetodoPago);
            this.groupBox.Controls.Add(this.lblFecha);
            this.groupBox.Controls.Add(this.lblContador);
            this.groupBox.Controls.Add(this.lblTotal);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(436, 173);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnRealizado);
            this.panel1.Controls.Add(this.btnMasDetalles);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 40);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(45, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Pedido vendido y enviado por EasyShop";
            // 
            // btnRealizado
            // 
            this.btnRealizado.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRealizado.FlatAppearance.BorderSize = 0;
            this.btnRealizado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnRealizado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizado.Image = global::ProyectoCompra.Properties.Resources.icon_compra_realizada;
            this.btnRealizado.Location = new System.Drawing.Point(3, 3);
            this.btnRealizado.Name = "btnRealizado";
            this.btnRealizado.Size = new System.Drawing.Size(36, 34);
            this.btnRealizado.TabIndex = 6;
            this.btnRealizado.UseVisualStyleBackColor = true;
            // 
            // CtrlHistorialPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox);
            this.Name = "CtrlHistorialPedido";
            this.Size = new System.Drawing.Size(439, 176);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Button btnMasDetalles;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRealizado;
    }
}
