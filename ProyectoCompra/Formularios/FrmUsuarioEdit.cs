using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
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
            if (txtCorreo.Text.Equals("") && (ctrlContrasenia.TextBoxtxtContrasenia.Equals("") && txtRepContrasenia.Text.Equals("")))
            {
                MessageBox.Show("Al menos rellena un campo de los posibles a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            actualizarContrasenia();
            actualizarCorreoElectronico();

        }

        private void actualizarContrasenia()
        {
            if (!ctrlContrasenia.TextBoxtxtContrasenia.Equals("") && !txtRepContrasenia.Text.Equals(""))
            {
                if (!ctrlContrasenia.TextBoxtxtContrasenia.Equals(txtRepContrasenia.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlContrasenia.TextBoxtxtContrasenia = "";
                    txtRepContrasenia.Text = "";
                    return;
                }
                string codigoVerificacion = Mensaje.enviarMensajeUnDestinatario(usuarioModificar.cliente.correo);
                if (!codigoVerificacion.Equals("-1"))
                {
                    FrmVerificarCuenta frmVerificarCuenta = new FrmVerificarCuenta(codigoVerificacion, ctrlContrasenia.TextBoxtxtContrasenia, true, "Contrasenia", txtUsuario.Text);
                    frmVerificarCuenta.ShowDialog();
                }
            }
        }

        private void actualizarCorreoElectronico()
        {
            if (!txtCorreo.Text.Equals(""))
            {
                if (BDUsuario.consultarUsuarioCorreoElectronico(txtCorreo.Text) != 0)
                {
                    MessageBox.Show("El correo electrónico proporcionado está en uso.");
                    return;
                }
                string codigoVerificacion = Mensaje.enviarMensajeUnDestinatario(txtCorreo.Text);
                if (!codigoVerificacion.Equals("-1"))
                {
                    FrmVerificarCuenta frmVerificarCuenta = new FrmVerificarCuenta(codigoVerificacion, txtCorreo.Text, true, "Correo Electronico", txtUsuario.Text);
                    frmVerificarCuenta.ShowDialog();
                }
            }
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
