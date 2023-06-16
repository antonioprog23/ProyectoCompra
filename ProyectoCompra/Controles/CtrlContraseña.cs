using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class ctrlContrasenia : UserControl
    {
        public ctrlContrasenia()
        {
            InitializeComponent();
        }

        private void btnMostrarPass_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.UseSystemPasswordChar)
            {
                btnMostrarPass.Image = Properties.Resources.mostrar_contrasenia;
                txtContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                btnMostrarPass.Image = Properties.Resources.ocultar_contrasenia;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        public string TextBoxtxtContrasenia { get { return txtContrasenia.Text; } set { txtContrasenia.Text = value; } }
    }
}
