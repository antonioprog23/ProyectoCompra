using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
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
            this.ctrlEnvio1.carritoListo = carritoListo;
            ctrlEnvio1.btnContinuar = this.btnContinuar;
        }

        public FrmAccesoPago(CarritoProvisional carritoProvisionalListo)
        {
            InitializeComponent();
            this.carritoProvisionalListo = carritoProvisionalListo;
            this.ctrlEnvio1.carritoProvisionalListo = carritoProvisionalListo;
        }

        private void FrmAccesoPago_Load(object sender, EventArgs e)
        {
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                lblPTotal.Text = carritoProvisionalListo.total.ToString();
                lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
            }
            else
            {
                lblPTotal.Text = carritoListo.total.ToString();
                lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                configurarUsuarioInvitado();
            }
            else
            {
                BDPedido.actualizarPedido(ConfigSesion.obtenerReferenciaIdUsuario(), ctrlEnvio1.obtenerMetodoPagoElegido());
                bool enviarFactura = ctrlEnvio1.enviarFactura;
                if (enviarFactura)
                {
                    // Mensaje.enviareReporte("antajac23@gmail.com");
                    //Reporte.obtenerReporte(ConfigSesion.obtenerReferenciaIdUsuario(), 0);
                }
                Application.Restart();
            }
        }

        private void configurarUsuarioInvitado()
        {
            if (ctrlEnvio1.frmDireccion != null)
            {
                List<Direccion> direcciones = FicheroDireccion.leerFichero();
                if (direcciones.Count > 0)
                {
                    string nombre = direcciones[0].nombre;
                    Cliente cliente = new Cliente(nombre, "");
                    Usuario usuario = new Usuario("", "", 1);

                    string direccion = direcciones[0].direccion;
                    string pais = direcciones[0].pais;
                    string provincia = direcciones[0].provincia;
                    string ciudad = direcciones[0].ciudad;
                    string cp = direcciones[0].codigoPostal;
                    string telefono = direcciones[0].telefono;
                    Direccion direccionInvitado = new Direccion("Invitado", direccion, pais, provincia, ciudad, cp, telefono);

                    if (BDUsuario.insertarDatosInvitado(cliente, usuario, direccionInvitado, CarritoProvisional.prepararListaProvisionalBD()))
                    {
                        //Reporte.obtenerReporte(ConfigSesion.obtenerReferenciaIdUsuario(), 2);
                        FicheroCarrito.borrarFicheroAux();
                        FicheroDireccion.borrarFicheroAux();
                        FicheroTarjeta.borrarFicheroAux();
                    }
                }

            }
        }
    }
}
