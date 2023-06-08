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
        #region Fields
        private Usuario usuarioEncontrado;
        public bool isLogIn { get; set; }
        #endregion

        #region Constructor
        public frmInicioSesion()
        {
            InitializeComponent();

            this.isLogIn = false;
        }
        #endregion

        #region Eventos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text.Trim()) && string.IsNullOrEmpty(contrasenia.TextBoxtxtContrasenia.Trim()))
            {
                MessageBox.Show("Los datos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            usuarioEncontrado = BDUsuario.obtenerDatos(txtUsuario.Text.Trim(), contrasenia.TextBoxtxtContrasenia.Trim(), "");
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario no encontrado.");
                return;
            }
            ConfigSesion.guardarReferenciaIdUsuario(usuarioEncontrado.idUsuario);
            this.isLogIn = true;
            MessageBox.Show("Bienvenido", "Inicio sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
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
                if (frmVerificarCuenta.isVerificado)
                {
                    configuracionInicial();
                }
            }
            else
            {
                txtCorreo.Clear();
            }
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
        #endregion

        #region Métodos privados
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
                    usuario = new Usuario(textUsuario.Text.Trim(), txtContrasena.Text.Trim(), 0);
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

        public void configuracionInicial()
        {
            txtNombre.Texto = "";
            txtApellido.Texto = "";
            dateFNacimiento.Value = DateTime.Now;
            txtEdad.Text = "";
            cbxSexo.SelectedItem = -1;
            textUsuario.Text = "";
            txtCorreo.Text = "";
            txtContrasena.Text = "";
            txtRepContrasenia.Text = "";
            this.tabControl.SelectedIndex = 0;
        }
        #endregion
    }
}
