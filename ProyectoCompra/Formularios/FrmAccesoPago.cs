using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmAccesoPago : Form
    {
        private Carrito carritoListo;
        private CarritoProvisional carritoProvisionalListo;

        public FrmAccesoPago()
        {
            InitializeComponent();
        }

        public FrmAccesoPago(Carrito carritoListo)
        {
            InitializeComponent();
            this.carritoListo = carritoListo;
        }

        public FrmAccesoPago(CarritoProvisional carritoProvisionalListo)
        {
            InitializeComponent();
            this.carritoProvisionalListo = carritoProvisionalListo;
        }

        private void FrmAccesoPago_Load(object sender, EventArgs e)
        {
            configurarControlesIniciales(true, false);
            cargarProductosCarrito();
            this.lblResumenProductos.Text = string.Format("{0} ({1})", lblResumenProductos.Text, carritoListo.lista.Count);
            lblPTotal.Text = carritoListo.total.ToString();
            lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
        }

        private void cargarProductosCarrito()
        {
            if (carritoListo != null)
            {
                tlProductos.RowCount = carritoListo.lista.Count;
                for (int i = 0; i < tlProductos.RowCount; i++)
                {
                    CtrlProductoCarrito producto = new CtrlProductoCarrito();
                    Label id = (Label)producto.Controls.Find("lblIdMostrar", true)[0];
                    id.Text = carritoListo.lista[i].producto.id_producto.ToString();

                    Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                    nombre.Text = carritoListo.lista[i].producto.nombre;

                    Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                    precio.Text = carritoListo.lista[i].producto.precio.ToString();

                    NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                    cantidad.Text = carritoListo.lista[i].cantidad.ToString();
                    cantidad.Enabled = false;

                    Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                    imagen.Image = Imagen.obtenerImagenDB(carritoListo.lista[i].rutaImagen);

                    producto.botonBorrar.Visible = false;

                    tlProductos.Controls.Add(producto);
                }
            }
        }

        private void cargarProductosCarritoProvisional()
        {
            if (carritoProvisionalListo != null)
            {
                tlProductos.RowCount = carritoListo.lista.Count;
                for (int i = 0; i < tlProductos.RowCount; i++)
                {
                    CtrlProductoCarrito producto = new CtrlProductoCarrito();
                    Label id = (Label)producto.Controls.Find("lblIdMostrar", true)[0];
                    id.Text = carritoListo.lista[i].producto.id_producto.ToString();

                    Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                    nombre.Text = carritoListo.lista[i].producto.nombre;

                    Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                    precio.Text = carritoListo.lista[i].producto.precio.ToString();

                    NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                    cantidad.Text = carritoListo.lista[i].cantidad.ToString();
                    cantidad.Enabled = false;

                    Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                    imagen.Image = Imagen.obtenerImagenDB(carritoListo.lista[i].rutaImagen);

                    producto.botonBorrar.Visible = false;

                    tlProductos.Controls.Add(producto);
                }
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            configurarControlesDetalle(false, true);
        }

        private void btnOcultarDetalles_Click(object sender, EventArgs e)
        {
            configurarControlesIniciales(true, false);
        }

        private void configurarControlesIniciales(bool mostrar, bool ocultar)
        {
            this.Size = new System.Drawing.Size(829, 348);
            this.gbxOpcion.Size = new System.Drawing.Size(503, 287);
            this.panelDetalles.Size = new System.Drawing.Size(473, 68);
            this.gbxResumen.Size = new System.Drawing.Size(275, 287);
            this.btnContinuar.Location = new System.Drawing.Point(10, 258);
            this.btnOcultarDetalles.Visible = ocultar;
            this.btnDetalles.Visible = mostrar;
            this.flProductos.Visible = false;
        }

        private void configurarControlesDetalle(bool mostrar, bool ocultar)
        {
            this.Size = new System.Drawing.Size(829, 568);
            this.gbxOpcion.Size = new System.Drawing.Size(503, 481);
            this.panelDetalles.Size = new System.Drawing.Size(477, 245);
            this.gbxResumen.Size = new System.Drawing.Size(275, 479);
            this.btnContinuar.Location = new System.Drawing.Point(10, 450);
            this.flProductos.Size = new System.Drawing.Size(471, 200);
            this.btnOcultarDetalles.Visible = ocultar;
            this.btnDetalles.Visible = mostrar;
            this.flProductos.Visible = true;
        }
    }
}
