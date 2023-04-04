using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmBase : Form
    {
        private Usuario usuarioRecuperado;
        private Carrito carrito;
        private List<Carrito> lista;

        public FrmBase()
        {
            InitializeComponent();
            carrito = new Carrito();
            lista = carrito.GetLista();
            lblContador.Text = lista.Count.ToString();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            //USUARO 
            Usuario usuarioFichero = FicheroAuxiliar.leerFichero();
            if (usuarioFichero != null)
            {
                usuarioRecuperado = BDUsuario.obtenerDatos("", "", usuarioFichero.idUsuario.ToString());
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

        private void button37_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito();
            frmCarrito.ShowDialog();
        }

        public Label GetLabelContador()
        {
            return this.lblContador;
        }

        private void lblContador_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
