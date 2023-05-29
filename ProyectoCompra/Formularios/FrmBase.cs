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
        #region Fields

        public Usuario usuarioRecuperado;
        public List<Carrito> productos;
        List<CarritoProvisional> provisional;
        public Form formPadre { get; set; }
        public Form formActual { get; set; }

        #endregion

        #region Constructores
        public FrmBase()
        {
            InitializeComponent();
        }

        #endregion

        private void FrmBase_Load(object sender, EventArgs e)
        {
            configurarFrmBase();
            aumentarContador();
        }

        #region Métodos públicos

        public void configurarFrmBase()
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
            }
        }

        public void aumentarContador()
        {
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                provisional = CarritoProvisional.consultarCarritoProvisional();
                if (provisional.Count >= 0)
                {
                    lblContador.Text = provisional.Count.ToString();
                }
            }
            else
            {
                productos = BDCarrito.consultarCarrito(ConfigSesion.obtenerReferenciaIdUsuario());
                if (productos.Count >= 0)
                {
                    lblContador.Text = productos.Count.ToString();
                }
            }
        }

        #endregion

        #region Eventos
        private void btnIdentificarse_Click(object sender, EventArgs e)
        {
            frmInicioSesion inicioSesion = new frmInicioSesion(this);
            inicioSesion.ShowDialog();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil(usuarioRecuperado, this);
            frmPerfil.ShowDialog();
        }

        private void btnCarrito_Click(object sender, EventArgs e)
        {
            FrmCarrito frmCarrito = new FrmCarrito(this);
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
            if ((this.formPadre is FrmMain) && this.formPadre != null)
            {
                this.formPadre.Visible = true;
                this.formActual.Visible = false;
            }
        }

        private void FrmBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Menu
        private void lacteosmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 1, this);
            frmProductos.ShowDialog();
        }

        private void aceitesVinagresYSalsasmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 2, this);
            frmProductos.ShowDialog();
        }

        private void desayunomn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 3, this);
            frmProductos.ShowDialog();
        }

        private void conservasmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 4, this);
            frmProductos.ShowDialog();
        }

        private void comiadsInternacionalesmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 5, this);
            frmProductos.ShowDialog();
        }

        private void nutriciónDeportivamn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 6, this);
            frmProductos.ShowDialog();
        }

        private void frutasmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 7, this);
            frmProductos.ShowDialog();
        }
        private void quesosmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 8, this);
            frmProductos.ShowDialog();
        }
        private void mnsCarne_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 9, this);
            frmProductos.ShowDialog();
        }

        private void charcuteriamn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 10, this);
            frmProductos.ShowDialog();
        }

        private void pescadosMariscosYMoluscosmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 11, this);
            frmProductos.ShowDialog();
        }

        private void sushimn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 12, this);
            frmProductos.ShowDialog();
        }

        private void congeladosmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 13, this);
            frmProductos.ShowDialog();
        }

        private void postresmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 14, this);
            frmProductos.ShowDialog();
        }

        private void pastelesmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 15, this);
            frmProductos.ShowDialog();
        }

        private void mantequillasmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 16, this);
            frmProductos.ShowDialog();
        }

        private void platosmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 17, this);
            frmProductos.ShowDialog();
        }

        private void masasmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 18, this);
            frmProductos.ShowDialog();
        }
        private void zumosmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 19, this);
            frmProductos.ShowDialog();
        }

        private void sodamn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 20, this);
            frmProductos.ShowDialog();
        }
        private void bebidasConAlcoholmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 21, this);
            frmProductos.ShowDialog();
        }

        private void champagnemn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 22, this);
            frmProductos.ShowDialog();
        }

        private void bebidasEcologicasmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 23, this);
            frmProductos.ShowDialog();
        }

        private void bebidasSinAlcoholmn_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 24, this);
            frmProductos.ShowDialog();
        }
        #endregion

    }
}
