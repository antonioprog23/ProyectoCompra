using ProyectoCompra.Clases;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCompra.Ficheros
{
    internal class FicheroDireccion
    {
        //CONSTANTE
        private const string FICHERO = "..\\..\\Ficheros\\direccion.text";

        public static void escribirFichero(Direccion direccion)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FICHERO, true))
                {
                    sw.WriteLine(direccion.toStringWithSeparator());
                    File.SetAttributes(FICHERO, FileAttributes.Encrypted);
                    File.SetAttributes(FICHERO, FileAttributes.Normal);
                }
            }
            catch (DirectoryNotFoundException d)
            {
                MessageBox.Show(d.Message);
            }
            catch (IOException e)
            {
                //throw e;
                MessageBox.Show(e.Message);
            }
        }

        public static List<Direccion> leerFichero()
        {
            List<Direccion> direcciones = new List<Direccion>();
            try
            {
                if (File.Exists(FICHERO))
                {
                    using (StreamReader sr = new StreamReader(FICHERO))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            Direccion direccion = new Direccion(linea);
                            direcciones.Add(direccion);
                            linea = sr.ReadLine();
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                throw e;
            }
            catch (DirectoryNotFoundException d)
            {
                throw d;
            }
            catch (IOException e)
            {
                throw e;
            }

            return direcciones;
        }

        public static bool borrarFicheroAux()
        {
            bool eliminado = false;
            if (File.Exists(FICHERO))
            {
                try
                {
                    File.Delete(FICHERO);
                    eliminado = true;
                }
                catch (DirectoryNotFoundException)
                {

                }
                catch (IOException)
                {

                }
            }
            return eliminado;
        }
    }
}
