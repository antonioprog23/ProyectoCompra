using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Formularios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlResumenPedido : UserControl
    {
        public Factura factura { get; set; }
        private List<LineaPedido> lineasPedido;
        public FrmBase frmBase { get; set; }

        public CtrlResumenPedido()
        {
            InitializeComponent();
        }

        private void CtrlResumenPedido_Load(object sender, System.EventArgs e)
        {
            if (factura != null)
            {
                lineasPedido = factura.pedido.obtenerProductosDelPedido(factura.pedido.idPedido);
                lblNumProductos.Text = string.Format("{0} ({1})", lblNumProductos.Text, lineasPedido.Count);
                lblProductosMostrar.Text = factura.pedido.obtenerTotalPedido(factura.pedido.idPedido).ToString("0.00");
                lblTotalMostrar.Text = factura.pedido.obtenerTotalPedidoConGastosEnvíoEIntereses(Convert.ToDecimal(lblProductosMostrar.Text)).ToString("0.00");
            }
        }

        private void btnRepetirPedido_Click(object sender, System.EventArgs e)
        {
            Usuario usuario = new Usuario(ConfigSesion.obtenerReferenciaIdUsuario());
            foreach (LineaPedido lineaPedido in lineasPedido)
            {
                Carrito carrito = new Carrito(lineaPedido.cantidad, lineaPedido.producto);
                carrito.insertarProducto(usuario, carrito, true, lineaPedido.producto.imagen);
            }
            this.frmBase.aumentarContador();
            this.frmBase.configurarFrmBase();
        }


    }
}
