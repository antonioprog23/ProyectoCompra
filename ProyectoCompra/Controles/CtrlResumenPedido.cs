using ProyectoCompra.Clases;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlResumenPedido : UserControl
    {
        public Factura factura { get; set; }

        public CtrlResumenPedido()
        {
            InitializeComponent();
        }

    }
}
