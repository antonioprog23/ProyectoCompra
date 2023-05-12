using ProyectoCompra.Controles;
using System;
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
            for (int i = 0; i < tbPedidosLista.RowCount; i++)
            {
                for (int j = 0; j < tbPedidosLista.ColumnCount; j++)
                {
                    CtrlHistorialPedido ctrlHistorialPedido = new CtrlHistorialPedido();
                   tbPedidosLista.Controls.Add(ctrlHistorialPedido);
                }
            }
        }
    }
}
