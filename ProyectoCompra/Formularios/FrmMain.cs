using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmMain : Form
    {
        private Usuario usuarioRecuperado;

        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioRecuperado = usuario;
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

        private void button37_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (usuarioRecuperado == null)
            {
                btnIdentificarse.Visible = true;
                btnPerfil.Visible = false;
            }
            else
            {
                btnIdentificarse.Visible = false;
                btnPerfil.Visible = true;
            }
        }
    }
}
