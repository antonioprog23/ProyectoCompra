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
            this.btnOtrasOpciones = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMostrarUltimaModificacion = new System.Windows.Forms.Label();
            this.lblUltimaModificacion = new System.Windows.Forms.Label();
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
            this.ctrlMostrarContrasenia = new ProyectoCompra.Controles.ctrlContrasenia();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnOtrasOpciones);
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Location = new System.Drawing.Point(266, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 111);
            this.panel1.TabIndex = 1;
            // 
            // btnOtrasOpciones
            // 
            this.btnOtrasOpciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtrasOpciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOtrasOpciones.FlatAppearance.BorderSize = 0;
            this.btnOtrasOpciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnOtrasOpciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnOtrasOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtrasOpciones.Image = global::ProyectoCompra.Properties.Resources.icon_otras_opciones;
            this.btnOtrasOpciones.Location = new System.Drawing.Point(73, 4);
            this.btnOtrasOpciones.Name = "btnOtrasOpciones";
            this.btnOtrasOpciones.Size = new System.Drawing.Size(15, 36);
            this.btnOtrasOpciones.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnOtrasOpciones, "Otras opciones.");
            this.btnOtrasOpciones.UseVisualStyleBackColor = true;
            this.btnOtrasOpciones.Click += new System.EventHandler(this.btnOtrasOpciones_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(94, 3);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(29, 37);
            this.btnCerrarSesion.TabIndex = 0;
            this.toolTip.SetToolTip(this.btnCerrarSesion, "Cerrar sesión.");
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 475);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(238, 475);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblMostrarUltimaModificacion);
            this.panel2.Controls.Add(this.lblUltimaModificacion);
            this.panel2.Controls.Add(this.lblMostrarFAlta);
            this.panel2.Controls.Add(this.lblFechaAlta);
            this.panel2.Controls.Add(this.lblMostrarId);
            this.panel2.Controls.Add(this.lblId);
            this.panel2.Location = new System.Drawing.Point(8, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 111);
            this.panel2.TabIndex = 6;
            // 
            // lblMostrarUltimaModificacion
            // 
            this.lblMostrarUltimaModificacion.AutoSize = true;
            this.lblMostrarUltimaModificacion.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarUltimaModificacion.Location = new System.Drawing.Point(150, 69);
            this.lblMostrarUltimaModificacion.Name = "lblMostrarUltimaModificacion";
            this.lblMostrarUltimaModificacion.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarUltimaModificacion.TabIndex = 10;
            this.lblMostrarUltimaModificacion.Text = "label2";
            // 
            // lblUltimaModificacion
            // 
            this.lblUltimaModificacion.AutoSize = true;
            this.lblUltimaModificacion.Location = new System.Drawing.Point(28, 69);
            this.lblUltimaModificacion.Name = "lblUltimaModificacion";
            this.lblUltimaModificacion.Size = new System.Drawing.Size(102, 14);
            this.lblUltimaModificacion.TabIndex = 9;
            this.lblUltimaModificacion.Text = "Última modificación:";
            // 
            // lblMostrarFAlta
            // 
            this.lblMostrarFAlta.AutoSize = true;
            this.lblMostrarFAlta.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarFAlta.Location = new System.Drawing.Point(150, 39);
            this.lblMostrarFAlta.Name = "lblMostrarFAlta";
            this.lblMostrarFAlta.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarFAlta.TabIndex = 8;
            this.lblMostrarFAlta.Text = "label1";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(28, 39);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(58, 14);
            this.lblFechaAlta.TabIndex = 7;
            this.lblFechaAlta.Text = "Fecha alta:";
            // 
            // lblMostrarId
            // 
            this.lblMostrarId.AutoSize = true;
            this.lblMostrarId.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarId.Location = new System.Drawing.Point(150, 9);
            this.lblMostrarId.Name = "lblMostrarId";
            this.lblMostrarId.Size = new System.Drawing.Size(17, 14);
            this.lblMostrarId.TabIndex = 7;
            this.lblMostrarId.Text = "lbl";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 14);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctrlMostrarContrasenia);
            this.groupBox2.Controls.Add(this.lblMostrarUsuario);
            this.groupBox2.Controls.Add(this.lblMostrarCorreo);
            this.groupBox2.Controls.Add(this.lblContrasenia);
            this.groupBox2.Controls.Add(this.lblCorreo);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(8, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 135);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos usuario";
            // 
            // lblMostrarUsuario
            // 
            this.lblMostrarUsuario.AutoSize = true;
            this.lblMostrarUsuario.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarUsuario.Location = new System.Drawing.Point(150, 60);
            this.lblMostrarUsuario.Name = "lblMostrarUsuario";
            this.lblMostrarUsuario.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarUsuario.TabIndex = 21;
            this.lblMostrarUsuario.Text = "label1";
            // 
            // lblMostrarCorreo
            // 
            this.lblMostrarCorreo.AutoSize = true;
            this.lblMostrarCorreo.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarCorreo.Location = new System.Drawing.Point(150, 37);
            this.lblMostrarCorreo.Name = "lblMostrarCorreo";
            this.lblMostrarCorreo.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarCorreo.TabIndex = 20;
            this.lblMostrarCorreo.Text = "label1";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblContrasenia.Location = new System.Drawing.Point(28, 93);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(63, 14);
            this.lblContrasenia.TabIndex = 19;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCorreo.Location = new System.Drawing.Point(28, 37);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(43, 14);
            this.lblCorreo.TabIndex = 17;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUsuario.Location = new System.Drawing.Point(28, 60);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(47, 14);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos cliente";
            // 
            // lblMostrarDireccion
            // 
            this.lblMostrarDireccion.AutoSize = true;
            this.lblMostrarDireccion.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarDireccion.Location = new System.Drawing.Point(150, 165);
            this.lblMostrarDireccion.Name = "lblMostrarDireccion";
            this.lblMostrarDireccion.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarDireccion.TabIndex = 17;
            this.lblMostrarDireccion.Text = "label1";
            // 
            // lblMostrarSexo
            // 
            this.lblMostrarSexo.AutoSize = true;
            this.lblMostrarSexo.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarSexo.Location = new System.Drawing.Point(150, 141);
            this.lblMostrarSexo.Name = "lblMostrarSexo";
            this.lblMostrarSexo.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarSexo.TabIndex = 16;
            this.lblMostrarSexo.Text = "label1";
            // 
            // lblMostrarApellido
            // 
            this.lblMostrarApellido.AutoSize = true;
            this.lblMostrarApellido.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarApellido.Location = new System.Drawing.Point(150, 61);
            this.lblMostrarApellido.Name = "lblMostrarApellido";
            this.lblMostrarApellido.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarApellido.TabIndex = 15;
            this.lblMostrarApellido.Text = "label1";
            // 
            // lblMostrarEdad
            // 
            this.lblMostrarEdad.AutoSize = true;
            this.lblMostrarEdad.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarEdad.Location = new System.Drawing.Point(150, 116);
            this.lblMostrarEdad.Name = "lblMostrarEdad";
            this.lblMostrarEdad.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarEdad.TabIndex = 14;
            this.lblMostrarEdad.Text = "label1";
            // 
            // lblMostrarNombre
            // 
            this.lblMostrarNombre.AutoSize = true;
            this.lblMostrarNombre.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarNombre.Location = new System.Drawing.Point(150, 34);
            this.lblMostrarNombre.Name = "lblMostrarNombre";
            this.lblMostrarNombre.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarNombre.TabIndex = 13;
            this.lblMostrarNombre.Text = "label1";
            // 
            // lblMostrarFNacimiento
            // 
            this.lblMostrarFNacimiento.AutoSize = true;
            this.lblMostrarFNacimiento.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarFNacimiento.Location = new System.Drawing.Point(150, 87);
            this.lblMostrarFNacimiento.Name = "lblMostrarFNacimiento";
            this.lblMostrarFNacimiento.Size = new System.Drawing.Size(35, 14);
            this.lblMostrarFNacimiento.TabIndex = 12;
            this.lblMostrarFNacimiento.Text = "label1";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDireccion.Location = new System.Drawing.Point(28, 165);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(56, 14);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSexo.Location = new System.Drawing.Point(28, 141);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 14);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblEdad.Location = new System.Drawing.Point(28, 116);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(34, 14);
            this.lblEdad.TabIndex = 7;
            this.lblEdad.Text = "Edad:";
            // 
            // lblFNacimiento
            // 
            this.lblFNacimiento.AutoSize = true;
            this.lblFNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFNacimiento.Location = new System.Drawing.Point(28, 87);
            this.lblFNacimiento.Name = "lblFNacimiento";
            this.lblFNacimiento.Size = new System.Drawing.Size(108, 14);
            this.lblFNacimiento.TabIndex = 4;
            this.lblFNacimiento.Text = "Fecha de nacimiento:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApellido.Location = new System.Drawing.Point(28, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 14);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNombre.Location = new System.Drawing.Point(28, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(48, 14);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // ctrlMostrarContrasenia
            // 
            this.ctrlMostrarContrasenia.AutoSize = true;
            this.ctrlMostrarContrasenia.Font = new System.Drawing.Font("Arial Nova", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlMostrarContrasenia.Location = new System.Drawing.Point(153, 88);
            this.ctrlMostrarContrasenia.Name = "ctrlMostrarContrasenia";
            this.ctrlMostrarContrasenia.Size = new System.Drawing.Size(209, 28);
            this.ctrlMostrarContrasenia.TabIndex = 22;
            this.ctrlMostrarContrasenia.TextBoxtxtContrasenia = "";
            // 
            // FrmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Button btnOtrasOpciones;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMostrarUltimaModificacion;
        private System.Windows.Forms.Label lblUltimaModificacion;
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
        private Controles.ctrlContrasenia ctrlMostrarContrasenia;
    }
}