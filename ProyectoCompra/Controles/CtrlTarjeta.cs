using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlTarjeta : UserControl
    {
        private TarjetaCredit tarjetaCredit;
        private Usuario usuario;

        public CtrlTarjeta()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarBotones();
            cargarControles();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ctrlTxtTitular.Texto.Equals("") || ctrlTxtNTarjeta.Texto.Equals("") || ctrlTxtMesVen.Texto.Equals("") || ctrlAnioVen.Texto.Equals("") || ctrlCVV.Texto.Equals(""))
            {
                MessageBox.Show("Los campos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TarjetaCredit tarjetaCredit = crearTarjetaCredito();
            if (tarjetaCredit != null)
            {
                if (BDTarjetaCredito.actualizarTarjetaCredito(tarjetaCredit))
                {
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    MessageBox.Show("Se han actualizado los datos. Vuelva a abrir la ventana para actualizar los cambios.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void CtrlTarjeta_Load(object sender, EventArgs e)
        {
            cargarDatosTarjetaCredito();
        }

        private void cargarDatosTarjetaCredito()
        {
            usuario = FicheroAuxiliar.leerFichero();
            tarjetaCredit = BDTarjetaCredito.consultarTarjetaCredito(usuario.idUsuario);

            if (tarjetaCredit == null)
            {
                MessageBox.Show("Aún no tienes una tarjeta agregada. Si deseas agregar una tarjeta, elige la opción 'Editar'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ctrlTxtTitular.Texto = tarjetaCredit.titular;
            ctrlTxtNTarjeta.Texto = tarjetaCredit.numerosTarjeta;
            ctrlTxtMesVen.Texto = tarjetaCredit.mesVencimiento;
            ctrlAnioVen.Texto = tarjetaCredit.anioVencimiento;
            ctrlCVV.Texto = tarjetaCredit.cvv;
            btnEliminar.Visible = true;
        }

        private TarjetaCredit crearTarjetaCredito()
        {
            int idUsuariao = FicheroAuxiliar.leerFichero().idUsuario;
            return new TarjetaCredit(idUsuariao, ctrlTxtTitular.Texto, ctrlTxtNTarjeta.Texto, ctrlTxtMesVen.Texto, ctrlAnioVen.Texto, ctrlCVV.Texto);
        }
        private void cargarBotones()
        {
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Visible = false;
        }
        private void cargarControles()
        {
            ctrlTxtTitular.IsReadOnly = false;
            ctrlTxtNTarjeta.IsReadOnly = false;
            ctrlTxtMesVen.IsReadOnly = false;
            ctrlAnioVen.IsReadOnly = false;
            ctrlCVV.IsReadOnly = false;

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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (BDTarjetaCredito.eliminarTarjetaCredito(FicheroAuxiliar.leerFichero().idUsuario))
            {
                btnEliminar.Enabled = false;
                btnEditar.Enabled = false;
                btnAceptar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show("Se han actualizado los datos. Vuelva abrir la ventana para actualizar los datos.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
