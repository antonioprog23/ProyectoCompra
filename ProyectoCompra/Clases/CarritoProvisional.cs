﻿using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;

namespace ProyectoCompra.Clases
{
    public class CarritoProvisional
    {
        public int cantidad { get; set; }
        public string rutaImagen { get; set; }
        public Producto producto { get; set; }
        public int idProducto { get; set; }
        public decimal total { get; set; }
        public string iva { get; set; }
        public List<CarritoProvisional> lista;

        public CarritoProvisional(Producto producto, int cantidad, string rutaImagen)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.rutaImagen = rutaImagen;
        }

        public CarritoProvisional()
        {
        }

        public CarritoProvisional(int cantidad, List<CarritoProvisional> lista, string iva, decimal total)
        {
            this.cantidad = cantidad;
            this.lista = lista;
            this.iva = iva;
            this.total = total;
        }

        public CarritoProvisional(int idProducto, int cantidad)
        {
            this.cantidad = cantidad;
            this.idProducto = idProducto;
        }

        public CarritoProvisional(string linea)
        {
            string[] data = linea.Split(';');
            this.producto = new Producto(linea);
            this.cantidad = Convert.ToInt32(data[6]);
            this.rutaImagen = data[7];
        }

        public void insertarProducto(CarritoProvisional producto)
        {
            FicheroCarrito.escribirFichero(producto);
            comprobarCantidades(producto);
        }

        public static void eliminarProducto(int idProducto)
        {
            List<CarritoProvisional> lista = FicheroCarrito.leerFichero();
            if (lista.Count > 0)
            {
                CarritoProvisional productoEliminar = lista.Find(p => p.producto.id_producto == idProducto);
                if (lista.Remove(productoEliminar))
                {
                    if (lista.Count > 0)
                    {
                        FicheroCarrito.borrarFicheroAux();
                        if (lista.Count > 0)
                        {
                            foreach (CarritoProvisional c in lista)
                            {
                                FicheroCarrito.escribirFichero(c);
                            }
                        }
                    }
                    else
                    {
                        FicheroCarrito.borrarFicheroAux();
                    }
                }

            }
        }

        public static bool editarCantidadProducto(int idProducto, int cantidadNueva)
        {
            bool editado = false;
            List<CarritoProvisional> lista = FicheroCarrito.leerFichero();
            CarritoProvisional producto = lista.Find(p => p.producto.id_producto == idProducto);
            int indice = lista.IndexOf(producto);
            CarritoProvisional productoEditar = lista[indice];
            productoEditar.cantidad = cantidadNueva;
            FicheroCarrito.borrarFicheroAux();
            foreach (CarritoProvisional c in lista)
            {
                FicheroCarrito.escribirFichero(c);
            }
            return editado;
        }

        public static void vaciarCarrito()
        {
            FicheroCarrito.borrarFicheroAux();
        }

        //SI HAY DOS PRODUCTOS CON EL MISMO ID, SE SUMAN LAS CANTIDADES
        private void comprobarCantidades(CarritoProvisional carrito)
        {
            int contador = 0;
            List<CarritoProvisional> lista = consultarCarritoProvisional();
            List<CarritoProvisional> aux = lista.FindAll(p => p.producto.id_producto == carrito.producto.id_producto);
            foreach (CarritoProvisional productoAux in aux)
            {
                contador += productoAux.cantidad;
            }
            aux[0].cantidad = contador;
            lista.RemoveAll(p => p.producto.id_producto == carrito.producto.id_producto);
            lista.Add(aux[0]);
            FicheroCarrito.borrarFicheroAux();
            foreach (CarritoProvisional p in lista)
            {
                FicheroCarrito.escribirFichero(p);
            }
        }

        public static List<CarritoProvisional> consultarCarritoProvisional()
        {
            return FicheroCarrito.leerFichero();
        }

        public static List<CarritoProvisional> prepararListaProvisionalBD()
        {
            List<CarritoProvisional> lista = new List<CarritoProvisional>();
            List<CarritoProvisional> carrito = FicheroCarrito.leerFichero();
            foreach (CarritoProvisional producto in carrito)
            {
                CarritoProvisional carritoProvisional = new CarritoProvisional(producto.producto.id_producto, producto.cantidad);
                lista.Add(carritoProvisional);
            }

            return lista;
        }

        public decimal calcularSubTotal(List<CarritoProvisional> productos)
        {
            decimal subtTotal = 0;

            foreach (CarritoProvisional producto in productos)
            {
                subtTotal += producto.producto.precio * producto.cantidad;
            }
            return subtTotal;
        }

        public string toStringConSeparador()
        {
            return $"{this.producto.ToStringWithSeparator()};{this.cantidad};{this.rutaImagen}";
        }
    }
}
