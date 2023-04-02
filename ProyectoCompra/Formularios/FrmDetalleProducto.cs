using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    internal partial class FrmDetalleProducto : Form
    {
        private Image Image;
        private Producto producto;

        public FrmDetalleProducto(Image image, Producto producto)
        {
            InitializeComponent();
            this.Image = image;
            this.producto = producto;
        }

        private void FrmDetalleProducto_Load(object sender, EventArgs e)
        {
            lblImage.Image = Image;
            lblNombreMostrar.Text = producto.nombre;
            lblDescripcionMostrar.Text = producto.descripcion;
            lblPrecioMostrar.Text = producto.precio.ToString();
            lblFabricanteMostrar.Text = producto.fabricante.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito(Convert.ToInt32(dwCantidad.Value));
            carrito.insertarProducto(producto);
            Close();
        }
    }
}
