using ProyectoCompra.Clases;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlProductoHistorial : UserControl
    {
        public LineaPedido lineaPedido { get; set; }
        public Producto producto { get; set; }

        public CtrlProductoHistorial()
        {
            InitializeComponent();
        }

        private void CtrlProductoHistorial_Load(object sender, System.EventArgs e)
        {
            lblImage.Image = Imagen.obtenerImagenDB(producto.imagen.imagen);
            lblCantidadMostrar.Text = lineaPedido.cantidad.ToString();
            lblIDMostrar.Text = lineaPedido.producto.id_producto.ToString("D10");
            lblNombreMostrar.Text = lineaPedido.producto.nombre.ToString();
            lblPrecioMostrar.Text = lineaPedido.producto.precio.ToString();
        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            Usuario usuario = new Usuario(ConfigSesion.obtenerReferenciaIdUsuario());
            Carrito carrito = new Carrito(lineaPedido.cantidad, lineaPedido.producto);
            carrito.insertarProducto(usuario, carrito, true, lineaPedido.producto.imagen);
        }
    }
}
