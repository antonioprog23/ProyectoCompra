using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmUsuarioEdit : Form
    {
        private Usuario usuarioModificar;
        public FrmUsuarioEdit()
        {
            InitializeComponent();
        }

        public FrmUsuarioEdit(Usuario usuario)
        {
            InitializeComponent();
            usuarioModificar = usuario;
        }
        #region Eventos

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCrearUsuario_Load(object sender, EventArgs e)
        {
            cargarDatosAEditar();
            deshabilitarDatosCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorreo.Text) && (string.IsNullOrEmpty(ctrlContrasenia.TextBoxtxtContrasenia) && string.IsNullOrEmpty(txtRepContrasenia.Text)))
            {
                MessageBox.Show("Al menos rellena un campo de los posibles a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(string.IsNullOrEmpty(ctrlContrasenia.TextBoxtxtContrasenia) && string.IsNullOrEmpty(txtRepContrasenia.Text)) && !string.IsNullOrEmpty(txtCorreo.Text))
            {
                if (!comprobarCorreoElectronico() || !comprobarContrasenia())
                {
                    return;
                }
            }
            if (!comprobarContrasenia() && string.IsNullOrEmpty(txtCorreo.Text))
            {
                return;
            }
            if (!comprobarCorreoElectronico() && (string.IsNullOrEmpty(ctrlContrasenia.TextBoxtxtContrasenia) && string.IsNullOrEmpty(txtRepContrasenia.Text)))
            {
                return;
            }
            string codigoVerificacion = Mensaje.enviarMensajeCodigoVerificacionUnDestinatario(usuarioModificar.cliente.correo);
            if (!codigoVerificacion.Equals("-1"))
            {
                FrmVerificarCuenta frmVerificarCuenta = new FrmVerificarCuenta(codigoVerificacion, ctrlContrasenia.TextBoxtxtContrasenia, txtCorreo.Text, usuarioModificar.cliente.correo, true, txtUsuario.Text);
                frmVerificarCuenta.ShowDialog();
            }
        }

        private bool comprobarContrasenia()
        {
            bool isValido = false;
            if (!(string.IsNullOrEmpty(ctrlContrasenia.TextBoxtxtContrasenia) && string.IsNullOrEmpty(txtRepContrasenia.Text)))
            {

                if (!ctrlContrasenia.TextBoxtxtContrasenia.Equals(txtRepContrasenia.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlContrasenia.TextBoxtxtContrasenia = "";
                    txtRepContrasenia.Text = "";
                }
                else
                {
                    isValido = true;
                }
            }
            return isValido;
        }

        private bool comprobarCorreoElectronico()
        {
            bool isValido = false;
            if (!string.IsNullOrEmpty(txtCorreo.Text))
            {
                try
                {
                    MailAddress mail = new MailAddress(txtCorreo.Text);
                    if (BDUsuario.consultarUsuarioCorreoElectronico(txtCorreo.Text) != 0)
                    {
                        MessageBox.Show("El correo electrónico proporcionado está en uso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        isValido = true;
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValido = false;
                }
            }
            return isValido;
        }

        private void cargarDatosAEditar()
        {
            txtNombre.Texto = usuarioModificar.cliente.nombre;
            txtApellido.Texto = usuarioModificar.cliente.apellido;
            txtEdad.Texto = usuarioModificar.cliente.edad.ToString();
            cbxSexo.Text = usuarioModificar.cliente.sexo;
            dateFNacimiento.Value = Convert.ToDateTime(usuarioModificar.cliente.fechaNacimiento);
            txtUsuario.Text = usuarioModificar.username.ToString();
        }

        private void deshabilitarDatosCliente()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            cbxSexo.Enabled = false;
            dateFNacimiento.Enabled = false;
            txtUsuario.Enabled = false;
        }

        #endregion

    }
}
