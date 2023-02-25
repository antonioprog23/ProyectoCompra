using ProyectoCompra.Ficheros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    public class Usuario
    {
        //CONSTANTES
        private const char SEPARADOR = ';';
        public int idUsuario { get; set; }
        public Cliente cliente { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string fechaAlta { get; set; }

        public Usuario(int idUsuario, Cliente cliente, string username, string password, string fechaAlta)
        {
            this.idUsuario = idUsuario;
            this.cliente = cliente;
            this.username = username;
            this.password = password;
            this.fechaAlta = fechaAlta;
        }

        public Usuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public Usuario(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Usuario(string linea)
        {
            string[] datos = linea.Split(SEPARADOR);
            idUsuario = int.Parse(datos[0]);
        }

        public string toStringConSeparador()
        {
            return  string.Concat(idUsuario, Convert.ToString(SEPARADOR));
        }
    }
}
