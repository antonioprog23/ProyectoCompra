using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlEfectivo : UserControl
    {
        private List<Direccion> direcciones;
        private Direccion direccion1;
        private Direccion direccion2;

        public CtrlEfectivo()
        {
            InitializeComponent();
        }

        private void CtrlEfectivo_Load(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationElement element = config.AppSettings.Settings["idUsuario"];

                if (element != null)
                {
                    direcciones = BDDireccion.consusltarDireccion(Convert.ToInt32(element.Value));

                    if (direcciones.Count != 0)
                    {
                        direccion1 = direcciones[0];
                        if (direccion1 != null)
                        {
                            txtDireccion1.Text = direccion1.direccion;
                        }
                        if (direcciones.Count == 2)
                        {
                            direccion2 = direcciones[1];
                            if (direccion2 != null)
                            {
                                txtDireccion2.Text = direccion2.direccion;
                                txtDireccion2.Enabled = true;
                                lblDireccion2.Enabled = true;
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

    }
}
