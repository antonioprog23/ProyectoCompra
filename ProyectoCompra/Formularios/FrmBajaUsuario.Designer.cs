namespace ProyectoCompra.Formularios
{
    partial class FrmBajaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBajaUsuario));
            this.gbxUsuario = new System.Windows.Forms.GroupBox();
            this.lblRepContrasenia = new System.Windows.Forms.Label();
            this.txtRepContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbnUsuario = new System.Windows.Forms.RadioButton();
            this.rbnCorreoElectronico = new System.Windows.Forms.RadioButton();
            this.gbxCorreoElectronico = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.gbxUsuario.SuspendLayout();
            this.gbxCorreoElectronico.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxUsuario
            // 
            this.gbxUsuario.Controls.Add(this.lblRepContrasenia);
            this.gbxUsuario.Controls.Add(this.txtRepContrasenia);
            this.gbxUsuario.Controls.Add(this.lblContrasenia);
            this.gbxUsuario.Controls.Add(this.txtContrasenia);
            this.gbxUsuario.Controls.Add(this.lblUsuario);
            this.gbxUsuario.Controls.Add(this.txtUsuario);
            this.gbxUsuario.Location = new System.Drawing.Point(12, 35);
            this.gbxUsuario.Name = "gbxUsuario";
            this.gbxUsuario.Size = new System.Drawing.Size(272, 180);
            this.gbxUsuario.TabIndex = 0;
            this.gbxUsuario.TabStop = false;
            this.gbxUsuario.Text = "Datos usuario";
            // 
            // lblRepContrasenia
            // 
            this.lblRepContrasenia.AutoSize = true;
            this.lblRepContrasenia.ForeColor = System.Drawing.Color.Gray;
            this.lblRepContrasenia.Location = new System.Drawing.Point(31, 115);
            this.lblRepContrasenia.Name = "lblRepContrasenia";
            this.lblRepContrasenia.Size = new System.Drawing.Size(104, 13);
            this.lblRepContrasenia.TabIndex = 5;
            this.lblRepContrasenia.Text = "* Repite contraseña:";
            // 
            // txtRepContrasenia
            // 
            this.txtRepContrasenia.Enabled = false;
            this.txtRepContrasenia.Location = new System.Drawing.Point(34, 131);
            this.txtRepContrasenia.Name = "txtRepContrasenia";
            this.txtRepContrasenia.Size = new System.Drawing.Size(209, 20);
            this.txtRepContrasenia.TabIndex = 4;
            this.txtRepContrasenia.UseSystemPasswordChar = true;
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(31, 76);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(71, 13);
            this.lblContrasenia.TabIndex = 3;
            this.lblContrasenia.Text = "* Contraseña:";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(34, 92);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(209, 20);
            this.txtContrasenia.TabIndex = 2;
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(31, 37);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "* Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(34, 53);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(209, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(406, 221);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbnUsuario
            // 
            this.rbnUsuario.AutoSize = true;
            this.rbnUsuario.Checked = true;
            this.rbnUsuario.Location = new System.Drawing.Point(12, 12);
            this.rbnUsuario.Name = "rbnUsuario";
            this.rbnUsuario.Size = new System.Drawing.Size(61, 17);
            this.rbnUsuario.TabIndex = 2;
            this.rbnUsuario.TabStop = true;
            this.rbnUsuario.Text = "Usuario";
            this.rbnUsuario.UseVisualStyleBackColor = true;
            this.rbnUsuario.CheckedChanged += new System.EventHandler(this.rbnUsuario_CheckedChanged);
            // 
            // rbnCorreoElectronico
            // 
            this.rbnCorreoElectronico.AutoSize = true;
            this.rbnCorreoElectronico.Location = new System.Drawing.Point(290, 12);
            this.rbnCorreoElectronico.Name = "rbnCorreoElectronico";
            this.rbnCorreoElectronico.Size = new System.Drawing.Size(111, 17);
            this.rbnCorreoElectronico.TabIndex = 4;
            this.rbnCorreoElectronico.Text = "Correo electrónico";
            this.rbnCorreoElectronico.UseVisualStyleBackColor = true;
            this.rbnCorreoElectronico.CheckedChanged += new System.EventHandler(this.rbnCorreoElectronico_CheckedChanged);
            // 
            // gbxCorreoElectronico
            // 
            this.gbxCorreoElectronico.Controls.Add(this.lblCodigo);
            this.gbxCorreoElectronico.Controls.Add(this.txtCodigo);
            this.gbxCorreoElectronico.Controls.Add(this.label1);
            this.gbxCorreoElectronico.Controls.Add(this.txtCorreoElectronico);
            this.gbxCorreoElectronico.Enabled = false;
            this.gbxCorreoElectronico.Location = new System.Drawing.Point(290, 35);
            this.gbxCorreoElectronico.Name = "gbxCorreoElectronico";
            this.gbxCorreoElectronico.Size = new System.Drawing.Size(272, 180);
            this.gbxCorreoElectronico.TabIndex = 3;
            this.gbxCorreoElectronico.TabStop = false;
            this.gbxCorreoElectronico.Text = "Datos usuario";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Gray;
            this.lblCodigo.Location = new System.Drawing.Point(30, 76);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "* Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(33, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(209, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "* Correo electronico:";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(33, 53);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(209, 20);
            this.txtCorreoElectronico.TabIndex = 2;
            this.txtCorreoElectronico.TextChanged += new System.EventHandler(this.txtCorreoElectronico_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(487, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAyuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAyuda.Location = new System.Drawing.Point(12, 217);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(272, 31);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.MouseEnter += new System.EventHandler(this.btnAyuda_MouseEnter);
            this.btnAyuda.MouseLeave += new System.EventHandler(this.btnAyuda_MouseLeave);
            // 
            // FrmBajaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(575, 253);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.rbnCorreoElectronico);
            this.Controls.Add(this.gbxCorreoElectronico);
            this.Controls.Add(this.rbnUsuario);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbxUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmBajaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Baja usuario";
            this.gbxUsuario.ResumeLayout(false);
            this.gbxUsuario.PerformLayout();
            this.gbxCorreoElectronico.ResumeLayout(false);
            this.gbxCorreoElectronico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxUsuario;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbnUsuario;
        private System.Windows.Forms.RadioButton rbnCorreoElectronico;
        private System.Windows.Forms.GroupBox gbxCorreoElectronico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.Label lblRepContrasenia;
        private System.Windows.Forms.TextBox txtRepContrasenia;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnCancelar;
    }
}