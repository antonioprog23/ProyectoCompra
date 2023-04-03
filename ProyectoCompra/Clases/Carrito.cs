using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ProyectoCompra.Clases
{
    internal class Carrito
    {
        private int cantidad;
        private Image imagen;
        private Producto producto;

        public Carrito(int cantidad, Image imagen)
        {
            this.cantidad = cantidad;
            this.imagen = imagen;
            List<Carrito> lista = FicheroCarrito.leerFichero();
        }

        public Carrito(string linea)
        {
            string[] data = linea.Split(';');
            this.producto = new Producto(Convert.ToInt32(data[0]), data[1], Convert.ToDecimal(data[2]), data[3]);
            this.cantidad = Convert.ToInt32(data[4]);
        }

        public void insertarProducto(Producto producto)
        {
            this.producto = producto;
            int contador = 0;
            FicheroCarrito.escribirFichero(this);
            List<Carrito> lista = FicheroCarrito.leerFichero();

            List<Carrito> aux = lista.FindAll(p => p.GetProducto().id_producto == producto.id_producto);
            foreach (Carrito productoAux in aux)
            {
                contador += productoAux.cantidad;
            }
            aux[0].cantidad = contador;
            lista.RemoveAll(p => p.GetProducto().id_producto == producto.id_producto);
            lista.Add(aux[0]);
            FicheroCarrito.borrarFicheroAux();
            foreach (Carrito p in lista)
            {
                FicheroCarrito.escribirFichero(p);
            }

        }

        public Producto GetProducto() { return this.producto; }

        public int GetCantidad() { return this.cantidad; }
        public void SetCantidad(int cantidad) { this.cantidad = cantidad; }
        public Image GetImage() { return this.imagen; }

        public string toStringConSeparador()
        {
            return $"{this.producto.id_producto};{this.producto.nombre};{this.producto.precio};{this.producto.descripcion};{this.cantidad};{this.imagen}";
        }

    }
}
