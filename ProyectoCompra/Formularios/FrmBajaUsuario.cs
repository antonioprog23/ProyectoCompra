using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmBajaUsuario : Form
    {
        private string codigo;

        public FrmBajaUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbnUsuario.Checked)
            {
                configurarBajaConUsuario();
            }
            else
            {
                configurarBajaConCorreoElectronico();
            }
        }

        private void rbnUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnUsuario.Enabled)
            {
                gbxUsuario.Enabled = true;
                gbxCorreoElectronico.Enabled = false;
                if (!txtCorreoElectronico.Text.Equals(""))
                {
                    txtCorreoElectronico.Clear();
                }
                if (!txtCodigo.Text.Equals("") || txtCodigo.Text.Equals(""))
                {
                    codigo = "";
                    txtCodigo.Enabled = false;
                    lblCodigo.Enabled = false;
                    txtCodigo.Clear();
                }
            }
        }

        private void rbnCorreoElectronico_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnUsuario.Enabled)
            {
                gbxUsuario.Enabled = false;
                gbxCorreoElectronico.Enabled = true;
                if (!txtUsuario.Text.Equals(""))
                {
                    txtUsuario.Clear();
                }
                if (!txtContrasenia.Text.Equals(""))
                {
                    txtContrasenia.Clear();
                }
                if (!txtRepContrasenia.Text.Equals(""))
                {
                    txtRepContrasenia.Clear();
                }
            }
        }

        private void btnAyuda_MouseEnter(object sender, EventArgs e)
        {
            btnAyuda.Text = "Elige una opción para darte de baja.";
        }

        private void btnAyuda_MouseLeave(object sender, EventArgs e)
        {
            btnAyuda.Text = "";
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (txtContrasenia.Text.Equals(""))
            {
                txtRepContrasenia.Enabled = false;
                lblRepContrasenia.ForeColor = Color.Gray;
            }
            else
            {
                txtRepContrasenia.Enabled = true;
                lblRepContrasenia.ForeColor = Color.Black;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void configurarBajaConUsuario()
        {
            if (txtUsuario.Text.Equals("") || txtContrasenia.Text.Equals("") || txtRepContrasenia.Text.Equals(""))
            {
                MessageBox.Show("Los datos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!txtContrasenia.Text.Equals(txtRepContrasenia.Text.Trim()))
            {
                MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasenia.Clear();
                txtRepContrasenia.Clear();
                return;
            }
            if (BDUsuario.consultarUsuarioName(txtUsuario.Text.Trim()) == 0)
            {
                MessageBox.Show("No existe ese usuario en el sistema.\nPor favor, vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Clear();
                txtContrasenia.Clear();
                txtRepContrasenia.Clear();
                return;
            }

            var resultado = MessageBox.Show("¿Estás seguro de darte de baja?", "Baja del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (BDUsuario.darBajaUsuarioPorUsuario(txtUsuario.Text.Trim(), txtContrasenia.Text.Trim()))
                {
                    MessageBox.Show("Has sido dado de baja exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                txtUsuario.Clear();
                txtContrasenia.Clear();
                txtRepContrasenia.Clear();
            }
        }


        private void configurarBajaConCorreoElectronico()
        {
            if (txtCorreoElectronico.Text.Equals("") || txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Los datos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!txtCodigo.Text.Trim().Equals(codigo))
            {
                MessageBox.Show("El código no coincide, por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var resultado = MessageBox.Show("¿Estás seguro de darte de baja?", "Baja del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (BDUsuario.darBajaUsuarioPorCorreoElectronico(txtCorreoElectronico.Text.Trim()))
                {
                    MessageBox.Show("Has sido dado de baja exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
            else
            {
                txtCorreoElectronico.Clear();
                txtCodigo.Clear();
                txtCodigo.Enabled = false;
                lblCodigo.Enabled = false;
                btnEnviar.Visible = true;
                btnReenviarCodigo.Visible = false;
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (BDUsuario.consultarUsuarioCorreoElectronico(txtCorreoElectronico.Text.Trim()) == 0)
            {
                MessageBox.Show("No existe ningún usuario con el correo proporcionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            codigo = Mensaje.enviarMensajeCodigoVerificacionUnDestinatario(txtCorreoElectronico.Text.Trim());
            if (!codigo.Equals("-1"))
            {
                txtCodigo.Enabled = true;
                lblCodigo.Enabled = true;
                btnEnviar.Visible = false;
                btnReenviarCodigo.Visible = true;
            }
        }

        private void btnReenviarCodigo_Click(object sender, EventArgs e)
        {
            codigo = Mensaje.enviarMensajeCodigoVerificacionUnDestinatario(txtCorreoElectronico.Text.Trim());
            txtCodigo.Enabled = true;
            lblCodigo.Enabled = true;
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text.Equals(""))
            {
                txtCodigo.Enabled = false;
                lblCodigo.Enabled = false;
            }
        }
    }
}
