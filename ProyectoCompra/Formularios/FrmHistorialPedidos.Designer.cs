namespace ProyectoCompra.Formularios
{
    partial class FrmHistorialPedidos
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPedidosLista = new System.Windows.Forms.TableLayoutPanel();
            this.ctrlHistorialPedido1 = new ProyectoCompra.Controles.CtrlHistorialPedido();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.tbPedidosLista);
            this.flowLayoutPanel1.Controls.Add(this.ctrlHistorialPedido1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(469, 190);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tbPedidosLista
            // 
            this.tbPedidosLista.AutoScroll = true;
            this.tbPedidosLista.AutoSize = true;
            this.tbPedidosLista.ColumnCount = 1;
            this.tbPedidosLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbPedidosLista.Location = new System.Drawing.Point(3, 3);
            this.tbPedidosLista.Name = "tbPedidosLista";
            this.tbPedidosLista.RowCount = 1;
            this.tbPedidosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbPedidosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbPedidosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbPedidosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbPedidosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbPedidosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbPedidosLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tbPedidosLista.Size = new System.Drawing.Size(0, 0);
            this.tbPedidosLista.TabIndex = 0;
            // 
            // ctrlHistorialPedido1
            // 
            this.ctrlHistorialPedido1.AutoSize = true;
            this.ctrlHistorialPedido1.BackColor = System.Drawing.Color.White;
            this.ctrlHistorialPedido1.Location = new System.Drawing.Point(9, 3);
            this.ctrlHistorialPedido1.Name = "ctrlHistorialPedido1";
            this.ctrlHistorialPedido1.Size = new System.Drawing.Size(439, 176);
            this.ctrlHistorialPedido1.TabIndex = 1;
            this.ctrlHistorialPedido1.Visible = false;
            // 
            // FrmHistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 206);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHistorialPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial pedidos";
            this.Load += new System.EventHandler(this.FrmHistorialPedidos_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbPedidosLista;
        private Controles.CtrlHistorialPedido ctrlHistorialPedido1;
    }
}