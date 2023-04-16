using ProyectoCompra.Base_datos;
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
        private Usuario idUsuario;
        private Carrito carrito;

        public FrmCarrito()
        {
            InitializeComponent();
            carrito = new Carrito();
            idUsuario = FicheroAuxiliar.leerFichero();
            productos = carrito.consultarProductosCarrito(idUsuario.idUsuario);
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            FrmModoCompra frmModoCompra = new FrmModoCompra();
            frmModoCompra.ShowDialog();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            cargarDatos();
            if (productos.Count == 0)
            {
                this.Close();
            }
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
                id.Text = productos[i].producto.id_producto.ToString();
                Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                nombre.Text = productos[i].producto.nombre;
                Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                precio.Text = productos[i].producto.precio.ToString();
                NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                cantidad.Text = productos[i].cantidad.ToString();
                producto.botonBorrar.Click += new EventHandler(BototnBorrar_Click);
                producto.botonBorrar.Name = productos[i].producto.id_producto.ToString();
                producto.botonCantidad.Click += new EventHandler(BotonCantidad_Click);
                producto.botonCantidad.Name = productos[i].producto.id_producto.ToString();
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
                subtTotal += producto.producto.precio * producto.cantidad;
            }
            return subtTotal;
        }

        private void BototnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult confirmarBorrado = MessageBox.Show("¿Estás seguro de borrar el producto?", "Borrar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarBorrado == DialogResult.Yes)
            {
                Button button = sender as Button;
                carrito.vaciarCarrito(idUsuario.idUsuario, Convert.ToInt32(button.Name), false);
                actualizarVentana();
            }

        }

        private void BotonCantidad_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(Convert.ToInt32((sender as NumericUpDown).Name));
            Carrito carrito = new Carrito(Convert.ToInt32((sender as NumericUpDown).Value), producto);
            BDCarrito.insertarProductoCarrito(idUsuario, carrito, false);
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
            foreach (Carrito producto in productos)
            {
                carrito.vaciarCarrito(idUsuario.idUsuario, 0, true);
            }
            this.Close();
        }
    }
}
