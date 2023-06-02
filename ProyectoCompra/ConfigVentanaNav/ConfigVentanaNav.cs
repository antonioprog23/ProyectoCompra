using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoCompra.ConfigVentanaNav
{
    internal class ConfigVentanaNav
    {
        private static Stack<Form> pilaFormularios = new Stack<Form>();

        //Agrega el nuevo formulario a abrir y el anterior a este, se oculta
        public static void addForm(Form form)
        {
            pilaFormularios.Push(form);
            if (pilaFormularios.Count > 1)
            {
                foreach (Form ventana in pilaFormularios)
                {
                    ventana.Hide();
                }
            }
        }

        //Cierra el/los formularios abiertos que estan ocultos
        public static void deleteFormSecond()
        {
            while (pilaFormularios.Count > 0)
            {
                pilaFormularios.Pop().Close();
            }
        }
    }
}
