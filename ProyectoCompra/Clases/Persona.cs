using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    public class Persona
    {
        #region Atributos

        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string fechaNacimiento { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }

        #endregion

        #region Constructor

        public Persona(string nombre, string apellido, int edad, string fechaNacimiento, string sexo, string direccion, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.direccion = direccion;
            this.correo = correo;
        }

        public Persona(string nombre, string apellido, int edad, string fechaNacimiento, string sexo, string correo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.fechaNacimiento = fechaNacimiento;
            this.sexo = sexo;
            this.correo = correo;
        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region Métodos

        public override string ToString() => $"Persona [Nombre: {this.nombre}, Edad: {this.edad}, Fecha Nacimiento: {this.fechaNacimiento}, Dirección: {this.direccion}, Correo: {this.correo}]";

        #endregion
    }
}
