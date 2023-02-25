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
            // (Image.FromFile("C:\\Users\\anton\\Downloads\\idioma_castellano.png"));
            //cbxIdiomas.Items.Add(new { Icon = Image.FromFile("C:\\Users\\anton\\Downloads\\idioma_castellano.png") });
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
            Usuario usuario = null;
            if (!txtUsuario.Text.Equals("") && !contrasenia.TextBoxtxtContrasenia.Equals(""))
            {
                usuario = new Usuario(txtUsuario.Text);
                int idUsuario = BDUsuario.comprobarUsuarioExiste(usuario);
                if (idUsuario == 0)
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
                else
                {
                    MessageBox.Show("Bienvenido");
                    usuarioEncontrado = new Usuario(idUsuario);
                    //FicheroAuxiliar.escribirFichero(usuarioEncontrado);
                    //BDCliente.obtenerUltimoAcceso(idUsuario);
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
                if (BDCliente.insertarDatos(cliente, usuario))
                {
                    MessageBox.Show("Usuario creado.");
                    Close();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
