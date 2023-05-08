using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmVerificarCuenta : Form
    {
        private Usuario usuario;
        private string usuarioName;
        private Cliente cliente;
        private string codigoVerificacion;
        private string correoElectronico;
        private string valorCampoMoficiar;
        private bool editar;
        private string campo;

        public FrmVerificarCuenta(Cliente cliente, Usuario usuario, string codigoVerificacion, string correoElectronico)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.usuario = usuario;
            this.codigoVerificacion = codigoVerificacion;
            this.correoElectronico = correoElectronico;
        }

        public FrmVerificarCuenta(string codigoVerificacion, string valorCampoMoficiar, bool editar, string campo, string usuarioName)
        {
            InitializeComponent();
            this.codigoVerificacion = codigoVerificacion;
            this.valorCampoMoficiar = valorCampoMoficiar;
            this.editar = editar;
            this.usuarioName = usuarioName;
            this.campo = campo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            editarUsuario();
            if (!txtCodigoVerificacion.Text.Equals(codigoVerificacion))
            {
                var resultado = MessageBox.Show("El código no coincide.\n¿Deseas volver a recibir el código?", "Error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado is DialogResult.Yes)
                {
                    txtCodigoVerificacion.Clear();
                    this.codigoVerificacion = Mensaje.enviarMensajeUnDestinatario(correoElectronico);
                }
                return;
            }

            if ((BDUsuario.insertarDatos(cliente, usuario)))
            {
                MessageBox.Show("Usuario creado.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                frmInicioSesion frmInicioSesion = new frmInicioSesion();
                frmInicioSesion.ShowDialog();
            }
        }

        private void editarUsuario()
        {
            if (editar)
            {
                switch (campo)
                {
                    case "Correo Electronico":
                        if (BDUsuario.actualiarDatos(usuarioName, "", valorCampoMoficiar))
                        {
                            MessageBox.Show("Los datos se han actualizado correctamente.", "Afirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Restart();
                        }
                        break;
                    case "Contrasenia":
                        if (BDUsuario.actualiarDatos(usuarioName, valorCampoMoficiar, ""))
                        {
                            MessageBox.Show("Los datos se han actualizado correctamente.", "Afirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Application.Restart();
                        }
                        break;
                }
                return;
            }
        }
    }
}
