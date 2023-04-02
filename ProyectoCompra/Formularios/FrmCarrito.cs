using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmCarrito : Form
    {
        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            FrmModoCompra frmModoCompra = new FrmModoCompra();
            frmModoCompra.ShowDialog();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            List<Carrito> productos = FicheroCarrito.leerFichero();
            tbProductos.RowCount = productos.Count;
            for (int i = 0; i < tbProductos.RowCount; i++)
            {
                CtrlProductoCarrito producto = new CtrlProductoCarrito();
                Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                nombre.Text = productos[i].GetProducto().nombre;
                Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                precio.Text = productos[i].GetProducto().precio.ToString();
                NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                cantidad.Text = productos[i].GetCantidad().ToString();
                tbProductos.Controls.Add(producto);
            }
        }
    }
}
