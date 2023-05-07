using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmPagos : Form
    {
        public FrmPagos()
        {
            InitializeComponent();
        }

        private void rbnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 322;
            this.Width = 375;
            ctrlEfectivo1.Visible = false;
            ctrlTarjeta1.Visible = true;
            ctrlTarjeta1.Location = new Point(12, 62);
        }

        private void rbnEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            this.Height = 238;
            this.Width = 375;
            ctrlTarjeta1.Visible = false;
            ctrlEfectivo1.Visible = true;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            this.Height = 238;
            this.Width = 375;
        }
    }
}
