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
                    lblCodigo.ForeColor = Color.Gray;
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
                    if (BDUsuario.consultarUsuarioName(txtUsuario.Text, "") != -1)
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
                    else
                    {
                        MessageBox.Show("No existe ese usuario en el sistema.\nPor favor, vuelva a intentarlo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsuario.Clear();
                        txtContrasenia.Clear();
                        txtRepContrasenia.Clear();
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
                if (BDUsuario.darBajaUsuario("", "", txtCorreoElectronico.Text))
                {
                    MessageBox.Show("Has sido dado de baja exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCorreoElectronico.Text.Equals(""))
            {
                MessageBox.Show("Los datos son obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (BDUsuario.consultarUsuarioName("", txtCorreoElectronico.Text) != -1)
                {
                    codigo = Mensaje.enviarMensajeUnDestinatario(txtCorreoElectronico.Text);
                    if (!codigo.Equals(""))
                    {
                        MessageBox.Show("Compruebe su correo electrónico. Tendrá un código, por favor, introduzcalo en su campo correspondiente.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigo.Enabled = true;
                        lblCodigo.ForeColor = Color.Black;
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un problema. Por favor, verifique los datos introducidos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
