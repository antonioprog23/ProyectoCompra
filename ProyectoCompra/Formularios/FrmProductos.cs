﻿using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ProyectoCompra.Formularios
{
    public partial class FrmProductos : FrmBase
    {
        private List<Producto> lista;
        private Producto producto;
        private int categoria;
        private int subCategoria;

        public FrmProductos(int categoria, int subcategoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            this.subCategoria = subcategoria;
            lista = BDProducto.obtenerProductos(this.subCategoria);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cargarNombreGroupBox();
            cargarBotones();
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
                        Image image = obtenerImagen(contador);
                        button.Image = image;
                    }

                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            producto = obtenerProducto(Convert.ToInt32(button.Name));
            FrmDetalleProducto frmDetalleProducto = new FrmDetalleProducto(button.Image, producto);
            frmDetalleProducto.ShowDialog();
        }

        private Image obtenerImagen(int contador)
        {
            Image image = null;
            switch (subCategoria)
            {
                case 1:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_1_{0}", contador)) as Image;
                    break;
                case 2:
                    image = AlimentacionS2.ResourceManager.GetObject(string.Format("_2_{0}", contador)) as Image;
                    break;
                case 3:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_3_{0}", contador)) as Image;
                    break;
                case 4:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_4_{0}", contador)) as Image;
                    break;
                case 5:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_5_{0}", contador)) as Image;
                    break;
                case 6:
                    image = AlimentacionS1.ResourceManager.GetObject(string.Format("_6_{0}", contador)) as Image;
                    break;
            }

            return image;
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
    }
}
