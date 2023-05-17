using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmAccesoPago : Form
    {
        private Carrito carritoListo;
        private CarritoProvisional carritoProvisionalListo;
        public Button btnOcultarDetalles;
        public Button btnMostrarDetalles;

        public FrmAccesoPago()
        {
            InitializeComponent();
        }

        public FrmAccesoPago(Carrito carritoListo)
        {
            InitializeComponent();
            this.carritoListo = carritoListo;
            this.ctrlEnvio1.carritoListo = carritoListo;
        }

        public FrmAccesoPago(CarritoProvisional carritoProvisionalListo)
        {
            InitializeComponent();
            this.carritoProvisionalListo = carritoProvisionalListo;
            this.ctrlEnvio1.carritoProvisionalListo = carritoProvisionalListo;
        }

        private void FrmAccesoPago_Load(object sender, EventArgs e)
        {
            this.ctrlEnvio1.formModificar = this;
            this.ctrlEnvio1.groupBoxModificar = gbxResumen;
            this.ctrlEnvio1.botonModificar = btnContinuar;
            lblPTotal.Text = carritoListo.total.ToString();
            lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }
    }
}
