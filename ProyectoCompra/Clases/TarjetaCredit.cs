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

        public override string ToString()
        {
            return $"Tarjeta Credito [ Usuario: {0}, Titular: {1}, NºTarjeta: {2}, Mes vencimiento: {3}, Año vencimiento: {4}, CVV: {5}]";
        }
    }
}
