using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlTarjeta : UserControl
    {
        public CtrlTarjeta()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarBotones();
            cargarControles();
        }

        private void cargarBotones()
        {
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = false;
        }
        private void cargarControles()
        {
            ctrlTxtTitular.Texto = "";
            ctrlTxtNTarjeta.Texto = "";
            ctrlTxtMesVen.Texto = "";
            ctrlAnioVen.Texto = "";
            ctrlCVV.Texto = "";

            lblTitular.Text = string.Format("* {0}", lblTitular.Text);
            lblNTarjeta.Text = string.Format("* {0}", lblNTarjeta.Text);
            lblMesVen.Text = string.Format("* {0}", lblMesVen.Text);
            lblAnioVen.Text = string.Format("* {0}", lblAnioVen.Text);
            lblCVV.Text = string.Format("* {0}", lblCVV.Text);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ctrlTxtTitular.Texto.Equals("") || ctrlTxtNTarjeta.Texto.Equals("") || ctrlTxtMesVen.Texto.Equals("") || ctrlAnioVen.Texto.Equals("") || ctrlCVV.Texto.Equals(""))
            {
                MessageBox.Show("Los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
