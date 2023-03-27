namespace ProyectoCompra.Formularios
{
    partial class FrmUsuarioEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioEdit));
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.txtEdad = new ProyectoCompra.Controles.CtrlTextoBox();
            this.ctrlTextoBox10 = new ProyectoCompra.Controles.CtrlTextoBox();
            this.txtDireccion = new ProyectoCompra.Controles.CtrlTextoBox();
            this.txtNombre = new ProyectoCompra.Controles.CtrlTextoBox();
            this.txtApellido = new ProyectoCompra.Controles.CtrlTextoBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cbxSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.dateFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFNacimiento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRepContrasenia = new System.Windows.Forms.Label();
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.txtRepContrasenia = new System.Windows.Forms.TextBox();
            this.ctrlContrasenia = new ProyectoCompra.Controles.ctrlContrasenia();
            this.txtCorreo = new ProyectoCompra.Controles.CtrlTextoBox();
            this.txtUsuario = new ProyectoCompra.Controles.CtrlTextoBox();
            this.lblContrase = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbxCliente.SuspendLayout();
            this.gbxUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtEdad);
            this.gbxCliente.Controls.Add(this.ctrlTextoBox10);
            this.gbxCliente.Controls.Add(this.txtDireccion);
            this.gbxCliente.Controls.Add(this.txtNombre);
            this.gbxCliente.Controls.Add(this.txtApellido);
            this.gbxCliente.Controls.Add(this.lblDireccion);
            this.gbxCliente.Controls.Add(this.cbxSexo);
            this.gbxCliente.Controls.Add(this.lblSexo);
            this.gbxCliente.Controls.Add(this.lblEdad);
            this.gbxCliente.Controls.Add(this.dateFNacimiento);
            this.gbxCliente.Controls.Add(this.lblFNacimiento);
            this.gbxCliente.Controls.Add(this.lblApellido);
            this.gbxCliente.Controls.Add(this.lblNombre);
            resources.ApplyResources(this.gbxCliente, "gbxCliente");
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.TabStop = false;
            // 
            // txtEdad
            // 
            resources.ApplyResources(this.txtEdad, "txtEdad");
            this.txtEdad.IsNumerico = true;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Texto = "";
            // 
            // ctrlTextoBox10
            // 
            resources.ApplyResources(this.ctrlTextoBox10, "ctrlTextoBox10");
            this.ctrlTextoBox10.IsNumerico = false;
            this.ctrlTextoBox10.Name = "ctrlTextoBox10";
            this.ctrlTextoBox10.Texto = "";
            // 
            // txtDireccion
            // 
            resources.ApplyResources(this.txtDireccion, "txtDireccion");
            this.txtDireccion.IsNumerico = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Texto = "";
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.IsNumerico = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Texto = "";
            // 
            // txtApellido
            // 
            resources.ApplyResources(this.txtApellido, "txtApellido");
            this.txtApellido.IsNumerico = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Texto = "";
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
            // lblApellido
            // 
            resources.ApplyResources(this.lblApellido, "lblApellido");
            this.lblApellido.Name = "lblApellido";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.Name = "lblNombre";
            // 
            // lblRepContrasenia
            // 
            resources.ApplyResources(this.lblRepContrasenia, "lblRepContrasenia");
            this.lblRepContrasenia.Name = "lblRepContrasenia";
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.txtRepContrasenia);
            this.gbxUsuario.Controls.Add(this.ctrlContrasenia);
            this.gbxUsuario.Controls.Add(this.txtCorreo);
            this.gbxUsuario.Controls.Add(this.txtUsuario);
            this.gbxUsuario.Controls.Add(this.lblRepContrasenia);
            this.gbxUsuario.Controls.Add(this.lblContrase);
            this.gbxUsuario.Controls.Add(this.lblCorreo);
            this.gbxUsuario.Controls.Add(this.lblUsuario);
            resources.ApplyResources(this.gbxUsuario, "gbxUsuario");
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.TabStop = false;
            // 
            // txtRepContrasenia
            // 
            resources.ApplyResources(this.txtRepContrasenia, "txtRepContrasenia");
            this.txtRepContrasenia.Name = "txtRepContrasenia";
            this.txtRepContrasenia.UseSystemPasswordChar = true;
            // 
            // ctrlContrasenia
            // 
            resources.ApplyResources(this.ctrlContrasenia, "ctrlContrasenia");
            this.ctrlContrasenia.Name = "ctrlContrasenia";
            this.ctrlContrasenia.TextBoxtxtContrasenia = "";
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.IsNumerico = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Texto = "";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.IsNumerico = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Texto = "";
            // 
            // lblContrase
            // 
            resources.ApplyResources(this.lblContrase, "lblContrase");
            this.lblContrase.Name = "lblContrase";
            // 
            // lblCorreo
            // 
            resources.ApplyResources(this.lblCorreo, "lblCorreo");
            this.lblCorreo.Name = "lblCorreo";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // FrmUsuarioEdit
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxUsuario);
            this.Controls.Add(this.gbxCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUsuarioEdit";
            this.Load += new System.EventHandler(this.FrmCrearUsuario_Load);
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label lblFNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DateTimePicker dateFNacimiento;
        private System.Windows.Forms.Label lblRepContrasenia;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cbxSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.Label lblContrase;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private Controles.CtrlTextoBox ctrlTextoBox10;
        private Controles.CtrlTextoBox txtDireccion;
        private Controles.CtrlTextoBox txtNombre;
        private Controles.CtrlTextoBox txtApellido;
        private Controles.ctrlContrasenia ctrlContrasenia;
        private Controles.CtrlTextoBox txtCorreo;
        private Controles.CtrlTextoBox txtUsuario;
        private Controles.CtrlTextoBox txtEdad;
        private System.Windows.Forms.TextBox txtRepContrasenia;
    }
}