using ProyectoCompra.Clases;
using ProyectoCompra.Enumerados;
using ProyectoCompra.Formularios;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlHistorialPedido : UserControl
    {
        public Factura factura { get; set; }
        public FrmBase frmBase { get; set; }
        public CtrlHistorialPedido()
        {
            InitializeComponent();
        }

        private void btnMasDetalles_Click(object sender, EventArgs e)
        {
            FrmMasDetalles frmMasDetalles = new FrmMasDetalles(factura, this.frmBase);
            frmMasDetalles.ShowDialog();
        }

        private void CtrlHistorialPedido_Load(object sender, EventArgs e)
        {
            if (factura != null)
            {
                lblIDMostrar.Text = factura.idFactura.ToString("D10");
                lblFechaMostrar.Text = factura.fechaFactura.ToString("D");
                lblContadorProd.Text = factura.pedido.obtenerCantidadTotalProductosPedido(factura.pedido.idPedido).ToString();
                lblMPagoMostrar.Text = Enum.GetName(typeof(EMetodoPago), factura.pedido.metodoPago);
                lblTotalMostrar.Text = factura.pedido.obtenerTotalPedido(factura.pedido.idPedido).ToString("0.00");
            }
        }


    }
}
