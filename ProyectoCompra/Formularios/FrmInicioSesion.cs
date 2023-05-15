using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class frmInicioSesion : Form
    {
        private Usuario usuarioEncontrado;

        public frmInicioSesion()
        {
            InitializeComponent();
        }

        #region Eventos

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Equals("") && !contrasenia.TextBoxtxtContrasenia.Equals(""))
            {
                usuarioEncontrado = BDUsuario.obtenerDatos(txtUsuario.Text.Trim(), contrasenia.TextBoxtxtContrasenia.Trim(), "");
                if (usuarioEncontrado == null)
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
                else
                {
                    MessageBox.Show("Bienvenido");
                    ConfigSesion.guardarReferenciaIdUsuario(usuarioEncontrado.idUsuario);
                    Application.Restart();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = crearCliente();
            Usuario usuario = crearUsuario();
            if (cliente == null || usuario == null)
            {
                lblAlerta.Visible = true;
                return;
            }
            if (Regex.IsMatch(txtCorreo.Text, "^[a-zA-Z0-9]$"))
            {
                MessageBox.Show("El correo proporcionado no tiene formato de correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cliente = null;
                usuario = null;
                txtCorreo.Clear();
                return;
            }
            int codigoUsuarioConNombreUsado = BDUsuario.consultarUsuarioName(textUsuario.Text.Trim());
            if (codigoUsuarioConNombreUsado != 0)
            {
                textUsuario.Clear();
                MessageBox.Show("El nombre de usuario ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int codigoUsuarioConCorreoUsado = BDUsuario.consultarUsuarioCorreoElectronico(txtCorreo.Text.Trim());
            if (codigoUsuarioConCorreoUsado != 0)
            {
                txtCorreo.Clear();
                MessageBox.Show("El correo proporcionado ya está en uso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoVerificacion = Mensaje.enviarMensajeCodigoVerificacionUnDestinatario(txtCorreo.Text.Trim());
            if (!codigoVerificacion.Equals("-1"))
            {
                FrmVerificarCuenta frmVerificarCuenta = new FrmVerificarCuenta(cliente, usuario, codigoVerificacion, txtCorreo.Text.Trim());
                frmVerificarCuenta.ShowDialog();
            }
            else
            {
                txtCorreo.Clear();
            }
        }

        private Cliente crearCliente()
        {
            Cliente cliente = null;
            if (!txtNombre.Texto.Equals("") && !txtApellido.Texto.Equals("") && !txtEdad.Text.Equals("") && !dateFNacimiento.Value.Equals("") && !txtCorreo.Text.Equals(""))
            {
                cliente = new Cliente(txtNombre.Texto.Trim(), txtApellido.Texto.Trim(), int.Parse(txtEdad.Text.Trim()), dateFNacimiento.Value + "", cbxSexo.SelectedItem.ToString(), txtCorreo.Text.Trim());
            }
            return cliente;
        }

        private Usuario crearUsuario()
        {
            Usuario usuario = null;
            if (!textUsuario.Text.Equals("") && !txtContrasena.Text.Equals("") && !txtRepContrasenia.Text.Equals(""))
            {
                if (txtContrasena.Text.Equals(txtRepContrasenia.Text))
                {
                    usuario = new Usuario(textUsuario.Text.Trim(), txtContrasena.Text.Trim());
                }
                else
                {
                    MessageBox.Show("¡Las contraseñas no coinciden!");
                    txtContrasena.Clear();
                    txtRepContrasenia.Clear();
                }
            }
            return usuario;
        }

        private void btnAlerta_MouseEnter(object sender, EventArgs e)
        {
            lblAlerta.Visible = true;
        }

        private void btnAlerta_MouseLeave(object sender, EventArgs e)
        {
            lblAlerta.Visible = false;
        }

        private void btnRecuperarContrasenia_Click(object sender, EventArgs e)
        {
            FrmRecuperarContrasenia frmRecuperarContrasenia = new FrmRecuperarContrasenia();
            frmRecuperarContrasenia.ShowDialog();
        }

        private void btnRecuperarContrasenia_MouseEnter(object sender, EventArgs e)
        {
            btnRecuperarContrasenia.ForeColor = Color.Black;
        }

        private void btnRecuperarContrasenia_MouseLeave(object sender, EventArgs e)
        {
            btnRecuperarContrasenia.ForeColor = Color.DimGray;
        }

        private void dateFNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaNacimiento = dateFNacimiento.Value;
            txtEdad.Text = ((int)((DateTime.Now - fechaNacimiento).TotalDays / 365.25)).ToString();
        }
    }
}
