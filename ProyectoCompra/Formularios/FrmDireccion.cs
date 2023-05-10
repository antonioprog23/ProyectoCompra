using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmDireccion : Form
    {
        private List<Direccion> direcciones;
        private CtrlDireccion ctrlDireccion;
        public FrmDireccion()
        {
            InitializeComponent();
            cargarDirecciones();
            if (direcciones.Count == 0)
            {
                btnAniadirDireccion.Visible = false;
                ctrlDireccionMostrar.agregarDireccion = true;
            }
        }

        private void cargarDirecciones()
        {
            direcciones = BDDireccion.consusltarDireccion(FicheroAuxiliar.leerFichero().idUsuario);
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
                }
            }
        }

        private void btnAniadirDireccion_Click(object sender, EventArgs e)
        {
            ctrlDireccion = new CtrlDireccion(true);
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
            this.Controls.Remove(ctrlDireccion);
            this.Size = new Size(350, 361);
            btnAniadirDireccion.Visible = true;
            btnCancelar.Visible = false;
        }


    }
}
