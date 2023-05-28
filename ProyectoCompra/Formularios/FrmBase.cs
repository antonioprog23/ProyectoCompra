using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmBase : Form
    {
        public Usuario usuarioRecuperado;
        public List<Carrito> productos;

        public FrmBase()
        {
            InitializeComponent();
        }

        public FrmBase(Form formPadre, Form formActual)
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            int idReferenciaUsuariao = ConfigSesion.obtenerReferenciaIdUsuario();
            if (idReferenciaUsuariao != 0)
            {
                usuarioRecuperado = BDUsuario.obtenerDatos("", "", idReferenciaUsuariao.ToString());
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
            }
            aumentarContador();
        }

        public void aumentarContador()
        {
            productos = BDCarrito.consultarCarrito(ConfigSesion.obtenerReferenciaIdUsuario());
            lblContador.Text = productos.Count.ToString();
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

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
        }

        private void btnPerfil_MouseEnter(object sender, EventArgs e)
        {
            btnPerfil.Font = new Font(btnPerfil.Font, FontStyle.Underline);
        }

        private void btnPerfil_MouseLeave(object sender, EventArgs e)
        {
            btnPerfil.Font = new Font(btnPerfil.Font, FontStyle.Regular);
        }

        private void btnIdentificarse_MouseLeave(object sender, EventArgs e)
        {
            btnIdentificarse.Font = new Font(btnIdentificarse.Font, FontStyle.Regular);
        }

        private void btnIdentificarse_MouseEnter(object sender, EventArgs e)
        {
            btnIdentificarse.Font = new Font(btnIdentificarse.Font, FontStyle.Underline);
        }

        private void btnCarrito_MouseLeave(object sender, EventArgs e)
        {
            btnCarrito.Font = new Font(btnCarrito.Font, FontStyle.Regular);
        }

        private void btnCarrito_MouseEnter(object sender, EventArgs e)
        {
            btnCarrito.Font = new Font(btnCarrito.Font, FontStyle.Underline);
        }

        private void btnLogoMain_Click(object sender, EventArgs e)
        {

        }
    }
}
