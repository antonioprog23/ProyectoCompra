using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    internal class LineaPedido
    {
        public int idLineaPedido { get; set; }
        public int idPedido { get; set; }
        public Producto producto { get; set; }
        public int cantidad { get; set; }
        public decimal subtotal { get; set; }

        public LineaPedido(int idLineaPedido, int idPedido, Producto producto, int cantidad, decimal subtotal)
        {
            this.idLineaPedido = idLineaPedido;
            this.idPedido = idPedido;
            this.producto = producto;
            this.cantidad = cantidad;
            this.subtotal = subtotal;
        }

        public LineaPedido(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.cantidad = cantidad;
        }
    }
}
