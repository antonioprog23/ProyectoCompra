using ProyectoCompra.Base_datos;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ProyectoCompra.Clases
{
    public class Carrito
    {
        public int cantidad { get; set; }
        public decimal total { get; set; }
        public string iva { get; set; }
        public List<Carrito> lista;
        private BDCarrito BDCarrito;
        public string rutaImagen { set; get; }
        public Producto producto { set; get; }

        public Carrito(int cantidad, Producto producto, string rutaImagen)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.rutaImagen = rutaImagen;
        }

        public Carrito(int cantidad, Producto producto)
        {
            this.cantidad = cantidad;
            this.producto = producto;
        }

        public Carrito(int cantidad, List<Carrito> lista, string iva, decimal total)
        {
            this.cantidad = cantidad;
            this.lista = lista;
            this.iva = iva;
            this.total = total;
        }

        public Carrito() { }

        public void insertarProducto(params object[] data)
        {
            BDCarrito.insertarProductoCarrito(data);
        }

        public List<Carrito> consultarProductosCarrito(int idUsuario)
        {
            this.lista = BDCarrito.consultarCarrito(idUsuario);
            return lista;
        }

        public bool vaciarCarrito(int idUsuario, int idProducto, bool eliminarTodo)
        {
            bool isVacio = false;
            if (BDCarrito.vaciarCarrito(idUsuario, idProducto, eliminarTodo))
            {
                isVacio = true;
            }
            return isVacio;
        }

        public decimal calcularSubTotal(List<Carrito> productos)
        {
            decimal subtTotal = 0;

            foreach (Carrito producto in productos)
            {
                subtTotal += producto.producto.precio * producto.cantidad;
            }
            return subtTotal;
        }
    }
}
