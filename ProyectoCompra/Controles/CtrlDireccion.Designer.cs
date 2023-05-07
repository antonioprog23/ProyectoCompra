namespace ProyectoCompra.Controles
{
    partial class CtrlDireccion
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
            this.gbxDireccionDefecto = new System.Windows.Forms.GroupBox();
            this.ctrlTxtTelefono = new ProyectoCompra.Controles.CtrlTextoBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.ctrlTxtCP = new ProyectoCompra.Controles.CtrlTextoBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.ctrlTxtCiudad = new ProyectoCompra.Controles.CtrlTextoBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.ctrlTextoBox1 = new ProyectoCompra.Controles.CtrlTextoBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.ctrlTxtNomDireccion = new ProyectoCompra.Controles.CtrlTextoBox();
            this.lblNomDireccion = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbxDireccionDefecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDireccionDefecto
            // 
            this.gbxDireccionDefecto.AutoSize = true;
            this.gbxDireccionDefecto.Controls.Add(this.btnBorrar);
            this.gbxDireccionDefecto.Controls.Add(this.ctrlTxtTelefono);
            this.gbxDireccionDefecto.Controls.Add(this.lblTelefono);
            this.gbxDireccionDefecto.Controls.Add(this.ctrlTxtCP);
            this.gbxDireccionDefecto.Controls.Add(this.lblCP);
            this.gbxDireccionDefecto.Controls.Add(this.ctrlTxtCiudad);
            this.gbxDireccionDefecto.Controls.Add(this.lblCiudad);
            this.gbxDireccionDefecto.Controls.Add(this.cbxProvincia);
            this.gbxDireccionDefecto.Controls.Add(this.lblProvincia);
            this.gbxDireccionDefecto.Controls.Add(this.cbxPais);
            this.gbxDireccionDefecto.Controls.Add(this.lblDireccion);
            this.gbxDireccionDefecto.Controls.Add(this.ctrlTextoBox1);
            this.gbxDireccionDefecto.Controls.Add(this.lblPais);
            this.gbxDireccionDefecto.Controls.Add(this.ctrlTxtNomDireccion);
            this.gbxDireccionDefecto.Controls.Add(this.lblNomDireccion);
            this.gbxDireccionDefecto.Location = new System.Drawing.Point(0, 0);
            this.gbxDireccionDefecto.Name = "gbxDireccionDefecto";
            this.gbxDireccionDefecto.Size = new System.Drawing.Size(309, 242);
            this.gbxDireccionDefecto.TabIndex = 1;
            this.gbxDireccionDefecto.TabStop = false;
            this.gbxDireccionDefecto.Text = "Dirección (predeterminado)";
            // 
            // ctrlTxtTelefono
            // 
            this.ctrlTxtTelefono.AutoSize = true;
            this.ctrlTxtTelefono.Location = new System.Drawing.Point(19, 203);
            this.ctrlTxtTelefono.Name = "ctrlTxtTelefono";
            this.ctrlTxtTelefono.Size = new System.Drawing.Size(268, 20);
            this.ctrlTxtTelefono.TabIndex = 13;
            this.ctrlTxtTelefono.Texto = "";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(16, 187);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // ctrlTxtCP
            // 
            this.ctrlTxtCP.AutoSize = true;
            this.ctrlTxtCP.Location = new System.Drawing.Point(156, 163);
            this.ctrlTxtCP.Name = "ctrlTxtCP";
            this.ctrlTxtCP.Size = new System.Drawing.Size(131, 20);
            this.ctrlTxtCP.TabIndex = 11;
            this.ctrlTxtCP.Texto = "";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(153, 147);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(74, 13);
            this.lblCP.TabIndex = 10;
            this.lblCP.Text = "Código postal:";
            // 
            // ctrlTxtCiudad
            // 
            this.ctrlTxtCiudad.AutoSize = true;
            this.ctrlTxtCiudad.Location = new System.Drawing.Point(19, 163);
            this.ctrlTxtCiudad.Name = "ctrlTxtCiudad";
            this.ctrlTxtCiudad.Size = new System.Drawing.Size(131, 20);
            this.ctrlTxtCiudad.TabIndex = 9;
            this.ctrlTxtCiudad.Texto = "";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(16, 147);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(43, 13);
            this.lblCiudad.TabIndex = 8;
            this.lblCiudad.Text = "Ciudad:";
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(156, 123);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(131, 21);
            this.cbxProvincia.TabIndex = 7;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(153, 107);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 6;
            this.lblProvincia.Text = "Provincia";
            // 
            // cbxPais
            // 
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Location = new System.Drawing.Point(19, 123);
            this.cbxPais.Name = "cbxPais";
            this.cbxPais.Size = new System.Drawing.Size(131, 21);
            this.cbxPais.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 68);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección:";
            // 
            // ctrlTextoBox1
            // 
            this.ctrlTextoBox1.AutoSize = true;
            this.ctrlTextoBox1.Location = new System.Drawing.Point(19, 84);
            this.ctrlTextoBox1.Name = "ctrlTextoBox1";
            this.ctrlTextoBox1.Size = new System.Drawing.Size(268, 20);
            this.ctrlTextoBox1.TabIndex = 3;
            this.ctrlTextoBox1.Texto = "";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(16, 107);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "País:";
            // 
            // ctrlTxtNomDireccion
            // 
            this.ctrlTxtNomDireccion.AutoSize = true;
            this.ctrlTxtNomDireccion.Location = new System.Drawing.Point(19, 44);
            this.ctrlTxtNomDireccion.Name = "ctrlTxtNomDireccion";
            this.ctrlTxtNomDireccion.Size = new System.Drawing.Size(268, 20);
            this.ctrlTxtNomDireccion.TabIndex = 1;
            this.ctrlTxtNomDireccion.Texto = "";
            // 
            // lblNomDireccion
            // 
            this.lblNomDireccion.AutoSize = true;
            this.lblNomDireccion.Location = new System.Drawing.Point(16, 28);
            this.lblNomDireccion.Name = "lblNomDireccion";
            this.lblNomDireccion.Size = new System.Drawing.Size(93, 13);
            this.lblNomDireccion.TabIndex = 0;
            this.lblNomDireccion.Text = "Nombre dirección:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Image = global::ProyectoCompra.Properties.Resources.icon_borrar;
            this.btnBorrar.Location = new System.Drawing.Point(286, 12);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(17, 15);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // CtrlDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbxDireccionDefecto);
            this.Name = "CtrlDireccion";
            this.Size = new System.Drawing.Size(312, 245);
            this.gbxDireccionDefecto.ResumeLayout(false);
            this.gbxDireccionDefecto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDireccionDefecto;
        private CtrlTextoBox ctrlTxtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private CtrlTextoBox ctrlTxtCP;
        private System.Windows.Forms.Label lblCP;
        private CtrlTextoBox ctrlTxtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.ComboBox cbxProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cbxPais;
        private System.Windows.Forms.Label lblDireccion;
        private CtrlTextoBox ctrlTextoBox1;
        private System.Windows.Forms.Label lblPais;
        private CtrlTextoBox ctrlTxtNomDireccion;
        private System.Windows.Forms.Label lblNomDireccion;
        private System.Windows.Forms.Button btnBorrar;
    }
}
