using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmHistorialPedidos : Form
    {
        public FrmHistorialPedidos()
        {
            InitializeComponent();
        }

        private void FrmHistorialPedidos_Load(object sender, EventArgs e)
        {
            this.lblContadorPedidos.Text = string.Format("{0} ({1})", lblContadorPedidos.Text, 0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tbPedidosLista.Controls.Contains(ctrlHistorialPedido1))
            {
                tbPedidosLista.Controls.Clear();
            }
            List<Factura> facturas = BDPedido.consultarFacturas(ConfigSesion.obtenerReferenciaIdUsuario(), dtDesde.Value, dtHasta.Value);
            tbPedidosLista.RowCount = facturas.Count;
            for (int i = 0; i < tbPedidosLista.RowCount; i++)
            {
                CtrlHistorialPedido ctrlHistorialPedido = new CtrlHistorialPedido();
                ctrlHistorialPedido.factura = facturas[i];
                tbPedidosLista.Controls.Add(ctrlHistorialPedido);
            }
            this.lblContadorPedidos.Text = "";
            this.lblContadorPedidos.Text = string.Format("Pedidos filtrados ({0})", facturas.Count);
        }
    }
}
