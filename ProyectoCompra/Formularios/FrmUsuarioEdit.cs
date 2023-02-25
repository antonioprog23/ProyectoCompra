using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Linq;
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

        }

        private void cargarDatosAEditar()
        {
            txtNombre.Text = usuarioModificar.cliente.nombre;
            txtApellido.Text = usuarioModificar.cliente.apellido;
            txtEdad.Text = usuarioModificar.cliente.edad.ToString();
            cbxSexo.Text = usuarioModificar.cliente.sexo;
            dateFNacimiento.Value = Convert.ToDateTime(usuarioModificar.cliente.fechaNacimiento);
            txtDireccion.Text = usuarioModificar.cliente.direccion.ToString();
            txtCorreo.Text = usuarioModificar.cliente.correo.ToString();
            txtUsuario.Text = usuarioModificar.username.ToString();
        }

        private void deshabilitarDatosCliente()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            cbxSexo.Enabled = false;
            dateFNacimiento.Enabled = false;
            txtDireccion.Enabled = false;
        }

        #endregion
    }
}
