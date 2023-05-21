using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmFactura : Form
    {
        public int idUsuario { get; set; }

        public FrmFactura(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSFactura.ConsultarFactura' Puede moverla o quitarla según sea necesario.
            this.consultarFacturaTableAdapter.Fill(this.dSFactura.ConsultarFactura, idUsuario);
            this.reportViewer1.RefreshReport();
        }
    }
}
