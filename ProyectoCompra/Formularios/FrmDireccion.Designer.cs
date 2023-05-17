namespace ProyectoCompra.Formularios
{
    partial class FrmDireccion
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
            this.btnAniadirDireccion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.ctrlDireccionMostrar = new ProyectoCompra.Controles.CtrlDireccion();
            this.SuspendLayout();
            // 
            // btnAniadirDireccion
            // 
            this.btnAniadirDireccion.Location = new System.Drawing.Point(247, 287);
            this.btnAniadirDireccion.Name = "btnAniadirDireccion";
            this.btnAniadirDireccion.Size = new System.Drawing.Size(75, 23);
            this.btnAniadirDireccion.TabIndex = 1;
            this.btnAniadirDireccion.Text = "Añadir";
            this.btnAniadirDireccion.UseVisualStyleBackColor = true;
            this.btnAniadirDireccion.Click += new System.EventHandler(this.btnAniadirDireccion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(247, 286);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(166, 287);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // ctrlDireccionMostrar
            // 
            this.ctrlDireccionMostrar.agregarDireccion = false;
            this.ctrlDireccionMostrar.AutoSize = true;
            this.ctrlDireccionMostrar.direccion = null;
            this.ctrlDireccionMostrar.groupBox = "Dirección (predeterminado)";
            this.ctrlDireccionMostrar.Location = new System.Drawing.Point(12, 11);
            this.ctrlDireccionMostrar.Name = "ctrlDireccionMostrar";
            this.ctrlDireccionMostrar.Size = new System.Drawing.Size(312, 269);
            this.ctrlDireccionMostrar.TabIndex = 0;
            // 
            // FrmDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(334, 322);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAniadirDireccion);
            this.Controls.Add(this.ctrlDireccionMostrar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDireccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Direcciones";
            this.Load += new System.EventHandler(this.FrmDireccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.CtrlDireccion ctrlDireccionMostrar;
        private System.Windows.Forms.Button btnAniadirDireccion;
        public System.Windows.Forms.Button btnAceptar;
        public System.Windows.Forms.Button btnCancelar;
    }
}