using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmFactura : Form
    {
        public int idUsuario { get; set; }
        public int idPedido { get; set; }

        public FrmFactura(int idUsuario, int idPedido)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
            this.idPedido = idPedido;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSFactura.ConsultarFactura' Puede moverla o quitarla según sea necesario.
            this.consultarFacturaTableAdapter.Fill(this.dSFactura.ConsultarFactura, this.idUsuario, this.idPedido);
            this.reportViewer1.RefreshReport();
        }
    }
}
