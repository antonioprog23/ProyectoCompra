using ProyectoCompra.Formularios;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlHistorialPedido : UserControl
    {
        public CtrlHistorialPedido()
        {
            InitializeComponent();
        }

        private void btnMasDetalles_Click(object sender, EventArgs e)
        {
            FrmMasDetalles frmMasDetalles = new FrmMasDetalles();
            frmMasDetalles.ShowDialog();
        }
    }
}
