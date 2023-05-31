using ProyectoCompra.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoCompra.ConfigVentanaNav
{
    internal class ConfigVentanaNav
    {
        private static Stack<Form> pilaFormularios = new Stack<Form>();

        public static void addForm(Form form)
        {
            pilaFormularios.Push(form);
        }

        public static void deleteFormSecond()
        {
            while (pilaFormularios.Count > 0)
            {
                pilaFormularios.Pop().Close();
            }
        }
    }
}
