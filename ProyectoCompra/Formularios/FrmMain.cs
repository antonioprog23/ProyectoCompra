using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 1);
            frmProductos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 2);
            frmProductos.ShowDialog();
        }

        private void btnDesayunoMer_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 3);
            frmProductos.ShowDialog();
        }

        private void btnConserva_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 4);
            frmProductos.ShowDialog();
        }

        private void btnComidaInternacional_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 5);
            frmProductos.ShowDialog();
        }

        private void btnNutricionDep_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(1, 6);
            frmProductos.ShowDialog();
        }

        private void btnVerdurasHortalizas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 1);
            frmProductos.ShowDialog();
        }

        private void btnQuesos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 2);
            frmProductos.ShowDialog();
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 3);
            frmProductos.ShowDialog();
        }

        private void btnCharcuteria_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 4);
            frmProductos.ShowDialog();
        }

        private void btnPescados_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 5);
            frmProductos.ShowDialog();
        }

        private void btnSushi_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 6);
            frmProductos.ShowDialog();
        }

        private void btnCongelados_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 1);
            frmProductos.ShowDialog();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 2);
            frmProductos.ShowDialog();
        }

        private void btnPasteles_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 3);
            frmProductos.ShowDialog();
        }

        private void btnMantequillas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 4);
            frmProductos.ShowDialog();
        }

        private void btnPlatosListos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 5);
            frmProductos.ShowDialog();
        }

        private void btnPastas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 6);
            frmProductos.ShowDialog();
        }

        private void btnZumos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 1);
            frmProductos.ShowDialog();
        }

        private void btnAguaSoda_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 2);
            frmProductos.ShowDialog();
        }

        private void btnBebidaAlcohol_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 3);
            frmProductos.ShowDialog();
        }

        private void btnCavaSidra_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 4);
            frmProductos.ShowDialog();
        }

        private void btnBebidaEcologica_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 5);
            frmProductos.ShowDialog();
        }

        private void btnSinAlcohol_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 6);
            frmProductos.ShowDialog();
        }

        private void btnLavadoRopa_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 1);
            frmProductos.ShowDialog();
        }

        private void btnLimpiezaHogar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 2);
            frmProductos.ShowDialog();
        }

        private void btnLavavajillas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 3);
            frmProductos.ShowDialog();
        }

        private void btnLejiasAmoniacos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 4);
            frmProductos.ShowDialog();
        }

        private void btnInsecticidas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 5);
            frmProductos.ShowDialog();
        }

        private void btnLimpiezaCalzado_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 6);
            frmProductos.ShowDialog();
        }

        private void btnPerfumeria_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 1);
            frmProductos.ShowDialog();
        }

        private void btnBucal_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 2);
            frmProductos.ShowDialog();
        }

        private void btnBotiquin_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 3);
            frmProductos.ShowDialog();
        }

        private void btnCuidadoFacial_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 4);
            frmProductos.ShowDialog();
        }

        private void btnCuidadoCabello_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 5);
            frmProductos.ShowDialog();
        }

        private void btnLocionSolar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 6);
            frmProductos.ShowDialog();
        }

        private void btnLavadora_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 1);
            frmProductos.ShowDialog();
        }

        private void btnFrigorificos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 2);
            frmProductos.ShowDialog();
        }

        private void btnSecadora_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 3);
            frmProductos.ShowDialog();
        }

        private void btnHornoPlaca_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 4);
            frmProductos.ShowDialog();
        }

        private void btnCafeteras_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 5);
            frmProductos.ShowDialog();
        }

        private void btnClimatizacion_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 6);
            frmProductos.ShowDialog();
        }

        private void btnTelevisores_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 1);
            frmProductos.ShowDialog();
        }

        private void btnTelefonia_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 2);
            frmProductos.ShowDialog();
        }

        private void btnFotografia_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 3);
            frmProductos.ShowDialog();
        }

        private void btnInformatica_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 4);
            frmProductos.ShowDialog();
        }

        private void btnTablets_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 5);
            frmProductos.ShowDialog();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 6);
            frmProductos.ShowDialog();
        }

        private void btnJardin_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 1);
            frmProductos.ShowDialog();
        }

        private void btnBricolaje_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 2);
            frmProductos.ShowDialog();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 3);
            frmProductos.ShowDialog();
        }

        private void btnCasaDecoracion_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 4);
            frmProductos.ShowDialog();
        }

        private void btnTextilHogar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 5);
            frmProductos.ShowDialog();
        }
    }
}
