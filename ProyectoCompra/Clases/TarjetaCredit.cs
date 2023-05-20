using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    internal class TarjetaCredit
    {
        public int idUsusario { get; set; }
        public string titular { get; set; }
        public string numerosTarjeta { get; set; }
        public string mesVencimiento { get; set; }
        public string anioVencimiento { get; set; }
        public string cvv { get; set; }

        public TarjetaCredit(int idUsuario, string titular, string numerosTarjeta, string mesVencimiento, string anioVencimiento, string cvv)
        {
            this.idUsusario = idUsuario;
            this.titular = titular;
            this.numerosTarjeta = numerosTarjeta;
            this.mesVencimiento = mesVencimiento;
            this.anioVencimiento = anioVencimiento;
            this.cvv = cvv;
        }

        public TarjetaCredit(string titular, string numerosTarjeta, string mesVencimiento, string anioVencimiento, string cvv)
        {
            this.titular = titular;
            this.numerosTarjeta = numerosTarjeta;
            this.mesVencimiento = mesVencimiento;
            this.anioVencimiento = anioVencimiento;
            this.cvv = cvv;
        }

        //PARA EL FICHERO
        public TarjetaCredit(string linea)
        {
            string[] data = linea.Split(';');
            this.titular = data[0];
            this.numerosTarjeta = data[1];
            this.mesVencimiento = data[2];
            this.anioVencimiento = data[3];
            this.cvv = data[4];
        }

        public string ToStringWithSeparator()
        {
            return $"{this.titular};{this.numerosTarjeta};{this.mesVencimiento};{this.anioVencimiento};{this.cvv}";
        }
    }
}
