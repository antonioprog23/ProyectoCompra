using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCompra.Clases
{
    internal class Utilidades
    {
        public static string textoObligatorio(string texto, bool obligatorio)
        {
            if (obligatorio)
            {
                texto = $"* {texto}";
            }
            return texto;
        }
    }
}
