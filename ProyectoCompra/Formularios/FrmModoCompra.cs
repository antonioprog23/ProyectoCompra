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
    public partial class FrmModoCompra : Form
    {
        public FrmModoCompra()
        {
            InitializeComponent();
        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            FrmAccesoPago frmAccesoPago = new FrmAccesoPago();
            frmAccesoPago.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmInicioSesion frmInicioSesion = new frmInicioSesion();
            frmInicioSesion.ShowDialog();
        }
    }
}
