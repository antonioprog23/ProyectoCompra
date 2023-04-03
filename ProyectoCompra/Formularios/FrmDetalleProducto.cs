using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    internal partial class FrmDetalleProducto : Form
    {
        private Image Image;
        private Producto producto;
        private FrmBase FrmBase;
        private List<Carrito> lista;

        public FrmDetalleProducto(Image image, Producto producto)
        {
            InitializeComponent();
            this.Image = image;
            this.producto = producto;
            FrmBase = new FrmBase();
            lista = FicheroCarrito.leerFichero();
            FrmBase.GetLabelContador().Text = lista.Count.ToString();
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
            Carrito carrito = new Carrito(Convert.ToInt32(dwCantidad.Value), Image);
            carrito.insertarProducto(producto);
            
            FrmBase.GetLabelContador().Text = lista.Count.ToString();
            Close();
        }

    }
}
