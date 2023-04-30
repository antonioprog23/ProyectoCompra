namespace ProyectoCompra.Controles
{
    partial class CtrlOtrasOpciones
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
            this.tbOpciones = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // tbOpciones
            // 
            this.tbOpciones.AutoSize = true;
            this.tbOpciones.ColumnCount = 4;
            this.tbOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbOpciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbOpciones.Location = new System.Drawing.Point(3, 3);
            this.tbOpciones.Name = "tbOpciones";
            this.tbOpciones.RowCount = 1;
            this.tbOpciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbOpciones.Size = new System.Drawing.Size(293, 138);
            this.tbOpciones.TabIndex = 0;
            // 
            // CtrlOtrasOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tbOpciones);
            this.Name = "CtrlOtrasOpciones";
            this.Size = new System.Drawing.Size(299, 144);
            this.Load += new System.EventHandler(this.CtrlOtrasOpciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbOpciones;
    }
}
