using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmDireccion : Form
    {
        private List<Direccion> direcciones;
        private CtrlDireccion ctrlDireccion;
        public bool isEleccion { get; set; }

        public FrmDireccion()
        {
            InitializeComponent();
            cargarDirecciones();
        }

        public FrmDireccion(bool isEleccion)
        {
            InitializeComponent();
            this.isEleccion = isEleccion;
            cargarDirecciones();
        }

        private void FrmDireccion_Load(object sender, EventArgs e)
        {
            if (direcciones.Count == 0)
            {
                btnAniadirDireccion.Visible = false;
                ctrlDireccionMostrar.agregarDireccion = true;
            }
            if (direcciones.Count == 0)
            {
                btnAniadirDireccion.Visible = false;
                ctrlDireccionMostrar.agregarDireccion = true;
            }
            if (direcciones.Count >= 1 && isEleccion)
            {
                btnAceptar.Visible = true;
                this.Size = new Size(668, 361);
                if (direcciones.Count == 1)
                {
                    this.Size = new Size(350, 361);
                }
            }
        }

        private void cargarDirecciones()
        {
            try
            {
                Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationElement element = configuration.AppSettings.Settings["idUsuario"];
                if (element != null)
                {
                    direcciones = BDDireccion.consusltarDireccion(Convert.ToInt32(element.Value));
                    if (direcciones.Count != 0)
                    {
                        if (direcciones[0] != null)
                        {
                            ctrlDireccionMostrar.direccion = direcciones[0];
                        }
                        if (direcciones.Count == 2)
                        {
                            ctrlDireccion = new CtrlDireccion();
                            ctrlDireccion.Location = new Point(330, 12);
                            ctrlDireccion.setBotonBorrarDireccion(true);
                            ctrlDireccion.groupBox = "Dirección (alternativo)";
                            ctrlDireccion.direccion = direcciones[1];
                            this.Controls.Add(ctrlDireccion);
                            this.Size = new Size(668, 335);

                            btnCancelar.Visible = false;
                            btnCancelar.Location = new Point(565, 286);
                            btnAniadirDireccion.Visible = false;
                            Button botonEliminar = null;
                            botonEliminar = (Button)ctrlDireccion.Controls.Find("btnBorrar", true)[0];
                            if (isEleccion)
                            {
                                btnAceptar.Location = new Point(567, 286);
                                botonEliminar.Visible = false;
                            }
                            else
                            {
                                botonEliminar.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (ConfigurationErrorsException ex)
            {
                throw ex;
            }
        }

        private void btnAniadirDireccion_Click(object sender, EventArgs e)
        {
            this.btnAceptar.Location = new Point(486, 285);

            ctrlDireccion = new CtrlDireccion(true, false);
            ctrlDireccion.Location = new Point(330, 12);

            ctrlDireccion.groupBox = "Dirección (alternativo)";
            this.Controls.Add(ctrlDireccion);
            this.Size = new Size(668, 361);

            btnCancelar.Visible = true;
            btnCancelar.Location = new Point(565, 286);
            btnAniadirDireccion.Visible = false;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.btnAceptar.Location = new Point(166, 286);
            this.Controls.Remove(ctrlDireccion);
            this.Size = new Size(350, 361);
            btnAceptar.Enabled = true;
            btnAniadirDireccion.Visible = true;
            btnCancelar.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (direcciones.Count != 0)
            {
                this.Close();
            }
        }
    }
}
