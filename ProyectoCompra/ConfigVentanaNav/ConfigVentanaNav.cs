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
            if (pilaFormularios.Count > 0)
            {
                foreach (Form ventana in pilaFormularios)
                {
                    ventana.Visible = false;
                }
            }
        }

        //Cierra el/los formularios abiertos que estan abierto/s oculto/s
        public static void deleteFormSecond()
        {
            while (pilaFormularios.Count > 0)
            {
                pilaFormularios.Pop().Close();
            }
        }
    }
}
