using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            Usuario usuario = FicheroAuxiliar.leerFichero();
            Carrito carrito = new Carrito(Convert.ToInt32(dwCantidad.Value), producto);

            carrito.insertarProducto(usuario, carrito, true, imagen.ToString());
            Close();
        }

    }
}
