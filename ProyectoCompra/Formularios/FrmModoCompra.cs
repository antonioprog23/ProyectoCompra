using ProyectoCompra.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmModoCompra : Form
    {
        public CarritoProvisional carritoProvisionalListo { get; set; }
        public FrmBase frmBase { get; set; }
        public FrmModoCompra()
        {
            InitializeComponent();
        }

        public FrmModoCompra(CarritoProvisional carritoProvisionalListo, FrmBase frmBase)
        {
            InitializeComponent();
            this.carritoProvisionalListo = carritoProvisionalListo;
            this.frmBase = frmBase;
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            FrmAccesoPago frmAccesoPago = new FrmAccesoPago(carritoProvisionalListo);
            frmAccesoPago.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmInicioSesion frmInicioSesion = new frmInicioSesion(this.frmBase);
            frmInicioSesion.ShowDialog();
            this.Close();
        }
    }
}
