using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmProductos : FrmBase
    {
        private object sender;
        private FrmMain frmMain;

        public FrmProductos(object sender)
        {
            InitializeComponent();
            this.sender = sender;
            this.frmMain = new FrmMain();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if ((this.sender as Control).Text.Equals("Lacteos y huevos"))
            {
                MessageBox.Show("aqui");
                List<Producto> lista = BDProducto.obtenerProductos("ConsultarProductos"); ;
                tableLayoutPanel1.RowCount = lista.Count / 6 ;
                tableLayoutPanel1.ColumnCount = 6;
                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                    {
                        Button button = new Button();
                        button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        button.Dock = DockStyle.Left;
                        button.Width = 184;
                        button.Height = 184;
                        tableLayoutPanel1.Controls.Add(button, j, i);
                        button.Text = lista[i].nombre;
                    }
                }
            }
        }
    }
}
