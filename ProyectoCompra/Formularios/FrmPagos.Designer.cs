namespace ProyectoCompra.Formularios
{
    partial class FrmPagos
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
            this.gbxFormaPago = new System.Windows.Forms.GroupBox();
            this.rbnTarjeta = new System.Windows.Forms.RadioButton();
            this.rbnEfectivo = new System.Windows.Forms.RadioButton();
            this.ctrlTarjeta1 = new ProyectoCompra.Controles.CtrlTarjeta();
            this.ctrlEfectivo1 = new ProyectoCompra.Controles.CtrlEfectivo();
            this.gbxFormaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxFormaPago
            // 
            this.gbxFormaPago.Controls.Add(this.rbnTarjeta);
            this.gbxFormaPago.Controls.Add(this.rbnEfectivo);
            this.gbxFormaPago.Location = new System.Drawing.Point(12, 12);
            this.gbxFormaPago.Name = "gbxFormaPago";
            this.gbxFormaPago.Size = new System.Drawing.Size(138, 44);
            this.gbxFormaPago.TabIndex = 0;
            this.gbxFormaPago.TabStop = false;
            this.gbxFormaPago.Text = "Método pago";
            // 
            // rbnTarjeta
            // 
            this.rbnTarjeta.AutoSize = true;
            this.rbnTarjeta.Location = new System.Drawing.Point(76, 19);
            this.rbnTarjeta.Name = "rbnTarjeta";
            this.rbnTarjeta.Size = new System.Drawing.Size(58, 17);
            this.rbnTarjeta.TabIndex = 2;
            this.rbnTarjeta.Text = "Tarjeta";
            this.rbnTarjeta.UseVisualStyleBackColor = true;
            this.rbnTarjeta.CheckedChanged += new System.EventHandler(this.rbnTarjeta_CheckedChanged);
            // 
            // rbnEfectivo
            // 
            this.rbnEfectivo.AutoSize = true;
            this.rbnEfectivo.Checked = true;
            this.rbnEfectivo.Location = new System.Drawing.Point(6, 19);
            this.rbnEfectivo.Name = "rbnEfectivo";
            this.rbnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.rbnEfectivo.TabIndex = 1;
            this.rbnEfectivo.TabStop = true;
            this.rbnEfectivo.Text = "Efectivo";
            this.rbnEfectivo.UseVisualStyleBackColor = true;
            this.rbnEfectivo.CheckedChanged += new System.EventHandler(this.rbnEfectivo_CheckedChanged);
            // 
            // ctrlTarjeta1
            // 
            this.ctrlTarjeta1.AutoSize = true;
            this.ctrlTarjeta1.BackColor = System.Drawing.Color.White;
            this.ctrlTarjeta1.Location = new System.Drawing.Point(12, 189);
            this.ctrlTarjeta1.Name = "ctrlTarjeta1";
            this.ctrlTarjeta1.Size = new System.Drawing.Size(341, 210);
            this.ctrlTarjeta1.TabIndex = 2;
            this.ctrlTarjeta1.Visible = false;
            // 
            // ctrlEfectivo1
            // 
            this.ctrlEfectivo1.AutoSize = true;
            this.ctrlEfectivo1.BackColor = System.Drawing.Color.White;
            this.ctrlEfectivo1.Location = new System.Drawing.Point(12, 62);
            this.ctrlEfectivo1.Name = "ctrlEfectivo1";
            this.ctrlEfectivo1.Size = new System.Drawing.Size(341, 129);
            this.ctrlEfectivo1.TabIndex = 1;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 401);
            this.Controls.Add(this.ctrlTarjeta1);
            this.Controls.Add(this.ctrlEfectivo1);
            this.Controls.Add(this.gbxFormaPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.gbxFormaPago.ResumeLayout(false);
            this.gbxFormaPago.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFormaPago;
        private System.Windows.Forms.RadioButton rbnTarjeta;
        private System.Windows.Forms.RadioButton rbnEfectivo;
        private Controles.CtrlEfectivo ctrlEfectivo1;
        private Controles.CtrlTarjeta ctrlTarjeta1;
    }
}