﻿namespace ProyectoCompra.Clases
{
    public class Cliente : Persona
    {
        #region Atributos

        public int id { get; set; }

        #endregion

        #region Constructores

        public Cliente(int id, string nombre, string apellido, int edad, string fechaNacimiento, string sexo, string direccion, string correo) : base(nombre, apellido, edad, fechaNacimiento, sexo, direccion, correo)
        {
            this.id = id;
        }
        public Cliente(int id, string nombre, string apellido, int edad, string fechaNacimiento, string sexo, string correo) : base(nombre, apellido, edad, fechaNacimiento, sexo, correo)
        {
            this.id = id;
        }
        public Cliente(string nombre, string apellido, int edad, string fechaNacimiento, string sexo, string correo) : base(nombre, apellido, edad, fechaNacimiento, sexo, correo)
        {

        }
        public Cliente(string nombre, string apellido) : base(nombre, apellido)
        {

        }
        #endregion

        #region Métodos

        #endregion
    }
}
