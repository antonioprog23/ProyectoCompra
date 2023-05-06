namespace ProyectoCompra.Controles
{
    partial class CtrlTarjeta
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
            this.gbxTarjeta = new System.Windows.Forms.GroupBox();
            this.lblMesVen = new System.Windows.Forms.Label();
            this.lblAnioVen = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.lblNTarjeta = new System.Windows.Forms.Label();
            this.lblTitular = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ctrlCVV = new ProyectoCompra.Controles.CtrlTextoBox();
            this.ctrlAnioVen = new ProyectoCompra.Controles.CtrlTextoBox();
            this.ctrlTxtMesVen = new ProyectoCompra.Controles.CtrlTextoBox();
            this.ctrlTxtTitular = new ProyectoCompra.Controles.CtrlTextoBox();
            this.ctrlTxtNTarjeta = new ProyectoCompra.Controles.CtrlTextoBox();
            this.gbxTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTarjeta
            // 
            this.gbxTarjeta.Controls.Add(this.btnAceptar);
            this.gbxTarjeta.Controls.Add(this.btnEditar);
            this.gbxTarjeta.Controls.Add(this.ctrlCVV);
            this.gbxTarjeta.Controls.Add(this.ctrlAnioVen);
            this.gbxTarjeta.Controls.Add(this.lblMesVen);
            this.gbxTarjeta.Controls.Add(this.lblAnioVen);
            this.gbxTarjeta.Controls.Add(this.lblCVV);
            this.gbxTarjeta.Controls.Add(this.ctrlTxtMesVen);
            this.gbxTarjeta.Controls.Add(this.ctrlTxtTitular);
            this.gbxTarjeta.Controls.Add(this.ctrlTxtNTarjeta);
            this.gbxTarjeta.Controls.Add(this.lblNTarjeta);
            this.gbxTarjeta.Controls.Add(this.lblTitular);
            this.gbxTarjeta.Controls.Add(this.btnCancelar);
            this.gbxTarjeta.Location = new System.Drawing.Point(0, 0);
            this.gbxTarjeta.Name = "gbxTarjeta";
            this.gbxTarjeta.Size = new System.Drawing.Size(335, 197);
            this.gbxTarjeta.TabIndex = 0;
            this.gbxTarjeta.TabStop = false;
            this.gbxTarjeta.Text = "Tarjeta";
            // 
            // lblMesVen
            // 
            this.lblMesVen.AutoSize = true;
            this.lblMesVen.Location = new System.Drawing.Point(20, 109);
            this.lblMesVen.Name = "lblMesVen";
            this.lblMesVen.Size = new System.Drawing.Size(90, 13);
            this.lblMesVen.TabIndex = 9;
            this.lblMesVen.Text = "Mes vencimiento:";
            // 
            // lblAnioVen
            // 
            this.lblAnioVen.AutoSize = true;
            this.lblAnioVen.Location = new System.Drawing.Point(135, 109);
            this.lblAnioVen.Name = "lblAnioVen";
            this.lblAnioVen.Size = new System.Drawing.Size(89, 13);
            this.lblAnioVen.TabIndex = 10;
            this.lblAnioVen.Text = "Año vencimiento:";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Location = new System.Drawing.Point(251, 109);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(31, 13);
            this.lblCVV.TabIndex = 11;
            this.lblCVV.Text = "CVV:";
            // 
            // lblNTarjeta
            // 
            this.lblNTarjeta.AutoSize = true;
            this.lblNTarjeta.Location = new System.Drawing.Point(20, 70);
            this.lblNTarjeta.Name = "lblNTarjeta";
            this.lblNTarjeta.Size = new System.Drawing.Size(58, 13);
            this.lblNTarjeta.TabIndex = 4;
            this.lblNTarjeta.Text = "Nº Tarjeta:";
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Location = new System.Drawing.Point(20, 31);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(39, 13);
            this.lblTitular.TabIndex = 2;
            this.lblTitular.Text = "Titular:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(233, 160);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 14;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(152, 160);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(233, 160);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            // 
            // ctrlCVV
            // 
            this.ctrlCVV.AutoSize = true;
            this.ctrlCVV.IsNumerico = true;
            this.ctrlCVV.IsReadOnly = true;
            this.ctrlCVV.Location = new System.Drawing.Point(254, 125);
            this.ctrlCVV.Name = "ctrlCVV";
            this.ctrlCVV.Size = new System.Drawing.Size(54, 20);
            this.ctrlCVV.TabIndex = 13;
            this.ctrlCVV.Texto = "";
            // 
            // ctrlAnioVen
            // 
            this.ctrlAnioVen.AutoSize = true;
            this.ctrlAnioVen.IsNumerico = true;
            this.ctrlAnioVen.IsReadOnly = true;
            this.ctrlAnioVen.Location = new System.Drawing.Point(138, 125);
            this.ctrlAnioVen.Name = "ctrlAnioVen";
            this.ctrlAnioVen.Size = new System.Drawing.Size(86, 20);
            this.ctrlAnioVen.TabIndex = 12;
            this.ctrlAnioVen.Texto = "";
            // 
            // ctrlTxtMesVen
            // 
            this.ctrlTxtMesVen.AutoSize = true;
            this.ctrlTxtMesVen.IsNumerico = true;
            this.ctrlTxtMesVen.IsReadOnly = true;
            this.ctrlTxtMesVen.Location = new System.Drawing.Point(23, 125);
            this.ctrlTxtMesVen.Name = "ctrlTxtMesVen";
            this.ctrlTxtMesVen.Size = new System.Drawing.Size(87, 20);
            this.ctrlTxtMesVen.TabIndex = 8;
            this.ctrlTxtMesVen.Texto = "";
            // 
            // ctrlTxtTitular
            // 
            this.ctrlTxtTitular.AutoSize = true;
            this.ctrlTxtTitular.IsNumerico = true;
            this.ctrlTxtTitular.IsReadOnly = true;
            this.ctrlTxtTitular.Location = new System.Drawing.Point(23, 47);
            this.ctrlTxtTitular.Name = "ctrlTxtTitular";
            this.ctrlTxtTitular.Size = new System.Drawing.Size(285, 20);
            this.ctrlTxtTitular.TabIndex = 6;
            this.ctrlTxtTitular.Texto = "";
            // 
            // ctrlTxtNTarjeta
            // 
            this.ctrlTxtNTarjeta.AutoSize = true;
            this.ctrlTxtNTarjeta.IsNumerico = true;
            this.ctrlTxtNTarjeta.IsReadOnly = true;
            this.ctrlTxtNTarjeta.Location = new System.Drawing.Point(23, 86);
            this.ctrlTxtNTarjeta.Name = "ctrlTxtNTarjeta";
            this.ctrlTxtNTarjeta.Size = new System.Drawing.Size(285, 20);
            this.ctrlTxtNTarjeta.TabIndex = 5;
            this.ctrlTxtNTarjeta.Texto = "";
            // 
            // CtrlTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.gbxTarjeta);
            this.Name = "CtrlTarjeta";
            this.Size = new System.Drawing.Size(338, 200);
            this.gbxTarjeta.ResumeLayout(false);
            this.gbxTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTarjeta;
        private CtrlTextoBox ctrlTxtTitular;
        private CtrlTextoBox ctrlTxtNTarjeta;
        private System.Windows.Forms.Label lblNTarjeta;
        private System.Windows.Forms.Label lblTitular;
        private CtrlTextoBox ctrlCVV;
        private CtrlTextoBox ctrlAnioVen;
        private System.Windows.Forms.Label lblMesVen;
        private System.Windows.Forms.Label lblAnioVen;
        private System.Windows.Forms.Label lblCVV;
        private CtrlTextoBox ctrlTxtMesVen;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
