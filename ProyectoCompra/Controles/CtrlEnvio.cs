using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
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

        public List<Direccion> direcciones { get; set; }
        public TarjetaCredit tarjetaCredit { get; set; }
        public bool isEfectivoElegida { get; set; }
        public Button btnContinuar { get; set; }

        public CtrlEnvio()
        {
            InitializeComponent();
            //TARJETA
            this.gbxTarjeta.Size = new System.Drawing.Size(433, 57);
        }

        public CtrlEnvio(Button btnContinuar)
        {
            InitializeComponent();
            //TARJETA
            this.gbxTarjeta.Size = new System.Drawing.Size(433, 57);
            this.btnContinuar = btnContinuar;
        }

        private void CtrlEnvio_Load(object sender, EventArgs e)
        {
            //DIRECCION DE ENVIO
            this.gbxDomicilio.Size = new System.Drawing.Size(433, 57);
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
                this.lblResumenProductos.Text = string.Format("{0} ({1})", lblResumenProductos.Text, carritoProvisionalListo.lista.Count);
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.flProductos.Visible = true;
            this.btnDetalles.Visible = false;
            this.btnOcultarDetalles.Visible = true;
        }

        private void btnOcultarDetalles_Click(object sender, EventArgs e)
        {
            this.btnDetalles.Visible = true;
            this.btnOcultarDetalles.Visible = false;
            this.flProductos.Visible = false;
        }

        private void rbtnCasa_Click(object sender, EventArgs e)
        {
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                FrmDireccion frmDireccion = new FrmDireccion(true, true);
                frmDireccion.ShowDialog();
                direccionInvitado();
            }
            else
            {
                FrmDireccion frmDireccion = new FrmDireccion(true, false);
                frmDireccion.ShowDialog();
                direccionUsuario();
            }
            comprobarBotonContinuar();
        }

        private void rbnTarjeta_Click(object sender, EventArgs e)
        {
            rbnEfectivo.Checked = false;
            this.gbxEfectivo.Size = new System.Drawing.Size(433, 57);

            FrmPagos frmPagos = new FrmPagos(true);
            frmPagos.ShowDialog();

            this.gbxTarjeta.Size = new System.Drawing.Size(433, 208);

            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                tarjetaInvitado();
            }
            else
            {
                tarjetaUsuario();
            }
            comprobarBotonContinuar();
        }

        private void tarjetaUsuario()
        {
            tarjetaCredit = BDTarjetaCredito.consultarTarjetaCredito(ConfigSesion.obtenerReferenciaIdUsuario());
            if (tarjetaCredit != null)
            {
                ctrlTxtTitular.Texto = tarjetaCredit.titular;
                ctrlTxtNTarjeta.Texto = tarjetaCredit.numerosTarjeta;
                ctrlTxtMesVen.Texto = tarjetaCredit.mesVencimiento;
                ctrlAnioVen.Texto = tarjetaCredit.anioVencimiento;
                ctrlCVV.Texto = tarjetaCredit.cvv;
                configuracionTarjeta();
            }
            else
            {
                this.gbxTarjeta.Size = new System.Drawing.Size(433, 57);
            }
        }

        private void tarjetaInvitado()
        {
            tarjetaCredit = FicheroTarjeta.leerFichero();
            if (tarjetaCredit != null)
            {
                ctrlTxtTitular.Texto = tarjetaCredit.titular;
                ctrlTxtNTarjeta.Texto = tarjetaCredit.numerosTarjeta;
                ctrlTxtMesVen.Texto = tarjetaCredit.mesVencimiento;
                ctrlAnioVen.Texto = tarjetaCredit.anioVencimiento;
                ctrlCVV.Texto = tarjetaCredit.cvv;
                configuracionTarjeta();
            }
            else
            {
                this.gbxTarjeta.Size = new System.Drawing.Size(433, 57);
            }
        }

        private void configuracionTarjeta()
        {
            ctrlTxtTitular.Visible = true;
            ctrlTxtNTarjeta.Visible = true;
            ctrlTxtMesVen.Visible = true;
            ctrlAnioVen.Visible = true;
            ctrlCVV.Visible = true;

            lblTitular.Visible = true;
            lblNTarjeta.Visible = true;
            lblMesVen.Visible = true;
            lblAnioVen.Visible = true;
            lblCVV.Visible = true;
        }

        private void rbnEfectivo_Click(object sender, EventArgs e)
        {
            rbnTarjeta.Checked = false;
            this.gbxTarjeta.Size = new System.Drawing.Size(433, 57);
            this.isEfectivoElegida = true;
            comprobarBotonContinuar();
        }

        private void direccionInvitado()
        {
            direcciones = FicheroDireccion.leerFichero();
            if (direcciones.Count > 0 && direcciones != null)
            {
                gbxDomicilio.Size = new System.Drawing.Size(433, 303);
                if (direcciones.Count == 1)
                {
                    lblNombre.Text = direcciones[0].nombre;
                    lblDireccion.Text = direcciones[0].direccion;
                    lblLocalidad.Text = direcciones[0].codigoPostal;
                    lblTelefono.Text = direcciones[0].telefono;

                    lblNombre.Visible = true;
                    lblDireccion.Visible = true;
                    lblLocalidad.Visible = true;
                    lblTelefono.Visible = true;
                }
                else
                {
                    //DIRECCION1
                    lblNombre.Text = direcciones[0].nombre;
                    lblDireccion.Text = direcciones[0].direccion;
                    lblLocalidad.Text = direcciones[0].codigoPostal;
                    lblTelefono.Text = direcciones[0].telefono;

                    lblNombre.Visible = true;
                    lblDireccion.Visible = true;
                    lblLocalidad.Visible = true;
                    lblTelefono.Visible = true;

                    //DIRECCION2 
                    lblNombre2.Text = direcciones[1].nombre;
                    lblDireccion2.Text = direcciones[1].direccion;
                    lblLocalidad2.Text = direcciones[1].codigoPostal;
                    lblTelefono2.Text = direcciones[1].telefono;

                    lblNombre2.Visible = true;
                    lblDireccion2.Visible = true;
                    lblLocalidad2.Visible = true;
                    lblTelefono2.Visible = true;
                }
            }
        }

        private void direccionUsuario()
        {
            direcciones = BDDireccion.consusltarDireccion(ConfigSesion.obtenerReferenciaIdUsuario());
            if (direcciones.Count > 0 && direcciones != null)
            {
                Usuario datos = BDUsuario.obtenerDatos("", "", ConfigSesion.obtenerReferenciaIdUsuario().ToString());
                gbxDomicilio.Size = new System.Drawing.Size(433, 184);
                if (direcciones.Count == 1)
                {
                    lblNombre.Text = datos.cliente.nombre;
                    lblDireccion.Text = direcciones[0].direccion;
                    lblLocalidad.Text = direcciones[0].codigoPostal;
                    lblTelefono.Text = direcciones[0].telefono;

                    lblNombre.Visible = true;
                    lblDireccion.Visible = true;
                    lblLocalidad.Visible = true;
                    lblTelefono.Visible = true;
                }
                else
                {
                    //DIRECCION1
                    lblNombre.Text = datos.cliente.nombre;
                    lblDireccion.Text = direcciones[0].direccion;
                    lblLocalidad.Text = direcciones[0].codigoPostal;
                    lblTelefono.Text = direcciones[0].telefono;

                    lblNombre.Visible = true;
                    lblDireccion.Visible = true;
                    lblLocalidad.Visible = true;
                    lblTelefono.Visible = true;

                    //DIRECCION2
                    lblNombre.Text = datos.cliente.nombre;
                    lblDireccion2.Text = direcciones[1].direccion;
                    lblLocalidad2.Text = direcciones[1].codigoPostal;
                    lblTelefono2.Text = direcciones[1].telefono;

                    lblNombre2.Visible = true;
                    lblDireccion2.Visible = true;
                    lblLocalidad2.Visible = true;
                    lblTelefono2.Visible = true;
                }
            }
        }

        private void comprobarBotonContinuar()
        {
            if (((direcciones != null) && tarjetaCredit != null) || (((direcciones != null) && isEfectivoElegida)))
            {
                this.btnContinuar.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmFactura frmFactura = new FrmFactura(ConfigSesion.obtenerReferenciaIdUsuario());
            frmFactura.ShowDialog();
        }
    }
}
