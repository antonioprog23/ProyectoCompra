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
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPedidosLista = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtHasta = new System.Windows.Forms.DateTimePicker();
            this.lblContadorPedidos = new System.Windows.Forms.Label();
            this.lblNotificadorPedidos = new System.Windows.Forms.Label();
            this.flPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.Controls.Add(this.tbPedidosLista);
            this.flPanel.Controls.Add(this.lblNotificadorPedidos);
            this.flPanel.Location = new System.Drawing.Point(12, 60);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(469, 190);
            this.flPanel.TabIndex = 0;
            // 
            // tbPedidosLista
            // 
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
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ProyectoCompra.Properties.Resources.icon_busca;
            this.btnBuscar.Location = new System.Drawing.Point(429, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 22);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtDesde
            // 
            this.dtDesde.Location = new System.Drawing.Point(17, 34);
            this.dtDesde.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtDesde.Name = "dtDesde";
            this.dtDesde.Size = new System.Drawing.Size(200, 20);
            this.dtDesde.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(14, 18);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(220, 18);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 6;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtHasta
            // 
            this.dtHasta.Location = new System.Drawing.Point(223, 34);
            this.dtHasta.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtHasta.Name = "dtHasta";
            this.dtHasta.Size = new System.Drawing.Size(200, 20);
            this.dtHasta.TabIndex = 5;
            // 
            // lblContadorPedidos
            // 
            this.lblContadorPedidos.AutoSize = true;
            this.lblContadorPedidos.Location = new System.Drawing.Point(355, 253);
            this.lblContadorPedidos.Name = "lblContadorPedidos";
            this.lblContadorPedidos.Size = new System.Drawing.Size(84, 13);
            this.lblContadorPedidos.TabIndex = 7;
            this.lblContadorPedidos.Text = "Pedidos filtrados";
            this.lblContadorPedidos.Visible = false;
            // 
            // lblNotificadorPedidos
            // 
            this.lblNotificadorPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificadorPedidos.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lblNotificadorPedidos.Location = new System.Drawing.Point(3, 6);
            this.lblNotificadorPedidos.Name = "lblNotificadorPedidos";
            this.lblNotificadorPedidos.Size = new System.Drawing.Size(460, 180);
            this.lblNotificadorPedidos.TabIndex = 1;
            this.lblNotificadorPedidos.Text = "Pedidos filtrados (0)";
            this.lblNotificadorPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHistorialPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 276);
            this.Controls.Add(this.lblContadorPedidos);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtDesde);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.flPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmHistorialPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Historial pedidos";
            this.Load += new System.EventHandler(this.FrmHistorialPedidos_Load);
            this.flPanel.ResumeLayout(false);
            this.flPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private System.Windows.Forms.TableLayoutPanel tbPedidosLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtHasta;
        private System.Windows.Forms.Label lblContadorPedidos;
        private System.Windows.Forms.Label lblNotificadorPedidos;
    }
}