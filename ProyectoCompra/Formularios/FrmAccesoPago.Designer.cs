namespace ProyectoCompra.Formularios
{
    partial class FrmAccesoPago
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
            this.gbxResumen = new System.Windows.Forms.GroupBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTPagar = new System.Windows.Forms.Label();
            this.lblGastosEnvio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxResumen
            // 
            this.gbxResumen.Controls.Add(this.btnContinuar);
            this.gbxResumen.Controls.Add(this.lblTotal);
            this.gbxResumen.Controls.Add(this.lblTPagar);
            this.gbxResumen.Controls.Add(this.lblGastosEnvio);
            this.gbxResumen.Controls.Add(this.label4);
            this.gbxResumen.Controls.Add(this.lblPTotal);
            this.gbxResumen.Controls.Add(this.label1);
            this.gbxResumen.Controls.Add(this.lblTitle);
            this.gbxResumen.Location = new System.Drawing.Point(526, 18);
            this.gbxResumen.Name = "gbxResumen";
            this.gbxResumen.Size = new System.Drawing.Size(275, 504);
            this.gbxResumen.TabIndex = 2;
            this.gbxResumen.TabStop = false;
            this.gbxResumen.Text = "Resumen del pedido";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Enabled = false;
            this.btnContinuar.Location = new System.Drawing.Point(10, 475);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(259, 23);
            this.btnContinuar.TabIndex = 9;
            this.btnContinuar.Text = "Realizar pedido";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Nova", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(196, 158);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "label7";
            // 
            // lblTPagar
            // 
            this.lblTPagar.AutoSize = true;
            this.lblTPagar.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTPagar.Location = new System.Drawing.Point(29, 158);
            this.lblTPagar.Name = "lblTPagar";
            this.lblTPagar.Size = new System.Drawing.Size(69, 14);
            this.lblTPagar.TabIndex = 7;
            this.lblTPagar.Text = "Total a pagar";
            // 
            // lblGastosEnvio
            // 
            this.lblGastosEnvio.AutoSize = true;
            this.lblGastosEnvio.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosEnvio.Location = new System.Drawing.Point(196, 118);
            this.lblGastosEnvio.Name = "lblGastosEnvio";
            this.lblGastosEnvio.Size = new System.Drawing.Size(28, 14);
            this.lblGastosEnvio.TabIndex = 4;
            this.lblGastosEnvio.Text = "3,99";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gastos de envío";
            // 
            // lblPTotal
            // 
            this.lblPTotal.AutoSize = true;
            this.lblPTotal.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTotal.Location = new System.Drawing.Point(196, 84);
            this.lblPTotal.Name = "lblPTotal";
            this.lblPTotal.Size = new System.Drawing.Size(35, 14);
            this.lblPTotal.TabIndex = 2;
            this.lblPTotal.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Productos";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(29, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 14);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pedido 1 de 1: EasyShop";
            // 
            // ctrlEnvio1
            // 
            this.ctrlEnvio1.AutoSize = true;
            this.ctrlEnvio1.btnContinuar = this.btnContinuar;
            this.ctrlEnvio1.carritoListo = null;
            this.ctrlEnvio1.carritoProvisionalListo = null;
            this.ctrlEnvio1.direcciones = null;
            this.ctrlEnvio1.isEfectivoElegida = false;
            this.ctrlEnvio1.Location = new System.Drawing.Point(12, 12);
            this.ctrlEnvio1.Name = "ctrlEnvio1";
            this.ctrlEnvio1.Size = new System.Drawing.Size(509, 513);
            this.ctrlEnvio1.TabIndex = 3;
            this.ctrlEnvio1.tarjetaCredit = null;
            // 
            // FrmAccesoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 534);
            this.Controls.Add(this.ctrlEnvio1);
            this.Controls.Add(this.gbxResumen);
            this.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAccesoPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acceso pago";
            this.Load += new System.EventHandler(this.FrmAccesoPago_Load);
            this.gbxResumen.ResumeLayout(false);
            this.gbxResumen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTPagar;
        private System.Windows.Forms.Label lblGastosEnvio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private Controles.CtrlEnvio ctrlEnvio1;
        public System.Windows.Forms.Button btnContinuar;
    }
}