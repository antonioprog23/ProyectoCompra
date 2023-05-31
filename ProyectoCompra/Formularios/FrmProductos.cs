using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ProyectoCompra.Formularios
{
    public partial class FrmProductos : FrmBase
    {
        #region Fields

        private List<Producto> lista;
        private Producto producto;
        private int categoria;
        private int subCategoria;
        private FrmMain frmMain;
        private FrmProductos frmProductos;

        #endregion

        public FrmProductos(int categoria, int subcategoria, FrmMain frmMain)
        {
            InitializeComponent();
            this.categoria = categoria;
            this.subCategoria = subcategoria;
            this.frmMain = frmMain;
            this.frmProductos = formProductos;

            ConfigVentanaNav.ConfigVentanaNav.addForm(this);
            lista = BDProducto.obtenerProductos(this.subCategoria);
            configuracionFormMain();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarNombreGroupBox();
            cargarBotones();
        }

        #region Métodos privados

        private void configuracionFormMain()
        {
            this.frmMain.Visible = false;
            formPadre = frmMain;
            formActual = this;

            if (formProductos != null)
            {
                formProductos.Visible = false;
            }
        }

        private void cargarBotones()
        {
            int contador = 0;
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
                        button.Text = lista[contador].nombre;
                        button.Click += new EventHandler(button_Click);
                        tableLayoutPanel1.Controls.Add(button, j, i);
                        button.Name = contador.ToString();
                        contador++;
                        Image image = Imagen.cargarImagen(contador, subCategoria);
                        button.Image = image;
                    }

                }
            }
        }



        private Producto obtenerProducto(int contador)
        {
            return lista[contador];
        }

        private void cargarNombreGroupBox()
        {
            switch (categoria)
            {
                case 1:
                    gbxCategoria.Text = "Alimentación";
                    break;
                case 2:
                    gbxCategoria.Text = "Frescos";
                    break;
                case 3:
                    gbxCategoria.Text = "Fríos y congelados";
                    break;
                case 4:
                    gbxCategoria.Text = "Bebidas";
                    break;
                case 5:
                    gbxCategoria.Text = "Droguería";
                    break;
                case 6:
                    gbxCategoria.Text = "Cuidado personal";
                    break;
                case 7:
                    gbxCategoria.Text = "Electrodomésticos";
                    break;
                case 8:
                    gbxCategoria.Text = "Tecnología";
                    break;
                case 9:
                    gbxCategoria.Text = "Hogar";
                    break;
            }
        }

        #endregion

        #region Eventos
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            producto = obtenerProducto(Convert.ToInt32(button.Name));
            FrmDetalleProducto frmDetalleProducto = new FrmDetalleProducto(producto, sender);
            frmDetalleProducto.ShowDialog();
            aumentarContador();
        }
        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.frmMain.Visible = true;
            ConfigVentanaNav.ConfigVentanaNav.deleteFormSecond();
        }
        #endregion


    }
}
