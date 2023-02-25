namespace ProyectoCompra.Formularios
{
    partial class frmInicioSesion
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chxRecordar = new System.Windows.Forms.CheckBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbxIdiomas = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabInicioSesion = new System.Windows.Forms.TabPage();
            this.tabRegistrarse = new System.Windows.Forms.TabPage();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRepContrasenia = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblRepContrasenia = new System.Windows.Forms.Label();
            this.lblContrase = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.dateFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.btnAlerta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabInicioSesion.SuspendLayout();
            this.tabRegistrarse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMostrarPass);
            this.groupBox1.Controls.Add(this.chxRecordar);
            this.groupBox1.Controls.Add(this.txtContrasenia);
            this.groupBox1.Controls.Add(this.lblContrasenia);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.btnLogin);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // chxRecordar
            // 
            resources.ApplyResources(this.chxRecordar, "chxRecordar");
            this.chxRecordar.Name = "chxRecordar";
            this.chxRecordar.UseVisualStyleBackColor = true;
            // 
            // txtContrasenia
            // 
            resources.ApplyResources(this.txtContrasenia, "txtContrasenia");
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // lblContrasenia
            // 
            resources.ApplyResources(this.lblContrasenia, "lblContrasenia");
            this.lblContrasenia.Name = "lblContrasenia";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbxIdiomas
            // 
            this.cbxIdiomas.FormattingEnabled = true;
            this.cbxIdiomas.Items.AddRange(new object[] {
            resources.GetString("cbxIdiomas.Items"),
            resources.GetString("cbxIdiomas.Items1")});
            resources.ApplyResources(this.cbxIdiomas, "cbxIdiomas");
            this.cbxIdiomas.Name = "cbxIdiomas";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabInicioSesion);
            this.tabControl.Controls.Add(this.tabRegistrarse);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabInicioSesion
            // 
            this.tabInicioSesion.BackColor = System.Drawing.Color.White;
            this.tabInicioSesion.Controls.Add(this.groupBox1);
            this.tabInicioSesion.Controls.Add(this.cbxIdiomas);
            resources.ApplyResources(this.tabInicioSesion, "tabInicioSesion");
            this.tabInicioSesion.Name = "tabInicioSesion";
            // 
            // tabRegistrarse
            // 
            this.tabRegistrarse.BackColor = System.Drawing.Color.White;
            this.tabRegistrarse.Controls.Add(this.btnAceptar);
            this.tabRegistrarse.Controls.Add(this.lblAlerta);
            this.tabRegistrarse.Controls.Add(this.btnCancelar);
            this.tabRegistrarse.Controls.Add(this.groupBox2);
            this.tabRegistrarse.Controls.Add(this.groupBox3);
            this.tabRegistrarse.Controls.Add(this.btnAlerta);
            resources.ApplyResources(this.tabRegistrarse, "tabRegistrarse");
            this.tabRegistrarse.Name = "tabRegistrarse";
            // 
            // btnAceptar
            // 
            resources.ApplyResources(this.btnAceptar, "btnAceptar");
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAlerta
            // 
            resources.ApplyResources(this.lblAlerta, "lblAlerta");
            this.lblAlerta.Name = "lblAlerta";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRepContrasenia);
            this.groupBox2.Controls.Add(this.txtContrasena);
            this.groupBox2.Controls.Add(this.lblRepContrasenia);
            this.groupBox2.Controls.Add(this.lblContrase);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.lblCorreo);
            this.groupBox2.Controls.Add(this.textUsuario);
            this.groupBox2.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtRepContrasenia
            // 
            resources.ApplyResources(this.txtRepContrasenia, "txtRepContrasenia");
            this.txtRepContrasenia.Name = "txtRepContrasenia";
            this.txtRepContrasenia.UseSystemPasswordChar = true;
            // 
            // txtContrasena
            // 
            resources.ApplyResources(this.txtContrasena, "txtContrasena");
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblRepContrasenia
            // 
            resources.ApplyResources(this.lblRepContrasenia, "lblRepContrasenia");
            this.lblRepContrasenia.Name = "lblRepContrasenia";
            // 
            // lblContrase
            // 
            resources.ApplyResources(this.lblContrase, "lblContrase");
            this.lblContrase.Name = "lblContrase";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.Name = "txtCorreo";
            // 
            // lblCorreo
            // 
            resources.ApplyResources(this.lblCorreo, "lblCorreo");
            this.lblCorreo.Name = "lblCorreo";
            // 
            // textUsuario
            // 
            resources.ApplyResources(this.textUsuario, "textUsuario");
            this.textUsuario.Name = "textUsuario";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtDireccion);
            this.groupBox3.Controls.Add(this.lblDireccion);
            this.groupBox3.Controls.Add(this.cbxSexo);
            this.groupBox3.Controls.Add(this.lblSexo);
            this.groupBox3.Controls.Add(this.txtEdad);
            this.groupBox3.Controls.Add(this.lblEdad);
            this.groupBox3.Controls.Add(this.dateFNacimiento);
            this.groupBox3.Controls.Add(this.lblFNacimiento);
            this.groupBox3.Controls.Add(this.txtApellido);
            this.groupBox3.Controls.Add(this.lblApellido);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.lblNombre);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.Name = "txtDireccion";
            // 
            // lblDireccion
            // 
            resources.ApplyResources(this.lblDireccion, "lblDireccion");
            this.lblDireccion.Name = "lblDireccion";
            // 
            // cbxSexo
            // 
            this.cbxSexo.FormattingEnabled = true;
            this.cbxSexo.Items.AddRange(new object[] {
            resources.GetString("cbxSexo.Items"),
            resources.GetString("cbxSexo.Items1")});
            resources.ApplyResources(this.cbxSexo, "cbxSexo");
            this.cbxSexo.Name = "cbxSexo";
            // 
            // lblSexo
            // 
            resources.ApplyResources(this.lblSexo, "lblSexo");
            this.lblSexo.Name = "lblSexo";
            // 
            // txtEdad
            // 
            resources.ApplyResources(this.txtEdad, "txtEdad");
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged_1);
            // 
            // lblEdad
            // 
            resources.ApplyResources(this.lblEdad, "lblEdad");
            this.lblEdad.Name = "lblEdad";
            // 
            // dateFNacimiento
            // 
            resources.ApplyResources(this.dateFNacimiento, "dateFNacimiento");
            this.dateFNacimiento.Name = "dateFNacimiento";
            // 
            // lblFNacimiento
            // 
            resources.ApplyResources(this.lblFNacimiento, "lblFNacimiento");
            this.lblFNacimiento.Name = "lblFNacimiento";
            // 
            // txtApellido
            // 
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.Name = "txtApellido";
            // 
            // lblApellido
            // 
            resources.ApplyResources(this.lblApellido, "lblApellido");
            this.lblApellido.Name = "lblApellido";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnMostrarPass, "btnMostrarPass");
            this.btnMostrarPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarPass.FlatAppearance.BorderSize = 0;
            this.btnMostrarPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMostrarPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMostrarPass.Image = global::ProyectoCompra.Properties.Resources.ocultar_contrasenia;
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.UseVisualStyleBackColor = false;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // btnAlerta
            // 
            resources.ApplyResources(this.btnAlerta, "btnAlerta");
            this.btnAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlerta.FlatAppearance.BorderSize = 0;
            this.btnAlerta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAlerta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlerta.ForeColor = System.Drawing.Color.White;
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Tag = "";
            this.btnAlerta.UseVisualStyleBackColor = true;
            this.btnAlerta.MouseEnter += new System.EventHandler(this.btnAlerta_MouseEnter);
            this.btnAlerta.MouseLeave += new System.EventHandler(this.btnAlerta_MouseLeave);
            // 
            // frmInicioSesion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmInicioSesion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabInicioSesion.ResumeLayout(false);
            this.tabRegistrarse.ResumeLayout(false);
            this.tabRegistrarse.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnMostrarPass;
        private System.Windows.Forms.ComboBox cbxIdiomas;
        private System.Windows.Forms.CheckBox chxRecordar;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabInicioSesion;
        private System.Windows.Forms.TabPage tabRegistrarse;
        private System.Windows.Forms.Label lblAlerta;
        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRepContrasenia;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblRepContrasenia;
        private System.Windows.Forms.Label lblContrase;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.DateTimePicker dateFNacimiento;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
    }
}

