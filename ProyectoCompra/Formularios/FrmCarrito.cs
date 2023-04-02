using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmCarrito : Form
    {
        public FrmCarrito()
        {
            InitializeComponent();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            FrmModoCompra frmModoCompra = new FrmModoCompra();
            frmModoCompra.ShowDialog();
        }

        private void FrmCarrito_Load(object sender, EventArgs e)
        {
            List<Carrito> productos = FicheroCarrito.leerFichero();
            tbProductos.RowCount = productos.Count;
            for (int i = 0; i <= tbProductos.RowCount; i++)
            {
                CtrlProductoCarrito producto = new CtrlProductoCarrito();
                tbProductos.Controls.Add(producto);
            }
        }
    }
}
