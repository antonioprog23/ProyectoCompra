using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmProductos : FrmBase
    {
        private object sender;
        private List<Producto> lista;
        private int categoria;
        private ResourceManager resource;

        public FrmProductos(object sender, int categoria, int subcategoria)
        {
            InitializeComponent();
            this.sender = sender;
            this.categoria = categoria;
            lista = BDProducto.obtenerProductos(subcategoria);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ResourceManager resource = new ResourceManager("AlimentacionSub1", typeof(Program).Assembly);
            cargarNombreGroupBox();
            int contador = 0;
            if ((this.sender as Control).Text.Equals("Lacteos y huevos") || (this.sender as Control).Text.Equals("Aceites, vinagres y salsas"))
            {

                tableLayoutPanel1.RowCount = lista.Count / 6;
                tableLayoutPanel1.ColumnCount = 6;
                for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
                {
                    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                    {
                        if (contador <= lista.Count)
                        {
                            Button button = new Button();
                            button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                            button.Dock = DockStyle.Left;
                            button.Width = 184;
                            button.Height = 184;
                            tableLayoutPanel1.Controls.Add(button, j, i);
                            button.Text = lista[contador].nombre;
                            contador++;
                        }
                    }
                }
            }
        }

        private void cargarNombreGroupBox()
        {
            switch (categoria)
            {
                case 1:
                    gbxCategoria.Text = "Alimentación";
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
        }
    }
}
