using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
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
        public FrmMain formPadre { get; set; }
        public Form formActual { get; set; }
        public FrmProductos formProductos { get; set; }
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

        public void recuperarProductosInvitado()
        {
            List<CarritoProvisional> productos = FicheroCarrito.leerFichero();
            Carrito carrito = null;
            Usuario usuario = new Usuario(ConfigSesion.obtenerReferenciaIdUsuario());
            foreach (CarritoProvisional producto in productos)
            {
                carrito = new Carrito(Convert.ToInt32(producto.cantidad), producto.producto);
                carrito.insertarProducto(usuario, carrito, true);
            }
            FicheroCarrito.borrarFicheroAux();
        }
        #endregion

        #region Eventos
        private void btnIdentificarse_Click(object sender, EventArgs e)
        {
            frmInicioSesion inicioSesion = new frmInicioSesion();
            inicioSesion.ShowDialog();
            if (inicioSesion.isLogIn)
            {
                this.configurarFrmBase();
                this.formPadre.configurarFrmBase();
                recuperarProductosInvitado();
                this.aumentarContador();
                this.formPadre.aumentarContador();
            }
        }



        private void btnPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil(usuarioRecuperado, this);
            frmPerfil.ShowDialog();
            if (frmPerfil.isLogOut)
            {
                this.usuarioRecuperado = null;
                this.formPadre.usuarioRecuperado = null;
                this.configurarFrmBase();
                this.formPadre.configurarFrmBase();
                this.aumentarContador();
                this.formPadre.aumentarContador();
            }
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
            if (this.formActual != null && !(this.formActual is FrmMain))
            {
                ConfigVentanaNav.ConfigVentanaNav.deleteFormSecond();
            }
        }
        #endregion

        #region Menu
        private void lacteosmn_Click(object sender, EventArgs e)
        {

            formProductos = new FrmProductos(1, 1, this.formPadre);
            formProductos.ShowDialog();
        }

        private void aceitesVinagresYSalsasmn_Click(object sender, EventArgs e)
        {

            formProductos = new FrmProductos(1, 2, this.formPadre);
            formProductos.ShowDialog();
        }

        private void desayunomn_Click(object sender, EventArgs e)
        {

            formProductos = new FrmProductos(1, 3, this.formPadre);
            formProductos.ShowDialog();
        }

        private void conservasmn_Click(object sender, EventArgs e)
        {

            formProductos = new FrmProductos(1, 4, this.formPadre);
            formProductos.ShowDialog();
        }

        private void comiadsInternacionalesmn_Click(object sender, EventArgs e)
        {

            formProductos = new FrmProductos(1, 5, this.formPadre);
            formProductos.ShowDialog();
        }

        private void nutriciónDeportivamn_Click(object sender, EventArgs e)
        {

            formProductos = new FrmProductos(1, 6, this.formPadre);
            formProductos.ShowDialog();
        }

        private void frutasmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(2, 7, this.formPadre);
            formProductos.ShowDialog();
        }
        private void quesosmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(2, 8, this.formPadre);
            formProductos.ShowDialog();
        }
        private void mnsCarne_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(2, 9, this.formPadre);
            formProductos.ShowDialog();
        }

        private void charcuteriamn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(2, 10, this.formPadre);
            formProductos.ShowDialog();
        }

        private void pescadosMariscosYMoluscosmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(2, 11, this.formPadre);
            formProductos.ShowDialog();
        }

        private void sushimn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(2, 12, this.formPadre);
            formProductos.ShowDialog();
        }

        private void congeladosmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(3, 13, this.formPadre);
            formProductos.ShowDialog();
        }

        private void postresmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(3, 14, this.formPadre);
            formProductos.ShowDialog();
        }

        private void pastelesmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(3, 15, this.formPadre);
            formProductos.ShowDialog();
        }

        private void mantequillasmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(3, 16, this.formPadre);
            formProductos.ShowDialog();
        }

        private void platosmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(3, 17, this.formPadre);
            formProductos.ShowDialog();
        }

        private void masasmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(3, 18, this.formPadre);
            formProductos.ShowDialog();
        }
        private void zumosmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(4, 19, this.formPadre);
            formProductos.ShowDialog();
        }

        private void sodamn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(4, 20, this.formPadre);
            formProductos.ShowDialog();
        }
        private void bebidasConAlcoholmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(4, 21, this.formPadre);
            formProductos.ShowDialog();
        }

        private void champagnemn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(4, 22, this.formPadre);
            formProductos.ShowDialog();
        }

        private void bebidasEcologicasmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(4, 23, this.formPadre);
            formProductos.ShowDialog();
        }

        private void bebidasSinAlcoholmn_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(4, 24, this.formPadre);
            formProductos.ShowDialog();
        }
        private void lavadoDeRopaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(5, 25, this.formPadre);
            formProductos.ShowDialog();
        }

        private void limpiezaDeHogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(5, 26, this.formPadre);
            formProductos.ShowDialog();
        }

        private void lavavajillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(5, 27, this.formPadre);
            formProductos.ShowDialog();
        }

        private void lejíasYAmoníacosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(5, 28, this.formPadre);
            formProductos.ShowDialog();
        }

        private void insecticidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(5, 29, this.formPadre);
            formProductos.ShowDialog();
        }

        private void limpiezaCalzadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(5, 30, this.formPadre);
            formProductos.ShowDialog();
        }
        private void perfumeríaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(6, 31, this.formPadre);
            formProductos.ShowDialog();
        }

        private void higieneBucalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(6, 32, this.formPadre);
            formProductos.ShowDialog();
        }

        private void botiquínToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(6, 33, this.formPadre);
            formProductos.ShowDialog();
        }

        private void cuidadoFacialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(6, 34, this.formPadre);
            formProductos.ShowDialog();
        }

        private void cuidadoCabelloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(6, 35, this.formPadre);
            formProductos.ShowDialog();
        }

        private void lociónSolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(6, 36, this.formPadre);
            formProductos.ShowDialog();
        }
        private void lavadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(7, 37, this.formPadre);
            formProductos.ShowDialog();
        }

        private void frigoríficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(7, 38, this.formPadre);
            formProductos.ShowDialog();
        }

        private void secadorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(7, 39, this.formPadre);
            formProductos.ShowDialog();
        }

        private void hornoPlacasYCampanasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(7, 40, this.formPadre);
            formProductos.ShowDialog();
        }

        private void cafeterasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(7, 41, this.formPadre);
            formProductos.ShowDialog();
        }

        private void climatizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(7, 42, this.formPadre);
            formProductos.ShowDialog();
        }

        private void televisoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(8, 43, this.formPadre);
            formProductos.ShowDialog();
        }

        private void telefoníaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(8, 44, this.formPadre);
            formProductos.ShowDialog();
        }

        private void fotografíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(8, 45, this.formPadre);
            formProductos.ShowDialog();
        }

        private void informáticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(8, 46, this.formPadre);
            formProductos.ShowDialog();
        }

        private void tabletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(8, 47, this.formPadre);
            formProductos.ShowDialog();
        }

        private void audioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(8, 48, this.formPadre);
            formProductos.ShowDialog();
        }

        private void jardínYAireLibreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(9, 49, this.formPadre);
            formProductos.ShowDialog();
        }

        private void bricolajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(9, 50, this.formPadre);
            formProductos.ShowDialog();
        }

        private void mascotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(9, 51, this.formPadre);
            formProductos.ShowDialog();
        }

        private void casaYDecoraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(9, 52, this.formPadre);
            formProductos.ShowDialog();
        }

        private void textilHogarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formProductos = new FrmProductos(9, 53, this.formPadre);
            formProductos.ShowDialog();
        }

        #endregion
    }
}
