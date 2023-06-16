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
        private bool editar;
        private string correoActual;
        private string nuevaContrasenia;
        private string nuevoCorreoElectronico;
        public bool isVerificado { get; set; }

        public FrmVerificarCuenta(Cliente cliente, Usuario usuario, string codigoVerificacion, string correoElectronico)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.usuario = usuario;
            this.isVerificado = false;
            this.codigoVerificacion = codigoVerificacion;
            this.correoElectronico = correoElectronico;
        }

        public FrmVerificarCuenta(string codigoVerificacion, string nuevaContrasenia, string nuevoCorreoElectronico, string correoActual, bool editar, string usuarioName)
        {
            InitializeComponent();
            this.codigoVerificacion = codigoVerificacion;
            this.correoActual = correoActual;
            this.editar = editar;
            this.usuarioName = usuarioName;
            this.nuevaContrasenia = nuevaContrasenia;
            this.nuevoCorreoElectronico = nuevoCorreoElectronico;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!txtCodigoVerificacion.Text.Equals(codigoVerificacion))
            {
                var resultado = MessageBox.Show("El código no coincide.\n¿Deseas volver a recibir el código?", "Error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado is DialogResult.Yes)
                {
                    txtCodigoVerificacion.Clear();
                    if (editar)
                    {
                        this.codigoVerificacion = Mensaje.enviarMensajeCodigoVerificacionUnDestinatario(correoActual);
                    }
                    else
                    {
                        this.codigoVerificacion = Mensaje.enviarMensajeCodigoVerificacionUnDestinatario(correoElectronico);
                    }
                }
                return;
            }
            if (editar)
            {
                if (BDUsuario.actualiarDatos(usuarioName, nuevaContrasenia, nuevoCorreoElectronico))
                {
                    MessageBox.Show("Los datos se han actualizado correctamente.", "Afirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                return;
            }
            if ((BDUsuario.insertarDatos(cliente, usuario)))
            {
                MessageBox.Show("Usuario creado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.isVerificado = true;
                this.Close();
            }
        }
    }
}
