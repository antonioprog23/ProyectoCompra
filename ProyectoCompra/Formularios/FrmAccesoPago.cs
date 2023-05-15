using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmAccesoPago : Form
    {
        public FrmAccesoPago()
        {
            InitializeComponent();
        }

        private void FrmAccesoPago_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(829, 348);
            this.gbxOpcion.Size = new System.Drawing.Size(503, 287);
            this.panelDetalles.Size = new System.Drawing.Size(473, 68);
            this.gbxResumen.Size = new System.Drawing.Size(275, 287);
            this.btnContinuar.Location = new System.Drawing.Point(10, 258);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(829, 540);
            this.gbxOpcion.Size = new System.Drawing.Size(503, 479);
            this.panelDetalles.Size = new System.Drawing.Size(473, 234);
            this.gbxResumen.Size = new System.Drawing.Size(275, 479);
            this.btnContinuar.Location = new System.Drawing.Point(10, 450);
            this.btnOcultarDetalles.Visible = true;
            this.btnDetalles.Visible = false;
        }

        private void btnOcultarDetalles_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(829, 348);
            this.gbxOpcion.Size = new System.Drawing.Size(503, 287);
            this.panelDetalles.Size = new System.Drawing.Size(473, 68);
            this.gbxResumen.Size = new System.Drawing.Size(275, 287);
            this.btnContinuar.Location = new System.Drawing.Point(10, 258);
            this.btnOcultarDetalles.Visible = false;
            this.btnDetalles.Visible = true;
        }
    }
}
