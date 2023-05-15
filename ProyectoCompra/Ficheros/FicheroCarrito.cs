using ProyectoCompra.Clases;
using System.Collections.Generic;
using System.IO;

namespace ProyectoCompra.Ficheros
{
    internal class FicheroCarrito
    {
        //CONSTANTE
        private const string FICHERO = "..\\..\\Ficheros\\carritoProvisional.text";

        public static void escribirFichero(CarritoProvisional carrito)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FICHERO, true))
                {
                    sw.WriteLine(carrito.toStringConSeparador());
                    File.SetAttributes(FICHERO, FileAttributes.Encrypted);
                    File.SetAttributes(FICHERO, FileAttributes.Normal);
                }
            }
            catch (DirectoryNotFoundException d)
            {
                throw d;
            }
            catch (IOException e)
            {
                throw e;
            }
        }

        public static List<CarritoProvisional> leerFichero()
        {
            List<CarritoProvisional> carritoProvisional = new List<CarritoProvisional>();
            try
            {
                if (File.Exists(FICHERO))
                {
                    using (StreamReader sr = new StreamReader(FICHERO))
                    {
                        string linea = sr.ReadLine();
                        while (linea != null)
                        {
                            CarritoProvisional producto = new CarritoProvisional(linea);
                            carritoProvisional.Add(producto);
                            linea = sr.ReadLine();
                        }
                    }
                }
            }
            catch (FileNotFoundException e)
            {

            }
            catch (DirectoryNotFoundException d)
            {

            }
            catch (IOException e)
            {

            }

            return carritoProvisional;
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
