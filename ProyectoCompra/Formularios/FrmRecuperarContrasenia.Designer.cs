namespace ProyectoCompra.Formularios
{
    partial class FrmRecuperarContrasenia
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
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnCambiarContrasenia = new System.Windows.Forms.Button();
            this.ctrlContrasenia1 = new ProyectoCompra.Controles.ctrlContrasenia();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(28, 28);
            this.lblCorreoElectronico.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(47, 14);
            this.lblCorreoElectronico.TabIndex = 2;
            this.lblCorreoElectronico.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial Nova", 8.25F);
            this.txtUsuario.Location = new System.Drawing.Point(30, 46);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(261, 21);
            this.txtUsuario.TabIndex = 5;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCambiarContrasenia
            // 
            this.btnCambiarContrasenia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiarContrasenia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCambiarContrasenia.Location = new System.Drawing.Point(227, 173);
            this.btnCambiarContrasenia.Name = "btnCambiarContrasenia";
            this.btnCambiarContrasenia.Size = new System.Drawing.Size(64, 25);
            this.btnCambiarContrasenia.TabIndex = 6;
            this.btnCambiarContrasenia.Text = "Aceptar";
            this.btnCambiarContrasenia.UseVisualStyleBackColor = true;
            // 
            // ctrlContrasenia1
            // 
            this.ctrlContrasenia1.AutoSize = true;
            this.ctrlContrasenia1.Location = new System.Drawing.Point(31, 91);
            this.ctrlContrasenia1.Name = "ctrlContrasenia1";
            this.ctrlContrasenia1.Size = new System.Drawing.Size(261, 26);
            this.ctrlContrasenia1.TabIndex = 7;
            this.ctrlContrasenia1.TextBoxtxtContrasenia = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña nueva:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 21);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Repite contraseña:";
            // 
            // btnComprobar
            // 
            this.btnComprobar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprobar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnComprobar.Location = new System.Drawing.Point(183, 173);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(108, 25);
            this.btnComprobar.TabIndex = 11;
            this.btnComprobar.Text = "Comprobar usuario";
            this.btnComprobar.UseVisualStyleBackColor = true;
            // 
            // FrmRecuperarContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 218);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlContrasenia1);
            this.Controls.Add(this.btnCambiarContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.btnComprobar);
            this.Font = new System.Drawing.Font("Arial Nova Cond", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmRecuperarContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cambio de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnCambiarContrasenia;
        private Controles.ctrlContrasenia ctrlContrasenia1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprobar;
    }
}