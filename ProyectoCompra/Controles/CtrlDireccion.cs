using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlDireccion : UserControl
    {
        public string groupBox { get => gbxDireccionDefecto.Text; set { gbxDireccionDefecto.Text = value; } }

        public CtrlDireccion()
        {
            InitializeComponent();
        }
    }
}
