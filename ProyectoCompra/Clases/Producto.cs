using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    public class Producto
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

        public Producto(int id_producto, string nombre, string descripcion, decimal precio, string fabricante)
        {
            this.id_producto = id_producto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.fabricante = fabricante;
        }

        public Producto(int id_producto)
        {
            this.id_producto = id_producto;
        }

        public Producto(string linea)
        {
            string[] data = linea.Split(';');
            this.id_producto = Convert.ToInt32(data[0]);
            this.id_categoria = Convert.ToInt32(data[1]);
            this.nombre = data[2];
            this.descripcion = data[3];
            this.precio = Convert.ToDecimal(data[4]);
            this.fabricante = data[5];
        }

        #endregion

        #region Métodos
        public override string ToString()
        {
            return $"Producto [Id: {this.id_producto}, Categoría: {this.id_categoria}, Nombre: {this.nombre}, Descripción: {this.descripcion}, Precio: {this.precio}, Fabricante: {this.fabricante}]";
        }

        public string ToStringWithSeparator()
        {
            return $"{this.id_producto};{this.id_categoria};{this.nombre};{this.descripcion};{this.precio};{this.fabricante}";
        }

        #endregion
    }
}
