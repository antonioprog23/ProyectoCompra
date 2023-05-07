using ProyectoCompra.Controles;
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
    public partial class FrmDireccion : Form
    {
        private CtrlDireccion ctrlDireccion;
        public FrmDireccion()
        {
            InitializeComponent();
        }

        private void btnAniadirDireccion_Click(object sender, EventArgs e)
        {
            ctrlDireccion = new CtrlDireccion();
            ctrlDireccion.Location = new Point(330, 12);
            ctrlDireccion.groupBox = "Dirección (alternativo)";
            this.Controls.Add(ctrlDireccion);
            this.Size = new Size(668, 361);

            btnAceptar.Location = new Point(484, 286);
            btnCancelar.Location = new Point(565, 286);
            btnAniadirDireccion.Visible = false;
            btnAceptar.Visible = true;
            btnCancelar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(ctrlDireccion);
            this.Size = new Size(350, 361);
            btnAniadirDireccion.Visible = true;
            btnAceptar.Visible = false;
            btnCancelar.Visible = false;
        }
    }
}
