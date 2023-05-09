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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.cbxProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cbxPais = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblNomDireccion = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtNomDireccion = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.ctrlTxtTelefono = new ProyectoCompra.Controles.CtrlTextoBox();
            this.ctrlTxtCP = new ProyectoCompra.Controles.CtrlTextoBox();
            this.ctrlTxtCiudad = new ProyectoCompra.Controles.CtrlTextoBox();
            this.gbxDireccionDefecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDireccionDefecto
            // 
            this.gbxDireccionDefecto.Controls.Add(this.txtDireccion);
            this.gbxDireccionDefecto.Controls.Add(this.txtNomDireccion);
            this.gbxDireccionDefecto.Controls.Add(this.btnCancelar);
            this.gbxDireccionDefecto.Controls.Add(this.btnEditar);
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
            this.gbxDireccionDefecto.Controls.Add(this.lblPais);
            this.gbxDireccionDefecto.Controls.Add(this.lblNomDireccion);
            this.gbxDireccionDefecto.Controls.Add(this.btnAceptar);
            this.gbxDireccionDefecto.Location = new System.Drawing.Point(0, 0);
            this.gbxDireccionDefecto.Name = "gbxDireccionDefecto";
            this.gbxDireccionDefecto.Size = new System.Drawing.Size(309, 266);
            this.gbxDireccionDefecto.TabIndex = 1;
            this.gbxDireccionDefecto.TabStop = false;
            this.gbxDireccionDefecto.Text = "Dirección (predeterminado)";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(212, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(212, 229);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(16, 187);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 12;
            this.lblTelefono.Text = "Teléfono:";
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
            this.cbxProvincia.Enabled = false;
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Items.AddRange(new object[] {
            "Álava",
            "Albacete",
            "Alicante",
            "Almería",
            "Asturias",
            "Ávila ",
            "Badajoz",
            "Barcelona",
            "Burgos",
            "Cáceres",
            "Cádiz",
            "Cantabria",
            "Castellón",
            "Ciudad Real",
            "Córdoba",
            "Cuenca",
            "Gerona",
            "Granada",
            "Guadalajara",
            "Guipúzcoa",
            "Huelva",
            "Huesca",
            "Islas Baleares",
            "Jaén",
            "La Coruña",
            "La Rioja",
            "Las Palmas",
            "León - Castilla y León",
            "Lérida",
            "Lugo",
            "Madrid",
            "Málaga",
            "Murcia",
            "Navarra",
            "Orense",
            "Palencia",
            "Pontevedra",
            "Salamanca",
            "Santa Cruz de Tenerife",
            "Segovia",
            "Sevilla",
            "Soria",
            "Tarragona",
            "Teruel",
            "Toledo",
            "Valencia",
            "Valladolid",
            "Vizcaya",
            "Zamora",
            "Zaragoza"});
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
            this.cbxPais.Enabled = false;
            this.cbxPais.FormattingEnabled = true;
            this.cbxPais.Items.AddRange(new object[] {
            "España"});
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
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(16, 107);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(32, 13);
            this.lblPais.TabIndex = 2;
            this.lblPais.Text = "País:";
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
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(132, 229);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtNomDireccion
            // 
            this.txtNomDireccion.Location = new System.Drawing.Point(19, 45);
            this.txtNomDireccion.Name = "txtNomDireccion";
            this.txtNomDireccion.ReadOnly = true;
            this.txtNomDireccion.Size = new System.Drawing.Size(268, 20);
            this.txtNomDireccion.TabIndex = 18;
            this.txtNomDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(19, 84);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.ReadOnly = true;
            this.txtDireccion.Size = new System.Drawing.Size(268, 20);
            this.txtDireccion.TabIndex = 19;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctrlTxtTelefono
            // 
            this.ctrlTxtTelefono.AutoSize = true;
            this.ctrlTxtTelefono.IsNumerico = true;
            this.ctrlTxtTelefono.IsReadOnly = true;
            this.ctrlTxtTelefono.Location = new System.Drawing.Point(19, 203);
            this.ctrlTxtTelefono.Name = "ctrlTxtTelefono";
            this.ctrlTxtTelefono.Size = new System.Drawing.Size(268, 20);
            this.ctrlTxtTelefono.TabIndex = 13;
            this.ctrlTxtTelefono.Texto = "";
            // 
            // ctrlTxtCP
            // 
            this.ctrlTxtCP.AutoSize = true;
            this.ctrlTxtCP.IsNumerico = true;
            this.ctrlTxtCP.IsReadOnly = true;
            this.ctrlTxtCP.Location = new System.Drawing.Point(156, 163);
            this.ctrlTxtCP.Name = "ctrlTxtCP";
            this.ctrlTxtCP.Size = new System.Drawing.Size(131, 20);
            this.ctrlTxtCP.TabIndex = 11;
            this.ctrlTxtCP.Texto = "";
            // 
            // ctrlTxtCiudad
            // 
            this.ctrlTxtCiudad.AutoSize = true;
            this.ctrlTxtCiudad.IsReadOnly = true;
            this.ctrlTxtCiudad.Location = new System.Drawing.Point(19, 163);
            this.ctrlTxtCiudad.Name = "ctrlTxtCiudad";
            this.ctrlTxtCiudad.Size = new System.Drawing.Size(131, 20);
            this.ctrlTxtCiudad.TabIndex = 9;
            this.ctrlTxtCiudad.Texto = "";
            // 
            // CtrlDireccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbxDireccionDefecto);
            this.Name = "CtrlDireccion";
            this.Size = new System.Drawing.Size(312, 269);
            this.Load += new System.EventHandler(this.CtrlDireccion_Load);
            this.gbxDireccionDefecto.ResumeLayout(false);
            this.gbxDireccionDefecto.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblNomDireccion;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNomDireccion;
    }
}
