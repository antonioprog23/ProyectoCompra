using ProyectoCompra.Clases;
using ProyectoCompra.Formularios;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlMasInformacion : UserControl
    {
        public Factura factura { get; set; }

        public CtrlMasInformacion()
        {
            InitializeComponent();
        }

        private void CtrlMasInformacion_Load(object sender, System.EventArgs e)
        {
            if (factura != null)
            {
                cargarDatos();
            }
        }

        private void cargarDatos()
        {
            lblNomCliente.Text = string.Format("{0} {1}", factura.pedido.usuario.cliente.nombre, factura.pedido.usuario.cliente.apellido);
            lblCalle.Text = factura.pedido.direccion.direccion;
            lblCP.Text = string.Format("{0}, {1}", factura.pedido.direccion.ciudad, factura.pedido.direccion.codigoPostal);
            lblTelefono.Text = factura.pedido.direccion.telefono;

            lblNomCliente2.Text = string.Format("{0} {1}", factura.pedido.usuario.cliente.nombre, factura.pedido.usuario.cliente.apellido);
            lblCalle2.Text = factura.pedido.direccion.direccion;
            lblCP2.Text = string.Format("{0}, {1}", factura.pedido.direccion.ciudad, factura.pedido.direccion.codigoPostal);
            lblTelefono2.Text = factura.pedido.direccion.telefono;
        }

        private void btnDescargarFact_Click(object sender, System.EventArgs e)
        {
            FrmFactura factura = new FrmFactura(ConfigSesion.obtenerReferenciaIdUsuario(), this.factura.pedido.idPedido);
            factura.ShowDialog();
        }
    }
}
