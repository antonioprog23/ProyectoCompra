using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;

namespace ProyectoCompra.Clases
{
    internal class Carrito
    {
        private int cantidad;
        private List<Producto> productos;
        private Producto producto;

        public Carrito(int cantidad)
        {
            this.cantidad = cantidad;
            this.productos = new List<Producto>();
        }

        public Carrito(string linea)
        {
            string[] data = linea.Split(';');
            producto = new Producto(Convert.ToInt32(data[0]), data[1], Convert.ToDecimal(data[2]), data[3]);
            this.cantidad = Convert.ToInt32(data[4]);
        }

        public void insertarProducto(Producto producto)
        {
            this.producto = producto;
            productos.Add(producto);
            FicheroCarrito.escribirFichero(this);
        }

        public Producto GetProducto() { return this.producto; }

        public int GetCantidad() { return this.cantidad; }

        public string toStringConSeparador()
        {
            return $"{this.producto.id_producto};{this.producto.nombre};{this.producto.precio};{this.producto.descripcion};{this.cantidad}";
        }

    }
}
