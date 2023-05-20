using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using ProyectoCompra.Formularios;
using System;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlDireccion : UserControl
    {
        public Direccion direccion { get; set; }
        public bool agregarDireccion { get; set; }
        public string groupBox { get => gbxDireccionDefecto.Text; set { gbxDireccionDefecto.Text = value; } }
        private FrmDireccion frmDireccion;
        public bool isInvitado { get; set; }

        public CtrlDireccion()
        {
            InitializeComponent();
        }

        public CtrlDireccion(bool agregarDireccion)
        {
            InitializeComponent();
            this.agregarDireccion = agregarDireccion;
        }

        private void CtrlDireccion_Load(object sender, EventArgs e)
        {
            if (isInvitado)
            {
                lblNomDireccion.Text = "Nombre persona:";
            }
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
            btnEditar.Enabled = editar;
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
                if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
                {
                    txtNomDireccion.Text = direccion.nombre;
                    txtDireccion.Text = direccion.direccion;
                    cbxPais.Text = direccion.pais;
                    cbxProvincia.Text = direccion.provincia;

                    ctrlTxtCiudad.Texto = direccion.ciudad;
                    ctrlTxtCP.Texto = direccion.codigoPostal;
                    ctrlTxtTelefono.Texto = direccion.telefono;
                }
                else
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
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNomDireccion.Text.Equals("") || txtDireccion.Text.Equals("") || cbxPais.SelectedItem == null || cbxProvincia.SelectedItem == null || ctrlTxtCiudad.Texto.Equals("") || ctrlTxtCP.Texto.Equals("") || ctrlTxtTelefono.Texto.Equals(""))
            {
                MessageBox.Show("Los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //SE ACTUALIZA LA DIRECCION Q ESTA GUARDADA EN BD
            actualizarDireccion();
        }

        private void actualizarDireccion()
        {
            if (direccion != null)
            {
                direccion.nombre = txtNomDireccion.Text;
                direccion.direccion = txtDireccion.Text;
                direccion.pais = cbxPais.SelectedItem.ToString();
                direccion.provincia = cbxProvincia.SelectedItem.ToString();
                direccion.ciudad = ctrlTxtCiudad.Texto;
                direccion.codigoPostal = ctrlTxtCP.Texto;
                direccion.telefono = ctrlTxtTelefono.Texto;
                if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
                {
                    FicheroDireccion.editarFichero(direccion.idDireccion, direccion);
                }
                else
                {
                    if (BDDireccion.actualizarDireccion(direccion, ConfigSesion.obtenerReferenciaIdUsuario()))
                    {
                        MessageBox.Show("Los datos han sido actualizados.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarBotones(false, false, false);
                        cargarControlesText(true, true, false, false, true, true, true);
                    }
                }
            }
            else
            {
                Direccion direccion = new Direccion(txtNomDireccion.Text, txtDireccion.Text, cbxPais.SelectedItem.ToString(), cbxProvincia.SelectedItem.ToString(), ctrlTxtCiudad.Texto, ctrlTxtCP.Texto, ctrlTxtTelefono.Texto);
                if (direccion != null)
                {
                    if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
                    {
                        int idDireccionFichero = FicheroDireccion.obtenerIdDireccionMax();
                        direccion.idDireccion = idDireccionFichero;
                        FicheroDireccion.escribirFichero(direccion);
                        MessageBox.Show("Los datos han sido actualizados.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cargarBotones(false, false, false);
                        cargarControlesText(true, true, false, false, true, true, true);
                    }
                    else
                    {
                        if (BDDireccion.actualizarDireccion(direccion, ConfigSesion.obtenerReferenciaIdUsuario()))
                        {
                            MessageBox.Show("Los datos han sido actualizados.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargarBotones(false, false, false);
                            cargarControlesText(true, true, false, false, true, true, true);
                        }
                    }
                }
            }
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
