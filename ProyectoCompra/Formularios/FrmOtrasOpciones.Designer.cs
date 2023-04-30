namespace ProyectoCompra.Formularios
{
    partial class FrmOtrasOpciones
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlOtrasOpciones1 = new ProyectoCompra.Controles.CtrlOtrasOpciones();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ctrlOtrasOpciones1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 161);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ctrlOtrasOpciones1
            // 
            this.ctrlOtrasOpciones1.AutoSize = true;
            this.ctrlOtrasOpciones1.Location = new System.Drawing.Point(3, 3);
            this.ctrlOtrasOpciones1.Name = "ctrlOtrasOpciones1";
            this.ctrlOtrasOpciones1.Size = new System.Drawing.Size(610, 157);
            this.ctrlOtrasOpciones1.TabIndex = 0;
            // 
            // FrmOtrasOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(621, 167);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOtrasOpciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Otras opciones";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controles.CtrlOtrasOpciones ctrlOtrasOpciones1;
    }
}