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

        //ESTE ES PARA USARLO EN EL FICHERO
        public Direccion(int idDireccion, string nombre, string direccion, string pais, string provincia, string ciudad, string codigoPostal, string telefono)
        {
            this.idDireccion = idDireccion;
            this.nombre = nombre;
            this.direccion = direccion;
            this.pais = pais;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.codigoPostal = codigoPostal;
            this.telefono = telefono;
        }

        //PARA LEER Y DESGLOSAR LA LINEA DEL FICHERO
        public Direccion(string linea)
        {
            string[] data = linea.Split(';');
            this.idDireccion = Convert.ToInt32(data[0]);
            this.nombre = data[1];
            this.direccion = data[2];
            this.pais = data[3];
            this.provincia = data[4];
            this.ciudad = data[5];
            this.codigoPostal = data[6];
            this.telefono = data[7];
        }

        //PARA ESCRIBIR EN EL FICHERO
        public string toStringWithSeparator()
        {
            return $"{this.idDireccion};{this.nombre};{this.direccion};{this.pais};{this.provincia};{this.ciudad};{this.codigoPostal};{this.telefono}";
        }
    }
}
