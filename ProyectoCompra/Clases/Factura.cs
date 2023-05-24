using System;

namespace ProyectoCompra.Clases
{
    public class Factura
    {
        public int idFactura { get; set; }
        public Pedido pedido { get; set; }
        public int idEstadoFactura { get; set; }
        public DateTime fechaFactura { get; set; }

        public Factura(int idFactura, Pedido pedido, int idEstadoFactura, DateTime fechaFactura)
        {
            this.idFactura = idFactura;
            this.pedido = pedido;
            this.idEstadoFactura = idEstadoFactura;
            this.fechaFactura = fechaFactura;
        }

        public Factura(int idFactura, int idPedido, int idEstadoFactura, DateTime fechaFactura)
        {
            this.idFactura = idFactura;
            this.pedido.idPedido = idPedido;
            this.idEstadoFactura = idEstadoFactura;
            this.fechaFactura = fechaFactura;
        }
    }
}
