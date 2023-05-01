namespace ProyectoCompra.Formularios
{
    partial class FrmVerificarCuenta
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbx = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ctrlTextoCodigo = new ProyectoCompra.Controles.CtrlTextoBox();
            this.gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(15, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(100, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Código verificación:";
            // 
            // gbx
            // 
            this.gbx.Controls.Add(this.ctrlTextoCodigo);
            this.gbx.Controls.Add(this.lblCodigo);
            this.gbx.Location = new System.Drawing.Point(12, 12);
            this.gbx.Name = "gbx";
            this.gbx.Size = new System.Drawing.Size(291, 55);
            this.gbx.TabIndex = 2;
            this.gbx.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(228, 73);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ctrlTextoCodigo
            // 
            this.ctrlTextoCodigo.AutoSize = true;
            this.ctrlTextoCodigo.IsNumerico = true;
            this.ctrlTextoCodigo.Location = new System.Drawing.Point(121, 19);
            this.ctrlTextoCodigo.Name = "ctrlTextoCodigo";
            this.ctrlTextoCodigo.Size = new System.Drawing.Size(151, 20);
            this.ctrlTextoCodigo.TabIndex = 2;
            this.ctrlTextoCodigo.Texto = "";
            // 
            // FrmVerificarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(315, 111);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmVerificarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verificar cuenta";
            this.gbx.ResumeLayout(false);
            this.gbx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbx;
        private Controles.CtrlTextoBox ctrlTextoCodigo;
        private System.Windows.Forms.Button btnAceptar;
    }
}