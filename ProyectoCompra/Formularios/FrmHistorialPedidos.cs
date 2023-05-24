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
            List<Factura> facturas = BDPedido.consultarFacturas(ConfigSesion.obtenerReferenciaIdUsuario());
            tbPedidosLista.RowCount = facturas.Count;
            for (int i = 0; i < tbPedidosLista.RowCount; i++)
            {
                CtrlHistorialPedido ctrlHistorialPedido = new CtrlHistorialPedido();
                tbPedidosLista.Controls.Add(ctrlHistorialPedido);
            }
        }
    }
}
