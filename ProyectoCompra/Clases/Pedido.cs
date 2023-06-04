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
        public int metodoPago { get; set; }

        public Pedido(int idPedido, Usuario usuario, List<LineaPedido> lineaPedido, Direccion direccion, int idEstadoPedido, DateTime fecha, int metodoPago)
        {
            this.idPedido = idPedido;
            this.usuario = usuario;
            this.lineaPedidos = lineaPedido;
            this.direccion = direccion;
            this.idEstadoPedido = idEstadoPedido;
            this.fecha = fecha;
            this.metodoPago = metodoPago;
        }

        /// <summary>
        /// Devuelve la cantidad de productos del pedido.
        /// </summary>
        /// <param name="idPedido"></param>
        /// <returns></returns>
        public int obtenerCantidadTotalProductosPedido(int idPedido)
        {
            List<LineaPedido> productosPedido = lineaPedidos.FindAll(p => p.idPedido == idPedido);
            return productosPedido.Count;
        }
        /// <summary>
        /// Devuelve la lista de productos que forman parte de un pedido.
        /// </summary>
        /// <param name="idPedido"></param>
        /// <returns></returns>
        public List<LineaPedido> obtenerProductosDelPedido(int idPedido)
        {
            List<LineaPedido> productos = lineaPedidos.FindAll(p => p.idPedido == idPedido);
            return productos;
        }

        /// <summary>
        /// Devuelve el precio total del pedido.
        /// </summary>
        /// <param name="idPedido"></param>
        /// <returns></returns>
        public decimal obtenerTotalPedido(int idPedidoo)
        {
            decimal total = 0;
            List<LineaPedido> lineas = lineaPedidos.FindAll(p => p.idPedido == idPedido);
            foreach (LineaPedido lineaPedido in lineas)
            {
                total += lineaPedido.producto.precio * lineaPedido.cantidad;
            }
            return total;
        }

        public decimal obtenerTotalPedidoConGastosEnvíoEIntereses(decimal total)
        {
            return (total * 1.03m) + 3.99m;
        }
    }
}
