using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    internal partial class FrmDetalleProducto : Form
    {
        Carrito carrito;
        private Producto producto;
        private List<Carrito> lista;
        private Image imagen;

        public FrmDetalleProducto(Producto producto, object sender)
        {
            InitializeComponent();
            this.producto = producto;
            this.imagen = (sender as Button).Image;
            carrito = new Carrito();
        }

        private void FrmDetalleProducto_Load(object sender, EventArgs e)
        {
            lblNombreMostrar.Text = producto.nombre;
            lblDescripcionMostrar.Text = producto.descripcion;
            lblPrecioMostrar.Text = producto.precio.ToString();
            lblFabricanteMostrar.Text = producto.fabricante.ToString();
            lblImage.Image = imagen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int idUsuario = ConfigSesion.obtenerReferenciaIdUsuario();
            if (idUsuario == 0)
            {
                CarritoProvisional carritoProvisional = new CarritoProvisional(producto, Convert.ToInt32(dwCantidad.Value), imagen.Tag.ToString());
                carritoProvisional.insertarProducto(carritoProvisional);
            }
            else
            {
                Carrito carrito = new Carrito(Convert.ToInt32(dwCantidad.Value), producto);
                Usuario usuario = new Usuario(idUsuario);
                carrito.insertarProducto(usuario, carrito, true, imagen.Tag);
            }
            Close();
        }


    }
}
