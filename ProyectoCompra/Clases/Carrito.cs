using ProyectoCompra.Base_datos;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ProyectoCompra.Clases
{
    internal class Carrito
    {
        public int cantidad { get; set; }
        public List<Carrito> lista;
        private BDCarrito BDCarrito;
        public Producto producto { set; get; }

        public Carrito(int cantidad, Producto producto)
        {
            this.cantidad = cantidad;
            this.producto = producto;
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

    }
}
