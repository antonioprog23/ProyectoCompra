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
            FrmProductos frmProductos = new FrmProductos(sender, 1, 1);
            frmProductos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos(sender, 1, 2);
            frmProductos.ShowDialog();
        }
    }
}
