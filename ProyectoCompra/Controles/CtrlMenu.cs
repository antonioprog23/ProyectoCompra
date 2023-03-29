using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using ProyectoCompra.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlMenu : UserControl
    {
        private Usuario usuarioRecuperado;

        public CtrlMenu()
        {
            InitializeComponent();
        }

        private void CtrlMenu_Load(object sender, EventArgs e)
        {
            Usuario usuarioFichero = FicheroAuxiliar.leerFichero();
            if (usuarioFichero != null)
            {
                usuarioRecuperado = BDCliente.obtenerDatos("", "", usuarioFichero.idUsuario.ToString());
            }

            if (usuarioRecuperado == null)
            {
                btnIdentificarse.Visible = true;
                btnPerfil.Visible = false;
            }
            else
            {
                btnIdentificarse.Visible = false;
                btnPerfil.Visible = true;
                lblSaludo.Visible = true;
                lblSaludo.Text += string.Format("{0}.", usuarioRecuperado.cliente.nombre.ToString());
            }
        }

        private void btnIdentificarse_Click(object sender, EventArgs e)
        {
            frmInicioSesion inicioSesion = new frmInicioSesion();
            inicioSesion.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil(usuarioRecuperado);
            frmPerfil.ShowDialog();
        }

        private void lblContador_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
        }
    }
}
