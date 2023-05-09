using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    public class Direccion
    {
        public int idDireccion { get; set; }
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string pais { get; set; }
        public string provincia { get; set; }
        public string ciudad { get; set; }
        public string codigoPostal { get; set; }
        public string telefono { get; set; }

        public Direccion(int idDireccion, int idCliente, string nombre, string direccion, string pais, string provincia, string ciudad, string codigoPostal, string telefono)
        {
            this.idDireccion = idDireccion;
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.direccion = direccion;
            this.pais = pais;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.codigoPostal = codigoPostal;
            this.telefono = telefono;
        }

        public Direccion(string nombre, string direccion, string pais, string provincia, string ciudad, string codigoPostal, string telefono)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.pais = pais;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.codigoPostal = codigoPostal;
            this.telefono = telefono;
        }
    }
}
