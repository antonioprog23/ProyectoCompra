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
            FrmProductos frmProductos = new FrmProductos(2, 7);
            frmProductos.ShowDialog();
        }

        private void btnQuesos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 8);
            frmProductos.ShowDialog();
        }

        private void btnCarne_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 9);
            frmProductos.ShowDialog();
        }

        private void btnCharcuteria_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 10);
            frmProductos.ShowDialog();
        }

        private void btnPescados_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 11);
            frmProductos.ShowDialog();
        }

        private void btnSushi_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(2, 12);
            frmProductos.ShowDialog();
        }

        private void btnCongelados_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 13);
            frmProductos.ShowDialog();
        }

        private void btnPostres_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 14);
            frmProductos.ShowDialog();
        }

        private void btnPasteles_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 15);
            frmProductos.ShowDialog();
        }

        private void btnMantequillas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 16);
            frmProductos.ShowDialog();
        }

        private void btnPlatosListos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 17);
            frmProductos.ShowDialog();
        }

        private void btnPastas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(3, 18);
            frmProductos.ShowDialog();
        }

        private void btnZumos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 19);
            frmProductos.ShowDialog();
        }

        private void btnAguaSoda_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 20);
            frmProductos.ShowDialog();
        }

        private void btnBebidaAlcohol_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 21);
            frmProductos.ShowDialog();
        }

        private void btnCavaSidra_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 22);
            frmProductos.ShowDialog();
        }

        private void btnBebidaEcologica_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 23);
            frmProductos.ShowDialog();
        }

        private void btnSinAlcohol_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(4, 24);
            frmProductos.ShowDialog();
        }

        private void btnLavadoRopa_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 25);
            frmProductos.ShowDialog();
        }

        private void btnLimpiezaHogar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 26);
            frmProductos.ShowDialog();
        }

        private void btnLavavajillas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 27);
            frmProductos.ShowDialog();
        }

        private void btnLejiasAmoniacos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 28);
            frmProductos.ShowDialog();
        }

        private void btnInsecticidas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 29);
            frmProductos.ShowDialog();
        }

        private void btnLimpiezaCalzado_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(5, 30);
            frmProductos.ShowDialog();
        }

        private void btnPerfumeria_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 31);
            frmProductos.ShowDialog();
        }

        private void btnBucal_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 32);
            frmProductos.ShowDialog();
        }

        private void btnBotiquin_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 33);
            frmProductos.ShowDialog();
        }

        private void btnCuidadoFacial_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 34);
            frmProductos.ShowDialog();
        }

        private void btnCuidadoCabello_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 35);
            frmProductos.ShowDialog();
        }

        private void btnLocionSolar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(6, 36);
            frmProductos.ShowDialog();
        }

        private void btnLavadora_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 37);
            frmProductos.ShowDialog();
        }

        private void btnFrigorificos_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 38);
            frmProductos.ShowDialog();
        }

        private void btnSecadora_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 39);
            frmProductos.ShowDialog();
        }

        private void btnHornoPlaca_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 40);
            frmProductos.ShowDialog();
        }

        private void btnCafeteras_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 41);
            frmProductos.ShowDialog();
        }

        private void btnClimatizacion_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(7, 42);
            frmProductos.ShowDialog();
        }

        private void btnTelevisores_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 43);
            frmProductos.ShowDialog();
        }

        private void btnTelefonia_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 44);
            frmProductos.ShowDialog();
        }

        private void btnFotografia_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 45);
            frmProductos.ShowDialog();
        }

        private void btnInformatica_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 46);
            frmProductos.ShowDialog();
        }

        private void btnTablets_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 47);
            frmProductos.ShowDialog();
        }

        private void btnAudio_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(8, 48);
            frmProductos.ShowDialog();
        }

        private void btnJardin_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 49);
            frmProductos.ShowDialog();
        }

        private void btnBricolaje_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 50);
            frmProductos.ShowDialog();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 51);
            frmProductos.ShowDialog();
        }

        private void btnCasaDecoracion_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 52);
            frmProductos.ShowDialog();
        }

        private void btnTextilHogar_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(9, 53);
            frmProductos.ShowDialog();
        }
    }
}
