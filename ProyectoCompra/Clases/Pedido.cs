using System;

namespace ProyectoCompra.Clases
{
    internal class Pedido
    {
        public int idPedido { get; set; }
        public int idUsuario { get; set; }
        public int idEstadoPedido { get; set; }
        public decimal total { get; set; }
        public DateTime fecha { get; set; }

        public Pedido(int idPedido, int idUsuario, int idEstadoPedido, decimal total, DateTime fecha)
        {
            this.idPedido = idPedido;
            this.idUsuario = idUsuario;
            this.idEstadoPedido = idEstadoPedido;
            this.total = total;
            this.fecha = fecha;
        }

        public Pedido(int idUsuario, int idEstadoPedido, decimal total, DateTime fecha)
        {
            this.idUsuario = idUsuario;
            this.idEstadoPedido = idEstadoPedido;
            this.total = total;
            this.fecha = fecha;
        }

        public Pedido(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }


    }
}
