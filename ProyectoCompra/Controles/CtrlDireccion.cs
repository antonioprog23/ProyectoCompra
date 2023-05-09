using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
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

        private void CtrlDireccion_Load(object sender, EventArgs e)
        {
            recuperarDireccion();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarControlesText(false, false, true, true, false, false, false);
            cargarLabelObligatorio(true);
            cargarBotones(true, true, false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarLabelObligatorio(false);
            cargarBotones(false, false, true);
            cargarControlesText(true, true, false, false, true, true, true);
        }

        private void cargarBotones(bool cancelar, bool aceptar, bool editar)
        {
            btnCancelar.Visible = cancelar;
            btnAceptar.Visible = aceptar;
            btnEditar.Visible = editar;
        }

        private void cargarControlesText(bool nombre, bool direccion, bool pais, bool provincia, bool ciudad, bool cp, bool telefono)
        {
            txtNomDireccion.ReadOnly = nombre;
            txtDireccion.ReadOnly = direccion;
            cbxPais.Enabled = pais;
            cbxProvincia.Enabled = provincia;
            ctrlTxtCiudad.IsReadOnly = ciudad;
            ctrlTxtCP.IsReadOnly = cp;
            ctrlTxtTelefono.IsReadOnly = telefono;
        }

        private void cargarLabelObligatorio(bool obligatorio)
        {
            /*
            if (obligatorio)
            {
                lblNomDireccion.Text = string.Format("* {0}", lblNomDireccion.Text);
                lblDireccion.Text = string.Format("* {0}", lblDireccion.Text);
                lblPais.Text = string.Format("* {0}", lblPais.Text);
                lblProvincia.Text = string.Format("* {0}", lblProvincia.Text);
                lblCiudad.Text = string.Format("* {0}", lblCiudad.Text);
                lblCP.Text = string.Format("* {0}", lblCP.Text);
                lblTelefono.Text = string.Format("* {0}", lblTelefono.Text);
            }
            else
            {
                lblNomDireccion.Text = string.Format("{0}", lblNomDireccion.Text);
                lblDireccion.Text = string.Format("{0}", lblDireccion.Text);
                lblPais.Text = string.Format("{0}", lblPais.Text);
                lblProvincia.Text = string.Format("{0}", lblProvincia.Text);
                lblCiudad.Text = string.Format("{0}", lblCiudad.Text);
                lblCP.Text = string.Format("{0}", lblCP.Text);
                lblTelefono.Text = string.Format("{0}", lblTelefono.Text);
            }
            */
        }

        private void recuperarDireccion()
        {
            Direccion direccion = BDDireccion.consusltarDireccion(FicheroAuxiliar.leerFichero().idUsuario);
            if (direccion != null)
            {
                txtNomDireccion.Text = direccion.nombre;
                txtDireccion.Text = direccion.direccion;
                cbxPais.Text = direccion.pais;
                cbxProvincia.Text = direccion.provincia;

                ctrlTxtCiudad.Texto = direccion.ciudad;
                ctrlTxtCP.Texto = direccion.codigoPostal;
                ctrlTxtTelefono.Texto = direccion.telefono;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNomDireccion.Text.Equals("") || txtDireccion.Text.Equals("") || cbxPais.SelectedItem == null || cbxProvincia.SelectedItem == null || ctrlTxtCiudad.Texto.Equals("") || ctrlTxtCP.Texto.Equals("") || ctrlTxtTelefono.Texto.Equals(""))
            {
                MessageBox.Show("Los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Direccion direccion = new Direccion(txtNomDireccion.Text, txtDireccion.Text, cbxPais.SelectedItem.ToString(), cbxProvincia.SelectedItem.ToString(), ctrlTxtCiudad.Texto, ctrlTxtCP.Texto, ctrlTxtTelefono.Texto);
            if (BDDireccion.actualizarDireccion(direccion, FicheroAuxiliar.leerFichero().idUsuario))
            {
                MessageBox.Show("Los datos han sido actualizados.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
