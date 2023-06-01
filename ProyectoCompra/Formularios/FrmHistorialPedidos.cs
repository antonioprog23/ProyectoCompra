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
        #region Fields

        private CtrlHistorialPedido ctrlHistorialPedido;
        public FrmBase frmBase { get; set; }

        #endregion

        #region Constructor
        public FrmHistorialPedidos(FrmBase frmBase)
        {
            InitializeComponent();
            this.ctrlHistorialPedido = null;
            this.frmBase = frmBase;
        }
        #endregion

        private void FrmHistorialPedidos_Load(object sender, EventArgs e)
        {
            this.lblContadorPedidos.Text = string.Format("{0} ({1})", lblContadorPedidos.Text, 0);
        }

        #region Eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Factura> facturas = BDPedido.consultarFacturas(ConfigSesion.obtenerReferenciaIdUsuario(), dtDesde.Value, dtHasta.Value);

            if (ctrlHistorialPedido != null)
            {
                if (tbPedidosLista.Controls.Contains(ctrlHistorialPedido))
                {
                    tbPedidosLista.Controls.Clear();
                }
            }

            if (facturas.Count == 0)
            {
                this.lblContadorPedidos.Text = "";
                this.lblContadorPedidos.Text = string.Format("Pedidos filtrados ({0})", facturas.Count);
                this.lblContadorPedidos.Visible = false;
                this.lblNotificadorPedidos.Visible = true;
                return;
            }

            this.lblNotificadorPedidos.Visible = false;
            tbPedidosLista.RowCount = facturas.Count;
            for (int i = 0; i < tbPedidosLista.RowCount; i++)
            {
                ctrlHistorialPedido = new CtrlHistorialPedido();
                ctrlHistorialPedido.factura = facturas[i];
                ctrlHistorialPedido.frmBase = this.frmBase;
                tbPedidosLista.Controls.Add(ctrlHistorialPedido);
            }

            this.lblContadorPedidos.Text = "";
            this.lblContadorPedidos.Text = string.Format("Pedidos filtrados ({0})", facturas.Count);
            this.lblContadorPedidos.Visible = true;
        }
        #endregion
    }
}
