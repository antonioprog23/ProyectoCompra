using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmAccesoPago : Form
    {
        private Carrito carritoListo;
        private CarritoProvisional carritoProvisionalListo;
        private RadioButton rbtnCasa;

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
                this.rbtnCasa = ctrlEnvio1.Controls.Find("rbtnCasa", true)[0] as RadioButton;
                rbtnCasa.Click += rbtnCasa_Click;
                this.ctrlEnvio1.formModificar = this;
                this.ctrlEnvio1.groupBoxModificar = gbxResumen;
                this.ctrlEnvio1.botonModificar = btnContinuar;
                lblPTotal.Text = carritoProvisionalListo.total.ToString();
                lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
            }
            else
            {
                this.rbtnCasa = ctrlEnvio1.Controls.Find("rbtnCasa", true)[0] as RadioButton;
                rbtnCasa.Click += rbtnCasa_Click;
                this.ctrlEnvio1.formModificar = this;
                this.ctrlEnvio1.groupBoxModificar = gbxResumen;
                this.ctrlEnvio1.botonModificar = btnContinuar;
                lblPTotal.Text = carritoListo.total.ToString();
                lblTotal.Text = (decimal.Parse(lblPTotal.Text) + (decimal.Parse(lblGastosEnvio.Text))).ToString();
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

        }

        private void rbtnCasa_Click(object sender, EventArgs e)
        {
            FrmDireccion frmDireccion = new FrmDireccion(true);
            frmDireccion.ShowDialog();
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {

            }
            else
            {
                List<Direccion> direcciones = frmDireccion.direcciones;
                if (direcciones.Count > 0)
                {
                    this.btnContinuar.Enabled = true;
                }
            }
        }
    }
}
