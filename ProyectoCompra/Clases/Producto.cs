using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    internal class Producto
    {
        #region Atributos

        public int id_producto { get; set; }
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string fabricante { get; set; }

        #endregion

        #region Constructor

        public Producto(int id_producto, int id_categoria, string nombre, string descripcion, decimal precio, string fabricante)
        {
            this.id_producto = id_producto;
            this.id_categoria = id_categoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fabricante = fabricante;
        }

        public Producto(int id_producto, string nombre, decimal precio, string descripcion)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public Producto(int id_producto)
        {
            this.id_producto = id_producto;
        }

        #endregion

        #region

        public override string ToString()
        {
            return $"Producto [Id: {this.id_producto}, Categoría: {this.id_categoria}, Nombre: {this.nombre}, Descripción: {this.descripcion}, Precio: {this.precio}, Fabricante: {this.fabricante}]";
        }

        #endregion
    }
}
