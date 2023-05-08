using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmRecuperarContrasenia : Form
    {
        public FrmRecuperarContrasenia()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text.Equals(""))
            {
                MessageBox.Show("El campo es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Usuario usuario = BDUsuario.obtenerDatos("", "", BDUsuario.consultarUsuarioCorreoElectronico(txtCorreo.Text).ToString());
            if (usuario == null)
            {
                MessageBox.Show("El correo propocionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Mensaje.enviarMensajeContraseniaUnDestinatario(txtCorreo.Text, usuario.username);
            this.Close();
        }
    }
}
