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

        public CtrlTarjeta()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarBotones(true, true, false);
            cargarControles(true, false, false);
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
                if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
                {
                    FicheroTarjeta.escribirFichero(tarjetaCredit);
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    cargarControles(false, false, true);
                    MessageBox.Show("Se han actualizado los datos.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (BDTarjetaCredito.actualizarTarjetaCredito(tarjetaCredit))
                    {
                        btnAceptar.Enabled = false;
                        btnCancelar.Enabled = false;
                        cargarControles(false, false, true);
                        MessageBox.Show("Se han actualizado los datos.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarControles(false, true, false);
            cargarDatosTarjetaCredito();
            cargarBotones(false, false, true);
        }

        private void CtrlTarjeta_Load(object sender, EventArgs e)
        {
            cargarDatosTarjetaCredito();
        }

        private void cargarDatosTarjetaCredito()
        {
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                obtenerTarjetaInvitado();
            }
            else
            {
                obtenerTarjetaUsuario();
            }
        }

        private void obtenerTarjetaUsuario()
        {
            tarjetaCredit = BDTarjetaCredito.consultarTarjetaCredito(ConfigSesion.obtenerReferenciaIdUsuario());

            if (tarjetaCredit != null)
            {
                ctrlTxtTitular.Texto = tarjetaCredit.titular;
                ctrlTxtNTarjeta.Texto = tarjetaCredit.numerosTarjeta;
                ctrlTxtMesVen.Texto = tarjetaCredit.mesVencimiento;
                ctrlAnioVen.Texto = tarjetaCredit.anioVencimiento;
                ctrlCVV.Texto = tarjetaCredit.cvv;
                btnEliminar.Visible = true;
            }
            else
            {
                ctrlTxtTitular.Texto = "";
                ctrlTxtNTarjeta.Texto = "";
                ctrlTxtMesVen.Texto = "";
                ctrlAnioVen.Texto = "";
                ctrlCVV.Texto = "";
            }
        }

        private void obtenerTarjetaInvitado()
        {
            tarjetaCredit = FicheroTarjeta.leerFichero();

            if (tarjetaCredit != null)
            {
                ctrlTxtTitular.Texto = tarjetaCredit.titular;
                ctrlTxtNTarjeta.Texto = tarjetaCredit.numerosTarjeta;
                ctrlTxtMesVen.Texto = tarjetaCredit.mesVencimiento;
                ctrlAnioVen.Texto = tarjetaCredit.anioVencimiento;
                ctrlCVV.Texto = tarjetaCredit.cvv;
                btnEliminar.Visible = true;
            }
            else
            {
                ctrlTxtTitular.Texto = "";
                ctrlTxtNTarjeta.Texto = "";
                ctrlTxtMesVen.Texto = "";
                ctrlAnioVen.Texto = "";
                ctrlCVV.Texto = "";
            }
        }

        private TarjetaCredit crearTarjetaCredito()
        {
            TarjetaCredit tarjetaCredit = null;
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                tarjetaCredit = new TarjetaCredit(ctrlTxtTitular.Texto, ctrlTxtNTarjeta.Texto, ctrlTxtMesVen.Texto, ctrlAnioVen.Texto, ctrlCVV.Texto);
            }
            else
            {
                tarjetaCredit = new TarjetaCredit(ConfigSesion.obtenerReferenciaIdUsuario(), ctrlTxtTitular.Texto, ctrlTxtNTarjeta.Texto, ctrlTxtMesVen.Texto, ctrlAnioVen.Texto, ctrlCVV.Texto);
            }
            return tarjetaCredit;
        }

        private void cargarBotones(bool aceptar, bool cancelar, bool editar)
        {
            btnAceptar.Visible = aceptar;
            btnCancelar.Visible = cancelar;
            btnEditar.Visible = editar;
            if (tarjetaCredit == null)
            {
                btnEliminar.Visible = false;
            }
            else
            {
                btnEliminar.Visible = true;
            }
        }
        private void cargarControles(bool editar, bool cancelar, bool aceptar)
        {
            if (editar)
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
            if (cancelar)
            {
                ctrlTxtTitular.IsReadOnly = true;
                ctrlTxtNTarjeta.IsReadOnly = true;
                ctrlTxtMesVen.IsReadOnly = true;
                ctrlAnioVen.IsReadOnly = true;
                ctrlCVV.IsReadOnly = true;

                lblTitular.Text = string.Format("Titular:", lblTitular.Text);
                lblNTarjeta.Text = string.Format("NºTarjeta:", lblNTarjeta.Text);
                lblMesVen.Text = string.Format("Mes vencimiento:", lblMesVen.Text);
                lblAnioVen.Text = string.Format("Año vencimiento:", lblAnioVen.Text);
                lblCVV.Text = string.Format("CVV:", lblCVV.Text);
            }
            if (aceptar)
            {
                ctrlTxtTitular.Enabled = false;
                ctrlTxtNTarjeta.Enabled = false;
                ctrlTxtMesVen.Enabled = false;
                ctrlAnioVen.Enabled = false;
                ctrlCVV.Enabled = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idReferenciaUsuario = ConfigSesion.obtenerReferenciaIdUsuario();
            if (idReferenciaUsuario != 0)
            {
                if (BDTarjetaCredito.eliminarTarjetaCredito(idReferenciaUsuario))
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
}
