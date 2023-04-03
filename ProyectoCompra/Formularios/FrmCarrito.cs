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
        private List<Carrito> productos;
        public FrmCarrito()
        {
            InitializeComponent();
            productos = FicheroCarrito.leerFichero();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            FrmModoCompra frmModoCompra = new FrmModoCompra();
            frmModoCompra.ShowDialog();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            //PRODUCTOS FICHERO
            tbProductos.RowCount = productos.Count;
            lblContador.Text = productos.Count.ToString();
            for (int i = 0; i < tbProductos.RowCount; i++)
            {
                CtrlProductoCarrito producto = new CtrlProductoCarrito();
                Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                nombre.Text = productos[i].GetProducto().nombre;
                Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                precio.Text = productos[i].GetProducto().precio.ToString();
                NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                cantidad.Text = productos[i].GetCantidad().ToString();
                Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                imagen.Image = productos[i].GetImage();
                producto.botonBorrar.Click += new EventHandler(BototnBorrar_Click);
                tbProductos.Controls.Add(producto);
            }

            //SUBTOTAL
            lblSubTotal.Text = calcularSubTotal().ToString();
            //TOTAL
            lblTotal.Text = Convert.ToString(Convert.ToDecimal(lblSubTotal.Text) * ((Convert.ToDecimal(lblIVA.Text) / 100) + 1));
        }

        private decimal calcularSubTotal()
        {
            decimal subtTotal = 0;
            foreach (Carrito producto in productos)
            {
                subtTotal += producto.GetProducto().precio * producto.GetCantidad();
            }
            return subtTotal;
        }

        public void BototnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult confirmarBorrado = MessageBox.Show("¿Estás seguro de borrar el producto?", "Borrar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarBorrado == DialogResult.OK)
            {

            }
        }

    }
}
