using System;
using System.Collections.Generic;

namespace ProyectoCompra.Clases
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public Usuario usuario { get; set; }
        public List<LineaPedido> lineaPedidos { get; set; }
        public Direccion direccion { get; set; }
        public int idEstadoPedido { get; set; }
        public DateTime fecha { get; set; }

        public Pedido(int idPedido, Usuario usuario, List<LineaPedido> lineaPedido, Direccion direccion, int idEstadoPedido, DateTime fecha)
        {
            this.idPedido = idPedido;
            this.usuario = usuario;
            this.lineaPedidos = lineaPedido;
            this.direccion = direccion;
            this.idEstadoPedido = idEstadoPedido;
            this.fecha = fecha;
        }

        public int obtenerCantidadTotalProductosPedido(int idPedido)
        {
            List<LineaPedido> productosPedido = lineaPedidos.FindAll(p => p.idPedido == idPedido);
            return productosPedido.Count;
        }

        public List<LineaPedido> obtenerProductosDelPedido(int idPedido)
        {
            List<LineaPedido> productos = lineaPedidos.FindAll(p => p.idPedido == idPedido);
            return productos;
        }

    }
}
