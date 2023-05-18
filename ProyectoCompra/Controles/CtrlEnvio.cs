using ProyectoCompra.Clases;
using ProyectoCompra.Formularios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlEnvio : UserControl
    {
        public Carrito carritoListo { get; set; }
        public CarritoProvisional carritoProvisionalListo { get; set; }
        public Form formModificar { get; set; }
        public GroupBox groupBoxModificar { get; set; }
        public Button botonModificar { get; set; }

        public CtrlEnvio()
        {
            InitializeComponent();
        }

        public CtrlEnvio(Form formModificar, GroupBox groupBoxModificar, Button botonModificar)
        {
            InitializeComponent();
            this.formModificar = formModificar;
            this.groupBoxModificar = groupBoxModificar;
            this.botonModificar = botonModificar;
        }

        public CtrlEnvio(Carrito carritoListo)
        {
            InitializeComponent();
            this.carritoListo = carritoListo;
        }

        public CtrlEnvio(CarritoProvisional carritoProvisionalListo)
        {
            InitializeComponent();
            this.carritoProvisionalListo = carritoProvisionalListo;

        }

        private void CtrlEnvio_Load(object sender, EventArgs e)
        {
            configuracionInicial();
            cargarProductosCarrito();
            cargarProductosCarritoProvisional();
        }

        private void cargarProductosCarrito()
        {
            if (ConfigSesion.obtenerReferenciaIdUsuario() != 0)
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
                    this.lblResumenProductos.Text = string.Format("{0} ({1})", lblResumenProductos.Text, carritoListo.lista.Count);
                }
            }
        }

        private void cargarProductosCarritoProvisional()
        {
            if (carritoProvisionalListo != null)
            {
                tlProductos.RowCount = carritoProvisionalListo.lista.Count;
                for (int i = 0; i < tlProductos.RowCount; i++)
                {
                    CtrlProductoCarrito producto = new CtrlProductoCarrito();
                    Label id = (Label)producto.Controls.Find("lblIdMostrar", true)[0];
                    id.Text = carritoProvisionalListo.lista[i].producto.id_producto.ToString();

                    Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                    nombre.Text = carritoProvisionalListo.lista[i].producto.nombre;

                    Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                    precio.Text = carritoProvisionalListo.lista[i].producto.precio.ToString();

                    NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                    cantidad.Text = carritoProvisionalListo.lista[i].cantidad.ToString();
                    cantidad.Enabled = false;

                    Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                    imagen.Image = Imagen.obtenerImagenDB(carritoProvisionalListo.lista[i].rutaImagen);

                    producto.botonBorrar.Visible = false;

                    tlProductos.Controls.Add(producto);
                }
            }
        }

        private void configuracionInicial()
        {
            this.Size = new System.Drawing.Size(509, 295);
            this.gbxOpcion.Size = new System.Drawing.Size(503, 289);
            this.panelDetalles.Size = new System.Drawing.Size(477, 58);
            this.flProductos.Size = new System.Drawing.Size(471, 10);
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.formModificar.Size = new System.Drawing.Size(829, 543);
            this.groupBoxModificar.Size = new System.Drawing.Size(275, 472);
            this.botonModificar.Location = new System.Drawing.Point(10, 443);

            this.Size = new System.Drawing.Size(509, 478);
            this.gbxOpcion.Size = new System.Drawing.Size(503, 472);
            this.panelDetalles.Size = new System.Drawing.Size(477, 229);
            this.flProductos.Size = new System.Drawing.Size(471, 187);
            this.flProductos.Visible = true;
            this.btnDetalles.Visible = false;
            this.btnOcultarDetalles.Visible = true;
        }

        private void btnOcultarDetalles_Click(object sender, EventArgs e)
        {
            configuracionInicial();
            this.formModificar.Size = new System.Drawing.Size(829, 357);
            this.groupBoxModificar.Size = new System.Drawing.Size(275, 288);
            this.botonModificar.Location = new System.Drawing.Point(10, 259);
            this.btnDetalles.Visible = true;
            this.btnOcultarDetalles.Visible = false;
            this.flProductos.Visible = false;
        }

    }
}
