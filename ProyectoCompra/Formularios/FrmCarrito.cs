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
        private Carrito carrito;
        private List<Carrito> productos;

        public FrmCarrito()
        {
            InitializeComponent();
            carrito = new Carrito();
            productos = carrito.GetLista();
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
                Label id = (Label)producto.Controls.Find("lblIdMostrar", true)[0];
                id.Text = productos[i].GetProducto().id_producto.ToString();
                Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                nombre.Text = productos[i].GetProducto().nombre;
                Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                precio.Text = productos[i].GetProducto().precio.ToString();
                NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                cantidad.Text = productos[i].GetCantidad().ToString();
                Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                imagen.Image = productos[i].GetImage();
                producto.botonBorrar.Click += new EventHandler(BototnBorrar_Click);
                producto.botonBorrar.Name = productos[i].GetProducto().id_producto.ToString();
                producto.botonCantidad.Click += new EventHandler(BotonCantidad_Click);
                producto.botonCantidad.Name = productos[i].GetProducto().id_producto.ToString();
                tbProductos.Controls.Add(producto);
            }

            //SUBTOTAL
            lblSubTotal.Text = calcularSubTotal().ToString("N2");
            //TOTAL
            lblTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) * ((Convert.ToDecimal(lblIVA.Text) / 100) + 1)).ToString("N2");
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

        private void BototnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult confirmarBorrado = MessageBox.Show("¿Estás seguro de borrar el producto?", "Borrar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarBorrado == DialogResult.Yes)
            {
                Button button = sender as Button;
                carrito.borrarProducto(new Producto(Convert.ToInt32(button.Name)));
                actualizarVentana();
            }

        }

        private void BotonCantidad_Click(object sender, EventArgs e)
        {
            NumericUpDown cantidad = sender as NumericUpDown;
            Carrito carrito = productos.Find(p => p.GetProducto().id_producto == Convert.ToInt32(cantidad.Name));
            int index = productos.FindIndex(p => p.GetProducto().id_producto == Convert.ToInt32(cantidad.Name));
            carrito.SetCantidad(Convert.ToInt32(cantidad.Value));
            productos.RemoveAt(index);
            productos.Insert(index, carrito);
            FicheroCarrito.borrarFicheroAux();
            foreach (Carrito c in productos)
            {
                FicheroCarrito.escribirFichero(c);
            }
            actualizarVentana();
        }

        private void actualizarVentana()
        {
            //SE ACTUALIZA LA VENTANA
            this.Close();
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
        }

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            carrito.vaciarCarrito();
            actualizarVentana();
        }
    }
}
