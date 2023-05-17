using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using ProyectoCompra.Formularios;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlDireccion : UserControl
    {
        public Direccion direccion { get; set; }
        public bool agregarDireccion { get; set; }
        public string groupBox { get => gbxDireccionDefecto.Text; set { gbxDireccionDefecto.Text = value; } }
        private FrmDireccion frmDireccion;

        public CtrlDireccion()
        {
            InitializeComponent();
        }

        public CtrlDireccion(Direccion direccion)
        {
            InitializeComponent();
            this.direccion = direccion;
        }

        public CtrlDireccion(bool agregarDireccion, bool isEleccion)
        {
            InitializeComponent();
            this.agregarDireccion = agregarDireccion;
        }

        private void CtrlDireccion_Load(object sender, EventArgs e)
        {
            recuperarDireccion();
            cargarControlesText(true, true, false, false, true, true, true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
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

        private void recuperarDireccion()
        {
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
            if (direccion != null)
            {
                direccion.nombre = txtNomDireccion.Text;
                direccion.direccion = txtDireccion.Text;
                direccion.pais = cbxPais.SelectedItem.ToString();
                direccion.provincia = cbxProvincia.SelectedItem.ToString();
                direccion.ciudad = ctrlTxtCiudad.Texto;
                direccion.codigoPostal = ctrlTxtCP.Texto;
                direccion.telefono = ctrlTxtTelefono.Texto;
                if (BDDireccion.actualizarDireccion(direccion, obtenerIdUsuario()))
                {
                    MessageBox.Show("Los datos han sido actualizados.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarBotones(false, false, true);
                    cargarControlesText(true, true, false, false, true, true, true);
                }
            }
            if (agregarDireccion)
            {
                Direccion direccion = new Direccion(txtNomDireccion.Text, txtDireccion.Text, cbxPais.SelectedItem.ToString(), cbxProvincia.SelectedItem.ToString(), ctrlTxtCiudad.Texto, ctrlTxtCP.Texto, ctrlTxtTelefono.Texto);
                if (direccion != null)
                {
                    if (BDDireccion.actualizarDireccion(direccion, obtenerIdUsuario()))
                    {
                        cargarBotones(false, false, true);
                        cargarControlesText(true, true, false, false, true, true, true);
                    }
                }
            }
        }

        private int obtenerIdUsuario()
        {
            int idUsuario = 0;
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationElement element = config.AppSettings.Settings["idUsuario"];
                if (element != null)
                {
                    idUsuario = Convert.ToInt32(element.Value);
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }
            return idUsuario;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            cargarControlesText(false, false, true, true, false, false, false);
            cargarBotones(true, true, false);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (BDDireccion.eliminarDireccion(direccion))
            {
                MessageBox.Show("Se ha eliminado una dirección.Vuelva abrir la ventana para actualizar los cambios.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarBotones(false, false, false);
                cargarControlesText(true, true, false, false, true, true, true);
            }
        }

        public void setBotonBorrarDireccion(bool visible)
        {
            this.btnBorrar.Visible = visible;
        }
    }
}
