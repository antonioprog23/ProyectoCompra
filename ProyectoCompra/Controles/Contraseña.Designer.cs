namespace ProyectoCompra.Controles
{
    partial class ctrlContrasenia
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
            this.btnMostrarPass = new System.Windows.Forms.Button();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMostrarPass
            // 
            this.btnMostrarPass.BackColor = System.Drawing.Color.White;
            this.btnMostrarPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMostrarPass.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMostrarPass.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMostrarPass.FlatAppearance.BorderSize = 0;
            this.btnMostrarPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMostrarPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMostrarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarPass.Image = global::ProyectoCompra.Properties.Resources.ocultar_contrasenia;
            this.btnMostrarPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMostrarPass.Location = new System.Drawing.Point(199, 0);
            this.btnMostrarPass.Name = "btnMostrarPass";
            this.btnMostrarPass.Size = new System.Drawing.Size(20, 23);
            this.btnMostrarPass.TabIndex = 25;
            this.btnMostrarPass.UseVisualStyleBackColor = false;
            this.btnMostrarPass.Click += new System.EventHandler(this.btnMostrarPass_Click);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtContrasenia.Font = new System.Drawing.Font("Arial Nova", 8.25F);
            this.txtContrasenia.Location = new System.Drawing.Point(0, 0);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(190, 21);
            this.txtContrasenia.TabIndex = 24;
            this.txtContrasenia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContrasenia.UseSystemPasswordChar = true;
            // 
            // ctrlContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMostrarPass);
            this.Controls.Add(this.txtContrasenia);
            this.Name = "ctrlContrasenia";
            this.Size = new System.Drawing.Size(219, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarPass;
        private System.Windows.Forms.TextBox txtContrasenia;
    }
}
