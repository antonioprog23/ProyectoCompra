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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbProductos = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSubTotal = new System.Windows.Forms.GroupBox();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.gbIVA = new System.Windows.Forms.GroupBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.gbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.lblContador = new System.Windows.Forms.Label();
            this.lblCarritoVacio = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbSubTotal.SuspendLayout();
            this.gbIVA.SuspendLayout();
            this.gbTotal.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVaciarCarrito
            // 
            this.btnVaciarCarrito.Location = new System.Drawing.Point(365, 518);
            this.btnVaciarCarrito.Name = "btnVaciarCarrito";
            this.btnVaciarCarrito.Size = new System.Drawing.Size(102, 25);
            this.btnVaciarCarrito.TabIndex = 3;
            this.btnVaciarCarrito.Text = "Vaciar carrito";
            this.btnVaciarCarrito.UseVisualStyleBackColor = true;
            this.btnVaciarCarrito.Visible = false;
            this.btnVaciarCarrito.Click += new System.EventHandler(this.btnVaciarCarrito_Click);
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(6, 513);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(144, 25);
            this.btnConfirmarCompra.TabIndex = 2;
            this.btnConfirmarCompra.Text = "Confirmar compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Visible = false;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tbProductos);
            this.flowLayoutPanel1.Controls.Add(this.lblCarritoVacio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(465, 510);
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(473, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(164, 547);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnConfirmarCompra);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 544);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbSubTotal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbIVA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gbTotal, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.gbProductos, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 488);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // gbSubTotal
            // 
            this.gbSubTotal.Controls.Add(this.lblSubTotal);
            this.gbSubTotal.Location = new System.Drawing.Point(3, 247);
            this.gbSubTotal.Name = "gbSubTotal";
            this.gbSubTotal.Size = new System.Drawing.Size(144, 115);
            this.gbSubTotal.TabIndex = 7;
            this.gbSubTotal.TabStop = false;
            this.gbSubTotal.Text = "SubTotal";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Location = new System.Drawing.Point(6, 17);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(132, 95);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "label4";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbIVA
            // 
            this.gbIVA.Controls.Add(this.lblIVA);
            this.gbIVA.Location = new System.Drawing.Point(3, 125);
            this.gbIVA.Name = "gbIVA";
            this.gbIVA.Size = new System.Drawing.Size(144, 116);
            this.gbIVA.TabIndex = 7;
            this.gbIVA.TabStop = false;
            this.gbIVA.Text = "%IVA";
            // 
            // lblIVA
            // 
            this.lblIVA.Location = new System.Drawing.Point(6, 17);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(132, 96);
            this.lblIVA.TabIndex = 0;
            this.lblIVA.Text = "3";
            this.lblIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbTotal
            // 
            this.gbTotal.Controls.Add(this.lblTotal);
            this.gbTotal.Location = new System.Drawing.Point(3, 369);
            this.gbTotal.Name = "gbTotal";
            this.gbTotal.Size = new System.Drawing.Size(144, 112);
            this.gbTotal.TabIndex = 5;
            this.gbTotal.TabStop = false;
            this.gbTotal.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(6, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 92);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label2";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.lblContador);
            this.gbProductos.Location = new System.Drawing.Point(3, 3);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(144, 114);
            this.gbProductos.TabIndex = 4;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // lblContador
            // 
            this.lblContador.Location = new System.Drawing.Point(6, 17);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(132, 94);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "label1";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCarritoVacio
            // 
            this.lblCarritoVacio.Font = new System.Drawing.Font("Arial Nova Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarritoVacio.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCarritoVacio.Location = new System.Drawing.Point(3, 6);
            this.lblCarritoVacio.Name = "lblCarritoVacio";
            this.lblCarritoVacio.Size = new System.Drawing.Size(456, 501);
            this.lblCarritoVacio.TabIndex = 1;
            this.lblCarritoVacio.Text = "Ops... el carrito está vacío :/";
            this.lblCarritoVacio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCarritoVacio.Visible = false;
            // 
            // FrmCarrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 553);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnVaciarCarrito);
            this.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCarrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cesta de productos";
            this.Load += new System.EventHandler(this.FrmCarrito_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbSubTotal.ResumeLayout(false);
            this.gbIVA.ResumeLayout(false);
            this.gbTotal.ResumeLayout(false);
            this.gbProductos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnVaciarCarrito;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbProductos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.GroupBox gbSubTotal;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.GroupBox gbIVA;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.GroupBox gbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCarritoVacio;
    }
}