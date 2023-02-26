using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmPerfil : Form
    {
        private Usuario usuarioRecuperado;
        public FrmPerfil()
        {
            InitializeComponent();
        }

        public FrmPerfil(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioRecuperado = usuario;
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            //Usuario usuario = FicheroAuxiliar.leerFichero();
            if (usuarioRecuperado != null)
            {
                //usuarioRecuperado = BDCliente.obtenerDatos(usuario.idUsuario);
                    lblMostrarId.Text = usuarioRecuperado.idUsuario.ToString();
                    lblMostrarUsuario.Text = usuarioRecuperado.username.ToString();
                    txtMostrarContrasenia.Text = usuarioRecuperado.password.ToString();
                    lblMostrarFAlta.Text = usuarioRecuperado.fechaAlta;
                    lblMostrarNombre.Text = usuarioRecuperado.cliente.nombre.ToString();
                    lblMostrarApellido.Text = usuarioRecuperado.cliente.apellido.ToString();
                    lblMostrarEdad.Text = usuarioRecuperado.cliente.edad.ToString();
                    lblMostrarFNacimiento.Text = usuarioRecuperado.cliente.fechaNacimiento;
                    lblMostrarSexo.Text = usuarioRecuperado.cliente.sexo.ToString();
                    lblMostrarCorreo.Text = usuarioRecuperado.cliente.correo.ToString();
                    lblMostrarDireccion.Text = usuarioRecuperado.cliente.direccion.ToString();
                    txtMostrarContrasenia.Text = usuarioRecuperado.password.ToString();
                    lblMostrarUltimoAcceso.Text = usuarioRecuperado.fechaAlta.ToString();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            FicheroAuxiliar.borrarFicheroAux();
            Application.Restart();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmUsuarioEdit frmCrearUsuario = new FrmUsuarioEdit(usuarioRecuperado);
            frmCrearUsuario.ShowDialog();
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {

        }
    }
}

