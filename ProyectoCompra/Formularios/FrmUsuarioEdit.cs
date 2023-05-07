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
            if (!txtCorreo.Texto.Equals("") || (!ctrlContrasenia.TextBoxtxtContrasenia.Equals("") && !txtRepContrasenia.Text.Equals("")))
            {
                if (ctrlContrasenia.TextBoxtxtContrasenia.Equals(txtRepContrasenia.Text))
                {
                    if (BDUsuario.actualiarDatos(txtUsuario.Texto, "", "", ctrlContrasenia.TextBoxtxtContrasenia))
                    {
                        MessageBox.Show("Los datos se han actualizado correctamente.", "Afirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlContrasenia.TextBoxtxtContrasenia = "";
                    txtRepContrasenia.Text = "";
                    return;
                }
                if (BDUsuario.actualiarDatos(txtUsuario.Texto,txtCorreo.Texto, ""))
                {
                    MessageBox.Show("Los datos se han actualizado correctamente.", "Afirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Restart();
                }
            }
            else
            {
                MessageBox.Show("Al menos rellena un campo de los posibles a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cargarDatosAEditar()
        {
            txtNombre.Texto = usuarioModificar.cliente.nombre;
            txtApellido.Texto = usuarioModificar.cliente.apellido;
            txtEdad.Texto = usuarioModificar.cliente.edad.ToString();
            cbxSexo.Text = usuarioModificar.cliente.sexo;
            dateFNacimiento.Value = Convert.ToDateTime(usuarioModificar.cliente.fechaNacimiento);
            txtUsuario.Texto = usuarioModificar.username.ToString();
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
