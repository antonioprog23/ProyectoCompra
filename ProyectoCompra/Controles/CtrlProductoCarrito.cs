using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlProductoCarrito : UserControl
    {
        public Button botonBorrar { get => btnBorrar; set { btnBorrar = value; } }
        public NumericUpDown botonCantidad { get => cantidad; set { cantidad = value; } }

        public CtrlProductoCarrito()
        {
            InitializeComponent();

        }
    }
}
