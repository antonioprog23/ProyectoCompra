using ProyectoCompra.Base_datos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmBajaUsuario : Form
    {
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
                if (!txtCodigo.Text.Equals(""))
                {
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
            }
            else
            {
                if (!txtContrasenia.Text.Equals(txtRepContrasenia.Text))
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContrasenia.Clear();
                    txtRepContrasenia.Clear();
                }
                else
                {
                    if (BDUsuario.darBajaUsuario(txtUsuario.Text, txtContrasenia.Text, ""))
                    {
                        MessageBox.Show("Has sido dado de baja exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
        }

        private void configurarBajaConCorreoElectronico()
        {
            if (txtCorreoElectronico.Text.Equals("") || txtCodigo.Text.Equals(""))
            {
                MessageBox.Show("Los datos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

            }
        }

        private void txtCorreoElectronico_TextChanged(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text.Equals(""))
            {
                txtCodigo.Enabled = false;
                lblCodigo.ForeColor = Color.Gray;
            }
            else
            {
                txtCodigo.Enabled = true;
                lblCodigo.ForeColor = Color.Gray;
            }
        }
    }
}
