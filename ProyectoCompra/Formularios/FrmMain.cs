using ProyectoCompra.Clases;
using System;

namespace ProyectoCompra.Formularios
{
    public partial class FrmMain : FrmBase
    {
        public Usuario usuarioEncontrado { get; set; }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 1, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 2, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnDesayunoMer_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 3, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnConserva_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 4, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnComidaInternacional_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 5, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnNutricionDep_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 6, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnVerdurasHortalizas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 7, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnQuesos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 8, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 9, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCharcuteria_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 10, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnPescados_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 11, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnSushi_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 12, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCongelados_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 13, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 14, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnPasteles_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 15, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnMantequillas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 16, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnPlatosListos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 17, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnPastas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 18, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnZumos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 19, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnAguaSoda_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 20, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnBebidaAlcohol_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 21, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCavaSidra_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 22, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnBebidaEcologica_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 23, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnSinAlcohol_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 24, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnLavadoRopa_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 25, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnLimpiezaHogar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 26, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnLavavajillas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 27, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnLejiasAmoniacos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 28, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnInsecticidas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 29, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnLimpiezaCalzado_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 30, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnPerfumeria_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 31, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnBucal_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 32, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnBotiquin_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 33, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCuidadoFacial_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 34, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCuidadoCabello_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 35, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnLocionSolar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 36, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnLavadora_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 37, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnFrigorificos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 38, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnSecadora_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 39, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnHornoPlaca_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 40, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCafeteras_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 41, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnClimatizacion_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 42, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnTelevisores_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 43, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnTelefonia_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 44, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnFotografia_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 45, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnInformatica_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 46, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnTablets_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 47, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 48, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnJardin_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 49, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnBricolaje_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 50, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 51, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnCasaDecoracion_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 52, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }

        private void btnTextilHogar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 53, this);
            frmProductos.ShowDialog();
            aumentarContador();
        }
    }
}
