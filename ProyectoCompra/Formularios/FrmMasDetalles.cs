﻿using ProyectoCompra.Clases;
using ProyectoCompra.Controles;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.Formularios
{
    public partial class FrmMasDetalles : Form
    {
        public Factura factura { get; set; }

        public FrmMasDetalles(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;

            this.ctrlMasInformacion1.factura = this.factura;
            this.ctrlResumenPedido1.factura = this.factura;
        }

        private void FrmMasDetalles_Load(object sender, System.EventArgs e)
        {
            List<LineaPedido> lineas = factura.pedido.obtenerProductosDelPedido(factura.idFactura);
            tlProductos.RowCount = factura.pedido.obtenerCantidadTotalProductosPedido(factura.idFactura);
            for (int i = 0; i < tlProductos.RowCount; i++)
            {
                LineaPedido lineaPedido = lineas[i];
                Producto producto = lineaPedido.producto;
                CtrlProductoHistorial ctrlProductoHistorial = new CtrlProductoHistorial();
                ctrlProductoHistorial.lineaPedido = lineaPedido;
                ctrlProductoHistorial.producto = producto;
                tlProductos.Controls.Add(ctrlProductoHistorial);
            }
        }
    }
}
