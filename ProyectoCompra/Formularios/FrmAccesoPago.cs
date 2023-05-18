using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmAccesoPago : Form
    {
        private Carrito carritoListo;
        private CarritoProvisional carritoProvisionalListo;

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
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                lblPTotal.Text = carritoProvisionalListo.total.ToString();
                lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
            }
            else
            {
                lblPTotal.Text = carritoListo.total.ToString();
                lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }

    }
}
