using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.ConfigVentanaNav
{
    internal class ConfigVentanaNav
    {
        private static Stack<Form> pilaFormularios = new Stack<Form>();

        public static void addForm(Form form)
        {
            pilaFormularios.Clear();
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
