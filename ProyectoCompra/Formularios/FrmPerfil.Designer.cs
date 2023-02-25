namespace ProyectoCompra.Formularios
{
    partial class FrmPerfil
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMostrarUltimoAcceso = new System.Windows.Forms.Label();
            this.lblUltimoAcceso = new System.Windows.Forms.Label();
            this.lblMostrarFAlta = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblMostrarId = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMostrarUsuario = new System.Windows.Forms.Label();
            this.lblMostrarCorreo = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMostrarDireccion = new System.Windows.Forms.Label();
            this.lblMostrarSexo = new System.Windows.Forms.Label();
            this.lblMostrarApellido = new System.Windows.Forms.Label();
            this.lblMostrarEdad = new System.Windows.Forms.Label();
            this.lblMostrarNombre = new System.Windows.Forms.Label();
            this.lblMostrarFNacimiento = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfiguracion);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Location = new System.Drawing.Point(266, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 103);
            this.panel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 441);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(238, 441);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMostrarUltimoAcceso);
            this.panel2.Controls.Add(this.lblUltimoAcceso);
            this.panel2.Controls.Add(this.lblMostrarFAlta);
            this.panel2.Controls.Add(this.lblFechaAlta);
            this.panel2.Controls.Add(this.lblMostrarId);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Location = new System.Drawing.Point(8, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 103);
            this.panel2.TabIndex = 6;
            // 
            // lblMostrarUltimoAcceso
            // 
            this.lblMostrarUltimoAcceso.AutoSize = true;
            this.lblMostrarUltimoAcceso.Location = new System.Drawing.Point(150, 64);
            this.lblMostrarUltimoAcceso.Name = "lblMostrarUltimoAcceso";
            this.lblMostrarUltimoAcceso.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarUltimoAcceso.TabIndex = 10;
            this.lblMostrarUltimoAcceso.Text = "label2";
            // 
            // lblUltimoAcceso
            // 
            this.lblUltimoAcceso.AutoSize = true;
            this.lblUltimoAcceso.Location = new System.Drawing.Point(28, 64);
            this.lblUltimoAcceso.Name = "lblUltimoAcceso";
            this.lblUltimoAcceso.Size = new System.Drawing.Size(77, 13);
            this.lblUltimoAcceso.TabIndex = 9;
            this.lblUltimoAcceso.Text = "Último acceso:";
            // 
            // lblMostrarFAlta
            // 
            this.lblMostrarFAlta.AutoSize = true;
            this.lblMostrarFAlta.Location = new System.Drawing.Point(150, 36);
            this.lblMostrarFAlta.Name = "lblMostrarFAlta";
            this.lblMostrarFAlta.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarFAlta.TabIndex = 8;
            this.lblMostrarFAlta.Text = "label1";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(28, 36);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(60, 13);
            this.lblFechaAlta.TabIndex = 7;
            this.lblFechaAlta.Text = "Fecha alta:";
            // 
            // lblMostrarId
            // 
            this.lblMostrarId.AutoSize = true;
            this.lblMostrarId.Location = new System.Drawing.Point(150, 8);
            this.lblMostrarId.Name = "lblMostrarId";
            this.lblMostrarId.Size = new System.Drawing.Size(17, 13);
            this.lblMostrarId.TabIndex = 7;
            this.lblMostrarId.Text = "lbl";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMostrarUsuario);
            this.groupBox2.Controls.Add(this.lblMostrarCorreo);
            this.groupBox2.Controls.Add(this.lblContrasenia);
            this.groupBox2.Controls.Add(this.lblCorreo);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(8, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 125);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos usuario";
            // 
            // lblMostrarUsuario
            // 
            this.lblMostrarUsuario.AutoSize = true;
            this.lblMostrarUsuario.Location = new System.Drawing.Point(150, 56);
            this.lblMostrarUsuario.Name = "lblMostrarUsuario";
            this.lblMostrarUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarUsuario.TabIndex = 21;
            this.lblMostrarUsuario.Text = "label1";
            // 
            // lblMostrarCorreo
            // 
            this.lblMostrarCorreo.AutoSize = true;
            this.lblMostrarCorreo.Location = new System.Drawing.Point(150, 34);
            this.lblMostrarCorreo.Name = "lblMostrarCorreo";
            this.lblMostrarCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarCorreo.TabIndex = 20;
            this.lblMostrarCorreo.Text = "label1";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblContrasenia.Location = new System.Drawing.Point(28, 86);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 19;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCorreo.Location = new System.Drawing.Point(28, 34);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(41, 13);
            this.lblCorreo.TabIndex = 17;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsuario.Location = new System.Drawing.Point(28, 56);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMostrarDireccion);
            this.groupBox1.Controls.Add(this.lblMostrarSexo);
            this.groupBox1.Controls.Add(this.lblMostrarApellido);
            this.groupBox1.Controls.Add(this.lblMostrarEdad);
            this.groupBox1.Controls.Add(this.lblMostrarNombre);
            this.groupBox1.Controls.Add(this.lblMostrarFNacimiento);
            this.groupBox1.Controls.Add(this.lblDireccion);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblEdad);
            this.groupBox1.Controls.Add(this.lblFNacimiento);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Location = new System.Drawing.Point(8, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 183);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos cliente";
            // 
            // lblMostrarDireccion
            // 
            this.lblMostrarDireccion.AutoSize = true;
            this.lblMostrarDireccion.Location = new System.Drawing.Point(150, 153);
            this.lblMostrarDireccion.Name = "lblMostrarDireccion";
            this.lblMostrarDireccion.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarDireccion.TabIndex = 17;
            this.lblMostrarDireccion.Text = "label1";
            // 
            // lblMostrarSexo
            // 
            this.lblMostrarSexo.AutoSize = true;
            this.lblMostrarSexo.Location = new System.Drawing.Point(150, 81);
            this.lblMostrarSexo.Name = "lblMostrarSexo";
            this.lblMostrarSexo.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarSexo.TabIndex = 16;
            this.lblMostrarSexo.Text = "label1";
            // 
            // lblMostrarApellido
            // 
            this.lblMostrarApellido.AutoSize = true;
            this.lblMostrarApellido.Location = new System.Drawing.Point(150, 104);
            this.lblMostrarApellido.Name = "lblMostrarApellido";
            this.lblMostrarApellido.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarApellido.TabIndex = 15;
            this.lblMostrarApellido.Text = "label1";
            // 
            // lblMostrarEdad
            // 
            this.lblMostrarEdad.AutoSize = true;
            this.lblMostrarEdad.Location = new System.Drawing.Point(150, 129);
            this.lblMostrarEdad.Name = "lblMostrarEdad";
            this.lblMostrarEdad.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarEdad.TabIndex = 14;
            this.lblMostrarEdad.Text = "label1";
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.AutoSize = true;
            this.lblMostrarNombre.Location = new System.Drawing.Point(150, 32);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarNombre.TabIndex = 13;
            this.lblMostrarNombre.Text = "label1";
            // 
            // lblMostrarFNacimiento
            // 
            this.lblMostrarFNacimiento.AutoSize = true;
            this.lblMostrarFNacimiento.Location = new System.Drawing.Point(150, 57);
            this.lblMostrarFNacimiento.Name = "lblMostrarFNacimiento";
            this.lblMostrarFNacimiento.Size = new System.Drawing.Size(35, 13);
            this.lblMostrarFNacimiento.TabIndex = 12;
            this.lblMostrarFNacimiento.Text = "label1";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDireccion.Location = new System.Drawing.Point(28, 153);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSexo.Location = new System.Drawing.Point(28, 81);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEdad.Location = new System.Drawing.Point(28, 129);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFNacimiento.Location = new System.Drawing.Point(28, 57);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(109, 13);
            this.lblFNacimiento.TabIndex = 4;
            this.lblFNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApellido.Location = new System.Drawing.Point(28, 104);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(28, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Image = global::ProyectoCompra.Properties.Resources.icon_configuracion;
            this.btnConfiguracion.Location = new System.Drawing.Point(51, 3);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(37, 33);
            this.btnConfiguracion.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnConfiguracion, "Configuración.");
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(94, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(29, 34);
            this.btnCerrarSesion.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnCerrarSesion, "Cerrar sesión.");
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMostrarUltimoAcceso;
        private System.Windows.Forms.Label lblUltimoAcceso;
        private System.Windows.Forms.Label lblMostrarFAlta;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblMostrarId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMostrarUsuario;
        private System.Windows.Forms.Label lblMostrarCorreo;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMostrarDireccion;
        private System.Windows.Forms.Label lblMostrarSexo;
        private System.Windows.Forms.Label lblMostrarApellido;
        private System.Windows.Forms.Label lblMostrarEdad;
        private System.Windows.Forms.Label lblMostrarNombre;
        private System.Windows.Forms.Label lblMostrarFNacimiento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolTip toolTip;
    }
}