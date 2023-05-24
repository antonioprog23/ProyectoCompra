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

        public Pedido(int idPedido, Usuario usuario,List<LineaPedido> lineaPedido,Direccion direccion, int idEstadoPedido, DateTime fecha)
        {
            this.idPedido = idPedido;
            this.usuario = usuario;
            this.lineaPedidos = lineaPedido;
            this.direccion = direccion;
            this.idEstadoPedido = idEstadoPedido;
            this.fecha = fecha;
        }

        public Pedido(int idPedido, Usuario usuario, Direccion direccion, int idEstadoPedido, DateTime fecha)
        {
            this.idPedido = idPedido;
            this.usuario = usuario;
            this.direccion = direccion;
            this.idEstadoPedido = idEstadoPedido;
            this.fecha = fecha;
        }

        public Pedido(int idPedido, int idUsuario, int idEstadoPedido, DateTime fecha)
        {
            this.idPedido = idPedido;
            this.usuario.idUsuario = idUsuario;
            this.direccion = direccion;
            this.idEstadoPedido = idEstadoPedido;
            this.fecha = fecha;
        }

        public Pedido(int idUsuario, int idEstadoPedido, DateTime fecha)
        {
            this.usuario.idUsuario = idUsuario;
            this.idEstadoPedido = idEstadoPedido;
            this.fecha = fecha;
        }

        public Pedido(int idUsuario)
        {
            this.usuario.idUsuario = idUsuario;
        }


    }
}
