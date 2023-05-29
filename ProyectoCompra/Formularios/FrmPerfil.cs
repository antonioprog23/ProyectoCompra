using ProyectoCompra.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmPerfil : Form
    {
        private Usuario usuarioRecuperado;
        public FrmBase frmBase { get; set; }

        public FrmPerfil()
        {
            InitializeComponent();
        }

        public FrmPerfil(Usuario usuario, FrmBase frmBase)
        {
            InitializeComponent();
            this.usuarioRecuperado = usuario;
            this.frmBase = frmBase;
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            if (usuarioRecuperado != null)
            {
                lblMostrarId.Text = usuarioRecuperado.idUsuario.ToString("D16").ToUpper();
                lblMostrarUsuario.Text = usuarioRecuperado.username.ToString().ToUpper(); ;
                ctrlMostrarContrasenia.TextBoxtxtContrasenia = usuarioRecuperado.password.ToString().ToUpper(); ;
                lblMostrarFAlta.Text = usuarioRecuperado.fechaAlta;
                lblMostrarNombre.Text = usuarioRecuperado.cliente.nombre.ToString().ToUpper();
                lblMostrarApellido.Text = usuarioRecuperado.cliente.apellido.ToString().ToUpper();
                lblMostrarEdad.Text = usuarioRecuperado.cliente.edad.ToString().ToUpper();
                lblMostrarFNacimiento.Text = usuarioRecuperado.cliente.fechaNacimiento.ToUpper();
                lblMostrarSexo.Text = usuarioRecuperado.cliente.sexo.ToString().ToUpper();
                lblMostrarCorreo.Text = usuarioRecuperado.cliente.correo.ToString().ToUpper();
                lblMostrarUltimaModificacion.Text = usuarioRecuperado.fechaUltimaModificacion.ToString().ToUpper();
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            ConfigSesion.borrarReferenciaIdUsuario();
            this.frmBase.usuarioRecuperado = null;
            this.frmBase.aumentarContador();
            this.frmBase.configurarFrmBase();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmUsuarioEdit frmCrearUsuario = new FrmUsuarioEdit(usuarioRecuperado);
            frmCrearUsuario.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOtrasOpciones_Click(object sender, EventArgs e)
        {
            FrmOtrasOpciones frmOtrasOpciones = new FrmOtrasOpciones(this.frmBase);
            frmOtrasOpciones.ShowDialog();
        }
    }
}

