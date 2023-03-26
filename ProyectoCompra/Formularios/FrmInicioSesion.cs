using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using ProyectoCompra.Ficheros;
using System;
using System.Drawing;
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

        private void btnCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarioEdit frmCrearUsuario = new FrmUsuarioEdit();
            frmCrearUsuario.ShowDialog();
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!txtUsuario.Text.Equals("") && !contrasenia.TextBoxtxtContrasenia.Equals(""))
            {
                usuarioEncontrado = BDCliente.obtenerDatos(txtUsuario.Text, contrasenia.TextBoxtxtContrasenia);
                if (usuarioEncontrado == null)
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
                else
                {
                    MessageBox.Show("Bienvenido");
                    FrmMain main = new FrmMain(usuarioEncontrado);
                    Application.Restart();
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente cliente = crearCliente();
            Usuario usuario = crearUsuario();
            if (cliente != null && usuario != null)
            {
                int codigoUsuarioConNombreUsado = BDCliente.consultarUsuarioName(textUsuario.Text);
                if (codigoUsuarioConNombreUsado == -1)
                {
                    if ((BDCliente.insertarDatos(cliente, usuario)))
                    {
                        MessageBox.Show("Usuario creado.");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("¡El nombre de usuario ya existe!");
                }
            }
            else
            {
                lblAlerta.Visible = true;
            }
        }

        private Cliente crearCliente()
        {
            Cliente cliente = null;
            if (!txtNombre.Text.Equals("") && !txtApellido.Text.Equals("") && !txtEdad.Text.Equals("") && !dateFNacimiento.Value.Equals("") && !txtDireccion.Text.Equals("") && !txtCorreo.Text.Equals(""))
            {
                cliente = new Cliente(txtNombre.Text, txtApellido.Text, int.Parse(txtEdad.Text), dateFNacimiento.Value + "", cbxSexo.SelectedItem.ToString(), txtDireccion.Text, txtCorreo.Text);
            }
            return cliente;
        }

        private Usuario crearUsuario()
        {
            Usuario usuario = null;
            if (!textUsuario.Text.Equals("") && !txtContrasena.Text.Equals("") && !txtRepContrasenia.Text.Equals(""))
            {
                usuario = new Usuario(textUsuario.Text, txtContrasena.Text);
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

        private void txtEdad_TextChanged_1(object sender, EventArgs e)
        {
            int numero = 0;
            if (txtEdad.Text.Length > 0)
            {
                if (int.TryParse(txtEdad.Text, out numero))
                {
                    txtEdad.Text = Convert.ToString(numero);
                }
                else
                {
                    txtEdad.Text = "";
                }
            }
        }
    }
}
