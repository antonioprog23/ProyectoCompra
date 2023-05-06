using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlEfectivo : UserControl
    {
        public CtrlEfectivo()
        {
            InitializeComponent();
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            lblDireccion2.Enabled = true;
            txtDireccion2.Enabled = true;
            btnAgregarDireccion.Visible = false;
            btnAceptar.Visible = true;
            btnAceptar.Enabled = true;
        }

        private void CtrlEfectivo_Load(object sender, EventArgs e)
        {
            
        }
    }
}
