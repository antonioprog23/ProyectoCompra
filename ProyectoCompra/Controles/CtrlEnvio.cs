﻿using ProyectoCompra.Base_datos;
using ProyectoCompra.Clases;
using ProyectoCompra.Ficheros;
using ProyectoCompra.Formularios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Controles
{
    public partial class CtrlEnvio : UserControl
    {
        public Carrito carritoListo { get; set; }
        public CarritoProvisional carritoProvisionalListo { get; set; }

        private List<Direccion> direcciones;

        public CtrlEnvio()
        {
            InitializeComponent();
        }

        public CtrlEnvio(Carrito carritoListo)
        {
            InitializeComponent();
            this.carritoListo = carritoListo;
        }

        public CtrlEnvio(CarritoProvisional carritoProvisionalListo)
        {
            InitializeComponent();
            this.carritoProvisionalListo = carritoProvisionalListo;

        }

        private void CtrlEnvio_Load(object sender, EventArgs e)
        {
            this.gbxDomicilio.Size = new System.Drawing.Size(433, 57);
            cargarProductosCarrito();
            cargarProductosCarritoProvisional();
        }

        private void cargarProductosCarrito()
        {
            if (ConfigSesion.obtenerReferenciaIdUsuario() != 0)
            {
                if (carritoListo != null)
                {
                    tlProductos.RowCount = carritoListo.lista.Count;
                    for (int i = 0; i < tlProductos.RowCount; i++)
                    {
                        CtrlProductoCarrito producto = new CtrlProductoCarrito();
                        Label id = (Label)producto.Controls.Find("lblIdMostrar", true)[0];
                        id.Text = carritoListo.lista[i].producto.id_producto.ToString();

                        Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                        nombre.Text = carritoListo.lista[i].producto.nombre;

                        Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                        precio.Text = carritoListo.lista[i].producto.precio.ToString();

                        NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                        cantidad.Text = carritoListo.lista[i].cantidad.ToString();
                        cantidad.Enabled = false;

                        Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                        imagen.Image = Imagen.obtenerImagenDB(carritoListo.lista[i].rutaImagen);

                        producto.botonBorrar.Visible = false;

                        tlProductos.Controls.Add(producto);
                    }
                    this.lblResumenProductos.Text = string.Format("{0} ({1})", lblResumenProductos.Text, carritoListo.lista.Count);
                }
            }
        }

        private void cargarProductosCarritoProvisional()
        {
            if (carritoProvisionalListo != null)
            {
                tlProductos.RowCount = carritoProvisionalListo.lista.Count;
                for (int i = 0; i < tlProductos.RowCount; i++)
                {
                    CtrlProductoCarrito producto = new CtrlProductoCarrito();
                    Label id = (Label)producto.Controls.Find("lblIdMostrar", true)[0];
                    id.Text = carritoProvisionalListo.lista[i].producto.id_producto.ToString();

                    Label nombre = (Label)producto.Controls.Find("lblNombreMostrar", true)[0];
                    nombre.Text = carritoProvisionalListo.lista[i].producto.nombre;

                    Label precio = (Label)producto.Controls.Find("lblPrecioMostrar", true)[0];
                    precio.Text = carritoProvisionalListo.lista[i].producto.precio.ToString();

                    NumericUpDown cantidad = (NumericUpDown)producto.Controls.Find("cantidad", true)[0];
                    cantidad.Text = carritoProvisionalListo.lista[i].cantidad.ToString();
                    cantidad.Enabled = false;

                    Label imagen = (Label)producto.Controls.Find("lblImage", true)[0];
                    imagen.Image = Imagen.obtenerImagenDB(carritoProvisionalListo.lista[i].rutaImagen);

                    producto.botonBorrar.Visible = false;

                    tlProductos.Controls.Add(producto);
                }
                this.lblResumenProductos.Text = string.Format("{0} ({1})", lblResumenProductos.Text, carritoProvisionalListo.lista.Count);
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            this.flProductos.Visible = true;
            this.btnDetalles.Visible = false;
            this.btnOcultarDetalles.Visible = true;
        }

        private void btnOcultarDetalles_Click(object sender, EventArgs e)
        {
            this.btnDetalles.Visible = true;
            this.btnOcultarDetalles.Visible = false;
            this.flProductos.Visible = false;
        }

        private void rbtnCasa_Click(object sender, EventArgs e)
        {
            FrmDireccion frmDireccion = new FrmDireccion(true);
            frmDireccion.ShowDialog();
            if (ConfigSesion.obtenerReferenciaIdUsuario() == 0)
            {
                direcciones = FicheroDireccion.leerFichero();
                if (direcciones.Count > 0)
                {
                    gbxDomicilio.Size = new System.Drawing.Size(433, 303);
                    if (direcciones.Count == 1)
                    {
                        lblNombre.Text = "Anthony Mauricio Ibarra Valencia";
                        lblDireccion.Text = direcciones[0].direccion;
                        lblLocalidad.Text = direcciones[0].codigoPostal;
                        lblTelefono.Text = direcciones[0].telefono;
                    }
                    if (direcciones.Count == 2)
                    {
                        lblNombre2.Text = "Anthony Mauricio Ibarra Valencia";
                        lblDireccion2.Text = direcciones[1].direccion;
                        lblLocalidad2.Text = direcciones[1].codigoPostal;
                        lblTelefono2.Text = direcciones[1].telefono;

                        lblNombre2.Visible = true;
                        lblDireccion2.Visible = true;
                        lblLocalidad2.Visible = true;
                        lblTelefono2.Visible = true;
                    }
                }
            }
            else
            {
                direcciones = BDDireccion.consusltarDireccion(ConfigSesion.obtenerReferenciaIdUsuario());
                if (direcciones.Count > 0)
                {
                    gbxDomicilio.Size = new System.Drawing.Size(433, 303);
                }
            }
        }

        private void rbnTarjeta_Click(object sender, EventArgs e)
        {
            FrmPagos frmPagos = new FrmPagos(true);
            frmPagos.ShowDialog();
        }
    }
}