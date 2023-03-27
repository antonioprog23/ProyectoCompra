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
            bool actualizado = BDCliente.actualiarDatos(txtUsuario.Texto, txtDireccion.Texto, txtCorreo.Texto, ctrlContrasenia.TextBoxtxtContrasenia);
            if (actualizado)
            {
                MessageBox.Show("¡Los datos se han actualizado correctamente!");
                Close();
            }
        }

        private void cargarDatosAEditar()
        {
            txtNombre.Texto = usuarioModificar.cliente.nombre;
            txtApellido.Texto = usuarioModificar.cliente.apellido;
            txtEdad.Texto = usuarioModificar.cliente.edad.ToString();
            cbxSexo.Text = usuarioModificar.cliente.sexo;
            dateFNacimiento.Value = Convert.ToDateTime(usuarioModificar.cliente.fechaNacimiento);
            //txtDireccion.Texto = usuarioModificar.cliente.direccion.ToString();
            //txtCorreo.Texto = usuarioModificar.cliente.correo.ToString();
            txtUsuario.Texto = usuarioModificar.username.ToString();
        }

        private void deshabilitarDatosCliente()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEdad.Enabled = false;
            cbxSexo.Enabled = false;
            dateFNacimiento.Enabled = false;
            //txtDireccion.Enabled = false;
            txtUsuario.Enabled = false;
        }

        #endregion
    }
}
