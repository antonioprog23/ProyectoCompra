using ProyectoCompra.Clases;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlMasInformacion : UserControl
    {
        public Factura factura { get; set; }

        public CtrlMasInformacion()
        {
            InitializeComponent();
        }

    }
}
