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
        public FrmDireccion()
        {
            InitializeComponent();
        }

        private void btnAniadirDireccion_Click(object sender, EventArgs e)
        {
            CtrlDireccion ctrlDireccion = new CtrlDireccion();
            ctrlDireccion.Location = new Point(330, 12);
            ctrlDireccion.groupBox = "Dirección (alternativo)";
            this.Controls.Add(ctrlDireccion);
            this.Size = new Size(668,331);
        }
    }
}
