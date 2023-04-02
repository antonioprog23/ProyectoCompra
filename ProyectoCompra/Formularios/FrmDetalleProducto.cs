using ProyectoCompra.Clases;
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
    public partial class FrmDetalleProducto : Form
    {
        private Image Image;
        private Producto producto;

        public FrmDetalleProducto(Image image)
        {
            InitializeComponent();
            this.Image = image;
            this.producto = producto;
        }

        private void FrmDetalleProducto_Load(object sender, EventArgs e)
        {
            lblImagen.Image = Image;
        }
    }
}
