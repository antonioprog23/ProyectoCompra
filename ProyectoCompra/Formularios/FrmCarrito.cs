using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmCarrito : Form
    {
        private List<Carrito> productos;
        private List<CarritoProvisional> productosProvisionales;
        private int idUsuario;
        private Carrito carrito;
        private CarritoProvisional carritoProvisional;

        public FrmCarrito()
        {
            InitializeComponent();
            idUsuario = ConfigSesion.obtenerReferenciaIdUsuario();
            if (idUsuario == 0)
            {
                carritoProvisional = new CarritoProvisional();
                productosProvisionales = CarritoProvisional.consultarCarritoProvisional();
            }
            else
            {
                carrito = new Carrito();
                productos = carrito.consultarProductosCarrito(idUsuario);
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            int idUsuario = ConfigSesion.obtenerReferenciaIdUsuario();
            if (idUsuario != 0)
            {
                FrmAccesoPago frmAccesoPago = new FrmAccesoPago();
                frmAccesoPago.ShowDialog();
            }
            else
            {
                FrmModoCompra frmModoCompra = new FrmModoCompra();
                frmModoCompra.ShowDialog();
            }
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            cargarDatos();
            if (idUsuario == 0)
            {
                if (productosProvisionales.Count == 0)
                {
                    configurarBotones(true, false, false);
                    return;
                }
                configurarBotones(false, true, true);
            }
            else
            {
                if (productos.Count == 0)
                {
                    configurarBotones(true, false, false);
                    return;
                }
                configurarBotones(false, true, true);
            }
        }

        private void configurarBotones(bool carritoVacio, bool confirmarCompra, bool vaciarCarrito)
        {
            lblCarritoVacio.Visible = carritoVacio;
            btnConfirmarCompra.Visible = confirmarCompra;
            btnVaciarCarrito.Visible = vaciarCarrito;
        }

        private void cargarDatos()
        {
            if (idUsuario == 0)
            {
                cargarCarritoProvisional();
            }
            else
            {
                cargarCarrito();
            }


            //SUBTOTAL
            lblSubTotal.Text = calcularSubTotal().ToString("N2");
            //TOTAL
            lblTotal.Text = (Convert.ToDecimal(lblSubTotal.Text) * ((Convert.ToDecimal(lblIVA.Text) / 100) + 1)).ToString("N2");
        }

        private void cargarCarritoProvisional()
        {
            //PRODUCTOS FICHERO
            tbProductos.RowCount = productosProvisionales.Count;
            lblContador.Text = productosProvisionales.Count.ToString();
            for (int i = 0; i < tbProductos.RowCount; i++)
            {
                CtrlProductoCarrito producto = new CtrlProductoCarrito();

                Label id = (Label)producto.Controls.Find("lblIdMostrar", true)[0];
                id.Text = productosProvisionales[i].producto.id_producto.ToString();

                Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                nombre.Text = productosProvisionales[i].producto.nombre;

                Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                precio.Text = productosProvisionales[i].producto.precio.ToString();

                NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                cantidad.Text = productosProvisionales[i].cantidad.ToString();

                Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                imagen.Image = Imagen.obtenerImagenDB(productosProvisionales[i].rutaImagen);
                producto.botonBorrar.Click += new EventHandler(BototnBorrar_Click);
                producto.botonBorrar.Name = productosProvisionales[i].producto.id_producto.ToString();
                producto.botonCantidad.Click += new EventHandler(BotonCantidad_Click);
                producto.botonCantidad.Name = productosProvisionales[i].producto.id_producto.ToString();
                tbProductos.Controls.Add(producto);
            }
        }

        private void cargarCarrito()
        {
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
                Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                imagen.Image = Imagen.obtenerImagenDB(productos[i].rutaImagen);
                producto.botonBorrar.Click += new EventHandler(BototnBorrar_Click);
                producto.botonBorrar.Name = productos[i].producto.id_producto.ToString();
                producto.botonCantidad.Click += new EventHandler(BotonCantidad_Click);
                producto.botonCantidad.Name = productos[i].producto.id_producto.ToString();
                tbProductos.Controls.Add(producto);
            }
        }

        private decimal calcularSubTotal()
        {
            decimal subtTotal = 0;
            if (idUsuario == 0)
            {
                foreach (CarritoProvisional producto in productosProvisionales)
                {
                    subtTotal += producto.producto.precio * producto.cantidad;
                }
            }
            else
            {
                foreach (Carrito producto in productos)
                {
                    subtTotal += producto.producto.precio * producto.cantidad;
                }
            }
            return subtTotal;
        }

        private void BototnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult confirmarBorrado = MessageBox.Show("¿Estás seguro de borrar el producto?", "Borrar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Button button = sender as Button;
            if (productos != null)
            {
                if (confirmarBorrado == DialogResult.Yes)
                {
                    carrito.vaciarCarrito(idUsuario, Convert.ToInt32(button.Name), false);
                    this.Refresh();
                    //actualizarVentana();
                }
                return;
            }

            if (productosProvisionales != null)
            {
                if (confirmarBorrado == DialogResult.Yes)
                {
                    CarritoProvisional.eliminarProducto(Convert.ToInt32(button.Name.ToString()));

                    //actualizarVentana();
                }
                return;
            }

        }

        private void BotonCantidad_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto(Convert.ToInt32((sender as NumericUpDown).Name));
            if (idUsuario == 0)
            {


                CarritoProvisional.editarCantidadProducto(producto.id_producto, Convert.ToInt32((sender as NumericUpDown).Value));
            }
            else
            {
                Carrito carrito = new Carrito(Convert.ToInt32((sender as NumericUpDown).Value), producto);
                Usuario usuario = new Usuario(idUsuario);
                BDCarrito.insertarProductoCarrito(usuario, carrito, false, "");
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
            if (productos != null)
            {
                foreach (Carrito producto in productos)
                {
                    carrito.vaciarCarrito(idUsuario, 0, true);
                }
                this.Close();
            }

            if (productosProvisionales != null)
            {
                CarritoProvisional.vaciarCarrito();
                this.Close();
            }
        }
    }
}
