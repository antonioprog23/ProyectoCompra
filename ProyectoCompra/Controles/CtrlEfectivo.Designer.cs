namespace ProyectoCompra.Controles
{
    partial class CtrlEfectivo
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
            this.gbxEfectivo = new System.Windows.Forms.GroupBox();
            this.lblDireccion2 = new System.Windows.Forms.Label();
            this.txtDireccion2 = new System.Windows.Forms.TextBox();
            this.lblDireccion1 = new System.Windows.Forms.Label();
            this.txtDireccion1 = new System.Windows.Forms.TextBox();
            this.gbxEfectivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxEfectivo
            // 
            this.gbxEfectivo.AutoSize = true;
            this.gbxEfectivo.Controls.Add(this.lblDireccion2);
            this.gbxEfectivo.Controls.Add(this.txtDireccion2);
            this.gbxEfectivo.Controls.Add(this.lblDireccion1);
            this.gbxEfectivo.Controls.Add(this.txtDireccion1);
            this.gbxEfectivo.Location = new System.Drawing.Point(0, 0);
            this.gbxEfectivo.Name = "gbxEfectivo";
            this.gbxEfectivo.Size = new System.Drawing.Size(335, 98);
            this.gbxEfectivo.TabIndex = 2;
            this.gbxEfectivo.TabStop = false;
            this.gbxEfectivo.Text = "Efectivo";
            // 
            // lblDireccion2
            // 
            this.lblDireccion2.AutoSize = true;
            this.lblDireccion2.Enabled = false;
            this.lblDireccion2.Location = new System.Drawing.Point(20, 57);
            this.lblDireccion2.Name = "lblDireccion2";
            this.lblDireccion2.Size = new System.Drawing.Size(107, 13);
            this.lblDireccion2.TabIndex = 4;
            this.lblDireccion2.Text = "Dirección alternativa:";
            // 
            // txtDireccion2
            // 
            this.txtDireccion2.Enabled = false;
            this.txtDireccion2.Location = new System.Drawing.Point(133, 54);
            this.txtDireccion2.Name = "txtDireccion2";
            this.txtDireccion2.ReadOnly = true;
            this.txtDireccion2.Size = new System.Drawing.Size(182, 20);
            this.txtDireccion2.TabIndex = 3;
            this.txtDireccion2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDireccion1
            // 
            this.lblDireccion1.AutoSize = true;
            this.lblDireccion1.Location = new System.Drawing.Point(20, 31);
            this.lblDireccion1.Name = "lblDireccion1";
            this.lblDireccion1.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion1.TabIndex = 1;
            this.lblDireccion1.Text = "Dirección:";
            // 
            // txtDireccion1
            // 
            this.txtDireccion1.Location = new System.Drawing.Point(133, 28);
            this.txtDireccion1.Name = "txtDireccion1";
            this.txtDireccion1.ReadOnly = true;
            this.txtDireccion1.Size = new System.Drawing.Size(182, 20);
            this.txtDireccion1.TabIndex = 0;
            this.txtDireccion1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CtrlEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbxEfectivo);
            this.Name = "CtrlEfectivo";
            this.Size = new System.Drawing.Size(338, 101);
            this.Load += new System.EventHandler(this.CtrlEfectivo_Load);
            this.gbxEfectivo.ResumeLayout(false);
            this.gbxEfectivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxEfectivo;
        private System.Windows.Forms.Label lblDireccion2;
        private System.Windows.Forms.TextBox txtDireccion2;
        private System.Windows.Forms.Label lblDireccion1;
        private System.Windows.Forms.TextBox txtDireccion1;
    }
}
