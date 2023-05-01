﻿using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmVerificarCuenta : Form
    {
        private Usuario usuario;
        private Cliente cliente;
        private string codigoVerificacion;
        private string correoElectronico;

        public FrmVerificarCuenta(Cliente cliente, Usuario usuario, string codigoVerificacion, string correoElectronico)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.usuario = usuario;
            this.codigoVerificacion = codigoVerificacion;
            this.correoElectronico = correoElectronico;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ctrlTextoCodigo.Texto.Equals(codigoVerificacion))
            {
                if ((BDUsuario.insertarDatos(cliente, usuario)))
                {
                    MessageBox.Show("Usuario creado.", "Información.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmInicioSesion frmInicioSesion = new frmInicioSesion();
                    frmInicioSesion.ShowDialog();
                }
            }
            else
            {
                var resultado = MessageBox.Show("El código no coincide.\n¿Deseas volver a recibir el código?", "Error.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado is DialogResult.OK)
                {
                    this.codigoVerificacion = Mensaje.enviarMensajeUnDestinatario(correoElectronico);
                }
            }
        }
    }
}
